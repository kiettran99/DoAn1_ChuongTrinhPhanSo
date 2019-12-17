using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn1_ChuongTrinhPhanSo
{
    public class Fraction
    {
        protected int numerator;
        protected int denominator;

        //Tử số
        public int Numerator
        {
            get
            {
                return numerator;
            }
            set
            {
                numerator = value;
            }
        }
        //Mẫu số
        public int Denominator
        {
            get
            {
                return denominator;
            }
            set
            {
                if (value == 0)
                {
                    throw new Exception("Mẫu số không được bằng 0 !");
                }
                else
                {
                    denominator = value;
                }
            }
        }

        public Fraction()
        {
            Numerator = 0;
            Denominator = 1;
        }

        public Fraction(int num1 , int num2)
        {
            Numerator = num1;
            Denominator = num2;
        }

        //Phương thức gán giá trị tử và mẫu.
        public void Assign(int num1, int num2)
        {
            Numerator = num1;
            Denominator = num2;
        }

        //Phương thức trở về giá trị ban đầu.
        public void Reset()
        {
            Numerator = 0;
            Denominator = 1;
        }

        //Sao chép dữ liệu đã có sẵn.
        public void Coppy(Fraction num)
        {
            Numerator = num.Numerator;
            Denominator = num.Denominator;
        }
        
        /// <summary>
        /// Phân số tối giản.
        /// </summary>
        public void Minimalism()
        {
            int n = Minimalism(this.Numerator, this.Denominator);

            this.Numerator /= Math.Abs(n);
            this.Denominator /= Math.Abs(n);
        }

        //Tìm ước chung lớn nhất.
        private int Minimalism(int a, int b)
        {
            if (a % b == 0) return b;
            return Minimalism(b, a % b);
        }

        //Operator overloading
        #region Phân số với phân số
        public static Fraction operator +(Fraction num1, Fraction num2)
        {
            Fraction frac = new Fraction(num1.Numerator * num2.Denominator + num2.Numerator * num1.Denominator, num1.Denominator * num2.Denominator);
            frac.Minimalism();
            return frac;
        }

        public static Fraction operator -(Fraction num1, Fraction num2)
        {
            Fraction frac = new Fraction(num1.Numerator * num2.Denominator - num2.Numerator * num1.Denominator, num1.Denominator * num2.Denominator);
            frac.Minimalism();
            return frac;
        }

        public static Fraction operator *(Fraction num1, Fraction num2)
        {
            Fraction frac = new Fraction(num1.Numerator * num2.Numerator, num1.Denominator * num2.Denominator);
            frac.Minimalism();
            return frac;
        }

        public static Fraction operator /(Fraction num1, Fraction num2)
        {
            Fraction frac = new Fraction(num1.Numerator * num2.Denominator, num1.Denominator * num2.Numerator);
            frac.Minimalism();
            return frac;
        }

        #endregion
        #region Phân số cộng với số nguyên
        public static Fraction operator +(Fraction f, int n)
        {
            return new Fraction(f.Numerator + n * f.Denominator, f.Denominator);
        }
        public static Fraction operator -(Fraction f, int n)
        {
            return new Fraction(f.Numerator - n * f.Denominator, f.Denominator);
        }

        public static Fraction operator* (Fraction f, int n)
        {
            return new Fraction(f.Numerator * n, f.Denominator);
        }

        public static Fraction operator /(Fraction f, int n)
        {
            return new Fraction(f.Numerator, f.Denominator * n);
        }

        #endregion
    }
}