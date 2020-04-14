using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class TestSingleton
    {
        private static TestSingleton _instance;

        public  TestSingleton()
        {

        }
        public static TestSingleton Instance()
        {
            // Uses lazy initialization.

            // Note: this is not thread safe.

            if (_instance == null)
            {
                _instance = new TestSingleton();
            }

            return _instance;
        }
    }
    //class teste2 : TestSingleton
    //{

    //}
}
