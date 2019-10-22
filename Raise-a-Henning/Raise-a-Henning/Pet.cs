using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raise_a_Henning
{
    class Pet
    {
        protected int mat = 100;
        protected int sallskap = 100;
        protected int sallskapAndra = 100;
        protected int karlek = 100;
        protected int motion = 100;
        protected int dollar = 10;
        protected int dollarOkning = 1;

        private bool isAlive;
        static Random generator = new Random();
        public string name;

        public void DoAction(int which)
        {
            //Does the specified action, since the action are named action1, action2, action3 and so forth
            //it will just use the method from the typ of pet it is concerning
        }

        public void Tick()
        {

        }

        public void GetAlive()
        {

        }

        public void ListActions()
        {

        }

        public void PrintStats()
        {

        }

    }
}
