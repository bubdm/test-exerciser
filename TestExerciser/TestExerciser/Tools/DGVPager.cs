using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestExerciser.Tools
{
    public partial class DGVPager : UserControl
    {
        public DGVPager()
        {
            InitializeComponent();
        }

        #region 分页字段和属性

        private int pageIndex = 1;
        /// <summary>
        /// 当前页数
        /// </summary>
        public virtual int PageIndex
        {
            get { return pageIndex; }
            set { pageIndex = value; }
        }

        private int pageSize = 20;
        /// <summary>
        /// 每页记录数
        /// </summary>
        public virtual int PageSize
        {
            get { return pageSize; }
            set { pageSize = value; }
        }

        private int recordCount = 0;
        /// <summary>
        /// 总记录数
        /// </summary>
        public virtual int RecordCount
        {
            get { return recordCount; }
            set { recordCount = value; }
        }

        private int pageCount = 0;
        /// <summary>
        /// 总页数
        /// </summary>
        public int PageCount
        {
            get
            {
                if (pageSize != 0)
                {
                    pageCount = GetPageCount();
                }
                return pageCount;
            }
        }

        #endregion

        #region 页码变化时触发事件

        public event EventHandler OnPageChanged;

        #endregion

        #region 分页及相关事件功能实现

        /// <summary>
        /// 设窗体控件全部可用
        /// </summary>
        private void SetFormCtrEnabled()
        {
            linkFirst.Enabled = true;
            linkPrevious.Enabled = true;
            linkNext.Enabled = true;
            linkLast.Enabled = true;
            btnGo.Enabled = true;
        }

        /// <summary>
        /// 计算总页数
        /// </summary>
        /// <returns></returns>
        private int GetPageCount()
        {
            if (PageSize == 0)
            {
                return 0;
            }
            int pageCount = RecordCount / PageSize;
            if (RecordCount % PageSize == 0)
            {
                pageCount = RecordCount / PageSize;
            }
            else
            {
                pageCount = RecordCount / PageSize + 1;
            }
            return pageCount;
        }
        /// <summary>
        /// 用于客户端调用
        /// </summary>
        public void DrawControl(int count)
        {
            recordCount = count;
            DrawControl(false);
        }
        /// <summary>
        /// 根据不同的条件，改变页面控件的呈现状态
        /// </summary>
        private void DrawControl(bool callEvent)
        {

            lblCurrentPage.Text = PageIndex.ToString();
            lblPageCount.Text = PageCount.ToString();
            lblTotalCount.Text = RecordCount.ToString();

            if (callEvent && OnPageChanged != null)
            {
                OnPageChanged(this, null);//当前分页数字改变时，触发委托事件
            }
            SetFormCtrEnabled();
            if (PageCount == 1 || PageCount == 0)//有且仅有一页时
            {
                linkFirst.Enabled = false;
                linkPrevious.Enabled = false;
                linkNext.Enabled = false;
                linkLast.Enabled = false;
                btnGo.Enabled = false;
            }
            else if (PageIndex == 1)//当前页为第一页时
            {
                linkFirst.Enabled = false;
                linkPrevious.Enabled = false;
            }
            else if (PageIndex == PageCount)//当前页为最后一页时
            {
                linkNext.Enabled = false;
                linkLast.Enabled = false;
            }
        }

        #endregion

        #region 相关控件事件

        //首页按钮
        private void linkFirst_Click(object sender, EventArgs e)
        {
            PageIndex = 1;
            DrawControl(true);
        }

        //上一页按钮
        private void linkPrevious_Click(object sender, EventArgs e)
        {
            PageIndex = Math.Max(1, PageIndex - 1);
            DrawControl(true);
        }

        //下一页按钮
        private void linkNext_Click(object sender, EventArgs e)
        {
            PageIndex = Math.Min(PageCount, PageIndex + 1);
            DrawControl(true);
        }

        //尾页按钮
        private void linkLast_Click(object sender, EventArgs e)
        {
            PageIndex = PageCount;
            DrawControl(true);
        }

        /// <summary>
        /// 按下enter键，执行跳转页面功能
        /// </summary>
        private void txtPageNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            btnGo_Click(null, null);
        }

        /// <summary>
        /// 跳转页数限制
        /// </summary>
        private void txtPageNum_TextChanged(object sender, EventArgs e)
        {
            int num = 0;
            if (int.TryParse(txtPageNum.Text.Trim(), out num) && num > 0)
            {   //TryParse 函数，将字符串转换成等效的整数，返回bool型，判断是否转换成功。
                //输入除数字以外的字符是转换不成功的

                if (num > PageCount)   //输入数量大于最大页数时，文本框自动显示最大页数
                {
                    txtPageNum.Text = PageCount.ToString();
                }
            }
        }

        /// <summary>
        /// 跳转按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGo_Click(object sender, EventArgs e)
        {
            int num = 0;
            if (int.TryParse(txtPageNum.Text.Trim(), out num) && num > 0)
            {
                PageIndex = num;
                DrawControl(true);
            }
        }

        #endregion

        bool isTextChanged = false;

        /// <summary>
        /// 光标离开 每页设置文本框时，显示到首页
        private void txtPageSize_Leave(object sender, EventArgs e)
        {
            if (isTextChanged)
            {
                isTextChanged = false;
                linkFirst_Click(null, null);
            }
        }

        private void DGVPager_Load(object sender, EventArgs e)
        {

        }
    }
}
