﻿using System;
using System.CodeDom;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using DesignTE.MetaModel;
using YamlDotNet.Core;
using YamlDotNet.Core.Events;

namespace DesignTE.Serialization
{
    public class MetaModelYamlSerializer
    {
        public const string Icons = "icons";
        public const string Name = "name";
        public const string Title = "title";
        public const string Shortcut = "shortcut";
        public const string RecentFiles = "recentfiles";
        public const string LastOpenedFile = "lastopenedfile";
        public const string MapBackColor = "mapbackcolor";
        public const string NoteBackColor = "notebackcolor";
        public const string NodeStyles = "nodestyles";
        public const string RefNode = "refnode";


        public void Serialize(MetaModel.MetaModel metaModel, TextWriter writer)
        {
            Emitter emitter = new Emitter(writer);

            emitter.Emit(new StreamStart());
            emitter.Emit(new DocumentStart());
            emitter.Emit(new MappingStart());

            //icons
            emitter.Emit(new Scalar(Icons));
                emitter.Emit(new SequenceStart(null, null, true, SequenceStyle.Block));
                foreach (var modelIcon in metaModel.IconsList)
                {
                    emitter.Emit(new MappingStart());
                    emitter.Emit(new Scalar(Name));
                    emitter.Emit(new Scalar(modelIcon.Name));
                    emitter.Emit(new Scalar(Title));
                    emitter.Emit(new Scalar(modelIcon.Title));
                    emitter.Emit(new Scalar(Shortcut));
                    emitter.Emit(new Scalar(modelIcon.Shortcut));
                    emitter.Emit(new MappingEnd());
                }
                emitter.Emit(new SequenceEnd());
            //recent files
            if (metaModel.RecentFiles.Count > 0)
            {
                emitter.Emit(new Scalar(RecentFiles));
                emitter.Emit(new SequenceStart(null, null, true, SequenceStyle.Block));
                foreach (var recentFile in metaModel.RecentFiles)
                {
                    emitter.Emit(new Scalar(recentFile));
                }
                emitter.Emit(new SequenceEnd());
            }
            //last opened file
            if (metaModel.LastOpenedFile != null)
            {
                emitter.Emit(new Scalar(LastOpenedFile));
                emitter.Emit(new Scalar(metaModel.LastOpenedFile));
            }
            //map back color
            emitter.Emit(new Scalar(MapBackColor));
            emitter.Emit(new Scalar(Convert.ToColorHexValue(metaModel.MapEditorBackColor)));
            //note back color
            emitter.Emit(new Scalar(NoteBackColor));
            emitter.Emit(new Scalar(Convert.ToColorHexValue(metaModel.NoteEditorBackColor)));
            //node styles
            if (metaModel.NodeStyles.Any())
            {
                emitter.Emit(new Scalar(NodeStyles));
                emitter.Emit(new SequenceStart(null, null, true, SequenceStyle.Block));
                foreach (var nodeStyle in metaModel.NodeStyles)
                {
                    emitter.Emit(new MappingStart());
                    emitter.Emit(new Scalar(Title));
                    emitter.Emit(new Scalar(nodeStyle.Title));
                    emitter.Emit(new Scalar(RefNode));
                    new MapYamlSerializer().Serialize(nodeStyle.RefNode, emitter);
                    emitter.Emit(new MappingEnd());
                }
                emitter.Emit(new SequenceEnd()); 
            }

            emitter.Emit(new MappingEnd());
            emitter.Emit(new DocumentEnd(true));
            emitter.Emit(new StreamEnd());
        }

