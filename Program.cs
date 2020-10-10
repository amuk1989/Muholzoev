using System;
using System.Collections.Generic;

namespace FirstHWMuholzoev
{
    class Program
    {
        delegate void Func();
        public static readonly string Address = "Address";
        public static readonly string Format = "Format";
        private static void DummyFunc()
        {
            WriteToConsole("Петя", "школьный друг", 30);
        }

        private static void DummyFuncAgain()
        {
            WriteToConsole("Вася", "сосед", 54);
        }

        private static void DummyFuncMore()
        {
            WriteToConsole("Николай", "сын", 4);
        }

        private static void WriteToConsole(string name, string description,int age)
        {
            Console.WriteLine($"{Format}, {name}, {description}, {Address}, {age}");
        }

        private static void MakeAction(Func _func)
        {
            string methodName = _func.Method.Name;
            Console.WriteLine("Начало работы метода {0}", methodName);
            _func();
            Console.WriteLine("Окончание работы метода {0}", methodName);
        }
        private static List<Func> GetActionSteps()
        {
            return new List<Func>()
            {
                DummyFunc,
                DummyFuncAgain,
                DummyFuncMore
            };
        }

        static void Main(string[] args)
        {
            #region 1
            Store store = new Store();
            Customer customer = new Customer();
            #endregion

            #region 2
            List<Func> funcs = GetActionSteps();
            foreach (var func in funcs)
            {
                MakeAction(func);
            }

            Console.ReadLine();

            #endregion
        }
    }
}


