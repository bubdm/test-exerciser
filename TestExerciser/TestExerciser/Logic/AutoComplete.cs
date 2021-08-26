using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using EditorTE;
using System.IO;



namespace TestExerciser.Logic
{
    class AutoComplete
    {
        string[] keywords = { "import", "operate", "False", "None", "NotImplemented", "True", "__debug__", "and", "as", "assert", "break", "class", "continue", "def", "del", "elif", "else", "except", "exec", "finally", "for", "from", "global", "if","in", "is", "lambda", "not", "or", "pass", "print", "raise", "return", "self", "try", "while", "with", "yield" };
        static string[] methods = { };
        static string[] folderName = { };
        static string[] fileName = { };
        static string[] classes = { };
        string[] snippets = { "if(^)\n{\n;\n}", "if(^)\n{\n;\n}\nelse\n{\n;\n}", "for(^;;)\n{\n;\n}", "while(^)\n{\n;\n}", "do\n{\n^;\n}while();", "switch(^)\n{\ncase : break;\n}" };
        string[] declarationSnippets = { 
               "class ^:", "''' ^\n'''", "internal class ^\n{\n}",
               "def ^():", "private struct ^\n{\n;\n}", "internal struct ^\n{\n;\n}",
               "if ^():", "private void ^()\n{\n;\n}", "internal void ^()\n{\n;\n}", "protected void ^()\n{\n;\n}",
               //"public ^{ get; set; }", "private ^{ get; set; }", "internal ^{ get; set; }", "protected ^{ get; set; }"
               };
        ImageList myImageList = new ImageList();

        class ExplorerItem
        {
            public ExplorerItemType type;
            public string title;
            public int position;
        }

        enum ExplorerItemType
        {
            Class, Method, Property, Event
        }

        class ExplorerItemComparer : IComparer<ExplorerItem>
        {
            public int Compare(ExplorerItem x, ExplorerItem y)
            {
                return x.title.CompareTo(y.title);
            }
        }

        public void buildAutoCompleteMenu(AutocompleteMenu popupMenu)
        {
            AutoPop();
            List<AutocompleteItem> items = new List<AutocompleteItem>();

            foreach (var item in delRepeatData(folderName))
                items.Add(new MethodAutocompleteItem(item) { ImageIndex = 4 });
            foreach (var item in delRepeatData(fileName))
                items.Add(new MethodAutocompleteItem(item) { ImageIndex = 3 });
            foreach (var item in delRepeatData(classes))
                items.Add(new MethodAutocompleteItem(item) { ImageIndex = 1 });
            foreach (var item in delRepeatData(methods))
                items.Add(new MethodAutocompleteItem(item) { ImageIndex = 2 });  

            foreach (var item in snippets)
                items.Add(new SnippetAutocompleteItem(item) { ImageIndex = 1 });
            foreach (var item in declarationSnippets)
                items.Add(new DeclarationSnippet(item) { ImageIndex = 0 });                      
            foreach (var item in keywords)
                items.Add(new AutocompleteItem(item));

            items.Add(new InsertSpaceSnippet());
            items.Add(new InsertSpaceSnippet(@"^(\w+)([=<>!:]+)(\w+)$"));
            items.Add(new InsertEnterSnippet());

            //set as autocomplete source
            popupMenu.Items.SetAutocompleteItems(items);
            popupMenu.Items.MaximumSize = new System.Drawing.Size(200, 300);
            popupMenu.Items.Width = 200;
            popupMenu.SearchPattern = @"[\w\.:=!<>]";
            popupMenu.ImageList.Images.Add(global::TestExerciser.Properties.Resources.python);
            popupMenu.ImageList.Images.Add(global::TestExerciser.Properties.Resources.folder);
        }

        /// <summary>
        /// This item appears when any part of snippet text is typed
        /// </summary>
        class DeclarationSnippet : SnippetAutocompleteItem
        {
            public DeclarationSnippet(string snippet)
                : base(snippet)
            {
            }

            public override CompareResult Compare(string fragmentText)
            {
                var pattern = Regex.Escape(fragmentText);
                if (Regex.IsMatch(Text, "\\b" + pattern, RegexOptions.IgnoreCase))
                    return CompareResult.Visible;
                return CompareResult.Hidden;
            }
        }

        /// <summary>
        /// Divides numbers and words: "123AND456" -> "123 AND 456"  
        ///  Or "i=2" -> "i = 2"
        /// </summary>
        class InsertSpaceSnippet : AutocompleteItem
        {
            string pattern;

            public InsertSpaceSnippet(string pattern)
                : base("")
            {
                this.pattern = pattern;
            }

            public InsertSpaceSnippet()
                : this(@"^(\d+)([a-zA-Z_]+)(\d*)$")
            {
            }

            public override CompareResult Compare(string fragmentText)
            {
                if (Regex.IsMatch(fragmentText, pattern))
                {
                    Text = InsertSpaces(fragmentText);
                    if (Text != fragmentText)
                        return CompareResult.Visible;
                }
                return CompareResult.Hidden;
            }

            public string InsertSpaces(string fragment)
            {
                var m = Regex.Match(fragment, pattern);
                if (m == null)
                    return fragment;
                if (m.Groups[1].Value == "" && m.Groups[3].Value == "")
                    return fragment;
                return (m.Groups[1].Value + " " + m.Groups[2].Value + " " + m.Groups[3].Value).Trim();
            }

            public override string ToolTipTitle
            {
                get
                {
                    return Text;
                }
            }
        }

        /// <summary>
        /// Inerts line break after '}'
        /// </summary>
        class InsertEnterSnippet : AutocompleteItem
        {
            Place enterPlace = Place.Empty;

