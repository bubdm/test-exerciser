using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Windows.Forms;
using System.Collections;
using CCWin.SkinControl;

namespace TestExerciser.Logic
{
    class LoadXml
    {
        public void loadXmlToTree(XmlNode xmlNode, TreeNodeCollection nodes)
        {
            foreach (System.Xml.XmlNode node in xmlNode.ChildNodes)
            {
                TreeNode child = new TreeNode();
                child.Name = node.Attributes["Name"].Value;
                child.Text = node.Attributes["Text"].Value;
                nodes.Add(child);
                loadXmlToTree(node, child.Nodes);
            }
        }

        public void loadXmlToSkinComBox(XmlNode xmlNode, SkinComboBox comBox)
        {          
            foreach (System.Xml.XmlNode node in xmlNode.ChildNodes)
            {
                comBox.Items.Add(node.Attributes["Text"].Value);
                loadXmlToSkinComBox(node,comBox);
            }
        }

        public void loadXmlToComBox(XmlNode xmlNode, ComboBox comBox)
        {
            foreach (System.Xml.XmlNode node in xmlNode.ChildNodes)
            {
                comBox.Items.Add(node.Attributes["Text"].Value);
                loadXmlToComBox(node, comBox);
            }
        }
    }
}
