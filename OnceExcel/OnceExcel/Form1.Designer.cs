namespace OnceExcel
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
            this.path_text = new System.Windows.Forms.TextBox();
            this.open_btn = new System.Windows.Forms.Button();
            this.gen_btn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.status_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // path_text
            // 
            this.path_text.Location = new System.Drawing.Point(12, 12);
            this.path_text.Name = "path_text";
            this.path_text.Size = new System.Drawing.Size(188, 21);
            this.path_text.TabIndex = 1;
            // 
            // open_btn
            // 
            this.open_btn.Location = new System.Drawing.Point(206, 12);
            this.open_btn.Name = "open_btn";
            this.open_btn.Size = new System.Drawing.Size(75, 23);
            this.open_btn.TabIndex = 2;
            this.open_btn.Text = "选择表格";
            this.open_btn.UseVisualStyleBackColor = true;
            this.open_btn.Click += new System.EventHandler(this.open_btn_Click);
            // 
            // gen_btn
            // 
            this.gen_btn.Enabled = false;
            this.gen_btn.Location = new System.Drawing.Point(12, 39);
            this.gen_btn.Name = "gen_btn";
            this.gen_btn.Size = new System.Drawing.Size(269, 23);
            this.gen_btn.TabIndex = 3;
            this.gen_btn.Text = "生成表格";
            this.gen_btn.UseVisualStyleBackColor = true;
            this.gen_btn.Click += new System.EventHandler(this.gen_btn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(13, 70);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(268, 23);
            this.progressBar.TabIndex = 4;
            // 
            // status_label
            // 
            this.status_label.AutoSize = true;
            this.status_label.Location = new System.Drawing.Point(13, 100);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(0, 12);
            this.status_label.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 123);
            this.Controls.Add(this.status_label);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.gen_btn);
            this.Controls.Add(this.open_btn);
            this.Controls.Add(this.path_text);
            this.Name = "Form1";
            this.Text = "OnceExcel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox path_text;
        private System.Windows.Forms.Button open_btn;
        private System.Windows.Forms.Button gen_btn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label status_label;

    }
}

