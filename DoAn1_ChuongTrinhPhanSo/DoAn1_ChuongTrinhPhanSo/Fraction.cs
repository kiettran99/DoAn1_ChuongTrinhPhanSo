using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn1_ChuongTrinhPhanSo
{
    public class Fraction
    {
        //Tử số
        public int Numerator { get; set; }
        //Mẫu số
        public int Demoinator { get; set; }

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

            this.Numerator /= n;
            this.Demoinator /= n;
        }

        private int Minimalism(int a, int b)
        {
            if (a % b == 0) return b;
            return Minimalism(b, a % b);
        }
    }
}
