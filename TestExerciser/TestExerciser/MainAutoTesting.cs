using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Diagnostics;
using EditorTE;
using FarsiLibrary.Win;
using System.Threading;
using System.Drawing.Drawing2D;

using System.Data.OleDb;
using TestExerciser.User;
using TestExerciser.Logic;
using TestExerciser.Tools;



namespace TestExerciser
{

    public partial class MainAutoTesting : Form
    {
        public static string[] root_paths = {};
        public static string workspacePath = null;
        public static string pythonEnv = null;
        public static string pythonLibPath = null;
        public static string rootFolder = null;
        public static string selectedNodePath = null;

        string path;
        
        Style invisibleCharsStyle = new InvisibleCharsRenderer(Pens.Gray);
        Color currentLineColor = Color.FromArgb(100, 210, 210, 255);
        Color changedLineColor = Color.FromArgb(255, 230, 230, 255);

        public MainAutoTesting()
        {
            InitializeComponent();
            InitRun();
            getPythonLibPath();
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectProjectFolder.SelectedPath != null)
            {
                if (this.openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string openFile = this.openFileDialog.SafeFileName;
                    string openFilePath = this.openFileDialog.FileName;

                    try
                    {
                        CreateTab(openFilePath);

                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((tree_Solution.SelectedNode == null) || (tree_Solution.SelectedNode.Text == null))
            {
                MessageBox.Show("请选择要删除的节点！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (File.Exists(selectTreeNodeFullPath()))
            {
                try
                {
                    File.Delete(selectTreeNodeFullPath());
                    tree_Solution.SelectedNode.Remove();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (!tree_Solution.SelectedNode.FullPath.Contains("\\"))
                {
                    DialogResult deleteFolder = MessageBox.Show("确定要移除工程吗？", "消息提示：", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (deleteFolder == DialogResult.Yes)
                    {
                        deleteRootPaths(selectTreeNodeFullPath());
                        tree_Solution.SelectedNode.Remove();
                        InitializeControl();
                        deleteRootPaths(selectTreeNodeFullPath());
                    }
                }
                else
                {
                    try
                    {
                        DialogResult deleteFolder = MessageBox.Show("确定要删除所选内容？", "消息提示：", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (deleteFolder == DialogResult.Yes)
                        {
                            deleteRootPaths(selectTreeNodeFullPath());
                            delectDir(selectTreeNodeFullPath());
                            Directory.Delete(selectTreeNodeFullPath());
                            this.tree_Solution.SelectedNode.Remove();                            
                        }
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }         
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rightClickOnProManager.Close();
        }

        private void 红ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tree_Solution.SelectedNode != null)
            {
                tree_Solution.SelectedNode.BackColor = Color.Red;
            }
            else
            {
                toolTips.Show("请左键选中相应的节点", this.rightClickOnProManager);
                toolTips.AutoPopDelay = 10;
                toolTips.UseFading = true;
            }
        }

        private void 黄ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tree_Solution.SelectedNode.BackColor = Color.Yellow;
        }

        private void 蓝ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tree_Solution.SelectedNode.BackColor = Color.Blue;
        }

        private void 绿ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tree_Solution.SelectedNode.BackColor = Color.SpringGreen;
        }

        private void 紫ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tree_Solution.SelectedNode.BackColor = Color.Purple;
        }

        private void 粉2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tree_Solution.SelectedNode.BackColor = Color.Pink;
        }

        private void 默认DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tree_Solution.SelectedNode.BackColor = Color.White;
        }

        private void 打开文件路径ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.tree_Solution.SelectedNode!=null)
            {
                OpenFolderAndSelectFile(selectTreeNodeFullPath());
            }
            else
            {
                MessageBox.Show("请选中响应节点！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }           
        }

        private void 新建文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectProjectFolder.SelectedPath != null && selectProjectFolder.SelectedPath != "")
            {
                if (this.openFileDialog.ShowDialog() == DialogResult.OK)
                {
                   string [] openProjectPath = this.openFileDialog.SafeFileNames;
                }
            }
        }

        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            refreshTreeViewData();
        }
      
        private void 打开文件FToolStripMenu_Click(object sender, EventArgs e)
        {
            //if (selectProjectFolder.SelectedPath != null && selectProjectFolder.SelectedPath != "")
            //{
            if (this.openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string openFile = this.openFileDialog.SafeFileName;
                string openFilePath = this.openFileDialog.FileName;

                try
                {
                    CreateTab(openFilePath);

                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //}
        }

        private void 新建解决方案SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("待添加功能！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }



        private void 新建项目PToolStripMenuItem_Click(object sender, EventArgs e)
        {

            TestExerciser.Tools.AutoTestingManagement.ToolAutoNewSolution myToolNewSolution = new TestExerciser.Tools.AutoTestingManagement.ToolAutoNewSolution();
            if (myToolNewSolution.ShowDialog() == DialogResult.OK)
            {
                if (myToolNewSolution.IsCreateSolution)
                {
                    try
                    {
                        workspacePath = TestExerciser.Tools.AutoTestingManagement.ToolAutoNewSolution.projectLocation;
                        addToRootPaths(workspacePath);
                        getTreeViewData(workspacePath);
                        Properties.Settings.Default.lastProjectPath = workspacePath;
                        Properties.Settings.Default.Save();
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("创建项目失败！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void 新建文件夹RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(selectTreeNodeFullPath()) == false)
            {
                //if (selectProjectFolder.ShowDialog() == DialogResult.OK)
                //{
                //    //getTreeViewData(selectProjectFolder.SelectedPath);
                //    addToRootPaths(selectProjectFolder.SelectedPath);
                //    refreshTreeViewData();

                //}

                TestExerciser.Tools.AutoTestingManagement.ToolAutoNewFolder myToolAutoNewFolder = new TestExerciser.Tools.AutoTestingManagement.ToolAutoNewFolder();
                if (myToolAutoNewFolder.ShowDialog() == DialogResult.OK)
                {
                    if (myToolAutoNewFolder.IsCreateFolder)
                    {
                        try
                        {
                            workspacePath = TestExerciser.Tools.AutoTestingManagement.ToolAutoNewSolution.projectLocation;
                            refreshTreeViewData();
                        }
                        catch (Exception exception)
                        {
                            MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("创建文件夹失败！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择相应的文件夹！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void 新建文件FToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(selectTreeNodeFullPath()) == false)
                {
                    saveFileDialog.InitialDirectory = selectTreeNodeFullPath();
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        FileStream fs = File.Create(saveFileDialog.FileName);
                        fs.Dispose();
                        refreshTreeViewData();
                    }
                }
                else
                {
                    MessageBox.Show("请选择相应的文件夹！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void 打开支持库DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pythonEnv == null)
            {
                MessageBox.Show("请确保Python已经正确地添加到环境变量！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                getTreeViewData(Path.Combine(pythonLibPath, "site-packages"));
            }           
        }

        

        private void 重命名ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tree_Solution.SelectedNode.BeginEdit();
        }    

        private void 闭合CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tree_Solution.SelectedNode.Collapse();
        }

        private void 展开EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tree_Solution.SelectedNode.ExpandAll();
        }


      
       /// <summary>
       /// rightClickOnOutPutWindow
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void 清除CToolStripOutPut_Click(object sender, EventArgs e)
        {
            richDetails.Clear();
        }

        private void 查找FToolStripOutPut_Click(object sender, EventArgs e)
        {
            CurrentTB.ShowFindDialog();
        }

        private void 红RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richDetails.SelectionBackColor = Color.Red;
        }

        private void 粉ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richDetails.SelectionBackColor = Color.Pink;
        }

        private void 黄3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richDetails.SelectionBackColor = Color.Yellow;
        }

        private void 绿4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richDetails.SelectionBackColor = Color.SpringGreen;
        }

        private void 默认DToolStripOutPut_Click(object sender, EventArgs e)
        {
            richDetails.SelectionBackColor = Color.White;
        }

        private void 自动标记IToolStripOutPut_Click(object sender, EventArgs e)
        {

        }

        private void 自动滚屏RToolStripOutPut_Click(object sender, EventArgs e)
        {
            richDetails.SelectionStart = richDetails.TextLength;
            richDetails.ScrollToCaret();
        }

        private void 退出自动滚屏OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richDetails.SelectionStart = 0;
        }

        private void 退出EToolStripOutPut_Click(object sender, EventArgs e)
        {
            rightClickOnOutPutWindow.Close();
        }

        private void 执行项目ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.spbStatus.Visible = false;
            this.cleanUpResults();
            this.copyBinarys();
            rootFolder = selectProjectFolder.SelectedPath;
            rootFolder = selectTreeNodeFullPath();
            writeRunProjectSupportFile(rootFolder);
            path = rootFolder + @".\__runner.py";
            //runCmd("python.exe",rootFolder + @".\__runner.py");
            runCmdStread();
            sendLogMail();
        } 

        /// <summary>
        /// 执行工程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 执行工程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.spbStatus.Visible = true;
            this.cleanUpResults();
            this.copyBinarys();
            try
            {
                TreeNode root = new TreeNode();
                getResultData(root,selectTreeNodeFullPath());
                Application.DoEvents();
                getFiles(selectTreeNodeFullPath());                            
                spbStatusBegin();
                foreach (string strts in tsFilePath)
                {                    
                    if (this.spbStatus.Value < this.spbStatus.Maximum)
                    {                    
                        this.spbStatus.Value++;
                        outPut("执行进行中【" + this.spbStatus.Value.ToString() + " / " + this.spbStatus.Maximum + "】...");                       
                    }
                    else
                    {
                        outPut("执行结束...");
                    }
                    runCmd("python.exe", strts);
                    root.ImageIndex = 2;               
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 执行测试套
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 执行测试套ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.spbStatus.Visible = false;
            this.cleanUpResults();
            this.copyBinarys();
            if (Path.GetExtension(selectTreeNodeFullPath())==".ts")
            {
                Save(tsFiles.SelectedItem);
                RunAction("python.exe", selectTreeNodeFullPath());
            }
        }

        /// <summary>
        /// FormLoad事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            InitializeControl();
            this.initToolBarEnableFlase();
            timerNow_Tick(sender, e);
            
            打开支持库DToolStripMenuItem_Click(sender, e);
            if (Properties.Settings.Default.lastProjectPath != "")
            {
                if (Directory.Exists(Properties.Settings.Default.lastProjectPath))
                {
                    workspacePath = Properties.Settings.Default.lastProjectPath;
                    addToRootPaths(workspacePath);
                    getTreeViewData(workspacePath);
                }                
            }                       
        }

        /// <summary>
        /// 快捷键栏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Control | e.KeyCode == Keys.ShiftKey | e.KeyCode == Keys.F5)
            {
                this.执行项目ToolStripMenuItem_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F5 | e.KeyCode == Keys.Control)
            {
                this.执行工程ToolStripMenuItem_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F5)
            {
                this.执行测试套ToolStripMenuItem_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F6)
            {

            }
        }

        ///<summary>
        /// 运行cmd命令
        /// 不显示命令窗口
        /// </summary>
        /// <param name="cmdExe">指定应用程序的完整路径</param>
        /// <param name="cmdStr">执行命令行参数</param>
        private void runCmd(string cmdExe, string cmdStr)
        {
            try
            {
                System.Diagnostics.Process p = new System.Diagnostics.Process();
                p.StartInfo.FileName = "cmd.exe";
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardInput = true;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardError = true;
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.WorkingDirectory = selectProjectFolder.SelectedPath;
                p.Start();

                string str = string.Format(@" {0} ""{1}"" {2}", cmdExe, cmdStr, "&exit");
                p.StandardInput.WriteLine(str);
                p.StandardInput.AutoFlush = true;
                string outputMsg = p.StandardOutput.ReadToEnd();
                string errorMsg = p.StandardError.ReadToEnd();


                p.WaitForExit();
                p.Close();
                this.richResults.AppendText(outputMsg + errorMsg);
                
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void runCmd_Exited(object sender, EventArgs e)
        {
            // 执行结束后触发  
        }


        // 定义委托  
        public delegate void DelReadStdOutput(string result);
        public delegate void DelReadErrOutput(string result);
        // 定义委托事件
        public event DelReadStdOutput ReadStdOutput;
        public event DelReadErrOutput ReadErrOutput;

        // 将相应函数注册到委托事件中  
        private void InitRun()
        {           
            ReadStdOutput += new DelReadStdOutput(ReadStdOutputAction);
            ReadErrOutput += new DelReadErrOutput(ReadErrOutputAction);
        }

        private void RunAction(string StartFileName, string StartFileArg)
        {
            Process CmdProcess = new Process();
            CmdProcess.StartInfo.FileName = StartFileName;      // 命令  
            CmdProcess.StartInfo.Arguments = StartFileArg;      // 参数  

            CmdProcess.StartInfo.CreateNoWindow = true;         // 不创建新窗口  
            CmdProcess.StartInfo.UseShellExecute = false;
            CmdProcess.StartInfo.RedirectStandardInput = true;  // 重定向输入  
            CmdProcess.StartInfo.RedirectStandardOutput = true; // 重定向标准输出  
            CmdProcess.StartInfo.RedirectStandardError = true;  // 重定向错误输出  
            //CmdProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;  


            CmdProcess.EnableRaisingEvents = true;                      // 启用Exited事件  
            CmdProcess.Exited += new EventHandler(RunAction_Exited);   // 注册进程结束事件  
            CmdProcess.OutputDataReceived += new DataReceivedEventHandler(p_OutputDataReceived);
            CmdProcess.ErrorDataReceived += new DataReceivedEventHandler(p_ErrorDataReceived);
            CmdProcess.Start();

            CmdProcess.BeginOutputReadLine();
            CmdProcess.BeginErrorReadLine();


            // 如果打开注释，则以同步方式执行命令，此例子中用Exited事件异步执行。  
            // CmdProcess.WaitForExit();       
        }

        // 异步调用，需要invoke
        private void p_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {                  
                this.Invoke(ReadStdOutput, new object[] { e.Data });
            }
        }

        private void p_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                this.Invoke(ReadErrOutput, new object[] { e.Data });
            }
        }

        private void ReadStdOutputAction(string result)
        {
            this.richDetails.AppendText(result + "\r\n");
        }

        private void ReadErrOutputAction(string result)
        {
            this.richResults.AppendText(result + "\r\n");
        }

        private void RunAction_Exited(object sender, EventArgs e)
        {
            // 执行结束后触发  
        }

        /// <summary>
        /// 复制执行文件
        /// </summary>
        /// <param name="dir"></param>
        /// <param name="str"></param>
        private void copyFileToWorkspace(string dir, string str)
        {
            try
            {
                File.Copy(dir, Path.Combine(str, Path.GetFileName(dir)), true);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 获取打开文件树节点的路径
        /// </summary>
        /// <returns></returns>
        private string selectTreeNodeFullPath()
        {
            string full_path = "";
            if (tree_Solution.SelectedNode != null)
            {
                if (tree_Solution.SelectedNode.FullPath.StartsWith("site-packages"))
                {
                    full_path = Path.GetFullPath(Path.Combine(pythonEnv + "\\Lib\\", tree_Solution.SelectedNode.FullPath));
                }

                else
                {
                    if (tree_Solution.SelectedNode.FullPath.Contains("\\"))
                    {
                        try
                        {
                            string selected_node_path = tree_Solution.SelectedNode.FullPath;
                            string node_path_without_node_name = Regex.Match(selected_node_path, @"\\[\s\S]*").Value;
                            full_path = Path.GetFullPath(multipleProjectSelectedNodePath() + node_path_without_node_name);
                        }
                        catch (Exception exception)
                        {
                            MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        try
                        {
                            string selected_node_path = tree_Solution.SelectedNode.FullPath;
                            foreach (string rootPath in root_paths)
                            {
                                string root_name_str = Regex.Match(rootPath, @"[\s\S]*\\").Value;
                                string rootPathCom = Path.Combine(root_name_str + selected_node_path);
                                if (rootPathCom.Contains(rootPath))
                                {                                  
                                 full_path = rootPath;
                                }
                            }
                        }
                        catch (Exception exception)
                        {
                            MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }              
            }
            selectedNodePath = full_path;
            return full_path;
        }

        private string multipleProjectSelectedNodePath()
        {
            string root_path = null;
            string selected_node_path = tree_Solution.SelectedNode.FullPath;
            string node_path_without_node_name = Regex.Match(selected_node_path, @"[\s\S]*\\").Value;           
            foreach (string rootPath in root_paths)
            {
                string root_name_str = Regex.Match(rootPath, @"[\s\S]*\\").Value;
                string rootPathCom = Path.Combine(root_name_str + node_path_without_node_name);
                if (rootPathCom.Contains(rootPath))
                {                 
                    root_path = rootPath;
                }         
            }           
            return root_path;
        }

        private void addToRootPaths(string workspacePath)
        {
            List<string> root_paths_list = root_paths.ToList();
            root_paths_list.Add(workspacePath);
            root_paths = root_paths_list.ToArray();
        }

        private void deleteRootPaths(string workspacePath)
        {
            List<string> root_paths_list = root_paths.ToList();
            root_paths_list.Remove(workspacePath);
            root_paths = root_paths_list.ToArray();
        }

        /// <summary>
        /// 定位对应文件夹下的文件
        /// </summary>
        /// <param name="fileFullName"></param>
        private void OpenFolderAndSelectFile(String fileFullName)
        {
            System.Threading.Thread.Sleep(30);
            System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo("Explorer.exe");
            psi.Arguments = "/e,/select," + fileFullName;
            System.Diagnostics.Process.Start(psi);
        }

        /// <summary>
        /// 刷新树方法
        /// </summary>
        private void refreshTreeViewData()
        {
            if (tree_Solution.SelectedNode == null)
            {
                getTreeViewData(this.selectProjectFolder.SelectedPath);
            }
            else
            {
                tree_Solution.SelectedNode.Nodes.Clear();
                getFiles(selectTreeNodeFullPath(), tree_Solution.SelectedNode);
            }
            
        }

        /// <summary>
        /// 写入待执行文件__runner.py
        /// </summary>
        /// <param name="folder"></param>
        private void writeRunProjectSupportFile(string folder)
        {
            if (Directory.Exists(folder))
            {
                if (!File.Exists(folder + "__runner.py"))
                {
                    File.Delete(folder + "__runner.py");
                }
                FileStream fs = new FileStream(folder + "\\__runner.py", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine("#--*--uft8-*-");              
                sw.WriteLine("import os");
                sw.WriteLine("from ssas.logic import RunTestSuite");
                sw.WriteLine("if  __name__ == '__main__':");
                sw.WriteLine("    start_dir = os.path.dirname(__file__)");
                sw.WriteLine("    RunTestSuite().run(start_dir = start_dir)");
                sw.Close();
                richDetails.AppendText("The execute binary files have beed copied successfully...\n");

            }
            else
            {
                MessageBox.Show("__runner.py所对应的文件夹生成失败！", "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 树形节点双击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>      
        private void tree_Solution_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {                          
            clickTreeNodeToLoadFile();
            InitializeControl();
        }


        /// <summary>
        /// 树形节点单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tree_Solution_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            InitializeControl();
        }

        /// <summary>
        /// 创建树形节点并加载树形文件目录
        /// </summary>
        private void clickTreeNodeToLoadFile()
        {
            string selectFullPath = selectTreeNodeFullPath();
            if (File.Exists(selectFullPath))
            {
                try
                {
                    CreateTab(selectFullPath);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "异常消息提示：",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// 更改树节点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tree_Solution_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            string selected_node_path_without_node_name = Regex.Match(selectTreeNodeFullPath(), @"[\S\s]*\\").Value;
            string full_path = null;
            full_path = Path.GetFullPath(selected_node_path_without_node_name + "\\" + e.Label);
            if (e.Label != null)
            {
                treeNodeNameChanged(full_path);
                addToRootPaths(full_path);
                if (e.Label.LastIndexOf(".") + 1 != 0)
                {  
                    string ext = e.Label.Substring(e.Label.LastIndexOf(".") + 1, (e.Label.Length - e.Label.LastIndexOf(".") - 1));
                    setTreeSolutionImageIndex(ext, tree_Solution.SelectedNode);
                }
            }            
        }

        /// <summary>
        /// 树节点重命名
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeNodeNameChanged(string newNodePath)
        {
            try
            {
                FileInfo fileInfo = new FileInfo(selectTreeNodeFullPath());
                fileInfo.MoveTo(newNodePath);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
             
        }

        /// <summary>
        /// 移动文件夹中的所有文件夹与文件到另一个文件夹
        /// </summary>
        /// <param name="sourcePath">源文件夹</param>
        /// <param name="destPath">目标文件夹</param>
        private static void moveFolder(string sourcePath, string destPath)
        {
            if (Directory.Exists(sourcePath))
            {
                if (!Directory.Exists(destPath))
                {
                    //目标目录不存在则创建  
                    try
                    {
                        Directory.CreateDirectory(destPath);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("创建目标目录失败：" + ex.Message);
                    }
                }
                //获得源文件下所有文件  
                List<string> files = new List<string>(Directory.GetFiles(sourcePath));
                files.ForEach(c =>
                {
                    string destFile = Path.Combine(new string[] { destPath, Path.GetFileName(c) });
                    //覆盖模式  
                    if (File.Exists(destFile))
                    {
                        File.Delete(destFile);
                    }
                    File.Move(c, destFile);
                });
                //获得源文件下所有目录文件  
                List<string> folders = new List<string>(Directory.GetDirectories(sourcePath));

                folders.ForEach(c =>
                {
                    string destDir = Path.Combine(new string[] { destPath, Path.GetFileName(c) });
                    //Directory.Move必须要在同一个根目录下移动才有效，不能在不同卷中移动。  
                    //Directory.Move(c, destDir);  

                    //采用递归的方法实现  
                    moveFolder(c, destDir);
                });
            }
            else
            {
                throw new DirectoryNotFoundException("源目录不存在！");
            }  
        }

        /// <summary>
        /// 获取树形目录
        /// </summary>
        /// <param name="path"></param>
        public void getTreeViewData(string path)
        {
            TreeNode root = new TreeNode();
            //root.Text = "MyTest";
            getFiles(path, root);
            tree_Solution.Nodes.Add(root);
            if (root.Text == "site-packages")
            {
                root.ImageIndex = 2;
                root.SelectedImageIndex = 2;
            }
            else
            {
                root.ImageIndex = 4;
                root.SelectedImageIndex = 4;
            }
            this.KeyPreview = true;
        }

        private void getResultData(string path)
        {
            TreeNode root = new TreeNode();
            //root.Text = "MyTest";
            getFiles(path, root);
            stvStatus.Nodes.Add(root);
            stvStatus.ExpandAll();
            if (root.Text == "site-packages")
            {
                root.ImageIndex = 2;
                root.SelectedImageIndex = 2;
            }
            else
            {
                root.ImageIndex = 0;
                root.SelectedImageIndex = 0;
            }
        }

        private void getResultData(TreeNode root, string path)
        {
            //root.Text = "MyTest";
            getFiles(path, root);
            stvStatus.Nodes.Add(root);
            stvStatus.ExpandAll();
            if (root.Text == "site-packages")
            {
                root.ImageIndex = 2;
                root.SelectedImageIndex = 2;
            }
            else
            {
                root.ImageIndex = 0;
                root.SelectedImageIndex = 0;  
            } 
        }

        /// <summary>
        /// 从树形目录中读取文件，对应生成树形节点
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="node"></param>
        private void getFiles(string filePath, TreeNode node)
        {
            try
            {
                if (filePath == null || filePath == "")
                {
                    
                }
                else
                {
                    DirectoryInfo folder = new DirectoryInfo(filePath);
                    node.Text = folder.Name;
                    node.Tag = folder.FullName;
                    node.ImageIndex = 5;
                    FileInfo[] chldFiles = folder.GetFiles("*.*");
                    foreach (FileInfo chlFile in chldFiles)
                    {
                        if (!chlFile.Name.StartsWith(".") && chlFile.Name != "workspace" && chlFile.Name != "__pycache__" && !chlFile.Name.StartsWith( "__runner"))
                        {
                            TreeNode chldNode = new TreeNode();
                            chldNode.Text = chlFile.Name;
                            chldNode.Tag = chlFile.FullName;
                            string ext = chlFile.Name.Substring(chlFile.Name.LastIndexOf(".") + 1, (chlFile.Name.Length - chlFile.Name.LastIndexOf(".") - 1));
                            node.Nodes.Add(chldNode);
                            setTreeSolutionImageIndex(ext,chldNode);                                                                                     
                        }
                    }

                    DirectoryInfo[] chldFolders = folder.GetDirectories();
                    foreach (DirectoryInfo chldFolder in chldFolders)
                    {
                        if (!chldFolder.Name.StartsWith(".") && chldFolder.Name != "workspace" && chldFolder.Name != "__pycache__")
                        {
                            TreeNode chldNode = new TreeNode();
                            chldNode.Text = folder.Name;
                            chldNode.Tag = folder.FullName;
                            node.Nodes.Add(chldNode);
                            getFiles(chldFolder.FullName, chldNode);
                        }
                    }
                }               
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        string[] tsFilePath;
        List<string> tsFilePathList = new List<string>();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filePath"></param>
        private void getFiles(string filePath)
        {
            try
            {
                if (filePath == null || filePath == "")
                {

                }
                else
                {
                    DirectoryInfo folder = new DirectoryInfo(filePath);
                    FileInfo[] chldFiles = folder.GetFiles("*.*");
                    foreach (FileInfo chlFile in chldFiles)
                    {
                        if (!chlFile.Name.StartsWith(".") && chlFile.Name != "workspace" && chlFile.Name != "__pycache__" && !chlFile.Name.StartsWith("__runner"))
                        {
                            TreeNode chldNode = new TreeNode();
                            chldNode.Text = chlFile.Name;
                            chldNode.Tag = chlFile.FullName;
                            string ext = chlFile.Name.Substring(chlFile.Name.LastIndexOf(".") + 1, (chlFile.Name.Length - chlFile.Name.LastIndexOf(".") - 1));
                            if (ext == "ts")
                            {
                                tsFilePathList.Add( chlFile.FullName);
                                tsFilePath = tsFilePathList.ToArray();
                            }
                        }
                    }

                    DirectoryInfo[] chldFolders = folder.GetDirectories();
                    foreach (DirectoryInfo chldFolder in chldFolders)
                    {
                        if (!chldFolder.Name.StartsWith(".") && chldFolder.Name != "workspace" && chldFolder.Name != "__pycache__")
                        {
                            getFiles(chldFolder.FullName);
                        }
                    }
                }              
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 清理文件夹
        /// </summary>
        /// <param name="srcPath"></param>
        private void delectDir(string srcPath)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(srcPath);
                FileSystemInfo[] fileinfo = dir.GetFileSystemInfos();  //返回目录中所有文件和子目录
                foreach (FileSystemInfo i in fileinfo)
                {
                    if (i is DirectoryInfo)
                    {
                        DirectoryInfo subdir = new DirectoryInfo(i.FullName);
                        subdir.Delete(true);          //删除子目录和文件
                    }
                    else
                    {
                        File.Delete(i.FullName);      //删除指定文件
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// 获取文件的字符编码
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public Encoding getCodeString(String filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.Open, System.IO.FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            Byte[] buffer = br.ReadBytes(2);
            br.Close();
            fs.Close();
            if (buffer[0] >= 0xEF)
            {
                if (buffer[0] == 0xEF && buffer[1] == 0xBB)
                {
                    return System.Text.Encoding.UTF8;
                }
                else if (buffer[0] == 0xFE && buffer[1] == 0xFF)
                {
                    return System.Text.Encoding.BigEndianUnicode;
                }
                else if (buffer[0] == 0xFF && buffer[1] == 0xFE)
                {
                    return System.Text.Encoding.Unicode;
                }
                else
                {
                    return System.Text.Encoding.Default;
                }
            }
            else
            {
                return System.Text.Encoding.Default;
            }
        }


        /// <summary>
        /// 修改文件的字符编码
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="oldEncoding"></param>
        /// <param name="newEncoding"></param>
        public void changeFileCodeing(String filePath, Encoding oldEncoding, Encoding newEncoding)
        {
            FileStream fs = new FileStream(filePath, FileMode.Open);
            StreamReader sr = new StreamReader(fs, oldEncoding);
            FileStream fsw = new FileStream(filePath + ".temp", FileMode.OpenOrCreate);
            BinaryWriter bw = new BinaryWriter(fsw, newEncoding);

            char[] buffer = new char[1024];
            int i = sr.Read(buffer, 0, 1024);
            while (i > 0)
            {
                //转换  
                Byte[] buf = newEncoding.GetBytes(buffer, 0, i);
                bw.Write(buf);
                i = sr.Read(buffer, 0, 1024);
            }
            sr.Close();
            bw.Close();
            fs.Close();
            fsw.Close();
            File.Delete(filePath);
            File.Move(filePath + ".temp", filePath);
        }

        
        private void CreateTab(string fileName)
        {
            try
            {
                var tb = new Editor();
                tb.Font = new Font("Consolas", 9.75f);
                tb.ImeMode = ImeMode.On;
                tb.ContextMenuStrip = cmMain;
                tb.Dock = DockStyle.Fill;
                tb.BorderStyle = BorderStyle.Fixed3D;
                tb.LeftPadding = 17;
                if (this.pythonToolStripMenuItem.Checked == true)
                {
                    tb.Language = Language.Python;
                }
                else if (this.rubyToolStripMenuItem.Checked == true)
                {
                    tb.Language = Language.Ruby;
                }
                else if (this.csToolStripMenuItem.Checked == true)
                {
                    tb.Language = Language.CSharp;
                }
                else if (this.pHPToolStripMenuItem.Checked == true)
                {
                    tb.Language = Language.PHP;
                }
                else if (this.vbToolStripMenuItem.Checked == true)
                {
                    tb.Language = Language.VB;
                }
                else if (this.hTMLToolStripMenuItem.Checked == true)
                {
                    tb.Language = Language.HTML;
                }
                else if (this.xMLToolStripMenuItem.Checked == true)
                {
                    tb.Language = Language.XML;
                }
                else if (this.sQLToolStripMenuItem.Checked == true)
                {
                    tb.Language = Language.SQL;
                }
                else if (this.jSToolStripMenuItem.Checked == true)
                {
                    tb.Language = Language.JS;
                }
                else if (this.luaToolStripMenuItem.Checked == true)
                {
                    tb.Language = Language.Lua;
                }
                tb.AddStyle(new MarkerStyle(new SolidBrush(Color.FromArgb(50, Color.Gray))));//same words style
                var tab = new FATabStripItem(fileName != null ? Path.GetFileName(fileName) : "[new]", tb);
                tab.Tag = fileName;
                if (fileName != null)
                    tb.Text = File.ReadAllText(fileName);                               
                tb.ClearUndo();
                tb.Tag = new TbInfo();
                tb.IsChanged = false;
                tsFiles.AddTab(tab);
                tsFiles.SelectedItem = tab;
                tb.Focus();
                tb.DelayedTextChangedInterval = 100;
                tb.DelayedEventsInterval = 100;
                tb.TextChangedDelayed += new EventHandler<TextChangedEventArgs>(tTextChangedDelayed);
                tb.SelectionChangedDelayed += new EventHandler(tSelectionChangedDelayed);
                tb.KeyDown += new KeyEventHandler(tKeyDown);
                tb.MouseMove += new MouseEventHandler(tMouseMove);
                tb.LineRemoved += new EventHandler<LineRemovedEventArgs>(tLineRemoved);
                tb.PaintLine += new EventHandler<PaintLineEventArgs>(tPaintLine);               
                tb.ChangedLineColor = changedLineColor;
                if (btHighlightCurrentLine.Checked)
                    tb.CurrentLineColor = currentLineColor;
                tb.ShowFoldingLines = btShowFoldingLines.Checked;
                tb.HighlightingRangeType = HighlightingRangeType.VisibleRange;
                //Create AutocompleteMenu
                if (this.pythonToolStripMenuItem.Checked == true)
                {
                    AutocompleteMenu popupMenu = new AutocompleteMenu(tb);
                    popupMenu.Items.ImageList = ilAutocomplete;
                    popupMenu.Opening += new EventHandler<CancelEventArgs>(popupMenu_Opening);
                    AutoComplete myAutoComplete = new AutoComplete();
                    myAutoComplete.buildAutoCompleteMenu(popupMenu);
                    (tb.Tag as TbInfo).popupMenu = popupMenu;
                }
                this.initToolBarEnableTrue();
            }
            catch (Exception ex)
            {
                if (MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == System.Windows.Forms.DialogResult.Retry)
                    CreateTab(fileName);
            }
        }

        void tMouseMove(object sender, MouseEventArgs e)
        {
            var tb = sender as Editor;
            var place = tb.PointToPlace(e.Location);
            var r = new Range(tb, place, place);
            string text = r.GetFragment("[a-zA-Z]").Text;
            lbWordUnderMouse.Text = text;
        }

        void tKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.OemMinus)
            {
                NavigateBackward();
                e.Handled = true;
            }

            if (e.Modifiers == (Keys.Control | Keys.Shift) && e.KeyCode == Keys.OemMinus)
            {
                NavigateForward();
                e.Handled = true;
            }

            if (e.KeyData == (Keys.K | Keys.Control))
            {
                //forced show (MinFragmentLength will be ignored)
                (CurrentTB.Tag as TbInfo).popupMenu.Show(true);
                e.Handled = true;
            }

            if (e.KeyData == (Keys.S | Keys.Control))
            {
                Save(tsFiles.SelectedItem);
                ToolBalloon tb = new ToolBalloon();
                tb.BalloonText = "保存成功!";
                tb.Show();
                e.Handled = true;
            }
        }

        void tSelectionChangedDelayed(object sender, EventArgs e)
        {
            var tb = sender as Editor;
            //remember last visit time
            if (tb.Selection.IsEmpty && tb.Selection.Start.iLine < tb.LinesCount)
            {
                if (lastNavigatedDateTime != tb[tb.Selection.Start.iLine].LastVisit)
                {
                    tb[tb.Selection.Start.iLine].LastVisit = DateTime.Now;
                    lastNavigatedDateTime = tb[tb.Selection.Start.iLine].LastVisit;
                }
            }

            //highlight same words
            tb.VisibleRange.ClearStyle(tb.Styles[0]);
            if (!tb.Selection.IsEmpty)
                return;//user selected diapason
            //get fragment around caret
            var fragment = tb.Selection.GetFragment(@"\w");
            string text = fragment.Text;
            if (text.Length == 0)
                return;
            //highlight same words
            var ranges = tb.VisibleRange.GetRanges("\\b" + text + "\\b").ToArray();
            if (ranges.Length > 1)
                foreach (var r in ranges)
                    r.SetStyle(tb.Styles[0]);
        }

        void tTextChangedDelayed(object sender, TextChangedEventArgs e)
        {
            Editor tb = (sender as Editor);
            //rebuild object explorer
            string text = (sender as Editor).Text;
            ThreadPool.QueueUserWorkItem(
                (o) => ReBuildObjectExplorer(text)
            );

            //show invisible chars
            HighlightInvisibleChars(e.ChangedRange);

            //delete all markers
            tb.Range.ClearFoldingMarkers();

            var currentIndent = 0;
            var lastNonEmptyLine = 0;

            

            for (int i = 0; i < tb.LinesCount; i++)
            {
                var line = tb[i];
                var spacesCount = line.StartSpacesCount;
                if (spacesCount == line.Count) //empty line
                    continue;

                if (currentIndent < spacesCount)
                    //append start folding marker
                    tb[lastNonEmptyLine].FoldingStartMarker = "m" + currentIndent;
                else
                    if (currentIndent > spacesCount)
                        //append end folding marker
                        tb[lastNonEmptyLine].FoldingEndMarker = "m" + spacesCount;

                currentIndent = spacesCount;
                lastNonEmptyLine = i;
            }
        }

        void tLineRemoved(object sender, LineRemovedEventArgs e)
        {
            TbInfo info = (sender as Editor).Tag as TbInfo;

            //remove lines from bookmarks
            foreach (int id in e.RemovedLineUniqueIds)
                if (info.bookmarksLineId.Contains(id))
                {
                    info.bookmarksLineId.Remove(id);
                    info.bookmarks.Remove(id);
                }
        }

        void tPaintLine(object sender, PaintLineEventArgs e)
        {
            TbInfo info = (sender as Editor).Tag as TbInfo;

            //draw bookmark
            if (info.bookmarksLineId.Contains((sender as Editor)[e.LineIndex].UniqueId))
            {
                e.Graphics.FillEllipse(new LinearGradientBrush(new Rectangle(0, e.LineRect.Top, 15, 15), Color.White, Color.PowderBlue, 45), 0, e.LineRect.Top, 15, 15);
                e.Graphics.DrawEllipse(Pens.PowderBlue, 0, e.LineRect.Top, 15, 15);
            }
        }

        void popupMenu_Opening(object sender, CancelEventArgs e)
        {
            //---block autocomplete menu for comments
            //get index of green style (used for comments)
            var iGreenStyle = CurrentTB.GetStyleIndex(CurrentTB.SyntaxHighlighter.GreenStyle);
            if (iGreenStyle >= 0)
                if (CurrentTB.Selection.Start.iChar > 0)
                {
                    //current char (before caret)
                    var c = CurrentTB[CurrentTB.Selection.Start.iLine][CurrentTB.Selection.Start.iChar - 1];
                    //green Style
                    var greenStyleIndex = Range.ToStyleIndex(iGreenStyle);
                    //if char contains green style then block popup menu
                    if ((c.style & greenStyleIndex) != 0)
                        e.Cancel = true;
                }
        }

        private bool NavigateBackward()
        {
            DateTime max = new DateTime();
            int iLine = -1;
            Editor tb = null;
            for (int iTab = 0; iTab < tsFiles.Items.Count; iTab++)
            {
                var t = (tsFiles.Items[iTab].Controls[0] as Editor);
                for (int i = 0; i < t.LinesCount; i++)
                    if (t[i].LastVisit < lastNavigatedDateTime && t[i].LastVisit > max)
                    {
                        max = t[i].LastVisit;
                        iLine = i;
                        tb = t;
                    }
            }
            if (iLine >= 0)
            {
                tsFiles.SelectedItem = (tb.Parent as FATabStripItem);
                tb.Navigate(iLine);
                lastNavigatedDateTime = tb[iLine].LastVisit;
                Console.WriteLine("Backward: " + lastNavigatedDateTime);
                tb.Focus();
                tb.Invalidate();
                return true;
            }
            else
                return false;
        }

        private bool NavigateForward()
        {
            DateTime min = DateTime.Now;
            int iLine = -1;
            Editor tb = null;
            for (int iTab = 0; iTab < tsFiles.Items.Count; iTab++)
            {
                var t = (tsFiles.Items[iTab].Controls[0] as Editor);
                for (int i = 0; i < t.LinesCount; i++)
                    if (t[i].LastVisit > lastNavigatedDateTime && t[i].LastVisit < min)
                    {
                        min = t[i].LastVisit;
                        iLine = i;
                        tb = t;
                    }
            }
            if (iLine >= 0)
            {
                tsFiles.SelectedItem = (tb.Parent as FATabStripItem);
                tb.Navigate(iLine);
                lastNavigatedDateTime = tb[iLine].LastVisit;
                Console.WriteLine("Forward: " + lastNavigatedDateTime);
                tb.Focus();
                tb.Invalidate();
                return true;
            }
            else
                return false;
        }

        DateTime lastNavigatedDateTime = DateTime.Now;

        private void HighlightInvisibleChars(Range range)
        {
            range.ClearStyle(invisibleCharsStyle);
            if (btInvisibleChars.Checked)
                range.SetStyle(invisibleCharsStyle, @".$|.\r\n|\s");
        }

        List<ExplorerItem> explorerList = new List<ExplorerItem>();

        private void ReBuildObjectExplorer(string text)
        {
            try
            {
                List<ExplorerItem> list = new List<ExplorerItem>();
                int lastClassIndex = -1;
                //find classes, methods and properties
                Regex regex = new Regex(@"^(?<range>[\w\s]+\b(class|def|enum|interface)\s+[\w<>,\s]+)|^\s*(public|private|internal|protected)[^\n]+(\n?\s*{|;)?", RegexOptions.Multiline);
                regex.Matches(text);
                foreach (Match r in regex.Matches(text))
                    try
                    {
                        string s = r.Value;
                        int i = s.IndexOfAny(new char[] { '=', '{', ';' });
                        if (i >= 0)
                            s = s.Substring(0, i);
                        s = s.Trim();

                        var item = new ExplorerItem() { title = s, position = r.Index };
                        if (Regex.IsMatch(item.title, @"\b(class|enum|interface)\b"))
                        {
                            item.title = item.title.Substring(item.title.LastIndexOf(' ')).Trim();
                            item.type = ExplorerItemType.Class;
                            list.Sort(lastClassIndex + 1, list.Count - (lastClassIndex + 1), new ExplorerItemComparer());
                            lastClassIndex = list.Count;
                        }
                        else
                            if (item.title.Contains(" event "))
                            {
                                int ii = item.title.LastIndexOf(' ');
                                item.title = item.title.Substring(ii).Trim();
                                item.type = ExplorerItemType.Event;
                            }
                            else
                                if (item.title.Contains("("))
                                {
                                    var parts = item.title.Split('(');
                                    item.title = parts[0].Substring(parts[0].LastIndexOf(' ')).Trim() + "(" + parts[1];
                                    item.type = ExplorerItemType.Method;
                                }
                                else
                                    if (item.title.EndsWith("]"))
                                    {
                                        var parts = item.title.Split('[');
                                        if (parts.Length < 2) continue;
                                        item.title = parts[0].Substring(parts[0].LastIndexOf(' ')).Trim() + "[" + parts[1];
                                        item.type = ExplorerItemType.Method;
                                    }
                                    else
                                    {
                                        int ii = item.title.LastIndexOf(' ');
                                        item.title = item.title.Substring(ii).Trim();
                                        item.type = ExplorerItemType.Method;
                                    }
                        list.Add(item);
                    }
                    catch { ;}

                list.Sort(lastClassIndex + 1, list.Count - (lastClassIndex + 1), new ExplorerItemComparer());

                BeginInvoke(
                    new Action(() =>
                    {
                        explorerList = list;
                        dgvObjectExplorer.RowCount = explorerList.Count;
                        dgvObjectExplorer.Invalidate();
                    })
                );
            }
            catch { ;}
        }

        enum ExplorerItemType
        {
            Class, Method, Property, Event
        }

        class ExplorerItem
        {
            public ExplorerItemType type;
            public string title;
            public int position;
        }

        class ExplorerItemComparer : IComparer<ExplorerItem>
        {
            public int Compare(ExplorerItem x, ExplorerItem y)
            {
                return x.title.CompareTo(y.title);
            }
        }


        Editor CurrentTB
        {
            get
            {
                if (tsFiles.SelectedItem == null)
                    return null;
                return (tsFiles.SelectedItem.Controls[0] as Editor);
            }

            set
            {
                tsFiles.SelectedItem = (value.Parent as FATabStripItem);
                value.Focus();
            }
        }

        public class InvisibleCharsRenderer : Style
        {
            Pen pen;

            public InvisibleCharsRenderer(Pen pen)
            {
                this.pen = pen;
            }

            public override void Draw(Graphics gr, Point position, Range range)
            {
                var tb = range.tb;
                using (Brush brush = new SolidBrush(pen.Color))
                    foreach (var place in range)
                    {
                        switch (tb[place].c)
                        {
                            case ' ':
                                {
                                    var point = tb.PlaceToPoint(place);
                                    point.Offset(tb.CharWidth / 2, tb.CharHeight / 2);
                                    gr.DrawLine(pen, point.X, point.Y, point.X + 1, point.Y);
                                    if (tb[place.iLine].Count - 1 == place.iChar)
                                        goto default;
                                    break;
                                }
                            default:
                                if (tb[place.iLine].Count - 1 == place.iChar)
                                {
                                    var point = tb.PlaceToPoint(place);
                                    point.Offset(tb.CharWidth, 0);
                                    gr.DrawString("¶", tb.Font, brush, point);
                                }
                                break;
                        }
                    }
            }
        }

        public class TbInfo
        {
            // Key - Line.UniqueId
            public HashSet<int> bookmarksLineId = new HashSet<int>();
            // Index - bookmark number, Value - Line.UniqueId
            public List<int> bookmarks = new List<int>();
            //
            public AutocompleteMenu popupMenu;
        }

        private bool Save(FATabStripItem tab)
        {
            var tb = (tab.Controls[0] as Editor);
            if (tab.Tag == null)
            {
                if (saveFileDialog.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                    return false;
                tab.Title = Path.GetFileName(saveFileDialog.FileName);
                tab.Tag = saveFileDialog.FileName;
            }

            try
            {
                File.WriteAllText(tab.Tag as string, tb.Text);
                tb.IsChanged = false;
            }
            catch (Exception ex)
            {
                if (MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                    return Save(tab);
                else
                    return false;
            }

            tb.Invalidate();

            return true;
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            CreateTab(null);
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                CreateTab(openFileDialog.FileName);
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (tsFiles.SelectedItem != null)
                Save(tsFiles.SelectedItem);
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            if (CurrentTB != null)
            {
                var settings = new PrintDialogSettings();
                settings.Title = tsFiles.SelectedItem.Title;
                settings.Header = "&b&w&b";
                settings.Footer = "&b&p";
                CurrentTB.Print(settings);
            }
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            CurrentTB.Cut();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            CurrentTB.Copy();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            CurrentTB.Paste();
        }

        private void btInvisibleChars_Click(object sender, EventArgs e)
        {
            foreach (FATabStripItem tab in tsFiles.Items)
                HighlightInvisibleChars((tab.Controls[0] as Editor).Range);
            if (CurrentTB != null)
                CurrentTB.Invalidate();
        }

        private void btHighlightCurrentLine_Click(object sender, EventArgs e)
        {
            foreach (FATabStripItem tab in tsFiles.Items)
            {
                if (btHighlightCurrentLine.Checked)
                    (tab.Controls[0] as Editor).CurrentLineColor = currentLineColor;
                else
                    (tab.Controls[0] as Editor).CurrentLineColor = Color.Transparent;
            }
            if (CurrentTB != null)
                CurrentTB.Invalidate();
        }

        private void btShowFoldingLines_Click(object sender, EventArgs e)
        {
            foreach (FATabStripItem tab in tsFiles.Items)
                (tab.Controls[0] as Editor).ShowFoldingLines = btShowFoldingLines.Checked;
            if (CurrentTB != null)
                CurrentTB.Invalidate();
        }

        private void undoStripButton_Click(object sender, EventArgs e)
        {
            if (CurrentTB.UndoEnabled)
                CurrentTB.Undo();
        }

        private void redoStripButton_Click(object sender, EventArgs e)
        {
            if (CurrentTB.RedoEnabled)
                CurrentTB.Redo();
        }

        private void backStripButton_Click(object sender, EventArgs e)
        {
            NavigateBackward();
        }

        private void forwardStripButton_Click(object sender, EventArgs e)
        {
            NavigateForward();
        }

        private void bookmarkPlusButton_Click(object sender, EventArgs e)
        {
            if (CurrentTB == null)
                return;
            CurrentTB.BookmarkLine(CurrentTB.Selection.Start.iLine);
        }

        private void bookmarkMinusButton_Click(object sender, EventArgs e)
        {
            if (CurrentTB == null)
                return;
            CurrentTB.UnbookmarkLine(CurrentTB.Selection.Start.iLine);
        }

        private void gotoButton_DropDownOpening(object sender, EventArgs e)
        {
            gotoButton.DropDownItems.Clear();
            foreach (Control tab in tsFiles.Items)
            {
                Editor tb = tab.Controls[0] as Editor;
                foreach (var bookmark in tb.Bookmarks)
                {
                    var item = gotoButton.DropDownItems.Add(bookmark.Name + " [" + Path.GetFileNameWithoutExtension(tab.Tag as String) + "]");
                    item.Tag = bookmark;
                    item.Click += (o, a) =>
                    {
                        var b = (Bookmark)(o as ToolStripItem).Tag;
                        try
                        {
                            CurrentTB = b.TB;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        b.DoVisible();
                    };
                }
            }
        }

        bool tbFindChanged = false;
        private void tbFind_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r' && CurrentTB != null)
            {
                Range r = tbFindChanged ? CurrentTB.Range.Clone() : CurrentTB.Selection.Clone();
                tbFindChanged = false;
                r.End = new Place(CurrentTB[CurrentTB.LinesCount - 1].Count, CurrentTB.LinesCount - 1);
                var pattern = Regex.Escape(tbFind.Text);
                foreach (var found in r.GetRanges(pattern))
                {
                    found.Inverse();
                    CurrentTB.Selection = found;
                    CurrentTB.DoSelectionVisible();
                    return;
                }
                MessageBox.Show("没有找到匹配项！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                tbFindChanged = true;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            List<FATabStripItem> list = new List<FATabStripItem>();
            foreach (FATabStripItem tab in tsFiles.Items)
                list.Add(tab);
            foreach (var tab in list)
            {
                TabStripItemClosingEventArgs args = new TabStripItemClosingEventArgs(tab);
                tsFiles_TabStripItemClosing(args);
                if (args.Cancel)
                {
                    e.Cancel = true;
                    return;
                }
                tsFiles.RemoveTab(tab);
            }
        }

        private void tsFiles_TabStripItemSelectionChanged(TabStripItemChangedEventArgs e)
        {
            if (CurrentTB != null)
            {
                CurrentTB.Focus();
                string text = CurrentTB.Text;
                ThreadPool.QueueUserWorkItem(
                    (o) => ReBuildObjectExplorer(text)
                );
            }
        }

        private void tsFiles_TabStripItemClosing(TabStripItemClosingEventArgs e)
        {
            if ((e.Item.Controls[0] as Editor).IsChanged)
            {
                switch (MessageBox.Show("您确定要保存文件： " + e.Item.Title + "吗 ?", "保存提示：", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information))
                {
                    case System.Windows.Forms.DialogResult.Yes:
                        if (!Save(e.Item))
                            e.Cancel = true;
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                }
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentTB.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentTB.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentTB.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentTB.Selection.SelectAll();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CurrentTB.UndoEnabled)
                CurrentTB.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CurrentTB.UndoEnabled)
                CurrentTB.Redo();
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentTB.ShowFindDialog();
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentTB.ShowReplaceDialog();
        }

        private void autoIndentSelectedTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentTB.DoAutoIndent();
        }

        private void commentSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentTB.InsertLinePrefix("#");
        }

        private void uncommentSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentTB.RemoveLinePrefix("#");
        }

        private void cloneLinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //expand selection
            CurrentTB.Selection.Expand();
            //get text of selected lines
            string text = Environment.NewLine + CurrentTB.Selection.Text;
            //move caret to end of selected lines
            CurrentTB.Selection.Start = CurrentTB.Selection.End;
            //insert text
            CurrentTB.InsertText(text);
        }

        private void cloneLinesAndCommentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //start autoUndo block
            CurrentTB.BeginAutoUndo();
            //expand selection
            CurrentTB.Selection.Expand();
            //get text of selected lines
            string text = Environment.NewLine + CurrentTB.Selection.Text;
            //comment lines
            CurrentTB.InsertLinePrefix("#");
            //move caret to end of selected lines
            CurrentTB.Selection.Start = CurrentTB.Selection.End;
            //insert text
            CurrentTB.InsertText(text);
            //end of autoUndo block
            CurrentTB.EndAutoUndo();
        }

        private void 新建NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTab(null);
            
        }

        private void 打开解决方案SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("待添加功能！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void 打开项目PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectProjectFolder.ShowDialog() == DialogResult.OK)
            {
                workspacePath = selectProjectFolder.SelectedPath;
                if (Array.IndexOf<string>(root_paths, workspacePath) != -1)
                {
                    MessageBox.Show("打开项目名称冲突，请修改工程名称！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    addToRootPaths(workspacePath);
                    getTreeViewData(workspacePath);
                    Properties.Settings.Default.lastProjectPath=workspacePath;
                    Properties.Settings.Default.Save();
                }
            }
        }


        private void 保存SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tsFiles.SelectedItem != null)
                Save(tsFiles.SelectedItem);
        }

        private void 另存为AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tsFiles.SelectedItem != null)
            {
                string oldFile = tsFiles.SelectedItem.Tag as string;
                tsFiles.SelectedItem.Tag = null;
                if (!Save(tsFiles.SelectedItem))
                    if (oldFile != null)
                    {
                        tsFiles.SelectedItem.Tag = oldFile;
                        tsFiles.SelectedItem.Title = Path.GetFileName(oldFile);
                    }
            }
        }

        private void 退出QToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// 设置控件为不可见状态
        /// </summary>
        private void InitMenuItemToFlase()
        {
            this.删除ToolStripMenuItem.Visible = false;
            this.刷新ToolStripMenuItem.Visible = false;
            this.闭合CToolStripMenuItem.Visible = false;
            this.展开EToolStripMenuItem.Visible = false;
            this.标识ToolStripMenuItem.Visible = false;
            this.重命名ToolStripMenuItem.Visible = false;
            this.执行测试套ToolStripMenuItem.Enabled = false;
            this.执行项目ToolStripMenuItem.Enabled = false;
            this.执行工程ToolStripMenuItem.Enabled = false;
            this.自动标记IToolStripOutPut.Visible = false;
            this.自动滚屏RToolStripOutPut.Visible = false;
            this.打开文件路径ToolStripMenuItem.Visible = false;
        }


        /// <summary>
        /// 初始化右键菜单栏
        /// </summary>
        private void InitializeControl()
        {
            this.spbStatus.Visible = false;
            this.pythonToolStripMenuItem.Checked = true;
            this.执行项目ToolStripMenuItem.Enabled = false;
            this.执行工程ToolStripMenuItem.Enabled = false;
            this.执行测试套ToolStripMenuItem.Enabled = false;
            if (tree_Solution.SelectedNode == null)
            {
                this.KeyPreview = false;
                InitMenuItemToFlase();
                selectProjectFolder.SelectedPath = null;
                this.tsbStart.Visible = false;
            }
            else if (tree_Solution.SelectedNode.Text == null) 
            {
                InitMenuItemToFlase();
            }
            else
            {
                setSelectedNodeBackColor();
                if (tree_Solution.SelectedNode.FullPath.Contains("\\"))
                {
                    string  selectFullPath = selectTreeNodeFullPath();

                    this.KeyPreview = true;
                    this.删除ToolStripMenuItem.Visible = true;
                    this.标识ToolStripMenuItem.Visible = true;
                    this.打开文件路径ToolStripMenuItem.Visible = true;
                    this.刷新ToolStripMenuItem.Visible = true;
                    this.重命名ToolStripMenuItem.Visible = true;
                    this.tsbStart.Visible = true;

                    if (Directory.Exists(selectFullPath))
                    {                        
                        this.执行工程ToolStripMenuItem.Enabled = true;
                        this.闭合CToolStripMenuItem.Visible = true;
                        this.展开EToolStripMenuItem.Visible = true;
                        this.刷新ToolStripMenuItem.Visible = true;
                        this.新建文件夹RToolStripMenuItem.Visible = true;
                        this.新建文件ToolStripMenuItem.Visible = true;
                    }
                    else
                    {
                        this.执行工程ToolStripMenuItem.Enabled = false;
                        this.闭合CToolStripMenuItem.Visible = false;
                        this.展开EToolStripMenuItem.Visible = false;
                        this.刷新ToolStripMenuItem.Visible = false;
                        this.新建文件夹RToolStripMenuItem.Visible = false;
                        this.新建文件ToolStripMenuItem.Visible = false;
                    }
                    if (File.Exists(selectFullPath))
                    {
                        this.执行测试套ToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        this.执行测试套ToolStripMenuItem.Enabled = false;
                    }
                }
                else
                {
                    this.执行项目ToolStripMenuItem.Enabled = true;
                    this.闭合CToolStripMenuItem.Visible = true;
                    this.展开EToolStripMenuItem.Visible = true;
                    this.刷新ToolStripMenuItem.Visible = true;
                    this.新建文件夹RToolStripMenuItem.Visible = true;
                    this.新建文件ToolStripMenuItem.Visible = true;
                    this.打开文件路径ToolStripMenuItem.Visible = true;
                    this.删除ToolStripMenuItem.Visible = true;
                }           
            }
        }


        /// <summary>
        /// 选中树节点事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tree_Solution_AfterSelect(object sender, TreeViewEventArgs e)
        {
            InitializeControl();
        }

        private static string tryGetSoftwarePath(string softName)
        {
            string strPathResult = string.Empty;
            string strKeyName = "";     //"(Default)" key, which contains the intalled path
            object objResult = null;

            Microsoft.Win32.RegistryValueKind regValueKind;
            Microsoft.Win32.RegistryKey regKey = null;
            Microsoft.Win32.RegistryKey regSubKey = null;

            try
            {
                //Read the key
                regKey = Microsoft.Win32.Registry.LocalMachine;
                regSubKey = regKey.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\" + softName.ToString() + ".exe", false);

                //Read the path
                objResult = regSubKey.GetValue(strKeyName);
                regValueKind = regSubKey.GetValueKind(strKeyName);

                //Set the path
                if (regValueKind == Microsoft.Win32.RegistryValueKind.String)
                {
                    strPathResult = objResult.ToString();
                }
            }
            catch (System.Security.SecurityException ex)
            {
                throw new System.Security.SecurityException("您没有权限读取注册表！", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("读取注册错误！", ex);
            }
            finally
            {

                if (regKey != null)
                {
                    regKey.Close();
                    regKey = null;
                }

                if (regSubKey != null)
                {
                    regSubKey.Close();
                    regSubKey = null;
                }
            }

            if (strPathResult == string.Empty)
            {
                //Not found
                MessageBox.Show("无法找到程序集路径！请尝试通过“打开项目”打开文件路径！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            //Found
            return strPathResult;
        } 

        private void getPythonLibPath()
        {
            string pathExt = "lib\\site-packages";
            string environment = Environment.GetEnvironmentVariable("Path");
            string [] paths = environment.Split(';');
            string pathWithOutSlash = null;
            foreach (string path in paths)
            {
                bool foundMatch = false;                
                try
                {
                    foundMatch = Regex.IsMatch(path, @"\\Python\d{0,2}\-{0,1}\d{0,2}", RegexOptions.IgnoreCase | RegexOptions.Singleline);
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                pathWithOutSlash = path.TrimEnd(new char[] { '\\' });

                if (foundMatch)
                {
                    if (File.Exists(path + "python.exe"))
                    {
                        if (Directory.Exists(Path.Combine(pathWithOutSlash, pathExt)))
                        {
                            pythonEnv = pathWithOutSlash;
                            pythonLibPath = Path.Combine(pathWithOutSlash, "lib\\");
                        }  
                    }
                }
            }
        }

        public void ChangeKeyColor(string key, Color color)
        {
            Regex regex = new Regex(key);
            //找出内容中所有的要替换的关键字
            MatchCollection collection = regex.Matches(richDetails.Text);
            //对所有的要替换颜色的关键字逐个替换颜色    
            foreach (Match match in collection)
            {
                //开始位置、长度、颜色缺一不可
                richDetails.SelectionStart = match.Index;
                richDetails.SelectionLength = key.Length;
                richDetails.SelectionColor = color;
            }
        }

        private void dgvObjectExplorer_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (CurrentTB != null)
            {
                var item = explorerList[e.RowIndex];
                CurrentTB.GoEnd();
                CurrentTB.SelectionStart = item.position;
                CurrentTB.DoSelectionVisible();
                CurrentTB.Focus();
            }
        }

        private void dgvObjectExplorer_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            try
            {
                ExplorerItem item = explorerList[e.RowIndex];
                if (e.ColumnIndex == 1)
                    e.Value = item.title;
                else
                    switch (item.type)
                    {
                        case ExplorerItemType.Class:
                            e.Value = global::TestExerciser.Properties.Resources.class_libraries;
                            return;
                        case ExplorerItemType.Method:
                            e.Value = global::TestExerciser.Properties.Resources.box;
                            return;
                        case ExplorerItemType.Event:
                            e.Value = global::TestExerciser.Properties.Resources.lightning;
                            return;
                        case ExplorerItemType.Property:
                            e.Value = global::TestExerciser.Properties.Resources.property;
                            return;
                    }
            }
            catch { ;}
        }


        TreeNode[] selectedNode = { };
        private void setSelectedNodeBackColor()
        {
            List<TreeNode> selectedNode_list = selectedNode.ToList();
            selectedNode_list.Add(tree_Solution.SelectedNode);
            selectedNode = selectedNode_list.ToArray();
            if (selectedNode.Length == 1)
            {
                if (selectedNode[selectedNode.Length - 1] != null)
                {
                    selectedNode[selectedNode.Length - 1].BackColor = Color.LightGray;
                }              
            }
            else if (selectedNode.Length == 2)
            {
                if (selectedNode[selectedNode.Length - 1] != selectedNode[selectedNode.Length - 2])
                {
                    selectedNode[selectedNode.Length - 1].BackColor = Color.LightGray;
                    selectedNode[0].BackColor = Color.White;
                }
            }
            else if (selectedNode.Length > 2)
            {
                if (selectedNode[selectedNode.Length - 1] != selectedNode[selectedNode.Length - 2])
                {
                    selectedNode[selectedNode.Length - 1].BackColor = Color.LightGray;
                    selectedNode[selectedNode.Length - 2].BackColor = Color.White;
                }
            }        
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void setTreeSolutionImageIndex(string ext,TreeNode node)
        {

            if (ext == "ts")
            {
                node.ImageIndex = 1;
                node.SelectedImageIndex = 1;
            }
            else if (ext == "tc")
            {
                node.ImageIndex = 0;
                node.SelectedImageIndex = 0;
            }
            else if (ext == "py")
            {
                node.ImageIndex = 3;
                node.SelectedImageIndex = 3;
            }
            else if (ext == "cs")
            {
                node.ImageIndex = 6;
                node.SelectedImageIndex = 6;
            }
            else if (ext == "rb")
            {
                node.ImageIndex = 7;
                node.SelectedImageIndex = 7;
            }
            else if (ext == "txt")
            {
                node.ImageIndex = 8;
                node.SelectedImageIndex = 8;
            }
            else if (ext == "vb")
            {
                node.ImageIndex = 9;
                node.SelectedImageIndex = 9;
            }
            else
            {
                node.ImageIndex = 10;
                node.SelectedImageIndex = 10;
            }
        }

        private void setResultsImageIndexBegin(string ext, TreeNode node)
        {
                    
        }

        private void setResultsImageIndexEnd(string ext, TreeNode node)
        {

        }

        private void pythonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pythonToolStripMenuItem.Checked = true;
            this.rubyToolStripMenuItem.Checked = false;
            this.csToolStripMenuItem.Checked = false;
            this.vbToolStripMenuItem.Checked = false;
            this.pHPToolStripMenuItem.Checked = false;
            this.hTMLToolStripMenuItem.Checked = false;
            this.xMLToolStripMenuItem.Checked = false;
            this.sQLToolStripMenuItem.Checked = false;
            this.jSToolStripMenuItem.Checked = false;
            this.luaToolStripMenuItem.Checked = false;
        }

        private void rubyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pythonToolStripMenuItem.Checked = false;
            this.rubyToolStripMenuItem.Checked = true;
            this.csToolStripMenuItem.Checked = false;
            this.vbToolStripMenuItem.Checked = false;
            this.pHPToolStripMenuItem.Checked = false;
            this.hTMLToolStripMenuItem.Checked = false;
            this.xMLToolStripMenuItem.Checked = false;
            this.sQLToolStripMenuItem.Checked = false;
            this.jSToolStripMenuItem.Checked = false;
            this.luaToolStripMenuItem.Checked = false;
        }

        private void csToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pythonToolStripMenuItem.Checked = false;
            this.rubyToolStripMenuItem.Checked = false;
            this.csToolStripMenuItem.Checked = true;
            this.vbToolStripMenuItem.Checked = false;
            this.pHPToolStripMenuItem.Checked = false;
            this.hTMLToolStripMenuItem.Checked = false;
            this.xMLToolStripMenuItem.Checked = false;
            this.sQLToolStripMenuItem.Checked = false;
            this.jSToolStripMenuItem.Checked = false;
            this.luaToolStripMenuItem.Checked = false;
        }

        private void pHPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pythonToolStripMenuItem.Checked = false;
            this.rubyToolStripMenuItem.Checked = false;
            this.csToolStripMenuItem.Checked = false;
            this.vbToolStripMenuItem.Checked = false;
            this.pHPToolStripMenuItem.Checked = true;
            this.hTMLToolStripMenuItem.Checked = false;
            this.xMLToolStripMenuItem.Checked = false;
            this.sQLToolStripMenuItem.Checked = false;
            this.jSToolStripMenuItem.Checked = false;
            this.luaToolStripMenuItem.Checked = false;
        }

        private void vbToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pythonToolStripMenuItem.Checked = false;
            this.rubyToolStripMenuItem.Checked = false;
            this.csToolStripMenuItem.Checked = false;
            this.vbToolStripMenuItem.Checked = true;
            this.pHPToolStripMenuItem.Checked = false;
            this.hTMLToolStripMenuItem.Checked = false;
            this.xMLToolStripMenuItem.Checked = false;
            this.sQLToolStripMenuItem.Checked = false;
            this.jSToolStripMenuItem.Checked = false;
            this.luaToolStripMenuItem.Checked = false;
        }

        private void hTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pythonToolStripMenuItem.Checked = false;
            this.rubyToolStripMenuItem.Checked = false;
            this.csToolStripMenuItem.Checked = false;
            this.vbToolStripMenuItem.Checked = false;
            this.pHPToolStripMenuItem.Checked = false;
            this.hTMLToolStripMenuItem.Checked = true;
            this.xMLToolStripMenuItem.Checked = false;
            this.sQLToolStripMenuItem.Checked = false;
            this.jSToolStripMenuItem.Checked = false;
            this.luaToolStripMenuItem.Checked = false;
        }

        private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pythonToolStripMenuItem.Checked = false;
            this.rubyToolStripMenuItem.Checked = false;
            this.csToolStripMenuItem.Checked = false;
            this.vbToolStripMenuItem.Checked = false;
            this.pHPToolStripMenuItem.Checked = false;
            this.hTMLToolStripMenuItem.Checked = false;
            this.xMLToolStripMenuItem.Checked = true;
            this.sQLToolStripMenuItem.Checked = false;
            this.jSToolStripMenuItem.Checked = false;
            this.luaToolStripMenuItem.Checked = false;
        }

        private void sQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pythonToolStripMenuItem.Checked = false;
            this.rubyToolStripMenuItem.Checked = false;
            this.csToolStripMenuItem.Checked = false;
            this.vbToolStripMenuItem.Checked = false;
            this.pHPToolStripMenuItem.Checked = false;
            this.hTMLToolStripMenuItem.Checked = false;
            this.xMLToolStripMenuItem.Checked = false;
            this.sQLToolStripMenuItem.Checked = true;
            this.jSToolStripMenuItem.Checked = false;
            this.luaToolStripMenuItem.Checked = false;
        }

        private void jSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pythonToolStripMenuItem.Checked = false;
            this.rubyToolStripMenuItem.Checked = false;
            this.csToolStripMenuItem.Checked = false;
            this.vbToolStripMenuItem.Checked = false;
            this.pHPToolStripMenuItem.Checked = false;
            this.hTMLToolStripMenuItem.Checked = false;
            this.xMLToolStripMenuItem.Checked = false;
            this.sQLToolStripMenuItem.Checked = false;
            this.jSToolStripMenuItem.Checked = true;
            this.luaToolStripMenuItem.Checked = false;
        }

        private void luaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pythonToolStripMenuItem.Checked = false;
            this.rubyToolStripMenuItem.Checked = false;
            this.csToolStripMenuItem.Checked = false;
            this.vbToolStripMenuItem.Checked = false;
            this.pHPToolStripMenuItem.Checked = false;
            this.hTMLToolStripMenuItem.Checked = false;
            this.xMLToolStripMenuItem.Checked = false;
            this.sQLToolStripMenuItem.Checked = false;
            this.jSToolStripMenuItem.Checked = false;
            this.luaToolStripMenuItem.Checked = true;
        }

        /// <summary>
        /// 远程连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 远程连接ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process runMSTSC = new Process();
            runMSTSC.StartInfo.FileName = "mstsc";
            runMSTSC.Start();
            runMSTSC.Close();
        }

        private void spyX86NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process p = new Process();
                p.StartInfo.FileName = Application.StartupPath + @"\Tools\Sources\spyxx.exe";
                p.Start();
                p.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void spyX64MToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process p = new Process();
                p.StartInfo.FileName = Application.StartupPath + @"\Tools\Sources\spyxx_amd64.exe";
                p.Start();
                p.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void spyX64帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process p = new Process();
                p.StartInfo.FileName = Application.StartupPath + @"\Tools\Sources\spyxx_amd64.chm";
                p.Start();
                p.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void spyX86帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process p = new Process();
                p.StartInfo.FileName = Application.StartupPath + @"\Tools\Sources\spyxx.chm";
                p.Start();
                p.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pUTTYPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process p = new Process();
                p.StartInfo.FileName = Application.StartupPath + @"\Tools\Sources\PUTTY.EXE";
                p.Start();
                p.Close();
            }           
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AutoItToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process p = new Process();
                p.StartInfo.FileName = Application.StartupPath + @"\Tools\Sources\AUTOIT.EXE";
                p.Start();
                p.Close();
            }
            
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void x64ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process p = new Process();
                p.StartInfo.FileName = Application.StartupPath + @"\Tools\Sources\inspect_x64.EXE";
                p.Start();
                p.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void x86ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process p = new Process();
                p.StartInfo.FileName = Application.StartupPath + @"\Tools\Sources\inspect_x32.EXE";
                p.Start();
                p.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void auto3帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process p = new Process();
                p.StartInfo.FileName = Application.StartupPath + @"\Tools\Sources\AutoIt.chm";
                p.Start();
                p.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsFiles_KeyDown(object sender, KeyEventArgs e)
        {
            EditorTE.AutocompleteMenu popupMenu;
            if (e.KeyData == (Keys.K | Keys.Control))
            {
                var tb = sender as Editor;
                popupMenu = new EditorTE.AutocompleteMenu(tb);
                popupMenu.Show(true);
                e.Handled = true;
            }
        }

        private void pythonToolStrip_Click(object sender, EventArgs e)
        {
            try
            {
                Process p = new Process();
                p.StartInfo.FileName = pythonEnv + @"python.EXE";
                p.Start();
                p.Close();
            }         
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   

        }

        private void PythonIDLEtoolStrip_Click(object sender, EventArgs e)
        {
            try
            {
                Process p = new Process();
                p.StartInfo.FileName = pythonEnv + @"\idlelib\idle.bat";
                p.Start();
                p.Close();
            }           

            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }

        private void terminalToolStrip_Click(object sender, EventArgs e)
        {
            try
            {
                Process p = new Process();
                p.StartInfo.FileName = @"\cmd.exe";
                p.Start();
                p.Close();
            }            
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        private void 文件清理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestExerciser.Tools.AutoTestingManagement.ToolAutoCleanScripts myToolAutoCleanScripts = new TestExerciser.Tools.AutoTestingManagement.ToolAutoCleanScripts();
            myToolAutoCleanScripts.Show();
        }

        private void 选项ToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void tsbLogView_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(MainAutoTesting.rootFolder + @"\.log"))
            {
                TestExerciser.Tools.AutoTestingManagement.ToolAutoLogView myToolAutoLogView = new TestExerciser.Tools.AutoTestingManagement.ToolAutoLogView();
                myToolAutoLogView.Show();
            }
            else
            {
                MessageBox.Show("请确认log文件是否生成！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tsmErrClearnAll_Click(object sender, EventArgs e)
        {
            this.richResults.Clear();
        }

        private void tsmErrRed_Click(object sender, EventArgs e)
        {
            richDetails.SelectionBackColor = Color.Red;
        }

        private void tsmErrPink_Click(object sender, EventArgs e)
        {
            richDetails.SelectionBackColor = Color.Pink;
        }

        private void tsmErrYellow_Click(object sender, EventArgs e)
        {
            richDetails.SelectionBackColor = Color.Yellow;
        }

        private void tsmErrGreen_Click(object sender, EventArgs e)
        {
            richDetails.SelectionBackColor = Color.Green;
        }

        private void tsmErrDefault_Click(object sender, EventArgs e)
        {
            richDetails.SelectionBackColor = Color.Black;
        }

        private void tsmErrAutoMark_Click(object sender, EventArgs e)
        {

        }

        private void tsmErrAutoScroll_Click(object sender, EventArgs e)
        {
            richResults.SelectionStart = richResults.TextLength;
            richResults.ScrollToCaret();
        }

        private void tsmErrQuitAutoScroll_Click(object sender, EventArgs e)
        {
            richResults.SelectionStart = 0;
            richResults.ScrollToCaret();
        }

        private void tsmErrQuit_Click(object sender, EventArgs e)
        {
            this.rightClickOnErrorWindow.Close();
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            this.richDetails.Clear();
            this.richResults.Clear();
        }

        private void stbWarp_CheckedChanged(object sender, EventArgs e)
        {
            if (this.stbWarp.Checked)
            {
                this.richDetails.WordWrap = true;
                this.richResults.WordWrap = true;
            }
            else
            {
                this.richDetails.WordWrap = false;
                this.richResults.WordWrap = false;
            }
        }

        private void tsbUp_Click(object sender, EventArgs e)
        {
            richResults.SelectionStart = 0;
            richResults.ScrollToCaret();
        }

        private void stbDown_Click(object sender, EventArgs e)
        {
            richResults.SelectionStart = richResults.TextLength;
            richResults.ScrollToCaret();
        }

        private void richOutPut_TextChanged(object sender, EventArgs e)
        {

        }

        private void richResults_TextChanged(object sender, EventArgs e)
        {

        }

        private void outPut( string log)
        {
            this.richResults.AppendText(DateTime.Now.ToString("HH:mm:ss：") + log +"\r\n");            
        }

        private void spbStatusBegin()
        {
            this.spbStatus.Value = 0;
            this.spbStatus.Minimum = 0;
            this.spbStatus.Maximum = tsFilePath.Length;
            outPut("开始执行...");
        }

        private void timerNow_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            this.labtimeNow.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        
        private void spbStatusTrueOrFalse()
        {
            if (this.richResults.Text != "")
            {
                bool foundMatchSucceed = false;
                bool foundMatchFailed = false;
                try
                {
                    foundMatchSucceed = Regex.IsMatch(this.richResults.Text, @"\sOK[\s]*\z", RegexOptions.IgnoreCase | RegexOptions.Singleline);
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                try
                {
                    foundMatchFailed = Regex.IsMatch(this.richResults.Text, @"\sFAILED\s\(errors=[\d]*\)[\s]*\Z|SyntaxError:\sinvalid\ssyntax[\s]*|..错误\:\s没有找到进程", RegexOptions.IgnoreCase | RegexOptions.Singleline);
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                if (foundMatchFailed)
                {
                    this.spbStatus.TrackFore = Color.Red;
                }

                else if (foundMatchSucceed)
                {
                    this.spbStatus.TrackFore = Color.Green;
                }
                else
                {
                    this.spbStatus.TrackFore = Color.Gold;
                }
            }
            else
            {
                this.spbStatus.Visible = false;
            }
        }


        private void sendLogMail()
        {
            if (ManageDB.userEmailAddress != null)
            {
                SendMail mail = new SendMail();
                mail.mailFrom = "TestExerciser@163.com";
                mail.mailPwd = "admin123";
                mail.mailSubject = "用例执行结果";
                mail.mailBody = MainAutoTesting.rootFolder + @"\.log";
                mail.isbodyHtml = false;
                mail.host = "smtp.163.com";
                mail.mailToArray = new string[] {ManageDB.userEmailAddress };
                mail.mailCcArray = new string[] { };
                if (mail.Send())
                {

                }
            }           
        }

        private void 封装管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            TestExerciser.Tools.AutoTestingManagement.ToolAutoCodePacking myToolAutoCodePacking = new TestExerciser.Tools.AutoTestingManagement.ToolAutoCodePacking();
            myToolAutoCodePacking.Show();
        }

        private void 脚本生成GToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestExerciser.Tools.AutoTestingManagement.ToolAutoExcelReader rdb = new TestExerciser.Tools.AutoTestingManagement.ToolAutoExcelReader();
            rdb.ShowDialog();
            if (rdb.addToProj == true)
            {
                workspacePath = rdb.selectedWorkspacePath();
                if (Array.IndexOf<string>(root_paths, workspacePath) != -1)
                {
                    MessageBox.Show("打开项目名称冲突，请修改工程名称！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    addToRootPaths(workspacePath);
                    getTreeViewData(workspacePath);
                }
            }
        }

        private void initToolBarEnableFlase()
        {
            saveToolStripButton.Enabled = false;
            printToolStripButton.Enabled = false;
            cutToolStripButton.Enabled = false;
            copyToolStripButton.Enabled = false;
            pasteToolStripButton.Enabled = false;
            btInvisibleChars.Enabled = false;
            btHighlightCurrentLine.Enabled = false;
            btShowFoldingLines.Enabled = false;
            undoStripButton.Enabled = false;
            redoStripButton.Enabled = false;
            backStripButton.Enabled = false;
            forwardStripButton.Enabled = false;
            bookmarkMinusButton.Enabled = false;
            bookmarkPlusButton.Enabled = false;
        }

        private void initToolBarEnableTrue()
        {
            saveToolStripButton.Enabled = true;
            printToolStripButton.Enabled = true;
            cutToolStripButton.Enabled = true;
            copyToolStripButton.Enabled = true;
            pasteToolStripButton.Enabled = true;
            btInvisibleChars.Enabled = true;
            btHighlightCurrentLine.Enabled = true;
            btShowFoldingLines.Enabled = true;
            undoStripButton.Enabled = true;
            redoStripButton.Enabled = true;
            backStripButton.Enabled = true;
            forwardStripButton.Enabled = true;
            bookmarkMinusButton.Enabled = true;
            bookmarkPlusButton.Enabled = true;
        }

        private void gotoButton_Click(object sender, EventArgs e)
        {
            gotoButton_DropDownOpening(sender, e);
        }

        private void copyBinarys()
        {
             //this.runCmd("", "xcopy " + @"\\172.20.32.147\resources\ " + @"C:\School\" +" /s /e /y");
        }

        private void cleanUpResults()
        {
            this.richDetails.Text = "";
            this.richResults.Text = "";
        }

        private void runCmds()
        {
            runCmd("python.exe", path);
        }

        private void runCmdStread()
        {
            Thread myThread = new Thread(new ThreadStart(runCmds));
            myThread.IsBackground = true;
            myThread.Start();
        }
    }
}
