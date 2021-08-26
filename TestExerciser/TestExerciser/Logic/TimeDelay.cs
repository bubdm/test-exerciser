using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using TestExerciser.User;

namespace TestExerciser.Logic
{
    class TimeDelay
    {

        public bool closingCurrentWindowDelay(int delayTime, Control txtStatus,Form formName,string tipMsg,string tipMsgEnd)
        {
            DateTime now = DateTime.Now;
            int s;
            do
            {
                TimeSpan spand = DateTime.Now - now;
                s = spand.Seconds;
                Application.DoEvents();
                txtStatus.ForeColor = Color.Blue;
                int i = delayTime - s;
                txtStatus.Text = tipMsg + "窗口将在" + i + "秒后退出！" + tipMsgEnd;              
            }
            while (s < delayTime);
            formName.Visible = false;
            formName.Close();
            return true;
        }

        public bool restartDelay(int delayTime, Control txtStatus, string tipMsg, string tipMsgEnd)
        {
            DateTime now = DateTime.Now;
            int s;
            do
            {
                TimeSpan spand = DateTime.Now - now;
                s = spand.Seconds;
                Application.DoEvents();
                txtStatus.ForeColor = Color.Blue;
                int i = delayTime - s;
                txtStatus.Text = tipMsg + "窗口将在" + i + "秒后退出！" + tipMsgEnd;
            }
            while (s < delayTime);
            Application.Restart();
            return true;
        }

        public string timeNow()
        {
            string timeNow = null;
            DateTime now = DateTime.Now;
            timeNow = now.ToShortTimeString();
            return timeNow;
        }

        public void timeUse(Control txtStatus)
        {
            
        }
    }
}
