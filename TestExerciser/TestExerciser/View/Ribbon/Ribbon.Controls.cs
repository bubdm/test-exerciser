﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using DesignTE.View.EditorTabs;
using DesignTE.View.MapControls;
using RibbonLib;
using RibbonLib.Controls;

namespace DesignTE.View.Ribbon
{
    public partial class Ribbon
    {
        private RibbonHelpButton HelpButton;
        private RibbonApplicationMenu ApplicationMenu;
        private RibbonRecentItems RecentItems;
        private RibbonButton ButtonNew;
        private RibbonButton ButtonOpen;
        private RibbonButton ButtonSave;
        private RibbonButton SaveAs;
        private RibbonButton SaveAll;
        private RibbonDropDownButton Export;
        private RibbonButton ExportAsPNG;
        private RibbonButton ExportAsJPG;
        private RibbonButton Close;
        private RibbonButton ButtonExit;
        private RibbonTab TabHome;
        private RibbonGroup NewNode;
        private RibbonButton NewChildNode;
        private RibbonButton NewLongNode;
        private RibbonButton NewNodeAbove;
        private RibbonButton NewNodeBelow;
        private RibbonButton NewNodeParent;
        private RibbonGroup GrpEdit;
        private RibbonButton EditText;
        private RibbonButton EditLong;
        private RibbonButton DeleteNode;
        private RibbonGroup GrpClipboard;
        private RibbonButton Paste;
        private RibbonButton PasteAsText;
        private RibbonButton Cut;
        private RibbonButton Copy;
        private RibbonToggleButton FormatPainter;
        private RibbonGroup GrpFont;
        private RibbonFontControl RichFont;
        private RibbonGroup GrpFormat;
        private RibbonDropDownColorPicker BackColor;
        private RibbonButton ClearFormatting;
        private RibbonGroup GrpIcons;
        private RibbonInRibbonGallery IconsGallery;
        private RibbonButton RemoveLastIcon;
        private RibbonButton RemoveAllIcons;
        private RibbonButton LaunchIconsDialog;
        private RibbonTab TabEdit;
        private RibbonGroup GrpSelect;
        private RibbonButton SelectAll;
        private RibbonButton SelectSiblings;
        private RibbonButton SelectAncestors;
        private RibbonButton SelectChildren;
        private RibbonButton SelectDescendents;
        private RibbonButton SelectDescendentsUpto1;
        private RibbonButton SelectDescendentsUpto2;
        private RibbonButton SelectDescendentsUpto3;
        private RibbonButton SelectDescendentsUpto4;
        private RibbonButton SelectDescendentsUpto5;
        private RibbonCheckBox ExpandOnSelect;
        private RibbonDropDownButton SelectLevel;
        private RibbonButton SelectLevel1;
        private RibbonButton SelectLevel2;
        private RibbonButton SelectLevel3;
        private RibbonButton SelectLevel4;
        private RibbonButton SelectLevel5;
        private RibbonButton SelectLevelCurrent;
        private RibbonGroup GrpExpand;
        private RibbonButton ExpandAll;
        private RibbonButton CollapseAll;
        private RibbonButton ToggleCurrent;
        private RibbonButton ToggleBranch;
        private RibbonButton ExpandMapToCurrentLevel;
        private RibbonButton ExpandMapToLevel1;
        private RibbonButton ExpandMapToLevel2;
        private RibbonButton ExpandMapToLevel3;
        private RibbonButton ExpandMapToLevel4;
        private RibbonButton ExpandMapToLevel5;
        private RibbonGroup GrpNavigate;
        private RibbonButton NavigateToCenter;
        private RibbonButton NavigateToFirstSibling;
        private RibbonButton NavigateToLastSibling;
        private RibbonGroup GrpMove;
        private RibbonButton MoveUp;
        private RibbonButton MoveDown;
        private RibbonGroup GrpSort;
        private RibbonButton SortAlphabetic;
        private RibbonButton SortDueDate;
        private RibbonButton SortNodeCount;
        private RibbonButton SortCreateDate;
        private RibbonButton SortModifiedDate;
        private RibbonToggleButton SortOrder;
        private RibbonGroup GrpUndo;
        private RibbonButton Undo;
        private RibbonButton Redo;
        private RibbonTab TabInsert;
        private RibbonGroup GrpHyperlink;
        private RibbonButton Hyperlink;
        private RibbonButton HyperlinkFile;
        private RibbonButton HyperlinkFolder;
        private RibbonButton RemoveHyperlink;
        private RibbonGroup GrpNote;
        private RibbonButton InsertNote;
        private RibbonGroup GrpTask;
        private RibbonButton AddTask;
        private RibbonButton AddTaskToday;
        private RibbonButton AddTaskTomorrow;
        private RibbonButton AddTaskNextWeek;
        private RibbonButton AddTaskNextMonth;
        private RibbonButton AddTaskNextQuarter;
        private RibbonButton CompleteTask;
        private RibbonButton RemoveTask;
        private RibbonTab TabFormat;
        private RibbonGroup GrpNodeFormat;
        private RibbonDropDownGallery NodeShape;
        private RibbonButton ClearShapeFormat;
        private RibbonDropDownColorPicker LineColor;
        private RibbonDropDownButton LinePattern;
        private RibbonButton LinePatternSolid;
        private RibbonButton LinePatternDashed;
        private RibbonButton LinePatternDotted;
        private RibbonButton LinePatternMixed;
        private RibbonDropDownButton LineThickness;
        private RibbonButton LineThickness1;
        private RibbonButton LineThickness2;
        private RibbonButton LineThickness4;
        private RibbonGroup GrpNodeStyle;
        private RibbonInRibbonGallery NodeStyleGallery;
        private RibbonButton CreateNodeStyle;
        private RibbonGroup GrpClearFormat;
        private RibbonTab TabView;
        private RibbonGroup GrpViewTask;
        private RibbonButton ViewCalendar;
        private RibbonButton ViewTaskList;
        private RibbonGroup GrpViewNote;
        private RibbonButton ViewNote;
        private RibbonTabGroup TabGroupNote;
        private RibbonTab TabNoteEditor;
        private RibbonGroup GrpNoteFont;
        private RibbonGroup GrpNoteClearFormat;
        private RibbonGroup GrpParagraph;
        private RibbonButton Bullets;
        private RibbonButton Numbers;
        private RibbonButton Outdent;
        private RibbonButton Indent;
        private RibbonButton AlignLeft;
        private RibbonButton AlignCenter;
        private RibbonButton AlignRight;
        private RibbonButton Justify;
        private RibbonGroup GrpNoteStyles;
        private RibbonButton NoteHeading1;
        private RibbonButton NoteHeading2;
        private RibbonButton NoteHeading3;
        private RibbonButton NoteNormal;
        private RibbonGroup GrpNoteTable;
        private RibbonButton NoteInsertTable;
        private RibbonGroup GrpNoteEditHtml;
        private RibbonButton NoteEditHtml;
        private RibbonTabGroup TabGroupNoteTable;
        private RibbonTab TabNoteTableLayout;
        private RibbonGroup GrpCustomizeTable;
        private RibbonButton ModifyTableProperties;
        private RibbonGroup GrpTableDelete;
        private RibbonButton DeleteRow;
        private RibbonButton DeleteColumn;
        private RibbonButton DeleteTable;
        private RibbonGroup GrpTableInsert;
        private RibbonButton InsertRowAbove;
        private RibbonButton InsertRowBelow;
        private RibbonButton InsertColumnLeft;
        private RibbonButton InsertColumnRight;
        private RibbonGroup GrpTableMove;
        private RibbonButton MoveRowUp;
        private RibbonButton MoveRowDown;
        private RibbonButton MoveColumnLeft;
        private RibbonButton MoveColumnRight;

