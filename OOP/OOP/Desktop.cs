using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Desktop : Computer
    {

        public enum caseType
        {
            Tower,
            miniTower,
            Laptop
        }

       

        public override string name
        {
            get
            {
                return base.name + " " + CaseType;
            }
        }

        public caseType CaseType { get; private set; }
        public bool isSleep { get; private set; }

        // this is a constructor, use keyword base to find the source of Computer

        public Desktop(string name, caseType CaseType) : base(name)
        {
            this.CaseType = CaseType;
      
        }

        public void ToggleSleep()
        {
            if (!isOn)
            {
                return;
            } else
            {
                isSleep = !isSleep;
            }
        }

        public override void TogglePower()
        {
            if(isSleep)
            {
                return;
            }else
            {
                base.TogglePower();
            }
        }
    }
}
