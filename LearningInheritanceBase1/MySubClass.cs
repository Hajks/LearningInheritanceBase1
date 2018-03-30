using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningInheritanceBase1
{
    class MySubClass : MyBaseClass
    {
        public MySubClass(string baseClassNeedsThis, int anotherValue) :base("nieważne") //if we wanna create subclass we need to include construcor from base otherwise we will get error
        {
            MessageBox.Show("To jest klasa pochodna: " + baseClassNeedsThis + " i " + anotherValue);
        }
    }
}
