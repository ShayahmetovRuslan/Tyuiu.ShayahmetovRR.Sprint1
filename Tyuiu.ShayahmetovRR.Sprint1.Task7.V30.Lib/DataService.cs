using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ShayahmetovRR.Sprint1.Task7.V30.Lib
{
    public class DataService : ISprint1Task7V30
    {
        public double Calculate(double x, double y)
        {
            double var1 = (Math.Pow(Math.Sin(x), 5) + Math.Pow(x, 3)) / (Math.Pow(3, x));
            double var2 = (Math.Pow(y, 5)) / (Math.Pow(5, y));
            return x + Math.Exp(x) + var1 + var2;
        }
    }
}
