using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using TestExerciser.Logic;
using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace TestExerciser.Tools.ProjectManagement
{
    public partial class ToolProjectVersion : Form
    {
        ManageDB myManageDB = new ManageDB();
        TreeNode myRoot = new TreeNode();

        public ToolProjectVersion()
        {
            InitializeComponent();
        }

        private void tSave_Click(object sender, EventArgs e)
        {
            SaveToXml(MainProjectManager.myCurrentProNo);      
        }

        private void tAdd_Click(object sender, EventArgs e)
        {
            TreeNode myVersion = new TreeNode();
            ToolProjectSetName myToolProjectSetName = new ToolProjectSetName();
            myToolProjectSetName.Text = "添加版本";
            if (myToolProjectSetName.ShowDialog() == DialogResult.OK)
            {
                myVersion.Text = myToolProjectSetName.txtStruct.Text;
                myVersion.ImageIndex = 0;
                myVersion.SelectedImageIndex = 0;
                this.tv_Version.TopNode.Nodes.Add(myVersion);
                this.tv_Version.SelectedNode.ExpandAll();
                this.tv_Version.SelectedNode = myVersion;
            }
        }

        private void ToolProjectVersion_Load(object sender, EventArgs e)
        {
            loadXMLToTreeViewControl();
            this.tv_Version.ExpandAll();
            if (this.tv_Version.Nodes.Count == 0)
            {
                TreeNode myRoot = new TreeNode();
                myRoot.Text = MainProjectManager.myCurrentProName;
                myRoot.ImageIndex = 1;
                myRoot.SelectedImageIndex = 1;
                this.tv_Version.Nodes.Add(myRoot);
            }        
        }

        private void SaveToXml(string xmlFileName)
        {
            XDeclaration dec = new XDeclaration("1.0", "utf-8", "yes");
            XDocument xml = new XDocument(dec);

            XElement root = new XElement("Tree");

            foreach (TreeNode node in this.tv_Version.Nodes)
            {
                XElement e = CreateElements(node);
                root.Add(e);
            }
            xml.Add(root);
            string xmlContent = xml.ToString();
            string sql = "declare @xmlDoc xml;set @xmlDoc ='" + xml + "'update ProjectManager set proVersions = @xmlDoc where proNO ='" + MainProjectManager.myCurrentProNo + "'";
            myManageDB.saveXML(sql);
            this.labStatus.ForeColor = Color.Green;
            this.labStatus.Text = "保存成功！";
        }

        private XElement CreateElements(TreeNode node)
        {
            XElement root = CreateElement(node);

            foreach (TreeNode n in node.Nodes)
            {
                XElement e = CreateElements(n);
                root.Add(e);
            }
            return root;
        }

        private XElement CreateElement(TreeNode node)
        {
            return new XElement("Node",
                new XAttribute("Name", node.Name),
                new XAttribute("Text", node.Text)
                );
        }

        private void loadXMLToTreeViewControl()
        {
            string str = myManageDB.getDataFromCell("proVersions", "ProjectManager", "proNO", MainProjectManager.myCurrentProNo);
            if (str != null && str != "")
            {
                StringReader myReader = new StringReader(str);
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(myReader);
                LoadXml myProjectStruct = new LoadXml();
                myProjectStruct.loadXmlToTree(xmlDoc.DocumentElement, this.tv_Version.Nodes);
            }
        }

        private void ToolProjectVersion_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainProjectManager myMainProjectManager = new MainProjectManager();
            myMainProjectManager.Show();
        }

        private void tv_Version_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            this.tv_Version.SelectedNode.BeginEdit();
        }

        private void tModify_Click(object sender, EventArgs e)
        {
            if (this.tv_Version.TopNode != this.tv_Version.SelectedNode)
            {
                ToolProjectSetName myToolProjectSetName = new ToolProjectSetName();
                myToolProjectSetName.Text = "修改版本";
                if (myToolProjectSetName.ShowDialog() == DialogResult.OK)
                {
                    this.tv_Version.SelectedNode.Text = myToolProjectSetName.txtStruct.Text;
                }
            }
            else
            {
                MessageBox.Show("不支持修改顶级项目名称！", "消息提示：", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }          
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (this.tv_Version.TopNode != this.tv_Version.SelectedNode)
            {
                if (MessageBox.Show("确定要修改该单元格内容吗？", "消息提示：", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    this.tv_Version.SelectedNode.Remove();
                }
            }
            else
            {
                MessageBox.Show("不支持删除顶级项目名称！", "消息提示：", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }
    }
}
