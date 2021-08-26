﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace DesignTE.MetaModel
{
    public interface IIcon
    {
        Bitmap Bitmap { get; }

        string Name { get; }
    }
}
