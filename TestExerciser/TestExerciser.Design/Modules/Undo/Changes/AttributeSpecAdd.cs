using DesignTE.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignTE.Modules.Undo.Changes
{
    class AttributeSpecAdd : IChange
    {
        MapTree.AttributeSpec spec;

        public AttributeSpecAdd(MapTree.AttributeSpec spec)
        {
            this.spec = spec;
        }

        public string Description
        {
            get { return "Attribute Spec Added"; }
        }

        public void Undo()
        {
            spec.Delete();
        }
    }
}
