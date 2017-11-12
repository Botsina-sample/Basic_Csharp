using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var comp = new Desktop("Macintosh 2", Desktop.caseType.Tower);
            //var comp = new Laptop("Macbook", 1280, 720);

            Console.WriteLine("\n\n\n\nType: " + comp.GetType());

            var IsComp = comp is Computer;
            Console.WriteLine("IsComputer: " + IsComp);

            

            Console.WriteLine("Name: " + comp.name);

            Console.WriteLine("CaseType: " + comp.CaseType);

            comp.TogglePower();
            Console.WriteLine("Status: " + comp.isOn);

            comp.ToggleSleep();
            Console.WriteLine("Status: " + comp.isSleep);

            comp.TogglePower();
            Console.WriteLine("Status: " + comp.isOn);


        }
    }
}
