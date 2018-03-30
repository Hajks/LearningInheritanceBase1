using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningInheritanceBase1
{
    class Chameleon : Vertebrate
    {   /* 
            public override void Eat(Food morsel)
        {
            CatchWithTongue(morsel); //new method, rest is from old one
            Swallow(morsel);
            Digest();

            //but we can do this in bettery way like
            CatchWithTongue(morsel);
            base.Eat(morsel); // it's  Swallow + Digest from base class
        
       } */
    }
}
