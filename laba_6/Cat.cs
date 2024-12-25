using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_6
{
    class Cat : IMeowable
    {
        private string _name;

        public Cat(string name)
        {
            _name = name;
        }

        public string GetName() => _name;

        public override string ToString() => $"кот: {_name}";

        public void Meow(int n = 1)
        {
            Console.WriteLine(n == 1
                ? $"{_name}: мяу!"
                : $"{_name}: {string.Join("-", new string[n].Select(_ => "мяу"))}!");
        }
    }
}
