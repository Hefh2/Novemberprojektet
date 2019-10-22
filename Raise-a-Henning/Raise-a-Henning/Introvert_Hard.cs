using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raise_a_Henning
{
    class Introvert_Hard : Pet
    {
        private int matAvtag;
        private int sallskapAvtag;
        private int sallskapAndraAvtag;
        private int karlekAvtag;
        private int motionAvtag;

        public void Tick()
        {
            mat = mat - matAvtag;
            sallskap = sallskap - sallskapAvtag;
            sallskapAndra = sallskapAndra - sallskapAndraAvtag;
            karlek = karlek - karlekAvtag;
            motion = motion - motionAvtag;
            dollar = dollar + dollarOkning;

        }
    }
}
