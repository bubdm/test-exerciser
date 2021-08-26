using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignTE.View.NoteEditing.MsHtmlWrap
{
    internal class SelectionPreserver : IDisposable
    {
        public SelectionPreserver(MarkupRange selectedMarkupRange)
        {
            _preservedMarkupRange = selectedMarkupRange.Clone();
            _preservedMarkupRange.Start.Cling = true;
            _preservedMarkupRange.End.Cling = true;
        }

        public void Dispose()
        {
            _preservedMarkupRange.ToTextRange().select();
        }

        private MarkupRange _preservedMarkupRange = null;
    }
}
