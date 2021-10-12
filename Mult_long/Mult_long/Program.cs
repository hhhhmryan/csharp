using System;
using System.Linq;

namespace Mult_long
{
    class Program
    {
        static string ReverseString(string s)
        {
            char[] array = s.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Складываем супер длинные числа прямо в консоли!");

                Console.Write("Первое число: ");
                string a = Console.ReadLine();
                Console.Write("Второе число: ");
                string b = Console.ReadLine();
                string res = "";
                int c = 0, d = 0;

                //выравниваем количество разрядов путем дополнения нулями слева
                int max = Math.Max(a.Length, b.Length);
                if (a.Length < b.Length)
                    a = a.PadLeft(max, '0');
                else
                    if (a.Length > b.Length)
                    b = b.PadLeft(max, '0');
                //складываем
                for (int i = max - 1; i >= 0; i--)
                {
                    if (Char.IsDigit(a[i]) == true)
                    {
                        c = (d + (int)Char.GetNumericValue(a[i]) + (int)Char.GetNumericValue(b[i])) % 10;
                        res += c.ToString();
                        d = (d + (int)Char.GetNumericValue(a[i]) + (int)Char.GetNumericValue(b[i])) / 10;
                    }
                    else
                        throw new ArgumentNullException();
                }
                res = ReverseString(res);
                int[] nums = res.Select(res => res - '0').ToArray();

                Console.Write("Voila! :      ");
                for (int k = 0; k < nums.Length; k++)
                    Console.Write(nums[k]);
                Console.WriteLine();
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("\nstream numb by waterparks, the greatest hits out may 21");
            }
        }
    }
}
