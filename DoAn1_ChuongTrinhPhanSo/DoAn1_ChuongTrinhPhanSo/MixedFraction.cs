using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn1_ChuongTrinhPhanSo
{
    public class MixedFraction : Fraction
    {
        public int Whole { get; set; }

        public MixedFraction() : base()
        {
            Whole = 1;
        }

        public MixedFraction(int num1, int num2, int num3) :base(num1, num2)
        {
            Whole = num3;
        }

        public void Assign(int num1, int num2, int num3)
        {
            base.Assign(num1, num2);
            Whole = num3;
        }

        public new void Reset()
        {
            Whole = 1;
            base.Reset();
        }

        public void Coppy(MixedFraction m)
        {
            base.Coppy(m);
            Whole = m.Whole;
        }

        public new void Minimalism()
        {
            Numerator += Whole * base.Demoinator;
            base.Minimalism();
            Whole = 1;
        }
    }
}
