using System;
using System.Collections.Generic;
using System.Text;

namespace FirstHWMuholzoev
{
    public class ThreadSafeSingleton
    {
        private string[] strings;
        private ThreadSafeSingleton()
        {
            strings = new string[99];
        }
        public static Lazy<ThreadSafeSingleton> Instance
        {
            get { return Nested.instance; }
        }
        private class Nested
        {
            static Nested()
            {
            }

            internal static readonly Lazy<ThreadSafeSingleton> instance = new Lazy<ThreadSafeSingleton>();

        }
    }
}