        private void InitializeComponents()
        {
            // Instantiate Controls
            HelpButton = new RibbonHelpButton(ribbon, (uint)RibbonMarkupCommands.HelpButton);
            ApplicationMenu = new RibbonApplicationMenu(ribbon, (uint)RibbonMarkupCommands.ApplicationMenu);
            RecentItems = new RibbonRecentItems(ribbon, (uint)RibbonMarkupCommands.RecentItems);
            ButtonNew = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.ButtonNew);
            ButtonOpen = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.ButtonOpen);
            ButtonSave = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.ButtonSave);
            SaveAs = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.SaveAs);
            SaveAll = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.SaveAll);
            Export = new RibbonDropDownButton(ribbon, (uint)RibbonMarkupCommands.Export);
            ExportAsPNG = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.ExportAsPNG);
            ExportAsJPG = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.ExportAsJPG);
            Close = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.Close);
            ButtonExit = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.ButtonExit);
            TabHome = new RibbonTab(ribbon, (uint)RibbonMarkupCommands.TabHome);
            NewNode = new RibbonGroup(ribbon, (uint)RibbonMarkupCommands.NewNode);
            NewChildNode = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.NewChildNode);
            NewLongNode = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.NewLongNode);
            NewNodeAbove = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.NewNodeAbove);
            NewNodeBelow = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.NewNodeBelow);
            NewNodeParent = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.NewNodeParent);
            GrpEdit = new RibbonGroup(ribbon, (uint)RibbonMarkupCommands.GrpEdit);
            EditText = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.EditText);
            EditLong = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.EditLong);
            DeleteNode = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.DeleteNode);
            GrpClipboard = new RibbonGroup(ribbon, (uint)RibbonMarkupCommands.GrpClipboard);
            Paste = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.Paste);
            PasteAsText = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.PasteAsText);
            Cut = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.Cut);
            Copy = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.Copy);
            FormatPainter = new RibbonToggleButton(ribbon, (uint)RibbonMarkupCommands.FormatPainter);
            GrpFont = new RibbonGroup(ribbon, (uint)RibbonMarkupCommands.GrpFont);
            RichFont = new RibbonFontControl(ribbon, (uint)RibbonMarkupCommands.RichFont);
            GrpFormat = new RibbonGroup(ribbon, (uint)RibbonMarkupCommands.GrpFormat);
            BackColor = new RibbonDropDownColorPicker(ribbon, (uint)RibbonMarkupCommands.BackColor);
            ClearFormatting = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.ClearFormatting);
            GrpIcons = new RibbonGroup(ribbon, (uint)RibbonMarkupCommands.GrpIcons);
            IconsGallery = new RibbonInRibbonGallery(ribbon, (uint)RibbonMarkupCommands.IconsGallery);
            RemoveLastIcon = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.RemoveLastIcon);
            RemoveAllIcons = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.RemoveAllIcons);
            LaunchIconsDialog = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.LaunchIconsDialog);
            TabEdit = new RibbonTab(ribbon, (uint)RibbonMarkupCommands.TabEdit);
            GrpSelect = new RibbonGroup(ribbon, (uint)RibbonMarkupCommands.GrpSelect);
            SelectAll = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.SelectAll);
            SelectSiblings = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.SelectSiblings);
            SelectAncestors = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.SelectAncestors);
            SelectChildren = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.SelectChildren);
            SelectDescendents = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.SelectDescendents);
            SelectDescendentsUpto1 = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.SelectDescendentsUpto1);
            SelectDescendentsUpto2 = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.SelectDescendentsUpto2);
            SelectDescendentsUpto3 = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.SelectDescendentsUpto3);
            SelectDescendentsUpto4 = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.SelectDescendentsUpto4);
            SelectDescendentsUpto5 = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.SelectDescendentsUpto5);
            ExpandOnSelect = new RibbonCheckBox(ribbon, (uint)RibbonMarkupCommands.ExpandOnSelect);
            SelectLevel = new RibbonDropDownButton(ribbon, (uint)RibbonMarkupCommands.SelectLevel);
            SelectLevel1 = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.SelectLevel1);
            SelectLevel2 = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.SelectLevel2);
            SelectLevel3 = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.SelectLevel3);
            SelectLevel4 = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.SelectLevel4);
            SelectLevel5 = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.SelectLevel5);
            SelectLevelCurrent = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.SelectLevelCurrent);
            GrpExpand = new RibbonGroup(ribbon, (uint)RibbonMarkupCommands.GrpExpand);
            ExpandAll = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.ExpandAll);
            CollapseAll = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.CollapseAll);
            ToggleCurrent = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.ToggleCurrent);
            ToggleBranch = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.ToggleBranch);
            ExpandMapToCurrentLevel = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.ExpandMapToCurrentLevel);
            ExpandMapToLevel1 = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.ExpandMapToLevel1);
            ExpandMapToLevel2 = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.ExpandMapToLevel2);
            ExpandMapToLevel3 = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.ExpandMapToLevel3);
            ExpandMapToLevel4 = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.ExpandMapToLevel4);
            ExpandMapToLevel5 = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.ExpandMapToLevel5);
            GrpNavigate = new RibbonGroup(ribbon, (uint)RibbonMarkupCommands.GrpNavigate);
            NavigateToCenter = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.NavigateToCenter);
            NavigateToFirstSibling = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.NavigateToFirstSibling);
            NavigateToLastSibling = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.NavigateToLastSibling);
            GrpMove = new RibbonGroup(ribbon, (uint)RibbonMarkupCommands.GrpMove);
            MoveUp = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.MoveUp);
            MoveDown = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.MoveDown);
            GrpSort = new RibbonGroup(ribbon, (uint)RibbonMarkupCommands.GrpSort);
            SortAlphabetic = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.SortAlphabetic);
            SortDueDate = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.SortDueDate);
            SortNodeCount = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.SortNodeCount);
            SortCreateDate = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.SortCreateDate);
            SortModifiedDate = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.SortModifiedDate);
            SortOrder = new RibbonToggleButton(ribbon, (uint)RibbonMarkupCommands.SortOrder);
            GrpUndo = new RibbonGroup(ribbon, (uint)RibbonMarkupCommands.GrpUndo);
            Undo = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.Undo);
            Redo = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.Redo);
            TabInsert = new RibbonTab(ribbon, (uint)RibbonMarkupCommands.TabInsert);
            GrpHyperlink = new RibbonGroup(ribbon, (uint)RibbonMarkupCommands.GrpHyperlink);
            Hyperlink = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.Hyperlink);
            HyperlinkFile = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.HyperlinkFile);
            HyperlinkFolder = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.HyperlinkFolder);
            RemoveHyperlink = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.RemoveHyperlink);
            GrpNote = new RibbonGroup(ribbon, (uint)RibbonMarkupCommands.GrpNote);
            InsertNote = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.InsertNote);
            GrpTask = new RibbonGroup(ribbon, (uint)RibbonMarkupCommands.GrpTask);
            AddTask = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.AddTask);
            AddTaskToday = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.AddTaskToday);
            AddTaskTomorrow = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.AddTaskTomorrow);
            AddTaskNextWeek = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.AddTaskNextWeek);
            AddTaskNextMonth = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.AddTaskNextMonth);
            AddTaskNextQuarter = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.AddTaskNextQuarter);
            CompleteTask = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.CompleteTask);
            RemoveTask = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.RemoveTask);
            TabFormat = new RibbonTab(ribbon, (uint)RibbonMarkupCommands.TabFormat);
            GrpNodeFormat = new RibbonGroup(ribbon, (uint)RibbonMarkupCommands.GrpNodeFormat);
            NodeShape = new RibbonDropDownGallery(ribbon, (uint)RibbonMarkupCommands.NodeShape);
            ClearShapeFormat = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.ClearShapeFormat);
            LineColor = new RibbonDropDownColorPicker(ribbon, (uint)RibbonMarkupCommands.LineColor);
            LinePattern = new RibbonDropDownButton(ribbon, (uint)RibbonMarkupCommands.LinePattern);
            LinePatternSolid = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.LinePatternSolid);
            LinePatternDashed = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.LinePatternDashed);
            LinePatternDotted = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.LinePatternDotted);
            LinePatternMixed = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.LinePatternMixed);
            LineThickness = new RibbonDropDownButton(ribbon, (uint)RibbonMarkupCommands.LineThickness);
            LineThickness1 = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.LineThickness1);
            LineThickness2 = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.LineThickness2);
            LineThickness4 = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.LineThickness4);
            GrpNodeStyle = new RibbonGroup(ribbon, (uint)RibbonMarkupCommands.GrpNodeStyle);
            NodeStyleGallery = new RibbonInRibbonGallery(ribbon, (uint)RibbonMarkupCommands.NodeStyleGallery);
            CreateNodeStyle = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.CreateNodeStyle);
            GrpClearFormat = new RibbonGroup(ribbon, (uint)RibbonMarkupCommands.GrpClearFormat);
            TabView = new RibbonTab(ribbon, (uint)RibbonMarkupCommands.TabView);
            GrpViewTask = new RibbonGroup(ribbon, (uint)RibbonMarkupCommands.GrpViewTask);
            ViewCalendar = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.ViewCalendar);
            ViewTaskList = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.ViewTaskList);
            GrpViewNote = new RibbonGroup(ribbon, (uint)RibbonMarkupCommands.GrpViewNote);
            ViewNote = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.ViewNote);
            TabGroupNote = new RibbonTabGroup(ribbon, (uint)RibbonMarkupCommands.TabGroupNote);
            TabNoteEditor = new RibbonTab(ribbon, (uint)RibbonMarkupCommands.TabNoteEditor);
            GrpNoteFont = new RibbonGroup(ribbon, (uint)RibbonMarkupCommands.GrpNoteFont);
            GrpNoteClearFormat = new RibbonGroup(ribbon, (uint)RibbonMarkupCommands.GrpNoteClearFormat);
            GrpParagraph = new RibbonGroup(ribbon, (uint)RibbonMarkupCommands.GrpParagraph);
            Bullets = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.Bullets);
            Numbers = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.Numbers);
            Outdent = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.Outdent);
            Indent = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.Indent);
            AlignLeft = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.AlignLeft);
            AlignCenter = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.AlignCenter);
            AlignRight = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.AlignRight);
            Justify = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.Justify);
            GrpNoteStyles = new RibbonGroup(ribbon, (uint)RibbonMarkupCommands.GrpNoteStyles);
            NoteHeading1 = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.NoteHeading1);
            NoteHeading2 = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.NoteHeading2);
            NoteHeading3 = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.NoteHeading3);
            NoteNormal = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.NoteNormal);
            GrpNoteTable = new RibbonGroup(ribbon, (uint)RibbonMarkupCommands.GrpNoteTable);
            NoteInsertTable = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.NoteInsertTable);
            GrpNoteEditHtml = new RibbonGroup(ribbon, (uint)RibbonMarkupCommands.GrpNoteEditHtml);
            NoteEditHtml = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.NoteEditHtml);
            TabGroupNoteTable = new RibbonTabGroup(ribbon, (uint)RibbonMarkupCommands.TabGroupNoteTable);
            TabNoteTableLayout = new RibbonTab(ribbon, (uint)RibbonMarkupCommands.TabNoteTableLayout);
            GrpCustomizeTable = new RibbonGroup(ribbon, (uint)RibbonMarkupCommands.GrpCustomizeTable);
            ModifyTableProperties = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.ModifyTableProperties);
            GrpTableDelete = new RibbonGroup(ribbon, (uint)RibbonMarkupCommands.GrpTableDelete);
            DeleteRow = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.DeleteRow);
            DeleteColumn = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.DeleteColumn);
            DeleteTable = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.DeleteTable);
            GrpTableInsert = new RibbonGroup(ribbon, (uint)RibbonMarkupCommands.GrpTableInsert);
            InsertRowAbove = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.InsertRowAbove);
            InsertRowBelow = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.InsertRowBelow);
            InsertColumnLeft = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.InsertColumnLeft);
            InsertColumnRight = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.InsertColumnRight);
            GrpTableMove = new RibbonGroup(ribbon, (uint)RibbonMarkupCommands.GrpTableMove);
            MoveRowUp = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.MoveRowUp);
            MoveRowDown = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.MoveRowDown);
            MoveColumnLeft = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.MoveColumnLeft);
            MoveColumnRight = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.MoveColumnRight);

        }

    }
}

