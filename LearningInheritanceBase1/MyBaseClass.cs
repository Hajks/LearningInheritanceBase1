using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningInheritanceBase1
{
    class MyBaseClass
    {
        public MyBaseClass(string baseClassNeedsThis) { //we create class which need constructor to be made
            
              MessageBox.Show("To jest klasa bazowa: " + baseClassNeedsThis);
        }
    }
    
}
