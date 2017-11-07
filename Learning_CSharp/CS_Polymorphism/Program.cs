using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawObject[] newobj = new DrawObject[3];
            newobj[0] = new line();
            newobj[1] = new Circle();
            newobj[2] = new Triangle();

            foreach(DrawObject drawObj in newobj)
            {
                drawObj.Draw();
            }
        }

        public class DrawObject
        {
            public virtual void Draw()
            {
                Console.WriteLine("Draw something");
            }
        }

        public class line : DrawObject
        {
            public override void Draw()
            {
                Console.WriteLine("I draw a line");
            }
        }

        public class Circle : DrawObject
        {
            public override void Draw()
            {
                Console.WriteLine("I draw a circle");
            }
        }

        public class Triangle : DrawObject
        {
            public override void Draw()
            {
                Console.WriteLine("I draw a triangle");
            }
        }

    }
}
