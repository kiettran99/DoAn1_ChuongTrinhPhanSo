using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DoAn1_ChuongTrinhPhanSo
{
    public static class Utility
    {
        private static decimal sum = 0;

        public static decimal ToDecimal(this string s)
        {
            char[] c = new char[4];
            c[0] = '+';
            c[1] = '-';
            c[2] = '*';
            c[3] = '/';

            string[] str = s.Split('(', ')');
            string cast = "";

            decimal TotalValue = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (IsVaidCaculate(str[i]))
                {
                    sum = 0;
                    ToChangeDecimal(ref str[i], c);
                    TotalValue += sum;
                }
                cast += str[i];
            }

            cast = cast.Replace(" ", string.Empty);
            cast = cast.Trim().Replace("--", "+");
            cast = cast.Trim().Replace("π", "3141592/1000000");
            cast = cast.Trim().Replace("e", "2718281/1000000");
            //Check case if value = 5 or value = (5 + 2)
            FractionCalculator fraction = new FractionCalculator();
            //string result = fraction.textBox1.Text.Substring(0, 1);
            //if(result=="-")
            //    cast = cast.Trim().Replace(result, "-1*");
            if (str.Length == 1 && IsDigit(str[0]))
            {
                str[0] = str[0].Replace(" ", string.Empty);
                return decimal.Parse(str[0]);
            }

            if (!IsDigitString(str))
            {
                sum = 0;
                ToChangeDecimal(ref cast, c);
                TotalValue = sum;
            }

            return TotalValue;
        }

        private static bool IsVaidCaculate(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (!IsDigit(s[i].ToString()))
                {
                    return false;
                }
                else
                {
                    break;
                }
            }

            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (!IsDigit(s[i].ToString()))
                {
                    return false;
                }
                else
                {
                    break;
                }
            }

            return true;
        }

        private static void ToChangeDecimal(ref string a, char[] c)
        {
            string[] str;

            for (int i = 0; i < c.Length; i++)
            {
                str = a.Split(c[i]);

                if (str.Length > 1)
                {
                    for (int j = 0; j < str.Length; j++)
                    {
                        ToChangeDecimal(ref str[j], c);
                    }

                    if (IsDigitString(str))
                    {
                        decimal value = Calculate(str, c[i]);
                        sum = value;
                        a = value.ToString();
                        return;
                    }
                }
            }
        }

        private static bool IsDigit(string s)
        {
            decimal n;
            return decimal.TryParse(s, out n);
        }

        private static bool IsDigitString(string[] str)
        {
            foreach (string s in str)
            {
                if (!IsDigit(s)) return false;
            }
            return true;
        }
        private static decimal Calculate(string[] a, char c)
        {
            decimal value = Convert.ToDecimal(a[0]);

            for (int i = 1; i < a.Length; i++)
            {
                if (c == '+')
                    value += Convert.ToDecimal(a[i]);
                else if (c == '-')
                    value -= Convert.ToDecimal(a[i]);
                else if (c == '*')
                    value *= Convert.ToDecimal(a[i]);
                else
                    value /= Convert.ToDecimal(a[i]);
                //else if (c == 'π')
                //    value *=3141592/1000000;
            }
            return value;
        }
    }
}
