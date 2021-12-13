using System;

namespace Module3HW3
{
    class Program
    {
        private readonly Class2 _class2;
        private readonly Class1 _class1;
        public delegate void CalcHandler(Class2 class2);
        public event CalcHandler Notify;

        public void Show(EventHandler handler)
        {
            if (Notify != null)
            {
                Console.WriteLine("Result = " + _class2.Result(4));
            }
        }

        static void Main(string[] args)
        {
            var program = new Program();
            program.Show(program._class2.Calc(3, 5));

            Console.ReadKey();
        }
    }
}
