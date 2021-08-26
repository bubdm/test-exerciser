﻿/* Author: Syed Umar Anis (mail@umaranis.com)                    
 * Copyright (c) 2014 Syed Umar Anis                             
 * This software is licensed under MIT (see LICENSE.txt)    
 */

using DesignTE.Model;
using System.Drawing;
using System;
using System.Drawing.Drawing2D;

namespace DesignTE.View.MapControls.Drawing
{
    /// <summary>
    /// Performs all drawing on the panel surface.
    /// </summary>
    public static class MapPainter
    {

        public static Brush HighlightBrush = new SolidBrush(Color.FromArgb(235, 235, 235));
        private static readonly Pen dropHintPen;
        private static readonly Pen nodeHighlightPen;

        static MapPainter()
        {
            dropHintPen = new Pen(Color.Red);
            dropHintPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

            nodeHighlightPen = new Pen(Color.MediumBlue);
            nodeHighlightPen.DashStyle = DashStyle.Dash;
        }

        /// <summary>
        /// Draw tree (nodes + connections)
        /// </summary>
        /// <param name="iView"></param>
        /// <param name="g"></param>
        public static void DrawTree(IView iView, Graphics g)
        {
            DrawTreeNodes(iView, g);
            DrawNodeLinker(iView.Tree.RootNode, iView, g);

            foreach (var node in iView.Tree.SelectedNodes)
            {
                DrawSelection(node.NodeView, g);    
            }
            if (iView.HighlightedNode != null)
            {
                DrawHighlight(iView.HighlightedNode.NodeView, g);
            }
        }

        /// <summary>
        /// Draw Tree Nodes without connections
        /// </summary>
        /// <param name="iView"></param>
        /// <param name="g"></param>
        public static void DrawTreeNodes(IView iView, Graphics g)
        {
            //Draw root node
            NodeView nView = iView.GetNodeView(iView.Tree.RootNode);
            DrawRootNode(nView, g);

            //Draw rest
            DrawChildNodes(nView, iView, g);
        }

        private static void DrawChildNodes(NodeView nodeView, IView iView, Graphics g)
        {
            if (!nodeView.Node.Folded)
            {
                foreach (MapNode cNode in nodeView.Node.ChildNodes)
                {
                    DrawNode(cNode, true, iView, g);
                }
            }
        }

        public static void DrawNode(MapNode node, bool bDrawChildren, IView iView, System.Drawing.Graphics g)
        {
            NodeView nodeView = iView.GetNodeView(node);
            DrawNode(nodeView, g, iView.HighlightedNode == node);

            if (bDrawChildren)
            {
                DrawChildNodes(nodeView, iView, g);
            }

        }

        private static void DrawNode(NodeView nodeView, Graphics g, bool highlight = false)
        {
            MapNode node = nodeView.Node;
            if (!nodeView.BackColor.IsEmpty)
            {
                using (Brush brush = new SolidBrush(nodeView.BackColor))
                {
                    g.FillRectangle(brush, new RectangleF(nodeView.Left, nodeView.Top, nodeView.Width, nodeView.Height));
                }
            }
            TextRenderer.DrawText(g, node.Text, nodeView.Font,
                new RectangleF(nodeView.RecText.Left, nodeView.RecText.Top, NodeView.MAXIMUM_TEXT_WIDTH, 5000),
                nodeView.TextColor);
            for (int i = 0; i < nodeView.RecIcons.Count; i++)
            {
                nodeView.RecIcons[i].Draw(g);
            }
            nodeView.NoteIcon?.Draw(g);
            nodeView.Link?.Draw(g);
        }

        private static void DrawRootNode(NodeView nodeView, Graphics g)
        {
            MapNode node = nodeView.Node;

            System.Drawing.Drawing2D.GraphicsPath path = RoundedRectangle.Create((int)nodeView.Left, (int)nodeView.Top, (int)nodeView.Width, (int)nodeView.Height);

            if (!node.BackColor.IsEmpty)
                g.FillPath(new SolidBrush(node.BackColor), path);
                
            TextRenderer.DrawText(g, node.Text, nodeView.Font,
                new RectangleF(nodeView.RecText.Left, nodeView.RecText.Top, NodeView.MAXIMUM_TEXT_WIDTH, 5000),
                nodeView.TextColor);
            for (int i = 0; i < nodeView.RecIcons.Count; i++)
            {
                nodeView.RecIcons[i].Draw(g);
            }
            nodeView.NoteIcon?.Draw(g);
            nodeView.Link?.Draw(g);

            System.Drawing.Drawing2D.GraphicsPath pathCap = RoundedRectangle.Create((int)nodeView.Left, (int)nodeView.Top - 2, (int)nodeView.Width, (int)nodeView.Height + 2);
            g.DrawPath(Pens.Gray, pathCap);
            pathCap = RoundedRectangle.Create((int)nodeView.Left, (int)nodeView.Top - 1, (int)nodeView.Width, (int)nodeView.Height + 1);
            g.DrawPath(Pens.LightGray, pathCap);

            Pen p = Pens.Gray;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            g.DrawPath(p, path);
        }

