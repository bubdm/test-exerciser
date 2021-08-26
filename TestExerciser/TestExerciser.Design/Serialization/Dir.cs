using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DesignTE.Serialization
{
    public class Dir
    {
        public static string UserSettingsDirectory
        {
            get
            {
#if !DEBUG
                return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
                    "\\" + DesignTE.Controller.MainCtrl.APPLICATION_NAME + "\\";
#else
                return Path.GetTempPath() + DesignTE.Controller.MainCtrl.APPLICATION_NAME + "\\";
#endif
            }
        }
    }
}
