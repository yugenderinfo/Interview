using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class gen2<T>
    {
        public T GetName(T name)
        {

            return name;
        }

        public List<T> GetAllItems(string listType)
        {

            if (listType == "A")
            {
                List<T> aa = new List<T>();


                return aa.ToList();
            }
            return new List<T>();
        }

        static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }
        // Generics method 
        public void Display<TypeOfValue>(string msg, TypeOfValue value)
        {
            Console.WriteLine("{0},{1}", msg, value);
           
        }

    }
}
