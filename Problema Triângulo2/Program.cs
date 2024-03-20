﻿using System;

namespace Problema_Triângulo2
{
    class Program
    {
        static void Main(string[] args)
        {
            double xA, xB, xC, yA, yB, yC;
            xA = 3.00;
            xB = 4.00;
            xC = 5.00;
            yA = 7.50;
            yB = 4.50;
            yC = 4.02;

            double p = (xA + xB + xC) / 2;
            double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));
            p = (yA + yB + yC) / 2;
            double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

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
