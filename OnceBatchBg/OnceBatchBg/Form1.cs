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
using PowerPoint = Microsoft.Office.Interop.PowerPoint;
using Graph = Microsoft.Office.Interop.Graph;
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
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.label_path.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btn_gen_Click(object sender, EventArgs e)
        {
	        ShowPresentation();
	        GC.Collect();
        } 

        private void ShowPresentation()
        {
	        String strPic;
            strPic = this.label_path.Text;
            DirectoryInfo pic_path = new DirectoryInfo(strPic);

            PowerPoint.Application objApp;
            PowerPoint.Slides objSlides;
            PowerPoint.Presentations objPresSet;
            PowerPoint._Presentation objPres;
            PowerPoint._Slide objSlide;
            objApp = new PowerPoint.Application();
            objApp.Visible = MsoTriState.msoTrue;
            objPresSet = objApp.Presentations;

            objPres = objPresSet.Add();
            objSlides = objPres.Slides;
            
            FileInfo[] pic_files = pic_path.GetFiles();
            foreach (FileInfo NextFile in pic_files)    //遍历文件
            {
                string file_name = NextFile.Name.ToLower();
                if (file_name.EndsWith(".jpg") || file_name.EndsWith(".jpeg") || file_name.EndsWith(".png") || file_name.EndsWith(".tiff"))
                {
                    objSlide = objSlides.Add(1, PowerPoint.PpSlideLayout.ppLayoutBlank);
                    objSlide.FollowMasterBackground = MsoTriState.msoFalse;
                    objSlide.Background.Fill.UserPicture(NextFile.FullName);
                }
            }
        }
    }
}
