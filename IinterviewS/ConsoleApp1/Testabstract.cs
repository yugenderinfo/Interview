using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public abstract class Testabstract
    {
        // Non abstract method 
        public int AddTwoNumbers(int Num1, int Num2)
        {
            return Num1 + Num2;
        }

        public abstract void TestAdd( int a, int b);
    }

    public class simpleabstract : Testabstract
    {
        public override void TestAdd(int a, int b)
        {
            Console.WriteLine("testAbstractmethod"+ a+b);
        }
        

    }
}
