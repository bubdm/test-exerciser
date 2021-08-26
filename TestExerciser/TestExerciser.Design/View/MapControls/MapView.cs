﻿/* Author: Syed Umar Anis (mail@umaranis.com)                    
 * Copyright (c) 2014 Syed Umar Anis                             
 * This software is licensed under MIT (see LICENSE.txt)    
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DesignTE.Model;
using System.Windows.Forms;
using System.Drawing;
using DesignTE.MetaModel;

namespace DesignTE.View.MapControls
{
    /// <summary>
    /// Represent view state of the tree
    /// Encapsulates NodeLinksPanel
    /// Doesn't update model, instead generates event for the controller
    /// </summary>
    public class MapView : Drawing.IView
    {

        public const int HOR_MARGIN = 20;
        public const int VER_MARGIN = 3;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tree"></param>
        public MapView(MapTree tree)
        {
            this.tree = tree;
            MetaModel.MetaModel.Instance.SystemIconList.ForEach(a => a.StatusChange += systemIcon_StatusChange);

            Canvas = new MapViewPanel(this);            
            
            Canvas.BackColor = System.Drawing.Color.White;
            Canvas.Location = new System.Drawing.Point(0, 0);
            Canvas.Size = new System.Drawing.Size(200, 300);
            Canvas.TabIndex = 0;
            Canvas.Width = 4096;
            Canvas.Height = 4096;

            RegisterTreeEvents();
            RefreshNodePositions();
            Canvas.Invalidate();

            this.nodeTextEditor = new MapViewTextEditor(this, NodeView.DefaultFont);
            FormatPainter = new MapViewFormatPainter(this);                 

        }

        private readonly MapTree tree;
        public MapTree Tree
        {
            get { return tree; }            
        }

        public void CenterOnForm()
        {
            Canvas.Left = (Canvas.Parent.Width - Canvas.Width) / 2;
            Canvas.Top = (Canvas.Parent.Height - Canvas.Height) / 2;
        }

        private void RegisterTreeEvents()
        {
            this.tree.NodePropertyChanged += tree_NodePropertyChanged;
            this.tree.TreeStructureChanged += tree_TreeStructureChanged;
            this.tree.IconChanged += tree_IconChanged;
            this.tree.SelectedNodes.NodeSelected += SelectedNodes_NodeSelected;
            this.tree.SelectedNodes.NodeDeselected += SelectedNodes_NodeDeselected;
        }
                                               
        public MapViewPanel Canvas { get; set; }

        public SelectedNodes SelectedNodes
        {
            get
            {
                return Tree.SelectedNodes;
            }
        }        

        private readonly MapViewTextEditor nodeTextEditor;
        public MapViewTextEditor NodeTextEditor
        {
            get
            {
                return nodeTextEditor;
            }
        }

        public MapViewFormatPainter FormatPainter { get; private set; }

        private MapNode highlightedNode;
        public MapNode HighlightedNode
        {
            get
            {
                return highlightedNode;
            }
        }

        public void HighlightNode(MapNode node) { highlightedNode = node; Canvas.Invalidate(); }

        public void ClearHighlightedNode() { highlightedNode = null; Canvas.Invalidate(); }

        void tree_NodePropertyChanged(MapNode node, NodePropertyChangedEventArgs e)
        {
            if (node.NodeView == null) return;

            switch (e.ChangedProperty)
            {
                case NodeProperties.Text:
                    node.NodeView.RefreshText();
                    if (node == tree.RootNode) node.NodeView.RefreshPosition(node.NodeView.Left, node.NodeView.Top);
                    RefreshNodePositions(tree.RootNode, node.Pos);
                    break;
                case NodeProperties.Label:
                    throw new NotImplementedException();
                case NodeProperties.NoteText:
                    node.NodeView.RefreshNoteIcon();
                    if (node == Tree.RootNode) node.NodeView.RefreshPosition(node.NodeView.Left, node.NodeView.Top);
                    RefreshNodePositions(node.Parent ?? node, NodePosition.Undefined);
                    break;
                case NodeProperties.Bold:
                case NodeProperties.Italic:
                case NodeProperties.Strikeout:
                    node.NodeView.RefreshFont();
                    if (node == tree.RootNode) node.NodeView.RefreshPosition(node.NodeView.Left, node.NodeView.Top);
                    RefreshNodePositions(tree.RootNode, node.Pos);
                    break;                
                case NodeProperties.Folded:
                    RefreshNodePositions(tree.RootNode, node.Pos);
                    break;
                case NodeProperties.FontName:
                case NodeProperties.FontSize:
                    node.NodeView.RefreshFont();
                    if (node == tree.RootNode) node.NodeView.RefreshPosition(node.NodeView.Left, node.NodeView.Top);
                    RefreshNodePositions(tree.RootNode, node.Pos);
                    break;
                case NodeProperties.Link:
                    node.NodeView.RefreshLink();
                    if (node == tree.RootNode)
                    {
                        node.NodeView.RefreshPosition(node.NodeView.Left, node.NodeView.Top);
                        RefreshNodePositions(node, NodePosition.Undefined);
                    }
                    else
                    {
                        RefreshNodePositions(node.Parent, NodePosition.Undefined);
                    }
                    break;
                case NodeProperties.Image:
                case NodeProperties.ImageAlignment:
                    throw new NotImplementedException();
            }

            Canvas.Invalidate();
            
        }

        void tree_IconChanged(MapNode node, IconChangedEventArgs e)
        {
            if (node.NodeView == null) return;

            switch(e.ChangeType)
            {
                case IconChange.Added:
                    node.NodeView.AddIcon(e.Icon);
                    
                    break;
                case IconChange.Removed:
                    node.NodeView.RemoveIcon(e.Icon);
                    
                    break;
            }

            if (node == tree.RootNode) node.NodeView.RefreshPosition(node.NodeView.Left, node.NodeView.Top);
            RefreshNodePositions(node.Parent ?? node, NodePosition.Undefined);

            Canvas.Invalidate();
        }

        void tree_TreeStructureChanged(MapNode node, TreeStructureChangedEventArgs e)
        {
            switch(e.ChangeType)
            {
                case TreeStructureChange.Detached:
                case TreeStructureChange.Deleted:
                    RefreshNodePositions(tree.RootNode, NodePosition.Undefined);
                    break;
                case TreeStructureChange.Attached:
                case TreeStructureChange.New:
                    RefreshNodePositions(tree.RootNode, node.Pos);
                    break;
                case TreeStructureChange.MovedLeft:
                case TreeStructureChange.MovedRight:
                case TreeStructureChange.MovedUp:
                case TreeStructureChange.MovedDown:
                    RefreshNodePositions(node.Parent ?? node, NodePosition.Undefined);
                    AdjustLocationToShowNodeView(node.NodeView);
                    break;
            }

            Canvas.Invalidate();
        }

        void SelectedNodes_NodeDeselected(MapNode node, SelectedNodes selectedNodes)
        {            
            Canvas.Invalidate();
        }

        void SelectedNodes_NodeSelected(MapNode node, SelectedNodes selectedNodes)
        {
            NodeView nView = GetNodeView(node);
            AdjustLocationToShowNodeView(nView);         

            Canvas.Invalidate();
        }

        internal void AdjustLocationToShowNodeView(NodeView nView)
        {
            Rectangle visibleRect = Canvas.GetVisibleRectangle();

            if (visibleRect.Left > nView.Left)
            {
                
                Canvas.Left += (int)(visibleRect.Left - nView.Left + 10);
            }
            if (visibleRect.Top > nView.Top)
            {
                Canvas.Top += (int)(visibleRect.Top - nView.Top + 10);
            }
            int visibleRectRight = visibleRect.Right;
            int nViewRight = (int)(nView.Left + nView.Width);
            if (visibleRectRight < nViewRight)
            {
                Canvas.Left += (int)(visibleRectRight - nViewRight - 10);
            }
            int visibleRectBottom = visibleRect.Bottom;
            int nViewBottom = (int)(nView.Top + nView.Height);
            if (visibleRectBottom < nViewBottom)
            {
                Canvas.Top += (int)(visibleRectBottom - nViewBottom - 10);
            }

            Canvas.IgnoreNextMouseMove = true;
        }

        void systemIcon_StatusChange(MapNode node, ISystemIcon icon, MetaModel.SystemIconStatusChange e)
        {
            if (node.Tree != Tree) return; //event could be due to change in some other MapView
            if (node.NodeView == null) return;

            switch(e)
            {
                case SystemIconStatusChange.Show:
                    node.NodeView.AddIcon(icon);
                    break;
                case SystemIconStatusChange.Hide:
                    node.NodeView.RemoveIcon(icon);
                    break;
            }

            if (node == tree.RootNode) node.NodeView.RefreshPosition(node.NodeView.Left, node.NodeView.Top);
            RefreshNodePositions(node.Parent ?? node, NodePosition.Undefined);

            Canvas.Invalidate();
        }

        #region Refresh MapView

        public bool LayoutSuspended { get; private set; }

        /// <summary>
        /// Suspends recalculating NodeView positions for MapView.
        /// Useful if multiple changes are to be done in MapTree.
        /// Call <see cref="ResumeLayout"/> when changes are completed.
        /// </summary>
        public void SuspendLayout() { LayoutSuspended = true; }

        public void ResumeLayout(bool refreshLayout = false, NodePosition sideToRefresh = NodePosition.Undefined)
        {
            LayoutSuspended = false;
            if(refreshLayout)
            {
                RefreshNodePositions(Tree.RootNode, sideToRefresh);
                Canvas.Invalidate();
            }
        }

        /// <summary>
        /// Refreshes or initializes node positions for the whole tree
        /// </summary>
        private void RefreshNodePositions()
        {
            if (LayoutSuspended) return;

            NodeView nodeView = this.GetNodeView(Tree.RootNode);

            //var left = this.rootPosX;
            var left = this.Canvas.Width / 2;
            //var top = this.rootPosY;
            var top = this.Canvas.Height / 2;
            // add unit string for xhtml


            nodeView.RefreshPosition(left - (nodeView.Width / 2), top);

            RefreshNodePositions(Tree.RootNode, NodePosition.Undefined);

        }

        /// <summary>
        /// Refreshes or initializes node positions relative to the parent node position. 
        /// Parent node position must already be set.
        /// </summary>
        /// <param name="node">Parent Node</param>
        /// <param name="sideToRefresh">Which side to refresh (left or right). For Undefined or Root, both sides will be refreshed.</param>
        internal void RefreshNodePositions(MapNode node, NodePosition sideToRefresh)
        {
            if (LayoutSuspended) return;

            NodeView nView = this.GetNodeView(node);

            if (!node.HasChildren || node.Folded)
            {
                return;
            }
            else
            {
                for (int i = 0; i < 2; i++)
                {
                    IEnumerable<MapNode> childNodes;
                    NodePosition rpos;

                    if (i == 0)
                    {
                        rpos = NodePosition.Left;
                        childNodes = node.ChildLeftNodes;
                    }
                    else
                    {
                        rpos = NodePosition.Right;
                        childNodes = node.ChildRightNodes;
                    }

                    float left = nView.Left + nView.Width + HOR_MARGIN;
                    float top = nView.Top - (int)((this.GetNodeHeight(node, rpos) - nView.Height) / 2) - ((node.Pos == NodePosition.Root) ? (int)(nView.Height / 2) : 0);
                    int topOffset;
                    foreach (MapNode rnode in childNodes)
                    {
                        NodeView tView = this.GetNodeView(rnode);


                        topOffset = (int)((this.GetNodeHeight(rnode, rpos) - tView.Height) / 2);
                        if (i == 0)
                        {
                            left = nView.Left - tView.Width - HOR_MARGIN;
                        }

                        tView.RefreshPosition(left, top + topOffset);

                        top += (topOffset * 2) + tView.Height + VER_MARGIN;

                        if (!rnode.Folded)
                        {
                            // recursive call
                            RefreshNodePositions(rnode, NodePosition.Undefined);
                        }
                    }
                }

            }
        }        

        #endregion Refresh MapView

        public NodeView GetNodeView(MapNode node)
        {
            if (node.NodeView == null)
            {
                node.NodeView = new NodeView(node);
            }
            return node.NodeView;
        }

        /// <summary>
        /// Get hieght of the node including child nodes
        /// </summary>
        /// <param name="node"></param>
        /// <param name="pos"></param>
        /// <returns></returns>
        public float GetNodeHeight(MapNode node, NodePosition pos)
        {
            NodeView nView = this.GetNodeView(node);
            if (!node.HasChildren || node.Folded)
            {
                if (nView != null)
                {
                    return nView.Height;
                }                
            }

            // accumulate all children's height
            float height = 0;
            var sibCnt = 0;

            IEnumerable<MapNode> childNodes = pos == NodePosition.Left ? node.ChildLeftNodes : node.ChildRightNodes;

            foreach (MapNode cNode in childNodes)
            {
                sibCnt++;
                height += this.GetNodeHeight(cNode, pos);
            }


            height += (sibCnt - 1) * VER_MARGIN;
            return (nView.Height > height ? nView.Height : height);
        }


        public System.Drawing.Bitmap DrawToBitmap()
        {
            System.Drawing.Bitmap bmp = new System.Drawing.Bitmap(this.Canvas.Width, this.Canvas.Height);

            //built-in way of getting image
            //it is not working properly (shows a black rectangle) from the Ribbon project
            //works perfectly from WinXP project
            //this.Canvas.DrawToBitmap(bmp, new System.Drawing.Rectangle(0, 0, this.Canvas.Width, this.Canvas.Height));

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Canvas.BackColor); //set background color
                Drawing.MapPainter.DrawTree(this, g);
            }

            return bmp;
        }
                
        public MapNode GetMapNodeFromPoint(System.Drawing.Point point)
        {
            MapNode node = this.Tree.RootNode;
            return GetMapNodeFromPoint(point, node);

        }

        private MapNode GetMapNodeFromPoint(System.Drawing.Point point, MapNode node)
        {
            float xdiff = 0, ydiff = 0;
            if (node.NodeView != null)
            {
                xdiff = point.X - node.NodeView.Left;
                ydiff = point.Y - node.NodeView.Top;
                if (
                    (xdiff > 0 && xdiff < node.NodeView.Width) &&
                    (ydiff > 0 && ydiff < node.NodeView.Height))
                {
                    return node;
                }

                if (!node.Folded && node.HasChildren)
                {
                    if (
                        (node.Pos == NodePosition.Right && xdiff > (node.NodeView.Width + DesignTE.View.MapControls.MapView.HOR_MARGIN))
                        ||
                        (node.Pos == NodePosition.Left && xdiff < (-DesignTE.View.MapControls.MapView.HOR_MARGIN))
                        )
                    {
                        foreach (var cNode in node.ChildNodes)
                        {
                            MapNode tnode = GetMapNodeFromPoint(point, cNode);
                            if (tnode != null)
                            {
                                return tnode;
                            }
                        }
                    }
                    else if (node.Pos == NodePosition.Root)
                    {
                        NodePosition posToProcess = NodePosition.Undefined;
                        if (xdiff > (node.NodeView.Width + DesignTE.View.MapControls.MapView.HOR_MARGIN))
                        {
                            posToProcess = NodePosition.Right;
                        }
                        else if (xdiff < (-DesignTE.View.MapControls.MapView.HOR_MARGIN))
                        {
                            posToProcess = NodePosition.Left;
                        }

                        if (posToProcess != NodePosition.Undefined)
                        {
                            foreach (var cNode in node.ChildNodes)
                            {
                                if (cNode.Pos == posToProcess)
                                {
                                    var tNode = GetMapNodeFromPoint(point, cNode);
                                    if (tNode != null)
                                        return tNode;
                                }
                            }

                        }


                    }

                }
            }
            return null;

        }

        public Point GetMouseOffset(Control target, MouseEventArgs evt)
        {

            Point docPos = Canvas.Location;
            Point mousePos = Canvas.PointToScreen(evt.Location);
            return new Point(mousePos.X - docPos.X, mousePos.Y - docPos.Y);

        }

    }
        
}
