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
            cal.Num1.Reset();
            cal.Num2.Reset();
            cal.Result.Reset();

            //Thiết lập lại các thuộc tính.
            txtNumerator1.Text = txtNumerator2.Text = "0";
            txtDemoinator1.Text = txtDemoinator2.Text = "1";

            txtNumResult.ResetText();
            txtDemoResult.ResetText();

            lbMath.Text = "+";

            preMath = "+";
            isMulti = false;
            isInput = false;
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
            try
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
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSubtract_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDiivide_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnResult_Click(object sender, EventArgs e)
        {
            try
            {
                preMath = lbMath.Text;
                cal.Num1.Assign(int.Parse(txtNumerator1.Text), int.Parse(txtDemoinator1.Text));
                cal.Num2.Assign(int.Parse(txtNumerator2.Text), int.Parse(txtDemoinator2.Text));
                Call(lbMath.Text);
                isMulti = true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtTS2_TextChanged(object sender, EventArgs e)
        {
            isInput = true;
        }

        private void TextMinimalism_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!numMini.Text.Equals("") && !demoMini.Text.Equals("") && !wholeMini.Text.Equals(""))
                {
                    int num = Convert.ToInt32(numMini.Text);
                    int demo = Convert.ToInt32(demoMini.Text);
                    int whole = Convert.ToInt32(wholeMini.Text);

                    MixedFraction mixed = new MixedFraction(num, demo, whole);

                    mixed.Minimalism();

                    numRsMini.Text = mixed.Numerator.ToString();
                    demoRsMini.Text = mixed.Demoinator.ToString();
                }
                else
                {
                    if (!numMini.Text.Equals("") && !demoMini.Text.Equals(""))
                    {
                        int num = Convert.ToInt32(numMini.Text);
                        int demo = Convert.ToInt32(demoMini.Text);

                        Fraction fraction = new Fraction(num, demo);
                        fraction.Minimalism();

                        numRsMini.Text = fraction.Numerator.ToString();
                        demoRsMini.Text = fraction.Demoinator.ToString();
                    }
                    else
                    {
                        numRsMini.ResetText();
                        demoRsMini.ResetText();
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                resultChangeNum.ResetText();
            }
        }

        private void TextNumber_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!numChangeNum.Text.Equals("") && !demoChangeNum.Text.Equals(""))
                {
                    int num = Convert.ToInt32(numChangeNum.Text);
                    int demo = Convert.ToInt32(demoChangeNum.Text);

                    Fraction fraction = new Fraction(num, demo);
                    fraction.Minimalism();

                    resultChangeNum.Text = ((float)fraction.Numerator / fraction.Demoinator).ToString();

                }
                else
                {
                    resultChangeNum.ResetText();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                resultChangeNum.ResetText();
            }
        }

        private void TextCompare_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!numCompare1.Text.Equals("") && !demoCompare1.Text.Equals("") && !wholeCompare1.Text.Equals("")
                        && !numCompare2.Text.Equals("") && !demoCompare2.Text.Equals("") && !wholeCompare2.Text.Equals(""))
                {
                    int num1 = Convert.ToInt32(numCompare1.Text);
                    int demo1 = Convert.ToInt32(demoCompare1.Text);
                    int whole1 = Convert.ToInt32(wholeCompare1.Text);

                    MixedFraction mixed1 = new MixedFraction(num1, demo1, whole1);
                    mixed1.Minimalism();

                    int num2 = Convert.ToInt32(numCompare2.Text);
                    int demo2 = Convert.ToInt32(demoCompare2.Text);
                    int whole2 = Convert.ToInt32(wholeCompare2.Text);

                    MixedFraction mixed2 = new MixedFraction(num2, demo2, whole2);
                    mixed2.Minimalism();

                    //Dùng class calculator để xử lí
                    cal.Num1 = mixed1;
                    cal.Num2 = mixed2;

                    int result = cal.Compare();

                    switch (result)
                    {
                        case 0:
                            lbCompare.Text = "=";
                            break;
                        case 1:
                            lbCompare.Text = ">";
                            break;
                        case -1:
                            lbCompare.Text = "<";
                            break;
                        default:
                            lbCompare.Text = "?";
                            break;
                    }
                }
                else
                {
                    if (!numCompare1.Text.Equals("") && !demoCompare1.Text.Equals("")
                        && !numCompare2.Text.Equals("") && !demoCompare2.Text.Equals(""))
                    {
                        //Lấy dữ liệu phần số 1 để so sánh
                        int num1 = Convert.ToInt32(numCompare1.Text);
                        int demo1 = Convert.ToInt32(demoCompare1.Text);

                        Fraction fraction1 = new Fraction(num1, demo1);
                        fraction1.Minimalism();

                        //Lấy dữ liệu phần số 2 để so sánh
                        int num2 = Convert.ToInt32(numCompare2.Text);
                        int demo2 = Convert.ToInt32(demoCompare2.Text);

                        Fraction fraction2 = new Fraction(num2, demo2);
                        fraction2.Minimalism();

                        //Dùng class calculator để xử lí
                        cal.Num1 = fraction1;
                        cal.Num2 = fraction2;

                        int result = cal.Compare();

                         switch(result)
                        {
                            case 0:
                                lbCompare.Text = "=";
                                break;
                            case 1:
                                lbCompare.Text = ">";
                                break;
                            case -1:
                                lbCompare.Text = "<";
                                break;
                            default:
                                lbCompare.Text = "?";
                                break;
                        }
                    }
                    else
                    {
                        lbCompare.Text = "?";
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                resultChangeNum.ResetText();
            }
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            Referesh();
        }
    }
}
