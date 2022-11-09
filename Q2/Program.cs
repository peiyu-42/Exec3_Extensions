using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    /*
     * String.Left(int length)
     *   傳回字串的前面幾個字
     *   若value 是 null or empty, 都傳回 空字串
     *   若 length <= 0, 傳回空字串
     *   若value長度比length少, 傳回value
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            string values = "0123456789";
            int n = 5;
            Console.WriteLine($"傳回前 {n}個字: {values.Left(n)}");
            n = 22;
            Console.WriteLine($"傳回前 {n}個字: {values.Left(n)}");
        }
    }
    public static class MyString
    {
        public static string Left(this string value, int length)
        {
            string result = string.Empty;
            if (string.IsNullOrEmpty(value) == true)
            { return result; }
            if (length <= 0)
            { return result; }
            if (value.Length < length)
            { return value; }

            return result = value.Substring(0, length);
        }
    }
}
