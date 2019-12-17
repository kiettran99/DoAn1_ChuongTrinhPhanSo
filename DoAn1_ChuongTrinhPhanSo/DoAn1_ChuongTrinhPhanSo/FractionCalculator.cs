using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn1_ChuongTrinhPhanSo.UtilityCalculator;
using Deveel.Math;
using System.Windows.Documents;

namespace DoAn1_ChuongTrinhPhanSo
{
    public partial class FractionCalculator : Form
    {
        public FractionCalculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                char text = textBox1.Text[0];
                if (text == '-')
                    textBox1.Text = textBox1.Text.Insert(0, "0");
                string input = textBox1.Text;
                input = UtilityBigNum.ResolveExpressions(input);

                BigDecimal output = UtilityBigNum.ToDecimal(input);

                FractionBigNum fractionBigNum = new FractionBigNum(output, BigDecimal.One);
                fractionBigNum = CalculatorBigNum.ToFractionBignum(fractionBigNum.Numerator, fractionBigNum.Denominator);

                txtResult.Text = $"= {fractionBigNum.Numerator} / {fractionBigNum.Denominator} = {CalculatorBigNum.Round(output)}";

                if (textBox1.Text.Length > 0 && textBox1.Text[0].Equals('0'))
                    textBox1.Text = textBox1.Text.Remove(0, 1);
            }
            catch
            {
                MessageBox.Show("Biểu thức nhập không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void b1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void bdelete_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void b2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void b3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }
        private void b4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }
        private void b5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }


        private void b6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void b7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void b8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void b9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void b0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }
        private void bchia_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "/";
        }
        private void bcong_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "+";
        }
        private void btru_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "-";
        }

        private void bnhan_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "*";
        }

        private void bphay_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void bn1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "(";
        }

        private void bn2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ")";
        }

        private void bc1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
        }

        private void bupsize_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void bdownsize_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void bsin_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "sin(";
        }

        private void bcos_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "cos(";
        }

        private void btan_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "tan(";
        }

        private void bln_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "ln(";
        }

        private void blog_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "log(";
        }

        private void bcan_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "sqrt(";
        }

        private void bpi_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "π";
        }

        private void bgiaithua_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "!";
        }

        private void be_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "e";
        }
    }
}
