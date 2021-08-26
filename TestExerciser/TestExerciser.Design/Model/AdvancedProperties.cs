﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignTE.Model
{
    /// <summary>
    /// MapNode advanced properties
    /// </summary>
    internal class AdvancedProperties
    {
        /// <summary>
        /// Image file name
        /// </summary>
        internal string Image { get; set; }

        /// <summary>
        /// Alignment of text in relation to Image
        /// </summary>
        internal TextAlignment TextAlignment { get; set; }

        internal AdvancedProperties Clone()
        {
            return (AdvancedProperties)this.MemberwiseClone();
        }

    }

}
