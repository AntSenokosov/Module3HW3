using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3HW3
{
    public class Class2
    {
        private readonly Class1 _class1;
        private int _pow;

        public Class2()
        {
            _class1 = new Class1();
        }

        public Func<int, bool> Calc(Func<int, int, int> func, int first, int second)
        {
            func += _class1.Pow;
            _pow = func.Invoke(first, second);

            Func<int, bool> res = pow => Result(pow);

            return res;
        }

        public bool Result(int x)
        {
            var result = _pow % x;

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
