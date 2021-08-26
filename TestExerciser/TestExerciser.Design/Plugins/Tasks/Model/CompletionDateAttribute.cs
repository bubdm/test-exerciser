﻿using DesignTE.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignTE.Plugins.Tasks.Model
{
    public static class CompletionDateAttribute
    {
        public const string ATTRIBUTE_NAME = "Completion Date";

        /// <summary>
        /// Delete this attribute from the given node if attribute exists
        /// </summary>
        /// <param name="node"></param>
        public static void RemoveCompletionDate(MapNode node)
        {
            MapTree.AttributeSpec aspec = GetAttributeSpec(node.Tree);
            if (aspec != null)
            {
                node.DeleteAttribute(aspec);
            }
        }

        public static bool GetAttribute(MapNode node, out MapNode.Attribute attribute)
        {
            MapTree.AttributeSpec aspec = GetAttributeSpec(node.Tree);
            if (aspec != null)
            {
                if (node.GetAttribute(aspec, out attribute))
                {
                    return true;
                }
            }

            attribute = MapNode.Attribute.Empty;
            return false;
        }

        

        public static void SetCompletionDate(MapNode node, DateTime value)
        {
            MapTree.AttributeSpec aspec = GetOrCreateAttributeSpec(node.Tree);
            node.AddUpdateAttribute(new MapNode.Attribute(aspec, DateHelper.ToString(value)));
        }

        public static bool IsCompletionDate(this MapTree.AttributeSpec aspec)
        {
            return aspec.Name == ATTRIBUTE_NAME;
        }

        private static MapTree.AttributeSpec CreateAttributeSpec(this MapTree tree)
        {
            return new MapTree.AttributeSpec(
                tree, ATTRIBUTE_NAME, true, MapTree.AttributeDataType.DateTime,
                MapTree.AttributeListOption.NoList, null, MapTree.AttributeType.System);
        }

        public static MapTree.AttributeSpec GetAttributeSpec(MapTree tree)
        {
            MapTree.AttributeSpec aspec = tree.GetAttributeSpec(ATTRIBUTE_NAME);
            return aspec;
        }

        public static MapTree.AttributeSpec GetOrCreateAttributeSpec(MapTree tree)
        {
            MapTree.AttributeSpec aspec = GetAttributeSpec(tree);
            if (aspec == null) aspec = tree.CreateAttributeSpec();

            return aspec;
        }
    }
}
