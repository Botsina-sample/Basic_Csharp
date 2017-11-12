using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    abstract class Computer 
    {
        // this is a field, only computer class can manipulate this field.
        //string name; 

        protected string _name = "Unknown Type";
        public bool isOn { get; private set;}
        public virtual string name
        {
            get { return _name; }
            private set { _name = value; }
        }

        public Computer(string name)
        {
            this.name = name;
        }
        protected void TurnOn()
        {
            isOn = true;
        }
        protected void TurnOff()
        {
            isOn = false;
        }
        public virtual void TogglePower()
        {
            if(isOn)
            {
                TurnOff();
            } else
            {
                TurnOn();
            }
        }
    }
}
