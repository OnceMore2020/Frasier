using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Core;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace OnceExcel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void open_btn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path_text.Text = openFileDialog1.FileName;
                open_btn.Text = "选择成功";
                gen_btn.Enabled = true;
            }
        }

        private void gen_btn_Click(object sender, EventArgs e)
        {
            String input_filename = this.path_text.Text;
            Excel.Application ExcelApp = new Excel.Application();
            ExcelApp.Visible = false;
            Excel.Workbook workBook = ExcelApp.Workbooks.Open(input_filename);
            Excel.Worksheet workSheet = workBook.Sheets["Sheet1"];

            int code_index = 0;
            int name_index = 0;
            int num_index = 0 ;
            int mkv_index = 0;
            int cp_index = 0;

            // Indexing of columns
            for (int col_index = 1; ; ++col_index)
            {
                if (workSheet.Cells[1, col_index].Value == null)
                    break;
                if (workSheet.Cells[1, col_index].Value == "代码")
                {
                    code_index = col_index;
                    //Console.WriteLine(code_index);
                }
                else if (workSheet.Cells[1, col_index].Value == "名称")
                {
                    name_index = col_index;
                    //Console.WriteLine(name_index);
                }
                else if (workSheet.Cells[1, col_index].Value == "变动数量(万股)")
                {
                    num_index = col_index;
                    //Console.WriteLine(num_index);
                }
                else if (workSheet.Cells[1, col_index].Value == "变动部分参考市值(万元)")
                {
                    mkv_index = col_index;
                    //Console.WriteLine(mkv_index);
                }
                else if (workSheet.Cells[1, col_index].Value == "复权系数")
                {
                    cp_index = col_index;
                    //Console.WriteLine(cp_index);
                }
            }

            // Build a hash-table of codes and corresponding names and row indices
            Dictionary<String, KeyValuePair<String, List<int>>> code_map = new Dictionary<String, KeyValuePair<String, List<int>>>();
            status_label.Text = "解析表格...";
            progressBar.Minimum = 1;
            progressBar.Maximum = 200;
            for (int row_index = 2; ; ++row_index)
            {
                progressBar.Value = row_index % 200;
                if (workSheet.Cells[row_index, code_index].Value == null)
                    break;
                String crt_code = workSheet.Cells[row_index, code_index].Value;
                if (code_map.ContainsKey(crt_code))
                {
                    code_map[crt_code].Value.Add(row_index);
                }
                else
                {
                    code_map[crt_code] = new KeyValuePair<String, List<int>>(workSheet.Cells[row_index, name_index].Value,
                                                                             new List<int>());
                    code_map[crt_code].Value.Add(row_index);
                }
            }

            // Processing
            progressBar.Maximum = code_map.Count;
            int pbar_flag = 1;
            Dictionary<String, KeyValuePair<String, float>> result_map = new Dictionary<String, KeyValuePair<String, float>>();
            foreach (KeyValuePair<String, KeyValuePair<String, List<int>>> pair in code_map)
            {
                status_label.Text = "处理(" + pair.Value.Key + "-" + pair.Key + ")...";
                float crt_denominator = 0;
                float crt_numerator = 0;
                foreach (int row_index in pair.Value.Value)
                {
                    if (workSheet.Cells[row_index, mkv_index].Value!=null)
                        crt_numerator += workSheet.Cells[row_index, mkv_index].Value;
                    if ((workSheet.Cells[row_index, num_index].Value!=null) && (workSheet.Cells[row_index, cp_index].Value!=null))
                        crt_denominator += workSheet.Cells[row_index, num_index].Value * workSheet.Cells[row_index, cp_index].Value;
                }
                result_map[pair.Key] = new KeyValuePair<String, float>(pair.Value.Key, crt_numerator / crt_denominator);
                progressBar.Value = pbar_flag++;
            }

            status_label.Text = "生成表格...";
            progressBar.Maximum = result_map.Count;
            // Output
            Excel.Workbook output_workBook = ExcelApp.Workbooks.Add();
            Excel.Worksheet output_workSheet = output_workBook.Sheets["Sheet1"];
            output_workSheet.Cells[1, 1].Value = "代码";
            output_workSheet.Cells[1, 2].Value = "名称";
            output_workSheet.Cells[1, 3].Value = "等效价格";
            int output_index = 1;
            foreach (KeyValuePair<String, KeyValuePair<String, float>> pair in result_map)
            {
                progressBar.Value = output_index++;
                output_workSheet.Cells[output_index, 1].Value = pair.Key;
                output_workSheet.Cells[output_index, 2].Value = pair.Value.Key;
                output_workSheet.Cells[output_index, 3].Value = pair.Value.Value;
            }

            String saveas_filename = input_filename.Substring(0, input_filename.Length - 5) + "-等效价格表.xlsx";
            output_workBook.SaveAs(Filename: saveas_filename);
            workBook.Close(0);
            output_workBook.Close(0);
            ExcelApp.Quit();

            gen_btn.Enabled = false;
            status_label.Text = "保存成功！";
            path_text.Text = "";
            open_btn.Text = "选择表格";
        }
    }
}
