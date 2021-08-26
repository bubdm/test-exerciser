using DesignTE.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignTE.Plugins.Tasks.Model
{
    /// <summary>
    /// Arguments for event on change of Task properties other than Text, DueDate or Selected.
    /// <seealso cref="TaskTextEventArgs"/>, <seealso cref="PendingTaskEventArgs"/>, <seealso cref="TaskSelectionEventArgs"/>
    /// </summary>
    class PendingTaskPropertyEventArgs
    {
        public PendingTaskProperty PropertyChanged { get; set; }

        public object OldValue { get; set; }
    }

    enum PendingTaskProperty { StartDate }

    delegate void PendingTaskPropertyChanged(MapNode node, PendingTaskPropertyEventArgs args);
}
