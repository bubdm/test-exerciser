/* Author: Syed Umar Anis (mail@umaranis.com)                    
 * Copyright (c) 2014 Syed Umar Anis                             
 * This software is licensed under MIT (see LICENSE.txt)    
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using DesignTE.Model;

namespace DesignTE.View.MapControls
{
    public class Link
    {
        public Link(string link, NodeLinkType linkType)
        {
            ChangeLink(link, linkType);                        
        }

        public void ChangeLink(string link, NodeLinkType linkType)
        {
            this.linkType = linkType;

            switch (linkType)
            {
                case NodeLinkType.MindMapNode:
                    bitmap = DesignTE.Properties.Resources.LinkLocal;
                    break;
                case NodeLinkType.InternetLink:
                    bitmap = DesignTE.Properties.Resources.LinkWeb;
                    break;
                case NodeLinkType.EmailLink:
                    bitmap = DesignTE.Properties.Resources.LinkEmail;
                    break;
                case NodeLinkType.Executable:
                    bitmap = DesignTE.Properties.Resources.LinkExecutable;
                    break;
                case NodeLinkType.ImageFile:
                    bitmap = DesignTE.Properties.Resources.LinkImage;
                    break;
                case NodeLinkType.VideoFile:
                    bitmap = DesignTE.Properties.Resources.LinkVideo;
                    break;
                case NodeLinkType.Folder:
                    bitmap = DesignTE.Properties.Resources.LinkFolder;
                    break;
                case NodeLinkType.File:
                    bitmap = DesignTE.Properties.Resources.LinkFile;
                    break;
            }
        }

        
        private NodeLinkType linkType;

        public NodeLinkType LinkType
        {
            get { return linkType; }
            set { linkType = value; }
        }

        PointF location;

        public PointF Location
        {
            get { return location; }
            set { location = value; }
        }

               
        public Size Size
        {
            get 
            { 
                return bitmap.Size; 
            }            
        }

        Bitmap bitmap;

        public Bitmap Bitmap
        {
            get 
            { 
                return bitmap; 
            }            
        }

        public void Draw(Graphics g)
        {
            g.DrawImage(bitmap, location.X, location.Y, Size.Width, Size.Height);
        }
    }
}
