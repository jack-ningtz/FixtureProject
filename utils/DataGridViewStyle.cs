using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace FixtureProject.utils
{
    class DataGridViewStyle
    {
        public DataGridViewStyle() { }
        public void ChangeStyle(DataGridView dataGridView)
        {
            // 表格上下左右自适应
            dataGridView.Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left);
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.ReadOnly = true;
            // 列手工排序
            dataGridView.AllowUserToOrderColumns = true;
            // 列头系统样式，设置为false，自定义才生效
            dataGridView.EnableHeadersVisualStyles = false;
            // 列头高度大小模式
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            // 列头高度大小
            dataGridView.ColumnHeadersHeight = 30;
            // 列头居中
            dataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("微软雅黑", 10, FontStyle.Bold);
            // 列头边框样式
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            // 列头背景色
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#0099FF");
            // 列头前景色
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#fff");
            // 列宽自适应
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            // 网格线颜色
            dataGridView.GridColor = ColorTranslator.FromHtml("#006CB3");
            // 背景色
            dataGridView.BackgroundColor = ColorTranslator.FromHtml("#E7F5FF");
            // 行头边框样式
            dataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            // 行头背景色
            dataGridView.RowHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#0099FF");
            // 行高（要在窗体初始化的地方InitializeComponent调用才生效）
            dataGridView.RowTemplate.Height = 30;
            // 单元格内容居中
            dataGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // 单元格背景色
            dataGridView.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#97D5FF");
            // 隔行背景色
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#E1F3FF");
        }
    }
}
