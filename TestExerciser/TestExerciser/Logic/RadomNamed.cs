using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestExerciser.Logic
{
    class RadomNamed
    {
        public static string GuidTo16String()
        {
            long i = 1;
            foreach (byte b in Guid.NewGuid().ToByteArray())
                i *= ((int)b + 1);
            return string.Format("{0:x}", i - DateTime.Now.Ticks);
        }
    }
}
