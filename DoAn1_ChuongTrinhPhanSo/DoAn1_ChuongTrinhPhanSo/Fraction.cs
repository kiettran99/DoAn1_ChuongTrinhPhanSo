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
        protected int demoinator;

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
        public int Demoinator
        {
            get
            {
                return demoinator;
            }
            set
            {
                if (value == 0)
                {
                    throw new Exception("Mẫu số không được bằng 0 !");
                }
                else
                {
                    demoinator = value;
                }
            }
        }

        public Fraction()
        {
            Numerator = 0;
            Demoinator = 1;
        }

        public Fraction(int num1 , int num2)
        {
            Numerator = num1;
            Demoinator = num2;
        }

        public void Assign(int num1, int num2)
        {
            Numerator = num1;
            Demoinator = num2;
        }

        public void Reset()
        {
            Numerator = 0;
            Demoinator = 1;
        }

        public void Coppy(Fraction num)
        {
            Numerator = num.Numerator;
            Demoinator = num.Demoinator;
        }
        
        public void Minimalism()
        {
            int n = Minimalism(this.Numerator, this.Demoinator);

            this.Numerator /= Math.Abs(n);
            this.Demoinator /= Math.Abs(n);
        }

        private int Minimalism(int a, int b)
        {
            if (a % b == 0) return b;
            return Minimalism(b, a % b);
        }

        //Operator overloading
        #region Phân số với phân số
        public static Fraction operator +(Fraction num1, Fraction num2)
        {
            Fraction frac = new Fraction(num1.Numerator * num2.Demoinator + num2.Numerator * num1.Demoinator, num1.Demoinator * num2.Demoinator);
            frac.Minimalism();
            return frac;
        }

        public static Fraction operator -(Fraction num1, Fraction num2)
        {
            Fraction frac = new Fraction(num1.Numerator * num2.Demoinator - num2.Numerator * num1.Demoinator, num1.Demoinator * num2.Demoinator);
            frac.Minimalism();
            return frac;
        }

        public static Fraction operator *(Fraction num1, Fraction num2)
        {
            Fraction frac = new Fraction(num1.Numerator * num2.Numerator, num1.Demoinator * num2.Demoinator);
            frac.Minimalism();
            return frac;
        }

        public static Fraction operator /(Fraction num1, Fraction num2)
        {
            Fraction frac = new Fraction(num1.Numerator * num2.Demoinator, num1.Demoinator * num2.Numerator);
            frac.Minimalism();
            return frac;
        }

        #endregion
        #region Phân số cộng với số nguyên
        public static Fraction operator +(Fraction f, int n)
        {
            return new Fraction(f.Numerator + n * f.Demoinator, f.Demoinator);
        }
        public static Fraction operator -(Fraction f, int n)
        {
            return new Fraction(f.Numerator - n * f.Demoinator, f.Demoinator);
        }

        public static Fraction operator* (Fraction f, int n)
        {
            return new Fraction(f.Numerator * n, f.Demoinator);
        }

        public static Fraction operator /(Fraction f, int n)
        {
            return new Fraction(f.Numerator, f.Demoinator * n);
        }

        #endregion
    }
}