using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestExerciser.Logic
{
    class ListItem : System.Object
    {
        private string _Value = string.Empty;
        private string _Text = string.Empty;

        /// <summary>
        /// 值
        /// </summary>
        public string Value
        {
            get { return this._Value; }

            set { this._Value = value; }
        }
        /// <summary>
        /// 显示的文本
        /// </summary>
        public string Text
        {
            get { return this._Text; }

            set { this._Text = value; }
        }

        public ListItem(string value, string text)
        {
            this._Value = value;
            this._Text = text;
        }
        public override string ToString()
        {
            return this._Text;
        }

    }
}
