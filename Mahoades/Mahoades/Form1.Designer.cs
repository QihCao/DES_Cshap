namespace Mahoades
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_file = new System.Windows.Forms.Button();
            this.btn_s1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_K = new System.Windows.Forms.TextBox();
            this.txt_br = new System.Windows.Forms.TextBox();
            this.txt_mh = new System.Windows.Forms.TextBox();
            this.txt_gm = new System.Windows.Forms.TextBox();
            this.btn_mh = new System.Windows.Forms.Button();
            this.btn_gm = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_s2 = new System.Windows.Forms.Button();
            this.txt_file = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_time = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_file
            // 
            this.btn_file.Location = new System.Drawing.Point(497, 156);
            this.btn_file.Name = "btn_file";
            this.btn_file.Size = new System.Drawing.Size(94, 29);
            this.btn_file.TabIndex = 0;
            this.btn_file.Text = "File";
            this.btn_file.UseVisualStyleBackColor = true;
            this.btn_file.Click += new System.EventHandler(this.btn_file_Click);
            // 
            // btn_s1
            // 
            this.btn_s1.Location = new System.Drawing.Point(497, 221);
            this.btn_s1.Name = "btn_s1";
            this.btn_s1.Size = new System.Drawing.Size(94, 29);
            this.btn_s1.TabIndex = 1;
            this.btn_s1.Text = "Lưu";
            this.btn_s1.UseVisualStyleBackColor = true;
            this.btn_s1.Click += new System.EventHandler(this.btn_s1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Khóa K";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bản rõ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã hóa";
            // 
            // txt_K
            // 
            this.txt_K.Location = new System.Drawing.Point(165, 40);
            this.txt_K.Name = "txt_K";
            this.txt_K.Size = new System.Drawing.Size(271, 27);
            this.txt_K.TabIndex = 5;
            // 
            // txt_br
            // 
            this.txt_br.Location = new System.Drawing.Point(166, 95);
            this.txt_br.Multiline = true;
            this.txt_br.Name = "txt_br";
            this.txt_br.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_br.Size = new System.Drawing.Size(271, 44);
            this.txt_br.TabIndex = 6;
            // 
            // txt_mh
            // 
            this.txt_mh.Location = new System.Drawing.Point(165, 220);
            this.txt_mh.Multiline = true;
            this.txt_mh.Name = "txt_mh";
            this.txt_mh.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_mh.Size = new System.Drawing.Size(271, 49);
            this.txt_mh.TabIndex = 7;
            // 
            // txt_gm
            // 
            this.txt_gm.Location = new System.Drawing.Point(165, 295);
            this.txt_gm.Multiline = true;
            this.txt_gm.Name = "txt_gm";
            this.txt_gm.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_gm.Size = new System.Drawing.Size(271, 54);
            this.txt_gm.TabIndex = 8;
            // 
            // btn_mh
            // 
            this.btn_mh.Location = new System.Drawing.Point(118, 425);
            this.btn_mh.Name = "btn_mh";
            this.btn_mh.Size = new System.Drawing.Size(94, 29);
            this.btn_mh.TabIndex = 9;
            this.btn_mh.Text = "Mã hóa";
            this.btn_mh.UseVisualStyleBackColor = true;
            this.btn_mh.Click += new System.EventHandler(this.btn_mh_Click);
            // 
            // btn_gm
            // 
            this.btn_gm.Location = new System.Drawing.Point(343, 425);
            this.btn_gm.Name = "btn_gm";
            this.btn_gm.Size = new System.Drawing.Size(94, 29);
            this.btn_gm.TabIndex = 10;
            this.btn_gm.Text = "Giải mã";
            this.btn_gm.UseVisualStyleBackColor = true;
            this.btn_gm.Click += new System.EventHandler(this.btn_gm_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Giải mã";
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(240, 471);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(86, 31);
            this.btn_xoa.TabIndex = 12;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_s2
            // 
            this.btn_s2.Location = new System.Drawing.Point(497, 295);
            this.btn_s2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_s2.Name = "btn_s2";
            this.btn_s2.Size = new System.Drawing.Size(86, 31);
            this.btn_s2.TabIndex = 13;
            this.btn_s2.Text = "Lưu";
            this.btn_s2.UseVisualStyleBackColor = true;
            this.btn_s2.Click += new System.EventHandler(this.btn_s2_Click);
            // 
            // txt_file
            // 
            this.txt_file.Location = new System.Drawing.Point(240, 155);
            this.txt_file.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_file.Name = "txt_file";
            this.txt_file.Size = new System.Drawing.Size(196, 27);
            this.txt_file.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Thời gian";
            // 
            // lb_time
            // 
            this.lb_time.AutoSize = true;
            this.lb_time.Location = new System.Drawing.Point(168, 364);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(17, 20);
            this.lb_time.TabIndex = 16;
            this.lb_time.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 532);
            this.Controls.Add(this.lb_time);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_file);
            this.Controls.Add(this.btn_s2);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_gm);
            this.Controls.Add(this.btn_mh);
            this.Controls.Add(this.txt_gm);
            this.Controls.Add(this.txt_mh);
            this.Controls.Add(this.txt_br);
            this.Controls.Add(this.txt_K);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_s1);
            this.Controls.Add(this.btn_file);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_file;
        private Button btn_s1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_K;
        private TextBox txt_br;
        private TextBox txt_mh;
        private TextBox txt_gm;
        private Button btn_mh;
        private Button btn_gm;
        private Label label4;
        private Button btn_xoa;
        private Button btn_s2;
        private TextBox txt_file;
        private Label label5;
        private Label lb_time;
    }
}