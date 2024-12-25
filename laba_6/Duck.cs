using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_6
{
    class Duck : IMeowable
    {
        private string _name;

        public Duck(string name)
        {
            _name = name;
        }

        public string GetName() => _name;

        public override string ToString() => $"утка: {_name}";

        public void Meow(int times = 1)
        {
            Console.WriteLine(times == 1
                ? $"{_name}: кря!"
                : $"{_name}: {string.Join("-", new string[times].Select(_ => "кря"))}!");
        }
    }
}
