using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            ChildClass child = new ChildClass();

            child.print();

            ((giantClass)child).print();
        }
    }

    public class giantClass
    {
        string giantString;
        public giantClass()
        {
            Console.WriteLine();
        }

        public giantClass(string myString)
        {
            giantString = myString;
            Console.WriteLine(giantString);
        }

        public void print()
        {
            Console.WriteLine("This is a giant class");
        }
    }

    public class ParentClass : giantClass
    {
        public ParentClass() : base("From Derived")
        {
            Console.WriteLine("Parent Constructor.");
        }

        public void prints()
        {
            Console.WriteLine("I'm a Parent Class.");
        }
    }

    public class ChildClass : ParentClass 
    {
        public ChildClass()
        {
            Console.WriteLine("Child Constructor.");
        }
    }
}
