using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3HW3
{
    public class Class2
    {
        private Class1 _class1 = new Class1();
        public bool Result(int x)
        {
            var result = _class1.Pow() % x;

            if (result == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
