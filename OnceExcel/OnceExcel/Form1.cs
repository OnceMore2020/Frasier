using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Core;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace OnceBatchBg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_path_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.label_path.Text = openFileDialog1.FileName;
                btn_path.Text = "选择成功";
            }
        }

        private void btn_gen_Click(object sender, EventArgs e)
        {
	        ShowPresentation();
	        GC.Collect();
        } 

        private void ShowPresentation()
        {
	        String old_table_filename = this.label_path.Text;
            Excel.Application ExcelApp = new Excel.Application();
            Excel.Workbook workBook = ExcelApp.Workbooks.Open(old_table_filename);
            Excel.Worksheet workSheet = workBook.Sheets["Sheet1"];
            Excel.Range rngSource = workSheet.UsedRange.Columns["G"];
            Excel.Range rngTarget = workSheet.UsedRange.Columns["F"];
            rngTarget.Value = rngSource.Value;
            rngSource.Value = null;

            workSheet.Cells[2, 6] = "起数";
            workSheet.Cells[2, 7] = "止数";

            String header_text = "电费表：" + start_text.Text + " 至 " + end_text.Text;
            Excel.Range rngHeader = workSheet.UsedRange.Range["A1:M1"];
            rngHeader.Merge(true);
            rngHeader.Value = header_text;
           
            ExcelApp.Visible = false;

            String saveas_filename = old_table_filename.Substring(0,old_table_filename.Length-5) + "截至" + end_text.Text + ".xlsx";
            ExcelApp.ActiveWorkbook.SaveAs(Filename: saveas_filename);
            workBook.Close(0);
            ExcelApp.Quit();

            btn_gen.Text = "生成完毕！";         
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
