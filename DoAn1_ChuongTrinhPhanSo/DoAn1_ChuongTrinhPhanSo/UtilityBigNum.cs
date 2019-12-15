using System;
using System.Collections.Generic;
using System.Text;
using Deveel.Math;

namespace DoAn1_ChuongTrinhPhanSo.Utility
{
    public static class UtilityBigNum
    {
        private static BigDecimal sum = BigDecimal.Zero;
        private static BigDecimal TotalValue = BigDecimal.Zero;
        public static BigDecimal ToDecimal(this string s)
        {
            char[] c = new char[4];
            c[0] = '+';
            c[1] = '-';
            c[2] = '*';
            c[3] = '/';

            TotalValue = BigDecimal.Zero;

            string[] str = s.Split('(', ')');
            string cast = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (IsVaidCaculate(str[i]))
                {
                    sum = 0;
                    ToChangeDecimal(ref str[i], c);
                    TotalValue = TotalValue.Add(sum);
                }
                cast += str[i];
                cast = cast.Replace(" ", string.Empty);
            }


            cast = cast.Trim().Replace("--", "+");

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
                if (!IsDigit(s[i].ToString().Trim()))
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
                if (!IsDigit(s[i].ToString().Trim()))
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
                        BigDecimal value = Calculate(str, c[i]);
                        sum = value;
                        a = value.ToString();
                        return;
                    }
                }
            }
        }

        private static bool IsDigit(string s)
        {
            return BigDecimal.TryParse(s.Trim(), out _);
        }

        private static bool IsDigitString(string[] str)
        {
            foreach (string s in str)
            {
                if (!IsDigit(s)) return false;
            }
            return true;
        }
        private static BigDecimal Calculate(string[] a, char c)
        {
            BigDecimal value = BigDecimal.Parse(a[0].Trim());

            for (int i = 1; i < a.Length; i++)
            {
                if (c == '+')
                    value += BigDecimal.Parse(a[i].Trim());
                else if (c == '-')
                    value -= BigDecimal.Parse(a[i].Trim());
                else if (c == '*')
                    value *= BigDecimal.Parse(a[i].Trim());
                else
                    value /= BigDecimal.Parse(a[i].Trim());
            }
            return value;
        }
    }
}