using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestExerciser.Logic
{
    class GUID
    {
        public static string getGUID(string type)
        {
            return type + RadomNamed.GuidTo16String().ToString().ToUpper() + System.Text.RegularExpressions.Regex.Replace(DateTime.Now.ToString(), @"[^0-9]+", "");
        }    
    }
}
