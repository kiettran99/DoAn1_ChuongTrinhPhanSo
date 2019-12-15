using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Deveel.Math;

namespace DoAn1_ChuongTrinhPhanSo.UtilityCalculator
{
    public class FractionBigNum
    {
        private BigDecimal numerator;
        private BigDecimal denominator;

        //Tử số
        public BigDecimal Numerator
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
        public BigDecimal Denominator
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

        public FractionBigNum()
        {
            Numerator = BigDecimal.Zero;
            Denominator = BigDecimal.One;
        }


        public FractionBigNum(BigDecimal num1, BigDecimal num2)
        {
            //Set 5 decimal places
            num1 = num1.SetScale(5, RoundingMode.HalfEven);
            num2 = num2.SetScale(5, RoundingMode.HalfEven);

            Numerator = num1;
            Denominator = num2;
        }

        //Phương thức gán giá trị tử và mẫu.
        public void Assign(BigDecimal num1, BigDecimal num2)
        {
            Numerator = num1;
            Denominator = num2;
        }

        //Phương thức trở về giá trị ban đầu.
        public void Reset()
        {
            Numerator = BigDecimal.Zero;
            Denominator = BigDecimal.One;
        }

        //Sao chép dữ liệu đã có sẵn.
        public void Coppy(FractionBigNum num)
        {
            Numerator = num.Numerator;
            Denominator = num.Denominator;
        }

        /// <summary>
        /// Phân số tối giản.
        /// </summary>
        public void Minimalism()
        {
            BigDecimal n = Minimalism(this.Numerator, this.Denominator);

            this.Numerator /= n.Abs();
            this.Denominator /= n.Abs();
        }

        //Tìm ước chung lớn nhất.
        private BigDecimal Minimalism(BigDecimal a, BigDecimal b)
        {
            if ((a % b).IsZero) return b;
            return Minimalism(b, a % b);
        }

        //Operator overloading
        #region Phân số với phân số
        public static FractionBigNum operator +(FractionBigNum num1, FractionBigNum num2)
        {
            BigDecimal num = num1.Numerator.Multiply(num2.Denominator).Add(num2.Numerator.Multiply(num1.Denominator));
            BigDecimal demo = num1.Denominator.Multiply(num2.Denominator);
            FractionBigNum frac = new FractionBigNum(num, demo);
            frac.Minimalism();
            return frac;
        }

        public static FractionBigNum operator -(FractionBigNum num1, FractionBigNum num2)
        {
            FractionBigNum frac = new FractionBigNum(num1.Numerator.Multiply(num2.Denominator) - num2.Numerator.Multiply(num1.Denominator), num1.Denominator.Multiply(num2.Denominator));
            frac.Minimalism();
            return frac;
        }

        public static FractionBigNum operator *(FractionBigNum num1, FractionBigNum num2)
        {
            FractionBigNum frac = new FractionBigNum(num1.Numerator.Multiply(num2.Numerator), num1.Denominator.Multiply(num2.Denominator));
            frac.Minimalism();
            return frac;
        }

        public static FractionBigNum operator /(FractionBigNum num1, FractionBigNum num2)
        {
            FractionBigNum frac = new FractionBigNum(num1.Numerator.Multiply(num2.Denominator), num1.Denominator.Multiply(num2.Numerator));
            frac.Minimalism();
            return frac;
        }

        #endregion
        #region Phân số cộng với số nguyên
        public static FractionBigNum operator +(FractionBigNum f, BigDecimal n)
        {
            return new FractionBigNum(f.Numerator + n * f.Denominator, f.Denominator);
        }
        public static FractionBigNum operator -(FractionBigNum f, BigDecimal n)
        {
            return new FractionBigNum(f.Numerator - n * f.Denominator, f.Denominator);
        }

        public static FractionBigNum operator *(FractionBigNum f, BigDecimal n)
        {
            return new FractionBigNum(f.Numerator * n, f.Denominator);
        }

        public static FractionBigNum operator /(FractionBigNum f, BigDecimal n)
        {
            return new FractionBigNum(f.Numerator, f.Denominator * n);
        }

        #endregion
    }
}