        private static void DrawSelection(NodeView nView, Graphics g)
        {
            g.DrawLine(Pens.MediumBlue, nView.Left, nView.Top, nView.Right, nView.Top);
            g.DrawLine(Pens.MediumBlue, nView.Left, nView.Bottom - 1, nView.Right, nView.Bottom - 1);
            g.DrawArc(Pens.MediumBlue, nView.Right - 2, nView.Top, 5, nView.Height - 1, 270, 180);
            g.DrawArc(Pens.MediumBlue, nView.Left - 3, nView.Top, 5, nView.Height - 1, 90, 180);
        }

        /// <summary>
        /// Temporary change as mouse moves over a node
        /// </summary>
        /// <param name="nView"></param>
        /// <param name="g"></param>
        private static void DrawHighlight(NodeView nView, Graphics g)
        {
            g.DrawLine(nodeHighlightPen, nView.Left, nView.Top, nView.Right, nView.Top);
            g.DrawLine(nodeHighlightPen, nView.Left, nView.Bottom - 1, nView.Right, nView.Bottom - 1);
            g.DrawArc(nodeHighlightPen, nView.Right - 2, nView.Top, 5, nView.Height - 1, 270, 180);
            g.DrawArc(nodeHighlightPen, nView.Left - 3, nView.Top, 5, nView.Height - 1, 90, 180);
        }

        /// <summary>
        /// Draw node linker for the node and all its children
        /// </summary>
        /// <param name="node"></param>
        /// <param name="iView"></param>
        /// <param name="g"></param>
        /// <param name="drawChildren">if false, linkers are not drawn for children</param>
        public static void DrawNodeLinker(MapNode node, IView iView, Graphics g, bool drawChildren = true)
        {
            if (node.Parent != null)
            {

                NodeView nodeView = iView.GetNodeView(node);
                NodeView parentView = iView.GetNodeView(node.Parent);
                if (nodeView == null || parentView == null) return;

                float pos1X, pos1Y, // connector start point on parent node
                    pos2X, pos2Y;   // connector end point on current/child node

                float control1X, control1Y, control2X, control2Y;


                if (node.Pos == NodePosition.Right)
                {
                    pos1X = parentView.Left + parentView.Width;
                }
                else
                {
                    pos1X = parentView.Left;
                }

                pos1Y = node.Parent.Pos == NodePosition.Root || node.Parent.Shape == NodeShape.Bullet ?
                    parentView.Top + (int)(parentView.Height / 2) - 1 :
                    parentView.Top + parentView.Height - 1;
                
                
                pos2Y = node.Shape == NodeShape.Fork || node.Shape == NodeShape.None ?
                    nodeView.Top + nodeView.Height - 1 :
                    nodeView.Top + nodeView.Height / 2;



                if (node.Pos == NodePosition.Right)
                {
                    pos2X = nodeView.Left;
                    control1X = pos1X + 10;
                }
                else
                {
                    pos2X = nodeView.Left + nodeView.Width;
                    control1X = pos1X - 10;
                }

                control1Y = pos1Y;
                control2X = pos1X;
                control2Y = pos2Y;


                Pen p = Pens.Gray;
                bool disposePen = CreateCustomPen(node, ref p);
                
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

                g.DrawBezier(p, new PointF(pos1X, pos1Y), new PointF(control1X, control1Y),
                    new PointF(control2X, control2Y), new PointF(pos2X, pos2Y));


                DrawNodeShape(nodeView, g, p);

                DrawFoldedIndicator(nodeView, g, p);

                DrawFoldedIndicatorToNodeConnector(nodeView, g, p);

                if (disposePen) p.Dispose();

            }



            // recursive
            if (drawChildren && !node.Folded)
            {
                foreach (MapNode cNode in node.ChildNodes)
                {
                    DrawNodeLinker(cNode, iView, g);
                }
            }
        }

        /// <summary>
        /// Creates a custom pen if required, otherwise returns false
        /// </summary>
        /// <param name="pen"></param>
        /// <returns></returns>
        private static bool CreateCustomPen(MapNode node, ref Pen p)
        {
            bool customPen = false;
            if (!node.LineColor.IsEmpty)
            {
                p = new Pen(node.LineColor);
                customPen = true;
            }

            if (node.LineWidth != 0 && node.LineWidth != 1)
            {
                if (customPen == false)
                    p = new Pen(Color.Gray, node.LineWidth);
                else
                    p.Width = node.LineWidth;
                customPen = true;
            }

            if (node.LinePattern != System.Drawing.Drawing2D.DashStyle.Solid &&
                node.LinePattern != System.Drawing.Drawing2D.DashStyle.Custom)
            {
                if (customPen == false) p = new Pen(Color.Gray);
                p.DashCap = System.Drawing.Drawing2D.DashCap.Round;
                p.DashStyle = node.LinePattern;
                customPen = true;
            }

            return customPen;
        }

