using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Deveel.Math;

namespace DoAn1_ChuongTrinhPhanSo.UtilityCalculator
{
    public static class CalculatorBigNum
    {
        /// <summary>
        /// Phương thức xử lí các số âm ở mẫu, hoặc cùng âm dành cho phân số.
        /// </summary>
        /// <param name="num">Tử số</param>
        /// <param name="demo">Mẫu Số</param>
        private static void ResolveNegative(ref BigDecimal num, ref BigDecimal demo)
        {
            //Kiểm tra các số âm
            if (num.Sign == -1 && demo.Sign == -1)
            {
                num = num.Abs();
                demo = demo.Abs();
            }
            else
            {
                if (num.Sign == 1 && demo.Sign == -1)
                {
                    num = num.Negate();
                    demo = demo.Abs();
                }
            }
        }

        /// <summary>
        ///     Xử lí phân số nếu tử hoặc mẫu là số thập phân.
        /// </summary>
        /// <param name="cal"> Lớp Tính toán dùng độc lập để tính toán trả về kết quả.</param>
        /// <param name="num"> Tử số</param>
        /// <param name="demo"> Mẫu số</param>
        /// <returns></returns>
        public static FractionBigNum ToFractionBignum(BigDecimal num, BigDecimal demo)
        {
            try
            {
                ResolveNegative(ref num, ref demo);

                //Nếu phân số đầu tiên là số nguyên ta sẽ làm bình thường
                if (IsWhole(num) && IsWhole(demo))
                {
                    return Round(new FractionBigNum(num, demo));
                }
                else
                {
                    if (!IsWhole(num) && IsWhole(demo))
                    {
                        FractionBigNum fracNum = ChangeFraction(num);
                        fracNum.Minimalism();

                        FractionBigNum fracDemo = new FractionBigNum(BigDecimal.One, demo);

                        FractionBigNum Result = fracNum * fracDemo;

                        return Round(Result);
                    }
                    else
                    {
                        if (IsWhole(num) && !IsWhole(demo))
                        {

                            FractionBigNum fracNum = new FractionBigNum(num, BigDecimal.One);

                            FractionBigNum fracDemo = ChangeFraction(demo);
                            fracDemo.Minimalism();

                            FractionBigNum Result = fracNum / fracDemo;

                            return Round(Result);
                        }
                        else
                        {
                            FractionBigNum fracNum = ChangeFraction(num);
                            fracNum.Minimalism();

                            FractionBigNum fracDemo = ChangeFraction(demo);
                            fracDemo.Minimalism();

                            FractionBigNum Result = fracNum / fracDemo;

                            return Round(Result);
                        }
                    }
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                throw new Exception("Kiểm tra tử sử hoặc mẫu số nhập hợp lệ không, có thể mẫu số bằng 0?");
            }
        }

        /// <summary>
        ///  Round BigDecimal is looking clearly.
        /// </summary>
        /// <param name="num">Bignum</param>
        /// <returns></returns>
        public static BigDecimal Round(BigDecimal num)
        {
            int countDecimal = CountDecimal(num);

            if (IsWhole(num))
            {
                num = num.SetScale(0, RoundingMode.HalfEven);
            }
            else
            {
                num = num.SetScale(countDecimal, RoundingMode.HalfEven);
            }

            return num;
        }

        /// <summary>
        ///    Round fraction is looking clearly.
        /// </summary>
        /// <param name="frac">Bignum</param>
        /// <returns></returns>
        private static FractionBigNum Round(FractionBigNum frac)
        {
            int countDecimal = CountDecimal(frac.Numerator);

            if (IsWhole(frac.Numerator))
            {
                frac.Numerator = frac.Numerator.SetScale(0, RoundingMode.HalfEven);
            }
            else
            {
                frac.Numerator = frac.Numerator.SetScale(countDecimal, RoundingMode.HalfEven);
            }

            countDecimal = CountDecimal(frac.Denominator);

            if (IsWhole(frac.Denominator))
            {
                frac.Denominator = frac.Denominator.SetScale(0, RoundingMode.HalfEven);
            }
            else
            {
                frac.Denominator = frac.Denominator.SetScale(countDecimal, RoundingMode.HalfEven);
            }

            return frac;
        }

        /// <summary>
        /// Phương thức trả về số lượng sau dấu ".".
        /// </summary>
        /// <param name="n">Số thập phân.</param>
        /// <returns>số lượng số nguyên sau dấu ".".</returns>
        private static int CountDecimal(BigDecimal n)
        {
            int count = 0;

            while (!n.IsZero)
            {
                count++;
                n = n.Multiply(BigDecimal.Ten);
                n = n.Subtract(n.DivideToIntegralValue(BigDecimal.One));
            }

            return count;
        }

        /// <summary>
        /// Kiểm tra số vừa nhập là số nguyên dương.
        /// </summary>
        /// <param name="n">Số nhận từ bên ngoài.</param>
        /// <returns></returns>
        private static bool IsWhole(BigDecimal n)
        {
            return n == n.DivideToIntegralValue(BigDecimal.One);
        }



        /// <summary>
        ///   Chuyển số thập phân thành hỗn số.
        /// </summary>
        /// <param name="n">Số thập phân nhận từ bên ngoài.</param>
        /// <returns>Phần thực của hỗn số</returns>
        private static FractionBigNum ChangeFraction(BigDecimal n)
        {
            FractionBigNum frac = new FractionBigNum();

            int sign = n.Sign;

            n = n.Abs();

            BigDecimal whole = n.DivideToIntegralValue(BigDecimal.One);

            BigDecimal decimalPoint = n.Subtract(whole);

            frac.Numerator = decimalPoint.Multiply(BigDecimal.Ten.Pow(CountDecimal(decimalPoint))).DivideToIntegralValue(BigDecimal.One);
            frac.Denominator = BigDecimal.Ten.Pow(CountDecimal(decimalPoint)).DivideToIntegralValue(BigDecimal.One);
            frac.Minimalism();

            if (!whole.IsZero)
            {
                //If Whole is not zero then we change whole to fraction, add fraction.
                FractionBigNum frac2 = new FractionBigNum(whole, BigDecimal.One);
                frac = frac + frac2;
            }

            frac.Numerator *= sign;

            return frac;
        }
    }
}
