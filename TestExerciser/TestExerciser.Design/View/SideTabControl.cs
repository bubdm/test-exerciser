using DesignTE.View.NoteEditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DesignTE.View
{
    public sealed class SideTabControl : TabControl
    {
        private const string NoteTabTitle = "笔记编辑器";
        private const string TaskListTabTitle = "任务";

        public SideTabControl()
        {
            Dock = DockStyle.Fill;
            //SideBarTabs.Alignment = TabAlignment.Bottom;

            ImageList imageList = new ImageList();
            imageList.Images.Add(DesignTE.Properties.Resources.sticky_note_pin);
            ImageList = imageList;

            NoteTab = new TabPage(NoteTabTitle) { ImageIndex = 0 };
            NoteEditor = new NoteEditor { Dock = DockStyle.Fill };
            NoteTab.Controls.Add(NoteEditor);

            TabPages.Add(NoteTab);
        }

        public NoteEditor NoteEditor { get; set; }

        public TabPage NoteTab { get; private set; }

        //TODO: Should be handled the way 'View Calendar' ribbon command is done.
        public TabPage TaskListTab
        {
            get
            {
                return TabPages.Cast<TabPage>().FirstOrDefault(p => p.Text == TaskListTabTitle);
            }
        }



    }
}
