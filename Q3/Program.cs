using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class Program
    {
        /*
         * 針對 string 寫一個擴充方法 ToInt(this string value, int defaultValue), 
         * 可以將 string 轉換成 int 型別, 如果無法轉型成功, 傳回 defaultValue
         */
        static void Main(string[] args)
        {
            string value = "0123456789";
            Console.WriteLine(value.ToInt(-1));

            value = "abcdefghijk";
            Console.WriteLine(value.ToInt(-1));
        }
    }
    public static class MyString
    {
        public static int ToInt(this string value, int defaultValue)
        {
            return int.TryParse(value, out int number) ?
                number :
                defaultValue;
        }
    }
}
