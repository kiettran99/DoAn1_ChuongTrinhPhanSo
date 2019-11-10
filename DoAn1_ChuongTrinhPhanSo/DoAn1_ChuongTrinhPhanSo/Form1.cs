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


        /// <summary>
        ///    Giải quyết những trường hợp thực hiện phép tính phân số.
        /// </summary>
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
            txtDemoResult.Text = cal.Result.Denominator.ToString();
        }


        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            Referesh();
            tabControl.SelectedIndex = 1;
        }


        /// <summary>
        ///     Phép tính cộng 2 phân số.
        /// </summary>
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
                    txtDemoinator1.Text = cal.Num1.Denominator.ToString();

                    if (!isInput)
                    {
                        cal.Num2.Reset();
                        txtNumerator2.Text = "0";
                        txtDemoinator2.Text = "1";
                    }
                    else
                    {
                        cal.Num2 = cal.ToFraction(new Calculator(), decimal.Parse(txtNumerator2.Text), decimal.Parse(txtDemoinator2.Text));
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


        /// <summary>
        ///     Phép tính trừ 2 phân số.
        /// </summary>
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
                    txtDemoinator1.Text = cal.Num1.Denominator.ToString();

                    if (!isInput)
                    {
                        cal.Num2.Reset();
                        txtNumerator2.Text = "0";
                        txtDemoinator2.Text = "1";
                    }
                    else
                    {
                        cal.Num2 = cal.ToFraction(new Calculator(), decimal.Parse(txtNumerator2.Text), decimal.Parse(txtDemoinator2.Text));
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

        /// <summary>
        ///     Phép tính nhân 2 phân số.
        /// </summary>
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
                    txtDemoinator1.Text = cal.Num1.Denominator.ToString();

                    if (!isInput)
                    {
                        cal.Num2.Reset();
                        txtNumerator2.Text = "0";
                        txtDemoinator2.Text = "1";
                        preMath = "+";
                        Call("+");
                    }
                    else
                    {
                        cal.Num2 = cal.ToFraction(new Calculator(), decimal.Parse(txtNumerator2.Text), decimal.Parse(txtDemoinator2.Text));
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

        /// <summary>
        ///     Phép tính chia 2 phân số.
        /// </summary>
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
                    txtDemoinator1.Text = cal.Num1.Denominator.ToString();

                    if (!isInput)
                    {
                        cal.Num2.Reset();
                        txtNumerator2.Text = "0";
                        txtDemoinator2.Text = "1";
                        preMath = "+";
                        Call("+");
                    }
                    else
                    {
                        cal.Num2 = cal.ToFraction(new Calculator(), decimal.Parse(txtNumerator2.Text), decimal.Parse(txtDemoinator2.Text));
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

        /// <summary>
        ///     Giải phép toán hiện tại.
        /// </summary>
        private void BtnResult_Click(object sender, EventArgs e)
        {
            try
            {
                preMath = lbMath.Text;

                cal.Num1 = cal.ToFraction(new Calculator(), decimal.Parse(txtNumerator1.Text), decimal.Parse(txtDemoinator1.Text));
                cal.Num2 = cal.ToFraction(new Calculator(), decimal.Parse(txtNumerator2.Text), decimal.Parse(txtDemoinator2.Text));

                Call(lbMath.Text);
                isMulti = true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///     Cờ hiệu được bật lên khi người dùng thay đổi phân số thứ 2.
        /// </summary>
        private void TxtTS2_TextChanged(object sender, EventArgs e)
        {
            isInput = true;
        }

        /// <summary>
        ///     Xử lí phân số khi người dùng nhập.
        /// </summary>
        private void TextFraction1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!txtNumerator1.Text.Equals("") && !txtDemoinator1.Text.Equals(""))
                    cal.Result = cal.ToFraction(new Calculator(), decimal.Parse(txtNumerator1.Text), decimal.Parse(txtDemoinator1.Text));
            }
            catch { }
        }

        #region Khu Vực của Tab2: Phép tính khác.

        /// <summary>
        ///     Tối giản phân số.
        /// </summary>
        private void TextMinimalism_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!numMini.Text.Equals("") && !demoMini.Text.Equals("") && !wholeMini.Text.Equals(""))
                {
                    MixedFraction mixed = cal.ToMixedFraction(new Calculator(), Convert.ToDecimal(numMini.Text),
                        Convert.ToDecimal(demoMini.Text), Convert.ToDecimal(wholeMini.Text));

                    mixed.Minimalism();

                    numRsMini.Text = mixed.Numerator.ToString();
                    demoRsMini.Text = mixed.Denominator.ToString();
                }
                else
                {
                    if (!numMini.Text.Equals("") && !demoMini.Text.Equals(""))
                    {
                        Fraction fraction = cal.ToFraction(new Calculator(), Convert.ToDecimal(numMini.Text), Convert.ToDecimal(demoMini.Text));
                        fraction.Minimalism();

                        numRsMini.Text = fraction.Numerator.ToString();
                        demoRsMini.Text = fraction.Denominator.ToString();
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
                //MessageBox.Show(err.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numRsMini.ResetText();
                demoRsMini.ResetText();
            }
        }

        /// <summary>
        ///     Chuyển phân số thành số thập phân.
        /// </summary>
        private void TextNumber_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!numChangeNum.Text.Equals("") && !demoChangeNum.Text.Equals(""))
                {
                    Fraction fraction = cal.ToFraction(new Calculator(), Convert.ToDecimal(numChangeNum.Text), Convert.ToDecimal(demoChangeNum.Text));
                    fraction.Minimalism();

                    resultChangeNum.Text = ((float)fraction.Numerator / fraction.Denominator).ToString();

                }
                else
                {
                    resultChangeNum.ResetText();
                }
            }
            catch (Exception err)
            {
                //MessageBox.Show(err.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                resultChangeNum.ResetText();
            }
        }

        /// <summary>
        ///     So sánh các phân số với nhau cho kết quả.
        /// </summary>
        private void TextCompare_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!numCompare1.Text.Equals("") && !demoCompare1.Text.Equals("") && !wholeCompare1.Text.Equals("")
                        && !numCompare2.Text.Equals("") && !demoCompare2.Text.Equals("") && !wholeCompare2.Text.Equals(""))
                {
                    //Dùng class calculator để xử lí
                    MixedFraction mix1 = cal.ToMixedFraction(new Calculator(), Convert.ToDecimal(numCompare1.Text),
                        Convert.ToDecimal(demoCompare1.Text), Convert.ToDecimal(wholeCompare1.Text));

                    MixedFraction mix2 = cal.ToMixedFraction(new Calculator(), Convert.ToDecimal(numCompare2.Text),
                        Convert.ToDecimal(demoCompare2.Text), Convert.ToDecimal(wholeCompare2.Text));

                    mix1.Minimalism();
                    mix2.Minimalism();

                    cal.Num1 = mix1;
                    cal.Num2 = mix2;

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
                        //Dùng class calculator để xử lí
                        cal.Num1 = cal.ToFraction(new Calculator(), decimal.Parse(numCompare1.Text), decimal.Parse(demoCompare1.Text));
                        cal.Num2 = cal.ToFraction(new Calculator(), decimal.Parse(numCompare2.Text), decimal.Parse(demoCompare2.Text));

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
                        lbCompare.Text = "?";
                    }
                }
            }
            catch (Exception err)
            {
                //MessageBox.Show(err.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                resultChangeNum.ResetText();
            }
        }

        /// <summary>
        ///     Làm mới lại form này.
        /// </summary>
        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            Referesh();
        }

        /// <summary>
        ///     Chuyển số thập phân sang hỗn số và phân số khi người dùng nhập dữ liệu.
        /// </summary>
        private void TextChangeFrac_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textChangeFrac.Text.Length > 0)
                {
                    if (!textChangeFrac.Text[textChangeFrac.Text.Length - 1].Equals('.'))
                    {
                        decimal num = decimal.Parse(textChangeFrac.Text);
                        cal.Reset();

                        int whole = cal.ChangeFraction(num);

                        MixedFraction mixed = new MixedFraction(cal.Result.Numerator, cal.Result.Denominator, whole == 0 ? 0 : whole);

                        wholeChangeFrac1.Text = mixed.Whole.ToString();
                        numChangeFrac1.Text = mixed.Numerator.ToString();
                        demoChangeFrac1.Text = mixed.Denominator.ToString();

                        mixed.Minimalism();

                        numChangeFrac2.Text = mixed.Numerator.ToString();
                        demoChangeFrac2.Text = mixed.Denominator.ToString();
                    }
                }
                else
                {
                    cal.Reset();
                    wholeChangeFrac1.ResetText();
                    numChangeFrac1.ResetText();
                    demoChangeFrac1.ResetText();
                    numChangeFrac2.ResetText();
                    demoChangeFrac2.ResetText();
                }
            }
            catch (Exception err)
            {
                //MessageBox.Show(err.Message);
                wholeChangeFrac1.ResetText();
                numChangeFrac1.ResetText();
                demoChangeFrac1.ResetText();

                numChangeFrac2.ResetText();
                demoChangeFrac2.ResetText();
            }
        }

        #endregion

        /// <summary>
        ///  Truy cập link github của project thông qua trình duyệt mặc định.
        /// </summary>
        private void linkProject_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start((sender as LinkLabel).Text);
        }
    }
}
