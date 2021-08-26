using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using DesignTE.Model;

namespace DesignTE.View.MapControls.Drawing
{
    public interface IView
    {
        NodeView GetNodeView(MapNode node);

        MapTree Tree { get; }

        MapNode HighlightedNode { get; }
    }
}
