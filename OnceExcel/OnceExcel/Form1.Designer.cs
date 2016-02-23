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
            this.label_path = new System.Windows.Forms.TextBox();
            this.btn_path = new System.Windows.Forms.Button();
            this.btn_gen = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.start_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.end_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_path
            // 
            this.label_path.Location = new System.Drawing.Point(24, 30);
            this.label_path.Name = "label_path";
            this.label_path.Size = new System.Drawing.Size(298, 21);
            this.label_path.TabIndex = 1;
            // 
            // btn_path
            // 
            this.btn_path.Location = new System.Drawing.Point(328, 30);
            this.btn_path.Name = "btn_path";
            this.btn_path.Size = new System.Drawing.Size(75, 23);
            this.btn_path.TabIndex = 2;
            this.btn_path.Text = "选择表格";
            this.btn_path.UseVisualStyleBackColor = true;
            this.btn_path.Click += new System.EventHandler(this.btn_path_Click);
            // 
            // btn_gen
            // 
            this.btn_gen.Location = new System.Drawing.Point(24, 98);
            this.btn_gen.Name = "btn_gen";
            this.btn_gen.Size = new System.Drawing.Size(379, 46);
            this.btn_gen.TabIndex = 3;
            this.btn_gen.Text = "生成下个月表格";
            this.btn_gen.UseVisualStyleBackColor = true;
            this.btn_gen.Click += new System.EventHandler(this.btn_gen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // start_text
            // 
            this.start_text.Location = new System.Drawing.Point(105, 57);
            this.start_text.Name = "start_text";
            this.start_text.Size = new System.Drawing.Size(102, 21);
            this.start_text.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "至";
            // 
            // end_text
            // 
            this.end_text.Location = new System.Drawing.Point(236, 57);
            this.end_text.Name = "end_text";
            this.end_text.Size = new System.Drawing.Size(100, 21);
            this.end_text.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "电费记录周期";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 156);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.end_text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.start_text);
            this.Controls.Add(this.btn_gen);
            this.Controls.Add(this.btn_path);
            this.Controls.Add(this.label_path);
            this.Name = "Form1";
            this.Text = "OnceExcel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox label_path;
        private System.Windows.Forms.Button btn_path;
        private System.Windows.Forms.Button btn_gen;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox start_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox end_text;
        private System.Windows.Forms.Label label2;
    }
}