        private static void DrawNodeShape(NodeView nodeView, Graphics g, Pen p)
        {
            switch (nodeView.Node.Shape)
            {
                case NodeShape.None:
                case NodeShape.Fork:
                    float y = nodeView.Top + nodeView.Height - 1;
                    g.DrawLine(p, nodeView.Left, y, nodeView.Left + nodeView.Width, y);
                    break;
                case NodeShape.Bubble:
                    System.Drawing.Drawing2D.GraphicsPath path = RoundedRectangle.Create((int)nodeView.Left, (int)nodeView.Top, (int)nodeView.Width, (int)nodeView.Height);
                    g.DrawPath(p, path);
                    break;
                case NodeShape.Box:
                    g.DrawRectangle(p, nodeView.Left, nodeView.Top, nodeView.Width, nodeView.Height);
                    break;  
                case NodeShape.Bullet:
                    float x = nodeView.Node.Pos == NodePosition.Right ? nodeView.Left : nodeView.Left + nodeView.Width;
                    using (Pen penBullet = new Pen(p.Color, 2f))
                    {
                        g.DrawLine(penBullet, x, nodeView.Top + 1, x, nodeView.Top + nodeView.Height - 1);
                    }
                    break;
            }
        }

        public static void DrawNodeShape(MapNode node, IView iView, Graphics g)
        {
            Pen p = Pens.Gray;
            bool disposePen = CreateCustomPen(node, ref p);

            DrawNodeShape(iView.GetNodeView(node), g, p);

            if(disposePen) p.Dispose();
        }

        const int INDICATOR_MARGIN = 2;

        private static void DrawFoldedIndicator(NodeView nodeView, Graphics g, Pen p)
        {
            if (nodeView.Node.HasChildren && nodeView.Node.Folded)
            {
                float x;
                float y = nodeView.Node.Shape == NodeShape.Fork || nodeView.Node.Shape == NodeShape.None ?
                    y = nodeView.Top + nodeView.Height - 1 : // draw folded indicator at bottom
                    y = nodeView.Top + nodeView.Height / 2;  // draw folded indicator at mid point
                
                if (nodeView.Node.Pos == NodePosition.Right)
                {
                    x = nodeView.Left + nodeView.Width + INDICATOR_MARGIN;

                    // draw folded indicator
                    if(nodeView.Node.Shape != NodeShape.Bullet)
                        g.DrawEllipse(p, new RectangleF(new PointF(x, y - 3), new Size(6, 6))); 
                    else
                        g.FillPolygon(p.Brush, new PointF[3] {
                            new PointF(x, y - 5),
                            new PointF(x, y + 5),
                            new PointF(x + 6, y)
                        });
                    
                }
                else
                {
                    x = nodeView.Left - INDICATOR_MARGIN; 
                    
                    // draw folded indicator
                    if (nodeView.Node.Shape != NodeShape.Bullet)
                        g.DrawEllipse(p, new RectangleF(new PointF(x - 6, y - 3), new Size(6, 6)));
                    else
                        g.FillPolygon(p.Brush, new PointF[3] {
                                new PointF(x, y - 5),
                                new PointF(x, y + 5),
                                new PointF(x - 6, y)
                            });
                    
                }
            }
        }

        private static void DrawFoldedIndicatorToNodeConnector(NodeView nodeView, Graphics g, Pen p)
        {
            if (nodeView.Node.HasChildren && nodeView.Node.Folded && // only if node is folded
                (nodeView.Node.Shape == NodeShape.Fork || nodeView.Node.Shape == NodeShape.None)) // only if shape is fork
            {
                float x, y;
                y = nodeView.Top + nodeView.Height - 1;
                if (nodeView.Node.Pos == NodePosition.Right)
                {
                    x = nodeView.Left + nodeView.Width;
                    g.DrawLine(p, x, y, x + INDICATOR_MARGIN, y); // draw link between folded indicator and node shape
                }
                else
                {
                    x = nodeView.Left;
                    g.DrawLine(p, x, y, x - INDICATOR_MARGIN, y);
                }
            }

        }

        public static void DrawNodeDropHint(DropLocation location, Graphics g)
        {
            NodeView pView = location.Parent.NodeView;
            
            g.DrawLine(dropHintPen, pView.Left, pView.Top, pView.Right, pView.Top);
            g.DrawLine(dropHintPen, pView.Left, pView.Bottom - 1, pView.Right, pView.Bottom - 1);
            g.DrawArc(dropHintPen, pView.Right - 2, pView.Top, 5, pView.Height - 1, 270, 180);
            g.DrawArc(dropHintPen, pView.Left - 3, pView.Top, 5, pView.Height - 1, 90, 180);            
        }

    }
}
