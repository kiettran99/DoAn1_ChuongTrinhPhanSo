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
            this.txtDemoResult = new System.Windows.Forms.TextBox();
            this.txtNumResult = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDemoinator2 = new System.Windows.Forms.TextBox();
            this.txtNumerator2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDemoinator1 = new System.Windows.Forms.TextBox();
            this.txtNumerator1 = new System.Windows.Forms.TextBox();
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
            this.groupBox3.Controls.Add(this.txtDemoResult);
            this.groupBox3.Controls.Add(this.txtNumResult);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(393, 79);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(85, 145);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // txtDemoResult
            // 
            this.txtDemoResult.Location = new System.Drawing.Point(7, 89);
            this.txtDemoResult.Name = "txtDemoResult";
            this.txtDemoResult.Size = new System.Drawing.Size(70, 35);
            this.txtDemoResult.TabIndex = 3;
            this.txtDemoResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNumResult
            // 
            this.txtNumResult.Location = new System.Drawing.Point(7, 27);
            this.txtNumResult.Name = "txtNumResult";
            this.txtNumResult.Size = new System.Drawing.Size(70, 35);
            this.txtNumResult.TabIndex = 2;
            this.txtNumResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDemoinator2);
            this.groupBox2.Controls.Add(this.txtNumerator2);
            this.groupBox2.Location = new System.Drawing.Point(211, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(85, 145);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // txtDemoinator2
            // 
            this.txtDemoinator2.Location = new System.Drawing.Point(7, 89);
            this.txtDemoinator2.Name = "txtDemoinator2";
            this.txtDemoinator2.Size = new System.Drawing.Size(70, 35);
            this.txtDemoinator2.TabIndex = 4;
            this.txtDemoinator2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDemoinator2.TextChanged += new System.EventHandler(this.TxtTS2_TextChanged);
            // 
            // txtNumerator2
            // 
            this.txtNumerator2.Location = new System.Drawing.Point(7, 27);
            this.txtNumerator2.Name = "txtNumerator2";
            this.txtNumerator2.Size = new System.Drawing.Size(70, 35);
            this.txtNumerator2.TabIndex = 3;
            this.txtNumerator2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumerator2.TextChanged += new System.EventHandler(this.TxtTS2_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDemoinator1);
            this.groupBox1.Controls.Add(this.txtNumerator1);
            this.groupBox1.Location = new System.Drawing.Point(38, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(85, 145);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtDemoinator1
            // 
            this.txtDemoinator1.Location = new System.Drawing.Point(7, 89);
            this.txtDemoinator1.Name = "txtDemoinator1";
            this.txtDemoinator1.Size = new System.Drawing.Size(70, 35);
            this.txtDemoinator1.TabIndex = 2;
            this.txtDemoinator1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNumerator1
            // 
            this.txtNumerator1.Location = new System.Drawing.Point(7, 27);
            this.txtNumerator1.Name = "txtNumerator1";
            this.txtNumerator1.Size = new System.Drawing.Size(70, 35);
            this.txtNumerator1.TabIndex = 1;
            this.txtNumerator1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
        private System.Windows.Forms.TextBox txtDemoinator1;
        private System.Windows.Forms.TextBox txtNumerator1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDemoResult;
        private System.Windows.Forms.TextBox txtNumResult;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDemoinator2;
        private System.Windows.Forms.TextBox txtNumerator2;
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