        /// <summary>
        /// Throws YamlException
        /// </summary>
        /// <param name="metaModel"></param>
        /// <param name="textReader"></param>
        public void Deserialize(MetaModel.MetaModel metaModel, TextReader textReader)
        {
            Parser p = new Parser(textReader);
            //IParser p = new IParser(p);

            p.Expect<StreamStart>();
            p.Expect<DocumentStart>();
            p.Expect<MappingStart>();

            Scalar section = p.Peek<Scalar>();
            if (section.Value.Equals(Icons))
            {
                p.Expect<Scalar>();
                DeserializeIcons(metaModel, p);
                section = p.Peek<Scalar>();
            }

            if (section != null && section.Value.Equals(RecentFiles))
            {
                p.Expect<Scalar>();
                DeserializeRecentFiles(metaModel, p);
                section = p.Peek<Scalar>();
            }

            if (section != null && section.Value.Equals(LastOpenedFile))
            {
                p.Expect<Scalar>();
                metaModel.LastOpenedFile = p.Expect<Scalar>().Value;
                section = p.Peek<Scalar>();
            }

            if (section != null && section.Value.Equals(MapBackColor))
            {
                p.Expect<Scalar>();
                metaModel.MapEditorBackColor = (Color)(new ColorConverter().ConvertFromString(p.Expect<Scalar>().Value));
                section = p.Peek<Scalar>();
            }

            if (section != null && section.Value.Equals(NoteBackColor))
            {
                p.Expect<Scalar>();
                metaModel.NoteEditorBackColor = (Color)(new ColorConverter().ConvertFromString(p.Expect<Scalar>().Value));
                section = p.Peek<Scalar>(); 
            }

            if (section != null && section.Value.Equals(NodeStyles))
            {
                p.Expect<Scalar>();
                DeserializeNodeStyles(metaModel, p);
                //section = p.Peek<Scalar>(); //uncomment when adding another section
            }

            

            p.Expect<MappingEnd>();
            p.Expect<DocumentEnd>();
            p.Expect<StreamEnd>();
        }

        private void DeserializeIcons(MetaModel.MetaModel metaModel, IParser p)
        {
            p.Expect<SequenceStart>();

            while (p.Accept<MappingStart>())
            {
                DeserializeIcon(metaModel, p);
            }

            p.Expect<SequenceEnd>();
        }

        /// <summary>
        /// Name and Title are mandatory while shortcut is optional
        /// </summary>
        /// <param name="metaModel"></param>
        /// <param name="p"></param>
        private void DeserializeIcon(MetaModel.MetaModel metaModel, IParser p)
        {
            string name = null, title = null, shortcut = null;
            p.Expect<MappingStart>();

            p.Expect<Scalar>(); //name
            name = p.Expect<Scalar>().Value;

            p.Expect<Scalar>();
            title = p.Expect<Scalar>().Value;

            if (p.Accept<Scalar>())
            {
                if(p.Expect<Scalar>().Value.Equals(Shortcut))
                {
                    shortcut = p.Expect<Scalar>().Value;
                }
            }
            p.Expect<MappingEnd>();

            metaModel.IconsList.Add(new ModelIcon(name, title, shortcut));
        }

        private void DeserializeRecentFiles(MetaModel.MetaModel metaModel, IParser p)
        {
            p.Expect<SequenceStart>();

            while (p.Accept<Scalar>())
            {
                metaModel.RecentFiles.Add(p.Expect<Scalar>().Value);
            }

            p.Expect<SequenceEnd>();
        }

        private void DeserializeNodeStyles(MetaModel.MetaModel metaModel, IParser p)
        {
            p.Expect<SequenceStart>();

            while (p.Accept<MappingStart>())
            {
                DeserializeNodeStyle(metaModel, p);
            }

            p.Expect<SequenceEnd>();
        }

        private void DeserializeNodeStyle(MetaModel.MetaModel metaModel, IParser p)
        {
            var s = new NodeStyle();

            p.Expect<MappingStart>();

            p.Expect<Scalar>(); //Title
            s.Title = p.Expect<Scalar>().Value;

            p.Expect<Scalar>(); //RefNode
            s.RefNode = new MapYamlSerializer().Deserialize(p);

            p.Expect<MappingEnd>();
            
            metaModel.NodeStyles.Add(s);
        }
        
    }
}
