using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn1_ChuongTrinhPhanSo
{
    public class Calculator
    {
        //Feilds
        private Fraction num1;
        private Fraction num2;
        private Fraction result;

        //Properties
        public Fraction Num1 { get => num1; set => num1 = value; }
        public Fraction Num2 { get => num2; set => num2 = value; }
        public Fraction Result { get => result; set => result = value; }

        public Calculator()
        {
            num1 = new Fraction();
            num2 = new Fraction();

            result = new Fraction();
        }

        public Calculator(Fraction num1, Fraction num2, Fraction result)
        {
            this.num1 = num1;
            this.num2 = num2;
            this.result = result;
        }

        public void Add()
        {
            result.Numerator = num1.Numerator * num2.Demoinator + num2.Numerator * num1.Demoinator;
            result.Demoinator = num1.Demoinator * num2.Demoinator;
            Result.Minimalism();
        }

        public void Subtract()
        {
            result.Numerator = num1.Numerator * num2.Demoinator - num2.Numerator * num1.Demoinator;
            result.Demoinator = num1.Demoinator * num2.Demoinator;
            Result.Minimalism();
        }

        public void Multiply()
        {
            result.Numerator = num1.Numerator * num2.Numerator;
            result.Demoinator = num1.Demoinator * num2.Demoinator;
            Result.Minimalism();
        }

        public void Divide()
        {
            if (num2.Numerator == 0)
            {
                throw new Exception("Tử số của thứ 2 không được bằng 0 với phép chia");
            }
            else
            {
                result.Numerator = num1.Numerator * num2.Demoinator;
                result.Demoinator = num1.Demoinator * num2.Numerator;
                Result.Minimalism();
            }
        }

        /// <summary>
        ///   Phương thức so sánh 2 phân số.
        ///   Trả về (0) 2 số bằng nhau, (1) số thứ nhất lớn hơn, (-1) số thứ nhất bé hơn.
        /// </summary>
        public int Compare()
        {
            this.Subtract();

            if (result.Numerator == 0) return 0;
            else if (result.Numerator < 0) return -1;
            else if (result.Numerator > 0) return 1;

            return -2;      //Lỗi
        }
    }
}
