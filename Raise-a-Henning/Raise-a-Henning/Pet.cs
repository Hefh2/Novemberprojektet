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

        public bool GetAlive()
        {
            return isAlive;
        }

        public void DoAction()
        {}

        public void PrintStats()
        {}

        public void Tick()
        {}

        public void ListActions()
        {}
        
    }
}
