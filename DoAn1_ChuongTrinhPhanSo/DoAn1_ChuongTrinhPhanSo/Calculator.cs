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

        public void Reset()
        {
            Num1.Reset();
            Num2.Reset();
            Result.Reset();
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

        private MixedFraction ToFraction(decimal n)
        {
            int sign = n < 0 ? -1 : 1;

            n = Math.Abs(n);

            int whole = (int)n;
            decimal decimalPoint = n - (int)n;


            MixedFraction mixedFraction = new MixedFraction();

            mixedFraction.Numerator = (int)(decimalPoint * (decimal)Math.Pow(10, CountDecimal(decimalPoint)));
            mixedFraction.Demoinator = (int)Math.Pow(10, CountDecimal(decimalPoint));

            mixedFraction.Minimalism();

            if (sign == -1)
            {
                result.Numerator = Math.Abs(result.Numerator - result.Demoinator);
                whole += 1;
            }

            mixedFraction.Whole = sign * whole;

            return mixedFraction;
        }

        public int ChangeFraction(decimal n)
        {
            int sign = n < 0 ? -1 : 1;

            n = Math.Abs(n);

            int whole = (int)n;
            decimal decimalPoint = n - (int)n;


            result.Numerator = (int)(decimalPoint * (decimal)Math.Pow(10, CountDecimal(decimalPoint)));
            result.Demoinator = (int)Math.Pow(10, CountDecimal(decimalPoint));
            result.Minimalism();

            if (sign == -1)
            {
                result.Numerator = Math.Abs(result.Numerator - result.Demoinator);
                whole += 1;
            }

            return sign * whole;
        }

        public bool isWhole(decimal n)
        {
            return (int)n == n;
        }

        public Fraction ToFraction(Calculator cal, decimal num, decimal demo)
        {
            try
            {
                //Nếu phân số đầu tiên là số nguyên ta sẽ làm bình thường
                if (cal.isWhole(num) && cal.isWhole(demo))
                {
                    return new Fraction(Convert.ToInt32(num), Convert.ToInt32(demo));
                }
                else
                {
                    if (!cal.isWhole(num) && cal.isWhole(demo))
                    {
                        MixedFraction mix = cal.ToFraction(num);
                        mix.Minimalism();

                        Calculator calTemp = new Calculator();

                        calTemp.Num1 = mix;
                        calTemp.Num2 = new Fraction(1, Convert.ToInt32(demo));

                        calTemp.Multiply();

                        return calTemp.Result;
                    }
                    else
                    {
                        if (cal.isWhole(num) && !cal.isWhole(demo))
                        {
                            MixedFraction mix = cal.ToFraction(demo);
                            mix.Minimalism();

                            Calculator calTemp = new Calculator();

                            calTemp.Num1 = new Fraction(Convert.ToInt32(num), 1);
                            calTemp.Num2 = mix;

                            calTemp.Divide();

                            return calTemp.Result;
                        }
                        else
                        {
                            Calculator calTemp = new Calculator();

                            MixedFraction mix1 = cal.ToFraction(num);
                            mix1.Minimalism();

                            MixedFraction mix2 = cal.ToFraction(demo);
                            mix2.Minimalism();

                            calTemp.num1 = mix1;
                            calTemp.num2 = mix2;

                            calTemp.Divide();

                            return calTemp.result;
                        }
                    }
                }
            }
            catch
            {
                throw new Exception("Kiểm tra tử sử hoặc mẫu số nhập hợp lệ không, có thể mẫu số bằng 0?");
            }
        }

        //Chuyển 2 số dạng phân số
        public MixedFraction ToMixedFraction(Calculator cal, decimal num, decimal demo, decimal whole)
        {
            try
            {
                if (cal.isWhole(num) && cal.isWhole(demo) && !cal.isWhole(whole))
                {
                    Fraction fracWhole = cal.ToFraction(whole);

                    fracWhole = (fracWhole * Convert.ToInt32(demo) + Convert.ToInt32(num)) / Convert.ToInt32(demo);

                    return new MixedFraction(fracWhole.Numerator, fracWhole.Demoinator, 0);
                }
                else
                {
                    if (cal.isWhole(num) && !cal.isWhole(demo) && !cal.isWhole(whole))
                    {
                        //Chuyển thập phân thành phân số cho phầ thực
                        Fraction fracWhole = cal.ToFraction(whole);
                        //Chuyển thập phân thành phân số cho phần mẫu
                        Fraction fracDemo = cal.ToFraction(demo);

                        fracWhole = ((fracWhole * fracDemo) + Convert.ToInt32(num)) / fracDemo;

                        return new MixedFraction(fracWhole.Numerator, fracWhole.Demoinator, 0);
                    }
                    else
                    {
                        if (!cal.isWhole(num) && !cal.isWhole(demo) && !cal.isWhole(whole))
                        {
                            //Chuyển thập phân thành phân số cho phầ thực
                            Fraction fracWhole = cal.ToFraction(whole);
                            //Chuyển thập phân thành phân số cho phần mẫu
                            Fraction fracDemo = cal.ToFraction(demo);
                            //Chuyển thập phân thành phân số cho phần tử
                            Fraction fracNum = cal.ToFraction(num);


                            fracWhole = ((fracWhole * fracDemo) + fracNum) / fracDemo;

                            return new MixedFraction(fracWhole.Numerator, fracWhole.Demoinator, 0);
                        }
                        else
                        {
                            Fraction frac = cal.ToFraction(new Calculator(), num, demo);

                            return new MixedFraction(frac.Numerator, frac.Demoinator, Convert.ToInt32(whole));
                        }
                    }
                }
            }
            catch
            {
                throw new Exception("Kiểm tra tử sử hoặc mẫu số nhập hợp lệ không ?");
            }
        }

        private int CountDecimal(decimal n)
        {

            int count = 0;

            while (n > 0)
            {
                count++;
                n *= 10;
                n -= (int)n;
            }

            return count;
        }
    }
}
