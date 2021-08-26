﻿/* Author: Syed Umar Anis (mail@umaranis.com)                    
 * Copyright (c) 2014 Syed Umar Anis                             
 * This software is licensed under MIT (see LICENSE.txt)    
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DesignTE.View.MapControls;

namespace DesignTE.View.MapControls
{
    public class NodeMouseEventArgs : MouseEventArgs
    {
        public NodeMouseEventArgs(MouseEventArgs e)  : 
            base(e.Button, e.Clicks, e.X, e.Y, e.Delta)
        {
            
        }

        public NodePortion NodePortion { get; set; }
    }
}
