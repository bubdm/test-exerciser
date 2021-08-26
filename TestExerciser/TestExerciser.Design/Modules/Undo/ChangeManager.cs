﻿using DesignTE.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignTE.Modules.Undo
{
    /// <summary>
    /// Each MapTree should have its own instance of ChangeManager.
    /// </summary>
    public class ChangeManager
    {
        readonly Stack<IChange> undoStack;
        readonly Stack<IChange> redoStack;

        readonly ChangeFactory factory = new ChangeFactory();

        enum State { None, Undoing, Redoing }
        State state = State.None;

        public ChangeManager()
        {
            undoStack = new Stack<IChange>();
            redoStack = new Stack<IChange>();
        }

        public void Undo()
        {
            state = State.Undoing;
            if(undoStack.Count > 0)
            {
                undoStack.Pop().Undo();
            }
            state = State.None;
        }

        public void Redo()
        {
            state = State.Redoing;
            if (redoStack.Count > 0)
                redoStack.Pop().Undo();
            state = State.None;
        }

        public bool CanUndo { get { return undoStack.Count > 0; } }

        public bool CanRedo { get { return redoStack.Count > 0; } }

        public int UndoStackCount {
            get { return undoStack.Count; }
        }

        public int RedoStackCount {
            get { return redoStack.Count; }
        }

        public void RegisterMap(MapTree tree)
        {
            tree.AttributeChanged += Tree_AttributeChanged;
            tree.AttributeSpecChangeEvent += Tree_AttributeSpecChangeEvent;
            tree.IconChanged += Tree_IconChanged;
            tree.NodePropertyChanged += Tree_NodePropertyChanged;
            tree.TreeStructureChanged += Tree_TreeStructureChanged;
        }

        public void Unregister(MapTree tree)
        {
            tree.AttributeChanged -= Tree_AttributeChanged;
            tree.AttributeSpecChangeEvent -= Tree_AttributeSpecChangeEvent;
            tree.IconChanged -= Tree_IconChanged;
            tree.NodePropertyChanged -= Tree_NodePropertyChanged;
            tree.TreeStructureChanged -= Tree_TreeStructureChanged;

            undoStack.Clear();
            redoStack.Clear();
        }

        private void RecordChange(IChange change)
        {
            if (batch != null)
            {
                batch.Changes.Add(change);
            }
            else if (state != State.Undoing)
            {
                undoStack.Push(change);
                if (state != State.Redoing) redoStack.Clear();
            }
            else
            {
                redoStack.Push(change);
            }
        }

        private void Tree_TreeStructureChanged(MapNode node, TreeStructureChangedEventArgs e)
        {
            IChange change = factory.CreateChange(node, e);
            if (change != null) { RecordChange(change); }
        }

        private void Tree_NodePropertyChanged(MapNode node, NodePropertyChangedEventArgs e)
        {
            IChange change = factory.CreateChange(node, e);
            if (change != null) { RecordChange(change); }
        }

        private void Tree_IconChanged(MapNode node, IconChangedEventArgs e)
        {
            IChange change = factory.CreateChange(node, e);
            if (change != null) { RecordChange(change); }
        }

        private void Tree_AttributeChanged(MapNode node, AttributeChangeEventArgs e)
        {
            IChange change = factory.CreateChange(node, e);
            if (change != null) { RecordChange(change); }
        }

        private void Tree_AttributeSpecChangeEvent(MapTree.AttributeSpec node, MapTree.AttributeSpecEventArgs e)
        {
            IChange change = factory.CreateChange(node, e);
            if (change != null) { RecordChange(change); }
        }        

        #region Batch Changes

        private BatchChange batch;

        /// <summary>
        /// Are batch changes in progress.
        /// While batch is open, all changes are added to the batch till EndBatch is called.
        /// </summary>
        public bool IsBatchOpen
        {
            get
            {
                return batch != null;
            }
        }

        public IDisposable StartBatch(string changeDescription)
        {
            batch = new BatchChange(changeDescription, this);
            return batch;
        }

        public void EndBatch()
        {
            var tempBatch = batch;
            batch = null;
            if (tempBatch.Changes.Count > 0) //if batch is empty, ignore it
            {
                RecordChange(tempBatch);
            }

        }

        #endregion Batch Changes
    }
}
