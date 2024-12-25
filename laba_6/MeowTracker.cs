using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_6
{
    class MeowTracker : IMeowable
    {
        private readonly IMeowable _meowable;
        private int _meowCount;

        public MeowTracker(IMeowable meowable)
        {
            _meowable = meowable;
            _meowCount = 0;
        }

        public void Meow(int times = 1)
        {
            _meowable.Meow(times);
            _meowCount += times;
        }

        public int GetMeowCount() => _meowCount;

        public string GetName() => _meowable.GetName();
    }
}
