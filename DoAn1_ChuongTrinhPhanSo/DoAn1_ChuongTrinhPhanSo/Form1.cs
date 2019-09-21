using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1_ChuongTrinhPhanSo
{
    public partial class Form1 : Form
    {
        //Khởi tạo lớp tính toán
        private Calculator cal;
        //Chuỗi lưu lại phép toán trước đó
        private string preMath;
        //Phép tính liên tiếp khi người dùng nhấn bằng
        private bool isMulti;
        //Xác nhận phân số thứ 2 được nhập
        private bool isInput;

        public Form1()
        {
            InitializeComponent();
            cal = new Calculator();
            preMath = "+";
            isMulti = false;
            isInput = false;
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            Referesh();
        }

        #region Phương thức tự tạo

        /// <summary>
        /// Phương thức thiết lập lại về tính trạng lúc ban đầu.
        /// </summary>
        public void Referesh()
        {
            //Thiết lập lại các thuộc tính.
            txtNumerator1.Text = txtNumerator2.Text = "0";
            txtDemoinator1.Text = txtDemoinator2.Text = "1";

            txtNumResult.ResetText();
            txtDemoResult.ResetText();

            lbMath.Text = "+";
        }

        private void Call(string lb)
        {
            switch (lb)
            {
                case "+":
                    cal.Add();
                    break;
                case "-":
                    cal.Subtract();
                    break;
                case "x":
                    cal.Multiply();
                    break;
                case "/":
                    cal.Divide();
                    break;
            }
            isInput = false;
            txtNumResult.Text = cal.Result.Numerator.ToString();
            txtDemoResult.Text = cal.Result.Demoinator.ToString();
        }


        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            Referesh();
            tabControl.SelectedIndex = 1;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            preMath = lbMath.Text;
            lbMath.Text = (sender as Button).Text;
            if (isMulti)
            {
                cal.Num1.Coppy(cal.Result);
                txtNumerator1.Text = cal.Num1.Numerator.ToString();
                txtDemoinator1.Text = cal.Num1.Demoinator.ToString();

                if (!isInput)
                {
                    cal.Num2.Reset();
                    txtNumerator2.Text = "0";
                    txtDemoinator2.Text = "1";
                }
                else
                {
                    cal.Num2.Assign(int.Parse(txtNumerator2.Text), int.Parse(txtDemoinator2.Text));
                }

                //cal.Result.Reset();
                //txtTSKQ.Text = "0";
                //txtMSKQ.Text = "1";

                Call(preMath);
            }
        }

        private void BtnSubtract_Click(object sender, EventArgs e)
        {
            preMath = lbMath.Text;
            lbMath.Text = (sender as Button).Text;

            if (isMulti)
            {
                cal.Num1.Coppy(cal.Result);
                txtNumerator1.Text = cal.Num1.Numerator.ToString();
                txtDemoinator1.Text = cal.Num1.Demoinator.ToString();

                if (!isInput)
                {
                    cal.Num2.Reset();
                    txtNumerator2.Text = "0";
                    txtDemoinator2.Text = "1";
                }
                else
                {
                    cal.Num2.Assign(int.Parse(txtNumerator2.Text), int.Parse(txtDemoinator2.Text));
                }

                //cal.Result.Reset();
                //txtTSKQ.Text = "0";
                //txtMSKQ.Text = "1";

                Call(preMath);
            }
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            preMath = lbMath.Text;
            lbMath.Text = (sender as Button).Text;

            if (isMulti)
            {
                cal.Num1.Coppy(cal.Result);
                txtNumerator1.Text = cal.Num1.Numerator.ToString();
                txtDemoinator1.Text = cal.Num1.Demoinator.ToString();

                if (!isInput)
                {
                    cal.Num2.Reset();
                    txtNumerator2.Text = "0";
                    txtDemoinator2.Text = "1";
                    Call("+");
                }
                else
                {
                    cal.Num2.Assign(int.Parse(txtNumerator2.Text), int.Parse(txtDemoinator2.Text));
                    Call(preMath);
                }

                //cal.Result.Reset();
                //txtTSKQ.Text = "0";
                //txtMSKQ.Text = "1";
            }
        }

        private void BtnDiivide_Click(object sender, EventArgs e)
        {
            preMath = lbMath.Text;
            lbMath.Text = (sender as Button).Text;

            if (isMulti)
            {
                cal.Num1.Coppy(cal.Result);
                txtNumerator1.Text = cal.Num1.Numerator.ToString();
                txtDemoinator1.Text = cal.Num1.Demoinator.ToString();

                if (!isInput)
                {
                    cal.Num2.Reset();
                    txtNumerator2.Text = "0";
                    txtDemoinator2.Text = "1";
                    Call("+");
                }
                else
                {
                    cal.Num2.Assign(int.Parse(txtNumerator2.Text), int.Parse(txtDemoinator2.Text));
                    Call(preMath);
                }

                //cal.Result.Reset();
                //txtTSKQ.Text = "0";
                //txtMSKQ.Text = "1";
            }
        }

        private void BtnResult_Click(object sender, EventArgs e)
        {
            preMath = lbMath.Text;
            cal.Num1.Assign(int.Parse(txtNumerator1.Text), int.Parse(txtDemoinator1.Text));
            cal.Num2.Assign(int.Parse(txtNumerator2.Text), int.Parse(txtDemoinator2.Text));
            Call(lbMath.Text);
            isMulti = true;
        }

        private void TxtTS2_TextChanged(object sender, EventArgs e)
        {
            isInput = true;
        }
    }
}
