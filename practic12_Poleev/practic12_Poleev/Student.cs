using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practic12_Poleev
{
    class Student
    {
        public string name;
        public double rost;
        double ves = 60.0;
        public void SetEat(double eda)
        {
            ves += (eda * 1000 - 1600) /1000;
            //if (eda > 5 && eda < 10)
            //{
            //    rost -= 1;
            //    ves += 0.7 * (eda * 1000 - 1600);
            //}
            //else if (eda > 10)
            //{
            //    rost -= 2;
            //    ves += 0.5 * (eda * 1000 - 1800);
            //}
        }

        public double GetEat()
        {
            return ves;
        }
    }
}
