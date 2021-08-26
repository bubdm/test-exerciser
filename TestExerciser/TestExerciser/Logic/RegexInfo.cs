using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace TestExerciser.Logic
{
    class RegexInfo
    {
        /// <summary>
        /// 判断是否是邮箱地址
        /// </summary>
        /// <param name="emailAddress"></param>
        /// <returns></returns>
        public bool isMailAddress(string emailAddress)
        {
            bool foundMatch = false;
            try
            {
                foundMatch = Regex.IsMatch(emailAddress, @"^[A-Z0-9._%+-]+@(?:[A-Z0-9-]+\.)+[A-Z]{2,6}$", RegexOptions.IgnoreCase | RegexOptions.Singleline);
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return foundMatch;
        }

        /// <summary>
        /// 判断是6-20位密码
        /// </summary>
        /// <param name="txtPasswd"></param>
        /// <returns></returns>
        public bool isPasswdSecurity(string txtPasswd)
        {
            bool foundMatch = false;
            try
            {
                foundMatch = Regex.IsMatch(txtPasswd, @"\A(?=[\x20-\x7E]*?[A-Z])(?=[\x20-\x7E]*?[a-z])(?=[\x20-\x7E]*?[0-9])[\x20-\x7E]{6,20}\z", RegexOptions.IgnoreCase | RegexOptions.Singleline);
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return foundMatch;
        }

        /// <summary>
        /// 判断是否是2-10位中文
        /// </summary>
        /// <param name="txtFullName"></param>
        /// <returns></returns>
        public bool isChineseChar(string txtFullName)
        {
            bool foundMatch = false;
            try
            {
                foundMatch = Regex.IsMatch(txtFullName, @"^[\u4e00-\u9fa5]{2,10}", RegexOptions.IgnoreCase | RegexOptions.Singleline);
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return foundMatch;
        }

        /// <summary>
        /// 判断用户名是否是6到20位字母或数字
        /// </summary>
        /// <param name="txtUserName"></param>
        /// <returns></returns>
        public bool isUserNameFair(string txtUserName)
        {
            bool foundMatch = false;
            try
            {
                foundMatch = Regex.IsMatch(txtUserName, @"^(?![0-9]*$)[a-zA-Z0-9]{6,20}$", RegexOptions.IgnoreCase | RegexOptions.Singleline);
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return foundMatch;
        }

        /// <summary>
        /// 判断是否是IP地址
        /// </summary>
        /// <param name="txtIP"></param>
        /// <returns></returns>
        public bool isIP(string txtIP)
        {
            bool foundMatch = false;
            try
            {
                foundMatch = Regex.IsMatch(txtIP, @"d+.d+.d+.d+", RegexOptions.IgnoreCase | RegexOptions.Singleline);
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return foundMatch;
        }

        /// <summary>
        /// 判断是否是电话号码
        /// </summary>
        /// <param name="txtTelePhone"></param>
        /// <returns></returns>
        public bool isTelePhone(string txtTelePhone)
        {
            bool foundMatch = false;
            try
            {
                foundMatch = Regex.IsMatch(txtTelePhone, @"((d{3,4})|d{3,4}-)?d{7,8}(-d{3})*", RegexOptions.IgnoreCase | RegexOptions.Singleline);
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return foundMatch;
        }

        /// <summary>
        /// 判断项目名称是否满足：最长不得超过7个汉字，或14个字节(数字，字母和下划线)正则表达式
        /// </summary>
        /// <param name="txtTelePhone"></param>
        /// <returns></returns>
        public bool isProjectName(string txtTelePhone)
        {
            bool foundMatch = false;
            try
            {
                foundMatch = Regex.IsMatch(txtTelePhone, @"^[\u4e00-\u9fa5]{1,7}$|^[\dA-Za-z_]{1,14}$", RegexOptions.IgnoreCase | RegexOptions.Singleline);
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return foundMatch;
        }

        /// <summary>
        /// 判断项目路径是否正确
        /// </summary>
        /// <param name="txtLocation"></param>
        /// <returns></returns>
        public bool isProjectLocation(string txtLocation)
        {
            bool foundMatch = false;
            try
            {
                foundMatch = Regex.IsMatch(txtLocation, @"[a-zA-Z]\:[\\a-zA-Z0-9_\u4e00-\u9fa5\\]+[\.]?[a-zA-Z0-9_\u4e00-\u9fa5]+|[a-zA-Z]\:\\", RegexOptions.IgnoreCase | RegexOptions.Singleline);
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return foundMatch;
        }

        /// <summary>
        /// 1-20位由字母、数字、汉字组成的字符串
        /// </summary>
        /// <param name="txtStructName"></param>
        /// <returns></returns>
        public bool isStringName(string txtStructName)
        {
            bool foundMatch = false;
            try
            {
                foundMatch = Regex.IsMatch(txtStructName, @"^[0-9a-zA-Z\u4e00-\u9fa5]{1,20}$", RegexOptions.IgnoreCase | RegexOptions.Singleline);
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return foundMatch;
        }

        public string getMatchedChineseStr(string strOriginal)
        {
            string strMatch = "";
            try
            {
                strMatch = Regex.Match(strOriginal, @"^[\u4e00-\u9fa5]{2,10}").Value;
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return strMatch;
        }
    }
}
