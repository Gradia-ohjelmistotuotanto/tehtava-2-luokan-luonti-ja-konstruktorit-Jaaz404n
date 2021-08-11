using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KissaOhjelma
{
    class Cat
    {
        private int age;
        public string name;

        public Cat() {}

        public Cat(int age, string name)
        {
            this.age = age;
            this.name = name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return this.name;
        }

        public int GetAge()
        {
            return this.age;
        }
    }
}
