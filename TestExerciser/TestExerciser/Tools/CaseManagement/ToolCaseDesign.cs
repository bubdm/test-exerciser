using System;
using System.Windows.Forms;
using DesignTE.Plugins;
using DesignTE.View.NoteEditing;
using DesignTE.Controller;
using DesignTE.View;
using DesignTE.View.EditorTabs;

using System.Drawing;

namespace TestExerciser
{
    public partial class ToolCaseDesign : Form, DesignTE.View.IMainForm
    {
        private readonly MainCtrl mainCtrl;

        public ToolCaseDesign(MainCtrl mainCtrl)
        {
            this.mainCtrl = mainCtrl;
            Ribbon = new RibbonLib.Ribbon { ResourceName = "TestExerciser.View.Ribbon.RibbonMarkup.ribbon" };
            InitializeComponent();
            this.Controls.Add(Ribbon);
            SetupSideBar();

            // moving splitter makes it the focused control, below event focuses the last control again
            splitContainer_SideTab.GotFocus += SplitContainer1_GotFocus;

            // changing side bar tab gives focus away to tab control header, below event focuses relevant control again
            SideBarTabs.SelectedIndexChanged += SideBarTabs_SelectedIndexChanged;

            EditorTabs = new EditorTabs();
            splitContainer_SideTab.Panel1.Controls.Add(EditorTabs);
            Shown += MainForm_Shown;
            Shown += (sender, args) => Ribbon.Minimized = false;

#if (Win7)
            //this is required for Windows 7 & 8, otherwise sidebar is not laid out properly
            Load += (sender, args) => Ribbon.Minimized = true;
            Shown += (sender, args) => Ribbon.Minimized = false;
#endif
        }

        #region Manage Focus

        private Control focusedControl;
        public Control FocusedControl
        {
            get
            {
                return focusedControl;
            }

            set
            {
                if (focusedControl != value)
                {
                    var oldvalue = focusedControl;
                    focusedControl = value;
                    FocusedControlChanged?.Invoke(value, oldvalue);
                }
            }
        }

        /// <summary>
        /// Occurs when focus is tranferred to a control which can have permanent focus. NoteEditor and EditorTab can have permanent focus.
        /// Focus can temporarily transfer to controls like Menu, Ribbon etc., but these are ignored by this event.
        /// </summary>
        public event FocusedControlChangeDelegate FocusedControlChanged;

        private void FocusLastControl()
        {
            if (FocusedControl != null)
                FocusedControl.Focus();
            else
                EditorTabs.Focus();
        }

        public void FocusMapView()
        {
            EditorTabs.Focus();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            EditorTabs.ControlGotFocus += (a, b) => FocusedControl = EditorTabs;
            NoteEditor.Document.Focusing += (a, b) => FocusedControl = NoteEditor;
        }

        private void SplitContainer1_GotFocus(object sender, EventArgs e)
        {
            FocusLastControl();
        }

        private void SideBarTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SideBarTabs.SelectedTab == SideBarTabs.NoteTab)
                SideBarTabs.SelectedTab.Controls[0].Focus();
            else
                FocusMapView();
        }

        #endregion

        public RibbonLib.Ribbon Ribbon { get; private set; }
        public DesignTE.View.Ribbon.Ribbon RibbonCtrl { get; set; }

        public EditorTabs EditorTabs { get; private set; }
        public SideTabControl SideBarTabs { get; private set; }
        public NoteEditor NoteEditor { get; private set; }

        public DesignTE.View.StatusBar StatusBar { get { return this.statusStrip1; } }

        public bool IsNoteEditorActive
        {
            get { return ActiveControl == splitContainer_SideTab && splitContainer_SideTab.ActiveControl == NoteEditor; }
        }

        private void SetupSideBar()
        {
            SideBarTabs = new SideTabControl();
            NoteEditor = SideBarTabs.NoteEditor;

            this.splitContainer_SideTab.Panel2.Controls.Add(SideBarTabs);
        }

        public void InsertMenuItems(MainMenuItem[] menuItems)
        {
            RibbonCtrl.SetupPluginCommands(menuItems);
        }

        public void RefreshRecentFilesMenuItems()
        {
            RibbonCtrl.RefreshRecentItemsList();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if ((keyData & Keys.Control) == Keys.Control)
            {
                switch (keyData)
                {
                    case (Keys.Control | Keys.N):
                        mainCtrl.NewMap();
                        return true;
                    case (Keys.Control | Keys.O):
                        mainCtrl.OpenMap();
                        return true;
                    case (Keys.Control | Keys.S):
                        mainCtrl.SaveCurrentMap();
                        return true;
                    case (Keys.Control | Keys.Shift | Keys.S):
                        mainCtrl.SaveAll();
                        return true;
                    case (Keys.Control | Keys.Z):
                        mainCtrl.Undo();
                        return true;
                    case (Keys.Control | Keys.Y):
                        mainCtrl.Redo();
                        return true;
                    case (Keys.Control | Keys.C):
                        mainCtrl.Copy();
                        return true;
                    case (Keys.Control | Keys.V):
                        mainCtrl.Paste();
                        return true;
                    case (Keys.Control | Keys.X):
                        mainCtrl.Cut();
                        return true;
                    case (Keys.Control | Keys.B):
                        mainCtrl.CurrentMapCtrl.ToggleBold();
                        return true;
                    case (Keys.Control | Keys.I):
                        mainCtrl.CurrentMapCtrl.ToggleItalic();
                        return true;
                    case (Keys.Control | Keys.D):
                        mainCtrl.CurrentMapCtrl.ChangeFont();
                        return true;
                }
            }
            else if ((keyData & Keys.Alt) == Keys.Alt)
            {
                switch (keyData)
                {
                    case (Keys.Alt | Keys.I):
                        mainCtrl.CurrentMapCtrl.AppendIconFromIconSelectorExt();
                        return true;
                }
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void MainCaseDesign_Load(object sender, EventArgs e)
        {
            //var ribbonHandler = new View.Ribbon.Ribbon(form.Ribbon, mainCtrl, form);
            //form.RibbonCtrl = ribbonHandler;
            //form.Load += (sender, args) => ribbonHandler.OnRibbonLoaded();
        }
    }
}
