using System;

namespace _22222222222_лаба
{
    class Program
    {
        static void Main(string[] args)
        {

            int y, k;
            double x;
            Console.Write("y=");
            y = Convert.ToInt32(Console.ReadLine());

            Console.Write("k=");
            k = Convert.ToInt32(Console.ReadLine());

            x = (Math.Sqrt((Math.Pow(Math.Sin(y), 2)) + 6.835)) / (Math.Log10(y + k) + 3 * (Math.Pow((y), 2)));
            Console.Write(" x = " + x);
            Console.ReadKey(true);
        }
    }
}
