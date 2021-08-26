using DesignTE.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignTE.Modules.Undo.Changes
{
    class AttributeSpecDataType : IChange
    {
        MapTree.AttributeSpec spec;
        MapTree.AttributeDataType oldValue;

        public AttributeSpecDataType(MapTree.AttributeSpec spec, MapTree.AttributeDataType oldValue)
        {
            this.spec = spec;
            this.oldValue = oldValue;
        }

        public string Description
        {
            get { return "Attribute Spec DataType"; }
        }

        public void Undo()
        {
            spec.DataType = oldValue;
        }
    }
}
