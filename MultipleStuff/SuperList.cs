using System;
using System.Collections.Generic;

namespace MultipleStuff
{
    public class SuperList : List<double>
    {
        public void GetMinMax1(out double min, out double max)
        {
            if (Count == 0)
                throw new InvalidOperationException("Lista vazia");

            min = double.MaxValue;
            max = double.MinValue;

            foreach (double n in this)
            {
                if (n < min) min = n;
                if (n > max) max = n;
            }
        }

        public struct MinMax
        {
            public double Min;
            public double Max;

            public MinMax(double min, double max)
            {
                Min = min;
                Max = max;
            }
        }

        public MinMax GetMinMax2()
        {
            if (Count == 0)
                throw new InvalidOperationException("Lista vazia");

            double min = double.MaxValue;
            double max = double.MinValue;

            foreach (var n in this)
            {
                if (n < min) min = n;
                if (n > max) max = n;
            }

            return new MinMax(min, max);
        }

        
        public (double min, double max) GetMinMax3()
        {
            if (Count == 0)
                throw new InvalidOperationException("Lista vazia");

            double min = double.MaxValue;
            double max = double.MinValue;

            foreach (var n in this)
            {
                if (n < min) min = n;
                if (n > max) max = n;
            }
            
            return (min, max);
        }

        public (double minimo, double maximo) GetMinMax4()
        {
            if (Count == 0)
                throw new InvalidOperationException("Lista vazia");

            double minimo = double.MaxValue;
            double maximo = double.MinValue;

            foreach (var n in this)
            {
                if (n < minimo) minimo = n;
                if (n > maximo) maximo = n;
            }

            return (minimo, maximo);
        }
    }
}