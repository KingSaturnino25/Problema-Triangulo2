using System;

namespace Problema_Triângulo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            x.A = 3.00;
            x.B = 4.00;
            x.C = 5.00;
            y.A = 7.50;
            y.B = 4.50;
            y.C = 4.02;

            double p = (x.A + x.B + x.C) / 2;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));
            p = (y.A + y.B + y.C) / 2;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            Console.WriteLine("Area de X :" + areaX);
            Console.WriteLine("Area de Y :" + areaY);

            if (areaX == areaY)
                Console.WriteLine("Areas são iguais");
            else if (areaX > areaY)
                Console.WriteLine("Area X é maior");
                    else
                Console.WriteLine("Area Y é maior");


        }
    }
}
