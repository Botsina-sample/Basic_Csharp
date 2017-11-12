using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Laptop : Computer
    {
        public Display display { get; private set; }

        public Laptop(string name, int height, int width) : base(name)
        {
            display = new Display(width, height);
        }
    }
}
