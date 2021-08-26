using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestExerciser.Logic
{
    class DataGridViewRender
    {
        //目标DataGridView
        private CCWin.SkinControl.SkinDataGridView dataGridView;
        //需要自定义绘制的列
        private DataGridViewColumn hiddenColumn;
        //记录上一次选择的行，用于行索引改变时重绘该行而不是重绘整个控件画面
        private int preRowIndex = 0;
        //小图标
        private Bitmap icon1;
        //private Bitmap icon2;

        public DataGridViewRender(CCWin.SkinControl.SkinDataGridView dataGridView, DataGridViewColumn hiddenColumn = null)
        {
            this.dataGridView = dataGridView;
            this.hiddenColumn = hiddenColumn;
            SetupControl();
        }
        /// <summary>
        /// 设置控件属性
        /// </summary>
        private void SetupControl()
        {
            if (dataGridView == null) return;
            if (hiddenColumn != null)
            {
                hiddenColumn.Visible = false;
            }

            //绑定一些事件实现自定义行绘制
            dataGridView.ColumnWidthChanged += new
                DataGridViewColumnEventHandler(dgvCaseManager_ColumnWidthChanged);
            dataGridView.RowHeightChanged += new
                DataGridViewRowEventHandler(dgvCaseManager_RowHeightChanged);
            dataGridView.CurrentCellChanged += new
                EventHandler(dgvCaseManager_CurrentCellChanged);
            dataGridView.RowPostPaint += new
                DataGridViewRowPostPaintEventHandler(dgvCaseManager_RowPostPaint);

            //初始化小图标，这里在资源列表获取
            icon1 = Properties.Resources._2;
            //icon2 = Properties.Resources._0;
        }

        /// <summary>
        /// 列宽度改变时使控件整个画面无效并导致重绘
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvCaseManager_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            dataGridView.Invalidate();
        }

        /// <summary>
        /// 列高度改变时调整行内边距大小
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvCaseManager_RowHeightChanged(object sender, DataGridViewRowEventArgs e)
        {
            int preHeight = e.Row.GetPreferredHeight(
                e.Row.Index, DataGridViewAutoSizeRowMode.AllCellsExceptHeader, true) -
                e.Row.DefaultCellStyle.Padding.Bottom;
            Padding newPadding = e.Row.DefaultCellStyle.Padding;
            newPadding.Bottom = e.Row.Height - preHeight;
            e.Row.DefaultCellStyle.Padding = newPadding;
        }

        /// <summary>
        /// 重绘前一个选择的行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvCaseManager_CurrentCellChanged(object sender, EventArgs e)
        {
            if (preRowIndex != -1)
            {
                dataGridView.InvalidateRow(preRowIndex);
            }
            preRowIndex = dataGridView.CurrentCellAddress.Y;
        }

        /// <summary>
        /// 处理绘制行内容
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvCaseManager_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Rectangle rowBounds = new Rectangle(0, e.RowBounds.Top,
               dataGridView.Columns.GetColumnsWidth(DataGridViewElementStates.Visible) -
               dataGridView.HorizontalScrollingOffset + 1, e.RowBounds.Height);

            SolidBrush brush = null;
            try
            {
                if ((e.State & DataGridViewElementStates.Selected) == DataGridViewElementStates.Selected)
                    brush = new SolidBrush(e.InheritedRowStyle.SelectionForeColor);
                else
                    brush = new SolidBrush(e.InheritedRowStyle.ForeColor);

                //获取隐藏列的值
                object hiddenObj = dataGridView.Rows[e.RowIndex].Cells[hiddenColumn.Name].Value;
                if (hiddenObj != null)
                {
                    String text = hiddenObj.ToString();
                    //设定内容边界
                    Rectangle textBounds = rowBounds;
                    textBounds.X -= dataGridView.HorizontalScrollingOffset;
                    textBounds.Width += dataGridView.HorizontalScrollingOffset;

                    textBounds.Y += rowBounds.Height - e.InheritedRowStyle.Padding.Bottom;
                    textBounds.Height -= rowBounds.Height - e.InheritedRowStyle.Padding.Bottom;
                    textBounds.Height = (textBounds.Height / e.InheritedRowStyle.Font.Height) *
                        e.InheritedRowStyle.Font.Height;



                    RectangleF oldClip = e.Graphics.ClipBounds;
                    e.Graphics.SetClip(textBounds);
                    //画图标
                    e.Graphics.DrawImage(icon1, new Rectangle(textBounds.X + 5, textBounds.Y, icon1.Width, icon1.Height));
                    //e.Graphics.DrawImage(icon2, new Rectangle(textBounds.X + icon1.Width + 10, textBounds.Y, icon2.Width, icon2.Height));
                    textBounds.X += icon1.Width * 1 + 15;
                    textBounds.Y += 2;
                    //画文字
                    e.Graphics.DrawString(
                        text, e.InheritedRowStyle.Font, brush, textBounds);

                    e.Graphics.SetClip(oldClip);
                }
            }
            finally
            {
                brush.Dispose();
            }
        }
    }
}
