﻿using DesignTE.Serialization;
using DesignTE.View.NoteEditing.MsHtmlWrap;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DesignTE.View.NoteEditing
{
    /// <summary>
    /// Pastes image from Clipboard to NoteEditor
    /// </summary>
    public class ClipboardImagePaster
    {
        private readonly PersistenceManager pManager;

        public ClipboardImagePaster(NoteEditor editor, PersistenceManager pManager)
        {
            editor.Pasting += Editor_Pasting;
            this.pManager = pManager;
        }

        private void Editor_Pasting(object arg1, PastingEventArgs arg2)
        {
            arg2.Handled = PasteFromClipboard((NoteEditor)arg1, pManager.CurrentTree);
        }

        public static bool PasteFromClipboard(NoteEditor editor, PersistentTree tree)
        {
            if(Clipboard.ContainsImage())
            {
                Image image = Clipboard.GetImage();

                var imagePath = ImageLocalPath.CreateNewLocalPath("png");

                MemoryStream ms = new MemoryStream();
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);           
                tree.SetByteArray(imagePath.FileName, ms.ToArray());

                var htmlImage = new HtmlImageCreator(editor);
                htmlImage.InsertImage(imagePath.Url, "");

                return true;                            
            }
            else if (Clipboard.ContainsFileDropList())
            {
                var fileList = Clipboard.GetFileDropList();
                var imageList = FilterImageFiles(fileList);
                if (imageList.Any())
                {
                    imageList.ForEach(i =>
                    {
                        var localPath = ImageLocalPath.CreateNewLocalPath(Path.GetExtension(i).Substring(1));
                        tree.SetByteArray(localPath.FileName, File.ReadAllBytes(i));

                        var htmlImage = new HtmlImageCreator(editor);
                        htmlImage.InsertImage(localPath.Url, "");
                    });
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private static List<string> FilterImageFiles(StringCollection fileList)
        {
            string[] imageExtensions = { "png", "jpg", "jpeg", "gif", "bmp" };
            var imageList = new List<string>();
            foreach (var fileName in fileList)
            {
                if (imageExtensions.Any(ext => fileName.EndsWith(ext, StringComparison.InvariantCultureIgnoreCase)))
                {
                    imageList.Add(fileName);
                }
            }
            return imageList;
        }
    }
}