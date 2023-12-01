using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Метод_простых_итераций
{
    internal class Program
    {
        static double F(double x)
        {
            double F = Math.Pow(Math.E,(Math.Pow(x,3)-1))-1;
            return F;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Введите значение справа:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение слева:");
            double b = double.Parse(Console.ReadLine());
            double x = (a + b) / 2;
            double xk = 0;
            double Eps = 0.0000000001;
            double Epsizm = 1;
            double q = 0.435;

            while (Eps < Epsizm)
            {
                xk = F(x);
                Epsizm = q * Math.Abs(xk - x) / (1 - q);
                x = xk;
            }
            Console.WriteLine(xk);
            Console.ReadKey();
        }
    }
}
