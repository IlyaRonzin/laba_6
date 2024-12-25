using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_6
{
    interface IFraction
    {
        double ToDecimal();
        void SetValues(int numerator, int denominator);
    }
}
