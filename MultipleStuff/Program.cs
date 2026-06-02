using System;

namespace MultipleStuff
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var lista = new SuperList { 5.5, -2.3, 10, 0, 7.1 };

            lista.GetMinMax1(out double min1, out double max1);
            Console.WriteLine($"V1: min = {min1}, max = {max1}");

            var mm2 = lista.GetMinMax2();
            Console.WriteLine($"V2: min = {mm2.Min}, max = {mm2.Max}");

            var (min3, max3) = lista.GetMinMax3();
            Console.WriteLine($"V3: min = {min3}, max = {max3}");

            var r4 = lista.GetMinMax4();
            Console.WriteLine($"V4: min = {r4.minimo}, max = {r4.maximo}");
        }
    }
}
