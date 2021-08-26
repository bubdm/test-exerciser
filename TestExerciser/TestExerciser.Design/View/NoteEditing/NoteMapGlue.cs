﻿/* Author: Syed Umar Anis (mail@umaranis.com)                    
 * Copyright (c) 2014 Syed Umar Anis                             
 * This software is licensed under MIT (see LICENSE.txt)    
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DesignTE.Model;
using DesignTE.View.MapControls;
using DesignTE.View;
using System.Drawing;
using DesignTE.Serialization;
using DesignTE.View.NoteEditing;

namespace DesignTE.View.NoteEditing
{
    /// <summary>
    /// Note Window Controlller
    /// </summary>
    public class NoteMapGlue
    {
        
        private readonly NoteEditor editor;
        public NoteEditor Editor
        {
            get
            {
                return editor;
            }
        }


        private MapNode mapNode;

        /// <summary>
        /// Ignore <see cref="MapTree.NodePropertyChanged"/> event when <see cref="MapNode.NoteText"/> property is changed by <see cref="NoteMapGlue"/> itself.
        /// </summary>
        private bool ignoreModelChange;        

        public NoteMapGlue(NoteEditor editor, PersistenceManager manager)
        {
            this.editor = editor;
            editor.BackColor = MetaModel.MetaModel.Instance.NoteEditorBackColor; //System.Drawing.Color.LightYellow;     
            new NoteEditorContextMenu(editor);
                   
            manager.CurrentTreeChanged += Manager_CurrentTreeChanged;
            if (manager.CurrentTree != null) { Register(manager.CurrentTree.Tree); }

            if (editor.DocumentReady)
            {
                editor.Document.Body.LostFocus += editor_LostFocus; // setup editor lost focus event
            }
            else // same as above block in case the document is not ready yet
            {
                editor.Ready += (obj) => {
                    editor.Document.Body.LostFocus += editor_LostFocus;
                };
            }
        }

        #region Setting & Updating back Content

        /// <summary>
        /// Based on SelectedNodes status, set NoteEditor content. If multiple selection, NoteEditor is cleared.
        /// </summary>
        /// <param name="selectedNodes"></param>
        private void SetEditorContent(SelectedNodes selectedNodes)
        {
            if (selectedNodes.Count == 1)
            {
                mapNode = selectedNodes.First;
                editor.Enabled = true;
                if (selectedNodes.First.HasNoteText)
                {
                    editor.HTML = this.mapNode.NoteText;
                }
                else
                {
                    editor.Clear();
                }
                editor.ClearUndoStack();

            }
            else if (selectedNodes.Count > 1)
            {
                mapNode = null;
                editor.Enabled = false;
                editor.Clear();
                editor.ClearUndoStack();
            }
            else if (!editor.Empty)
            {
                mapNode = null;
                editor.Enabled = true;
                editor.Clear();
                editor.ClearUndoStack();
            }
        }

        public void UpdateNodeFromEditor()
        {
            if (editor.Dirty && mapNode != null)
            {
                mapNode.Tree.ChangeManager.StartBatch("Change Note");
                ignoreModelChange = true;
                if (!editor.Empty)
                {
                    mapNode.NoteText = editor.HTML;
                }
                else
                {
                    mapNode.NoteText = null;
                }
                editor.Dirty = false;
                ignoreModelChange = false;
                mapNode.Tree.ChangeManager.EndBatch();
            }
        }

        #endregion

        #region Registering for Change Events

        private void Manager_CurrentTreeChanged(PersistenceManager manager, PersistentTree oldTree, PersistentTree newTree)
        {
            if (oldTree != null)
            {
                Unregister(oldTree.Tree);
            }
            if (newTree != null)
            {
                Register(newTree.Tree);
            }
        }

        /// <summary>
        /// Only one MapTree should be registered at a time
        /// </summary>
        /// <param name="tree"></param>
        private void Register(MapTree tree)
        {
            if (tree != null)
            {
                
                if (editor.DocumentReady)
                {
                    SetEditorContent(tree.SelectedNodes); // setup the NoteEditor for already selected node
                }
                else // same as above block in case the document is not ready yet
                {
                    editor.Ready += (obj) => SetEditorContent(tree.SelectedNodes); 
                }

                // events for nodes selected in future
                tree.SelectedNodes.NodeSelected += Tree_NodeSelected;
                tree.SelectedNodes.NodeDeselected += Tree_NodeDeselected;
                // event for Node's Rich Content change (required where Note content is changed outside of Note window)
                tree.NodePropertyChanged += Tree_NodePropertyChanged;
                
            }            
        }


        private void Unregister(MapTree tree)
        {
            if (tree != null)
            {
                tree.SelectedNodes.NodeSelected -= Tree_NodeSelected;
                tree.SelectedNodes.NodeDeselected -= Tree_NodeDeselected;
                tree.NodePropertyChanged -= Tree_NodePropertyChanged;
            }
        }

        #endregion

        #region Change Events

        void Tree_NodeSelected(Model.MapNode node, SelectedNodes selectedNodes)
        {
            SetEditorContent(selectedNodes);
        }

        void Tree_NodeDeselected(MapNode node, SelectedNodes selectedNodes) 
        {
            UpdateNodeFromEditor();

            // in case deselection has resulted in 'selection of one node'
            SetEditorContent(selectedNodes);
        }

        /// <summary>
        /// Event for Node's Rich Content change (required where Note content is changed outside of Note window)
        /// </summary>
        /// <param name="node"></param>
        /// <param name="e"></param>
        private void Tree_NodePropertyChanged(MapNode node, NodePropertyChangedEventArgs e)
        {
            if (ignoreModelChange) return;

            if (node.Selected && e.ChangedProperty == NodeProperties.NoteText)
            {
                SetEditorContent(node.Tree.SelectedNodes);
            }
        }

        void editor_LostFocus(object sender, EventArgs e)
        {
            UpdateNodeFromEditor();
        }

        #endregion Change Events

    }
}