namespace DoAn1_ChuongTrinhPhanSo
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lbMath = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnDiivide = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtMSKQ = new System.Windows.Forms.TextBox();
            this.txtTSKQ = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMS2 = new System.Windows.Forms.TextBox();
            this.txtTS2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMS1 = new System.Windows.Forms.TextBox();
            this.txtTS1 = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(-5, -1);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(799, 398);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(791, 356);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Giới Thiệu";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnRefresh);
            this.tabPage2.Controls.Add(this.lbMath);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(791, 356);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Phép Tính Cơ Bản";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(93, 269);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(322, 50);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // lbMath
            // 
            this.lbMath.AutoSize = true;
            this.lbMath.Location = new System.Drawing.Point(154, 138);
            this.lbMath.Name = "lbMath";
            this.lbMath.Size = new System.Drawing.Size(27, 29);
            this.lbMath.TabIndex = 5;
            this.lbMath.Text = "+";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "=";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnResult);
            this.groupBox4.Controls.Add(this.btnDiivide);
            this.groupBox4.Controls.Add(this.btnMultiply);
            this.groupBox4.Controls.Add(this.btnSubtract);
            this.groupBox4.Controls.Add(this.btnAdd);
            this.groupBox4.Location = new System.Drawing.Point(508, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(266, 352);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Phép toán";
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(7, 265);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(259, 61);
            this.btnResult.TabIndex = 4;
            this.btnResult.Text = "=";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.BtnResult_Click);
            // 
            // btnDiivide
            // 
            this.btnDiivide.Location = new System.Drawing.Point(149, 158);
            this.btnDiivide.Name = "btnDiivide";
            this.btnDiivide.Size = new System.Drawing.Size(111, 87);
            this.btnDiivide.TabIndex = 3;
            this.btnDiivide.Text = "/";
            this.btnDiivide.UseVisualStyleBackColor = true;
            this.btnDiivide.Click += new System.EventHandler(this.BtnDiivide_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(7, 158);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(111, 87);
            this.btnMultiply.TabIndex = 2;
            this.btnMultiply.Text = "x";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.BtnMultiply_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Location = new System.Drawing.Point(149, 54);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(111, 87);
            this.btnSubtract.TabIndex = 1;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.BtnSubtract_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(7, 55);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(111, 87);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtMSKQ);
            this.groupBox3.Controls.Add(this.txtTSKQ);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(393, 79);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(85, 145);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // txtMSKQ
            // 
            this.txtMSKQ.Location = new System.Drawing.Point(7, 89);
            this.txtMSKQ.Name = "txtMSKQ";
            this.txtMSKQ.Size = new System.Drawing.Size(70, 35);
            this.txtMSKQ.TabIndex = 3;
            this.txtMSKQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTSKQ
            // 
            this.txtTSKQ.Location = new System.Drawing.Point(7, 27);
            this.txtTSKQ.Name = "txtTSKQ";
            this.txtTSKQ.Size = new System.Drawing.Size(70, 35);
            this.txtTSKQ.TabIndex = 2;
            this.txtTSKQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMS2);
            this.groupBox2.Controls.Add(this.txtTS2);
            this.groupBox2.Location = new System.Drawing.Point(211, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(85, 145);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // txtMS2
            // 
            this.txtMS2.Location = new System.Drawing.Point(7, 89);
            this.txtMS2.Name = "txtMS2";
            this.txtMS2.Size = new System.Drawing.Size(70, 35);
            this.txtMS2.TabIndex = 4;
            this.txtMS2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMS2.TextChanged += new System.EventHandler(this.TxtTS2_TextChanged);
            // 
            // txtTS2
            // 
            this.txtTS2.Location = new System.Drawing.Point(7, 27);
            this.txtTS2.Name = "txtTS2";
            this.txtTS2.Size = new System.Drawing.Size(70, 35);
            this.txtTS2.TabIndex = 3;
            this.txtTS2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTS2.TextChanged += new System.EventHandler(this.TxtTS2_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMS1);
            this.groupBox1.Controls.Add(this.txtTS1);
            this.groupBox1.Location = new System.Drawing.Point(38, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(85, 145);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtMS1
            // 
            this.txtMS1.Location = new System.Drawing.Point(7, 89);
            this.txtMS1.Name = "txtMS1";
            this.txtMS1.Size = new System.Drawing.Size(70, 35);
            this.txtMS1.TabIndex = 2;
            this.txtMS1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTS1
            // 
            this.txtTS1.Location = new System.Drawing.Point(7, 27);
            this.txtTS1.Name = "txtTS1";
            this.txtTS1.Size = new System.Drawing.Size(70, 35);
            this.txtTS1.TabIndex = 1;
            this.txtTS1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(790, 396);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chương trình tính phân số";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMS1;
        private System.Windows.Forms.TextBox txtTS1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtMSKQ;
        private System.Windows.Forms.TextBox txtTSKQ;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMS2;
        private System.Windows.Forms.TextBox txtTS2;
        private System.Windows.Forms.Label lbMath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnDiivide;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRefresh;
    }
}

