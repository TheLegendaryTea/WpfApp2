using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    internal class Tangens
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Tangens(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public double Tang()
        {
            return Y / X;
        }
    }
}
