using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    public class WeightCalc
    {
        public double hight { get; set; }
        public char gender { get; set; }

        public double GetWight()
        {
            switch (gender)
            {
                case 'M':
                    return (hight - 100) - ((hight - 150) / 4);
                case 'F':
                    return (hight - 100) - ((hight - 150) / 2);
                default:
                    return 0;

            }
        }
    }
}
