using Microsoft.Office.Interop.Excel;
using System;
using System.Windows.Forms;
namespace FixtureProject.utils
{
    public class Excel
    {
        public bool OutToExcelFromDataGridView(string title, DataGridView dgv, bool isShowExcel)
        {
            int titleColumnSpan = 0;//标题的跨列数
            string fileName = "";//保存的excel文件名
            int columnIndex = 1;//列索引
            if (dgv.Rows.Count == 0)
                return false;
            /*保存对话框*/
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel 文件|*.xlsx;*.xls;";
            sfd.FileName = title + DateTime.Now.ToString("yyyyMMddhhmmss");

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                new Sunny.UI.UITitlePage().ShowWaitForm();
                fileName = sfd.FileName;
                /*建立Excel对象*/
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                if (excel == null)
                {
                    MessageBox.Show("无法创建Excel对象,可能您的计算机未安装Excel!");
                    return false;
                }
                try
                {
                    excel.Application.Workbooks.Add(true);
                    excel.Visible = isShowExcel;
                    /*分析标题的跨列数*/
                    foreach (DataGridViewColumn column in dgv.Columns)
                    {

                        if (column.Visible == true)
                            titleColumnSpan++;
                    }
                    /*合并标题单元格*/
                    Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)excel.ActiveSheet;
                    //worksheet.get_Range("A1", "C10").Merge();           
                    worksheet.get_Range(worksheet.Cells[1, 1] as Range, worksheet.Cells[1, titleColumnSpan] as Range).Merge();
                    /*生成标题*/
                    excel.Cells[1, 1] = title;
                    (excel.Cells[1, 1] as Range).HorizontalAlignment = XlHAlign.xlHAlignCenter;//标题居中
                    (excel.Cells[1, 1] as Range).Interior.Color = System.Drawing.Color.FromArgb(255, 204, 153).ToArgb();  //生成字段名称     
                    (excel.Cells[1, 1] as Range).RowHeight = 25;
                    (excel.Cells[1, 1] as Range).Font.Bold = true;
                    (excel.Cells[1, 1] as Range).Font.Size = 18;
                    (excel.Cells[1, 1] as Range).Font.Name = "楷体";
                    (excel.Cells[1, 1] as Range).Borders.LineStyle = XlLineStyle.xlDashDotDot;
                    //Range.Font.Color=clBlue; 

                    columnIndex = 1;
                    for (int i = 0; i < dgv.ColumnCount; i++)
                    {
                        if (dgv.Columns[i].Visible == true && dgv.Columns[i].HeaderText != "删除")
                        {
                            excel.Cells[2, columnIndex] = dgv.Columns[i].HeaderText;
                            (excel.Cells[2, columnIndex] as Range).HorizontalAlignment = XlHAlign.xlHAlignCenter;//字段居中
                            (excel.Cells[2, columnIndex] as Range).Interior.Color = System.Drawing.Color.LightBlue.ToArgb();
                            (excel.Cells[2, columnIndex] as Range).Borders.LineStyle = XlLineStyle.xlContinuous;
                            columnIndex++;
                        }
                    }

                    for (int i = 0; i < dgv.RowCount; i++)
                    {
                        columnIndex = 1;
                        for (int j = 0; j < dgv.ColumnCount; j++)
                        {
                            if (dgv.Columns[j].Visible == true && dgv.Columns[j].HeaderText != "删除")
                            {
                                if (dgv[j, i].ValueType == typeof(string))
                                {
                                    excel.Cells[i + 3, columnIndex] = "'" + dgv[j, i].Value.ToString();
                                }
                                else
                                {
                                    excel.Cells[i + 3, columnIndex] = dgv[j, i].Value.ToString();
                                }
                                (excel.Cells[i + 3, columnIndex] as Range).HorizontalAlignment = XlHAlign.xlHAlignLeft;//字段居中
                                (excel.Cells[i + 3, columnIndex] as Range).Borders.LineStyle = XlLineStyle.xlContinuous;
                                columnIndex++;
                            }
                        }
                    }
                //单元格自适应
                (excel.Cells as Range).EntireColumn.AutoFit();

                    //隐藏进度条  
                    //tempProgressBar.Minimum = 0;
                    worksheet.SaveAs(fileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                    //excel.Quit();
                    //excel = null;
                    //GC.Collect();
                }
                catch { MessageBox.Show("？？？"); }
                finally
                {
                    excel.Quit();
                    excel = null;
                    GC.Collect();
                }

                KillProcess("Excel");
                return true;
            }
            else
            {
                return false;
            }

        }

        private static void KillProcess(string processName)//杀死与Excel相关的进程
        {
            System.Diagnostics.Process myproc = new System.Diagnostics.Process();//得到所有打开的进程
            try
            {
                foreach (System.Diagnostics.Process thisproc in System.Diagnostics.Process.GetProcessesByName(processName))
                {
                    if (!thisproc.CloseMainWindow())
                    {
                        thisproc.Kill();
                    }
                }
            }
            catch (Exception Exc)
            {
                throw new Exception("", Exc);
            }
        }
    }
}
