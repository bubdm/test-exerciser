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
    public partial class ToolProjectStruct : Form
    {

        ManageDB myManageDB = new ManageDB();

        public ToolProjectStruct()
        {
            InitializeComponent();
        }

        private void tSave_Click(object sender, EventArgs e)
        {
            SaveToXml(MainProjectManager.myCurrentProNo);            
        }

        private void ToolProjectStruct_Load(object sender, EventArgs e)
        {
            loadXMLToTreeViewControl();
            this.tv_Struct.ExpandAll();
            if (this.tv_Struct.Nodes.Count == 0)
            {
                TreeNode myRoot = new TreeNode();
                myRoot.Text = MainProjectManager.myCurrentProName;
                myRoot.ImageIndex = 1;
                myRoot.SelectedImageIndex = 1;
                this.tv_Struct.Nodes.Add(myRoot);
            }        
        }

        private void tAdd_Click(object sender, EventArgs e)
        {
            TreeNode mySubNode = new TreeNode();
            ToolProjectSetName myToolProjectSetName = new ToolProjectSetName();
            myToolProjectSetName.Text = "添加架构节点";
            if (myToolProjectSetName.ShowDialog() == DialogResult.OK)
            {
                mySubNode.Text = myToolProjectSetName.txtStruct.Text;
                mySubNode.ImageIndex = 0;
                mySubNode.SelectedImageIndex = 0;
                this.tv_Struct.SelectedNode.Nodes.Add(mySubNode);
                this.tv_Struct.SelectedNode.ExpandAll();
                this.tv_Struct.SelectedNode = mySubNode;
            }
        }

        private void SaveToXml(string xmlFileName)
        {
            XDeclaration dec = new XDeclaration("1.0", "utf-8", "yes");
            XDocument xml = new XDocument(dec);

            XElement root = new XElement("Tree");

            foreach (TreeNode node in this.tv_Struct.Nodes)
            {
                XElement e = CreateElements(node);
                root.Add(e);
            }
            xml.Add(root);
            string xmlContent = xml.ToString();
            string sql = "declare @xmlDoc xml;set @xmlDoc ='" + xml + "'update ProjectManager set proStructs = @xmlDoc where proNO ='" + MainProjectManager.myCurrentProNo + "'";
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
            string str = myManageDB.getDataFromCell("proStructs", "ProjectManager", "proNO", MainProjectManager.myCurrentProNo);
            if (str != null && str != "")
            {
                StringReader myReader = new StringReader(str);
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(myReader);
                LoadXml myLoadXml = new LoadXml();
                myLoadXml.loadXmlToTree(xmlDoc.DocumentElement, this.tv_Struct.Nodes);
            }
        }

        private void ToolProjectStruct_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainProjectManager myMainProjectManager = new MainProjectManager();
            myMainProjectManager.Show();
        }

        private void tModify_Click(object sender, EventArgs e)
        {
            if (this.tv_Struct.TopNode != this.tv_Struct.SelectedNode)
            {
                ToolProjectSetName myToolProjectSetName = new ToolProjectSetName();
                myToolProjectSetName.Text = "修改架构节点";
                if (myToolProjectSetName.ShowDialog() == DialogResult.OK)
                {
                    this.tv_Struct.SelectedNode.Text = myToolProjectSetName.txtStruct.Text;
                }
            }
            else
            {
                MessageBox.Show("不支持修改顶级项目名称！", "消息提示：", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }     
        }

        private void tDelete_Click(object sender, EventArgs e)
        {
            if (this.tv_Struct.TopNode != this.tv_Struct.SelectedNode)
            {
                if (MessageBox.Show("确定要修改该单元格内容吗？", "消息提示：", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    this.tv_Struct.SelectedNode.Remove();
                }
            }
            else
            {
                MessageBox.Show("不支持删除顶级项目名称！", "消息提示：", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }  
        }
    }
}
