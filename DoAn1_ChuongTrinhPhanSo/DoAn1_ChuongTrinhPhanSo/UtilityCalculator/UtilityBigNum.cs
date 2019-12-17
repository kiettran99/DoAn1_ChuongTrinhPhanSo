using System;
using System.Collections.Generic;
using System.Text;
using Deveel.Math;
using org.mariuszgromada.math.mxparser;

namespace DoAn1_ChuongTrinhPhanSo.UtilityCalculator
{
    public static class UtilityBigNum
    {
        private static BigDecimal sum = BigDecimal.Zero;
        private static BigDecimal TotalValue = BigDecimal.Zero;
        public static BigDecimal ToDecimal(string s)
        {
            s = s.Replace(" ", string.Empty);

            char[] c = new char[4];
            c[0] = '+';
            c[1] = '-';
            c[2] = '*';
            c[3] = '/';

            TotalValue = BigDecimal.Zero;

            string[] str = s.Split('(', ')');
            str = Referesh(str);
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

            //Check case if value = 5 or value = (5 + 2)
            if (str.Length == 1 && IsDigit(str[0]))
            {
                str[0] = str[0].Replace(" ", string.Empty);
                return BigDecimal.Parse(str[0]);
            }

            cast = cast.Trim().Replace("--", "+");

            if (str.Length != 1 || !IsDigitString(str))
            {
                sum = 0;
                ToChangeDecimal(ref cast, c);
                TotalValue = sum;
            }

            return TotalValue;
        }

        private static string[] Referesh(string[] str)
        {
            int count = 0;
            for (int i = 0;i < str.Length; i++)
            {
                if (!str[i].Equals("")) count++;
            }

            string[] strArray = new string[count];
            count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (!str[i].Equals("")) strArray[count++] = str[i];
            }

            return strArray;
        }

        public static string ResolveExpressions(string s)
        {
            s = ResolveExpression(s, "sin");
            s = ResolveExpression(s, "cos");
            s = ResolveExpression(s, "tan");
            s = ResolveExpression(s, "ln");
            s = ResolveExpression(s, "sqrt");
            return s;
        }

        private static string ResolveExpression(string s, string express)
        {
            s = s.Replace(" ", string.Empty);

            s = s.Trim().Replace("(-", "(0-");

            if (s.Length > 1 && s[0].Equals('π'))
                s = s.Trim().Replace("π", $"{Math.PI}");
            if (s.Length > 1 && s[0].Equals('e'))
                s = s.Trim().Replace("e", $"{Math.E}");

            s = s.Trim().Replace("+π", $"+{Math.PI}");
            s = s.Trim().Replace("(π", $"({Math.PI}");
            s = s.Trim().Replace("-π", $"-{Math.PI}");
            s = s.Trim().Replace("*π", $"*{Math.PI}");
            s = s.Trim().Replace("/π", $"/{Math.PI}");

            s = s.Trim().Replace("+e", $"+{Math.E}");
            s = s.Trim().Replace("(e", $"({Math.E}");
            s = s.Trim().Replace("-e", $"-{Math.E}");
            s = s.Trim().Replace("*e", $"*{Math.E}");
            s = s.Trim().Replace("/e", $"/{Math.E}");

            s = s.Trim().Replace("π", $"*{Math.PI}");
            s = s.Trim().Replace("e", $"*{Math.E}");

            string output;
            char[] c = new char[4];
            c[0] = '+';
            c[1] = '-';
            c[2] = '*';
            c[3] = '/';

            while (s.IndexOf(express) != -1)
            {
                string[] str = s.Split('(', ')');
                str = Referesh(str);
                string cast = "";

                for (int i = 0; i < str.Length; i++)
                {
                    if (IsVaidCaculate(str[i]))
                    {
                        sum = 0;
                        ToChangeDecimal(ref str[i], c);
                        TotalValue = TotalValue.Add(sum);
                    }
                    if (IsDigit(str[i]) && IsDigit(str[i]))
                        cast += "(" + str[i] + ")";
                    else cast += str[i];
                    cast = cast.Replace(" ", string.Empty);
                }

                //Solve bugs sin(sqrt(2)), but result sinsqrt(2)+1
                //cast = sinsqrt(2)+1
                //partCuting = sinsqrt(2)
                //resolveCutting = sin(sqrt(2))
                // cast = cast.replace(partCuting, resolveCutting));
                if (cast.Contains("sqrt") || cast.Contains("ln"))
                {
                    int start = cast.IndexOf(express);
                    string partCutting = cast.Substring(start, IndexOfLast(cast, start, c) - start);
                    string resolveCutting = partCutting.Replace(express, express + "(");
                    resolveCutting += ")";
                    cast = cast.Replace(partCutting, resolveCutting);
                    output = cast.Substring(start, IndexOfLast(cast, start, c) - start);
                }
                else
                {
                    output = cast;
                }
              
                Expression e = new Expression(output);
                BigDecimal bigDecimal = BigDecimal.Parse(e.calculate().ToString());
                s = cast.Replace(output, bigDecimal.ToPlainString());
            }
            return s;
        }

        private static int IndexOfLast(string s, int start, char[] c)
        {
            int end = s.Length;

            while (start < end)
            {
                for (int i = 0; i < c.Length; i++)
                {
                    if (s[start] == c[i]) return start;
                }
                start++;
            }

            return end;
        }

        private static bool IsVaidCaculate(string s)
        {
            s = s.Replace(" ", string.Empty);
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

                    if (!str.Equals("") && IsDigitString(str))
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
                    value = value.Add(BigDecimal.Parse(a[i].Trim()));
                else if (c == '-')
                    value = value.Subtract(BigDecimal.Parse(a[i].Trim()));
                else if (c == '*')
                    value = value.Multiply(BigDecimal.Parse(a[i].Trim()));
                else
                    value = value.Divide(BigDecimal.Parse(a[i].Trim()), 5, RoundingMode.HalfEven);
            }
            return value;
        }
    }
}