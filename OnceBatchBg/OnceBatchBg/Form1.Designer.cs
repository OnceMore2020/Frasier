namespace OnceBatchBg
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label_path = new System.Windows.Forms.TextBox();
            this.btn_path = new System.Windows.Forms.Button();
            this.btn_gen = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(78, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Have A Nice Day";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_path
            // 
            this.label_path.Location = new System.Drawing.Point(17, 57);
            this.label_path.Name = "label_path";
            this.label_path.Size = new System.Drawing.Size(296, 20);
            this.label_path.TabIndex = 1;
            // 
            // btn_path
            // 
            this.btn_path.Location = new System.Drawing.Point(319, 57);
            this.btn_path.Name = "btn_path";
            this.btn_path.Size = new System.Drawing.Size(75, 20);
            this.btn_path.TabIndex = 2;
            this.btn_path.Text = "选择路径";
            this.btn_path.UseVisualStyleBackColor = true;
            this.btn_path.Click += new System.EventHandler(this.btn_path_Click);
            // 
            // btn_gen
            // 
            this.btn_gen.Location = new System.Drawing.Point(134, 83);
            this.btn_gen.Name = "btn_gen";
            this.btn_gen.Size = new System.Drawing.Size(122, 28);
            this.btn_gen.TabIndex = 3;
            this.btn_gen.Text = "生成Powerpoint文件";
            this.btn_gen.UseVisualStyleBackColor = true;
            this.btn_gen.Click += new System.EventHandler(this.btn_gen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 118);
            this.Controls.Add(this.btn_gen);
            this.Controls.Add(this.btn_path);
            this.Controls.Add(this.label_path);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "OnceBackground";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox label_path;
        private System.Windows.Forms.Button btn_path;
        private System.Windows.Forms.Button btn_gen;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;

    }
}

