using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_6
{
    interface IMeowable
    {
        void Meow(int times = 1);
        string GetName();
    }
}
