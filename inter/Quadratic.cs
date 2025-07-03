using ScottPlot.TickGenerators.TimeUnits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inter
{
    public class Quadratic
    {
        // of the standard form ax^2 + bx + c
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }

        public Quadratic(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double CalculateValue(double xValue)
        {
            double result;
            double res = a * xValue * xValue;
            res += b * xValue;
            res += c;

            result = res;

            return result;
        }

    }
}
