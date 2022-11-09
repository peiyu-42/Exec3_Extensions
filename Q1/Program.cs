using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    /* 
     * Int32.IsOdd, IsEven
     *   IsOdd()傳回 bool , 表示是否為奇數
     *   IsEven()傳回 bool , 表示是否為偶數 
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = DateTime.Now.Day;
            Console.WriteLine(number);
            Console.WriteLine($"偶數: {number.IsEven()}");
            Console.WriteLine($"奇數: {number.IsOdd()}");
        }
    }
    public static class MyMath
    {
        public static bool IsOdd(this int num)
        {
            if (num % 2 == 1)
            { return true; }                

            return false;
        }
        public static bool IsEven(this int num)
        {
            if ((num % 2) == 0)
            { return true; }

            return false ;
        }
        
    }
}