            public InsertEnterSnippet()
                : base("[Line break]")
            {
            }

            public override CompareResult Compare(string fragmentText)
            {
                var r = Parent.Fragment.Clone();
                while (r.Start.iChar > 0)
                {
                    if (r.CharBeforeStart == '}')
                    {
                        enterPlace = r.Start;
                        return CompareResult.Visible;
                    }

                    r.GoLeftThroughFolded();
                }

                return CompareResult.Hidden;
            }

            public override string GetTextForReplace()
            {
                //extend range
                Range r = Parent.Fragment;
                Place end = r.End;
                r.Start = enterPlace;
                r.End = r.End;
                //insert line break
                return Environment.NewLine + r.Text;
            }

            public override void OnSelected(AutocompleteMenu popupMenu, SelectedEventArgs e)
            {
                base.OnSelected(popupMenu, e);
                if (Parent.Fragment.tb.AutoIndent)
                    Parent.Fragment.tb.DoAutoIndent();
            }

            public override string ToolTipTitle
            {
                get
                {
                    return "Insert line break after '}'";
                }
            }
        }

        public void AutoPop()
        {
            if (MainAutoTesting.pythonLibPath != null)
            {
                getAllClassAndMethod(MainAutoTesting.pythonLibPath + "\\site-packages\\ssas\\");
            }            
        }


        List<string> methodsList = methods.ToList();
        List<string> classesList = classes.ToList();
        List<string> folderList = folderName.ToList();
        List<string> fileList = fileName.ToList();
        private void getAllClassAndMethod(string filePath)
        {
            try
            {
                if (filePath == null || filePath == "")
                {
                    MessageBox.Show("未找到支撑库文件，请检查支撑库文件路径！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {                    
                    DirectoryInfo folder = new DirectoryInfo(filePath);
                    FileInfo[] chldFiles = folder.GetFiles("*.*");
                    foreach (FileInfo chlFile in chldFiles)
                    {
                        if (!chlFile.Name.StartsWith(".") && chlFile.Name != "workspace" && !chlFile.Name.StartsWith("__")&&chlFile.Name.EndsWith(".py"))
                        {
                            string chldfileName = Path.GetFileNameWithoutExtension(chlFile.FullName);
                            string childFullName = chlFile.FullName;
                            string chldfileFullName = chlFile.FullName;
                            string ext = chlFile.Name.Substring(chlFile.Name.LastIndexOf(".") + 1, (chlFile.Name.Length - chlFile.Name.LastIndexOf(".") - 1));
                            fileList.Add(chldfileName);

                            string text = File.ReadAllText(chlFile.FullName, Encoding.UTF8);
                            try
                            {
                                Regex regex = new Regex(@"^(?<range>[\w\s]+\b(class|def)\s+[\w<>,\s]+)", RegexOptions.Multiline);
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
                                            classesList.Add(item.title);
                                        }
                                        else
                                        {
                                            int ii = item.title.LastIndexOf(' ');
                                            item.title = item.title.Substring(ii).Trim();
                                            item.type = ExplorerItemType.Method;
                                            methodsList.Add(item.title);
                                        }

                                    }
                                    catch { ;}
                            }
                            catch { ;}                            
                        }
                    }
                    DirectoryInfo[] chldFolders = folder.GetDirectories();
                    foreach (DirectoryInfo chldFolder in chldFolders)
                    {
                        if (!chldFolder.Name.StartsWith(".") && chldFolder.Name != "workspace" && !chldFolder.Name.StartsWith("__"))
                        {
                            folderList.Add(chldFolder.Name);
                            getAllClassAndMethod(chldFolder.FullName);                            
                        }
                    }
                    methods = methodsList.ToArray();
                    classes = classesList.ToArray();
                    folderName = folderList.ToArray();
                    fileName = fileList.ToArray();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 将查找到的文件夹名称，文件名称，类名称，方法名称以树形结构存储
        /// </summary>
        TreeView myTreeView = new TreeView();
        public void getClassAndMethod(string path)
        {           
            TreeNode root = new TreeNode();
            getClassAndMethod(path, root);
            myTreeView.Nodes.Add(root);           
        }

        private void getClassAndMethod(string filePath, TreeNode node)
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
                        if (!chlFile.Name.StartsWith(".") && chlFile.Name != "workspace" && !chlFile.Name.StartsWith("__")&&chlFile.Name.EndsWith(".py"))
                        {
                            TreeNode chldNode = new TreeNode();
                            chldNode.Text = chlFile.Name;
                            chldNode.Tag = chlFile.FullName;
                            string ext = chlFile.Name.Substring(chlFile.Name.LastIndexOf(".") + 1, (chlFile.Name.Length - chlFile.Name.LastIndexOf(".") - 1));  
                            node.Nodes.Add(chldNode);
                        }
                    }

                    DirectoryInfo[] chldFolders = folder.GetDirectories();
                    foreach (DirectoryInfo chldFolder in chldFolders)
                    {
                        if (!chldFolder.Name.StartsWith(".") && chldFolder.Name != "workspace" && !chldFolder.Name.StartsWith("__"))
                        {
                            TreeNode chldNode = new TreeNode();
                            chldNode.Text = folder.Name;
                            chldNode.Tag = folder.FullName;
                            node.Nodes.Add(chldNode);
                            getClassAndMethod(chldFolder.FullName, chldNode);
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
        /// 移除数组中重复数据  
        /// </summary>  
        /// <param name="array">需要除重的数组</param>  
        /// <returns>不重复数组</returns>  
        public static string[] delRepeatData(string[] array)
        {
            return array.GroupBy(p => p).Select(p => p.Key).ToArray();
        } 
    }
}
