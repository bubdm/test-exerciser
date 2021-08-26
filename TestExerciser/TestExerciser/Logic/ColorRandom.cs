using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace TestExerciser.Logic
{
    class ColorRandom
    {
        public void colorSelect()
        {
            int iSeed = 10;
            Random ro = new Random(iSeed);
            long tick = DateTime.Now.Ticks;
            Random ran = new Random((int)(tick & 0xffffffffL) | (int)(tick >> 32));

            int R = ran.Next(255);
            int G = ran.Next(255);
            int B = ran.Next(255);
            B = (R + G > 400) ? R + G - 400 : B;//0 : 380 - R - G;
            B = (B > 255) ? 255 : B;
            Color.FromArgb(R, G, B);
        }
    }
}
