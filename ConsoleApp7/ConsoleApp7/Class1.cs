using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Class1
    {
        public void Method1Pub()
        {
            Method2Priv();
        }

        private void Method2Priv()
        {

        }
    }
}
