using DesignTE.MetaModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignTE.Plugins
{
    interface IPluginSystemIcon
    {
        /// <summary>
        /// This method is called only once.
        /// </summary>
        /// <returns></returns>
        ISystemIcon[] CreateSystemIcons();
    }
}
