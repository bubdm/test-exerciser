using System.Windows.Forms;
using DesignTE.View.MapControls;
using DesignTE.View.NoteEditing;
using System;

namespace DesignTE.View
{
    public delegate void FocusedControlChangeDelegate(Control gotFocus, Control lostFocus);

    public interface IMainForm
    {
        EditorTabs.EditorTabs EditorTabs { get; }
        bool IsNoteEditorActive { get; }
        NoteEditor NoteEditor { get; }
        SideTabControl SideBarTabs { get; }
        StatusBar StatusBar { get; }
        string Text { get; set; }

        event EventHandler Load;
        event EventHandler Shown;
        event FormClosingEventHandler FormClosing;        
        event FocusedControlChangeDelegate FocusedControlChanged;

        void FocusMapView();
        void InsertMenuItems(Plugins.MainMenuItem[] menuItems);
        void RefreshRecentFilesMenuItems();
    }
}