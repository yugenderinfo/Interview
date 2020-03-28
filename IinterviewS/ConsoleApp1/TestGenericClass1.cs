using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ConsoleApp1
{
    class TestGenericClass1
    {
    }

    public class  generic<t> 
    {
        public void Add(t input)
        {

        }

        public void Adda(t input, t output)
        {
          
        }

        public class MyGenericClass<T>
        {
            private T genericMemberVariable;

            public MyGenericClass(T value)
            {
                genericMemberVariable = value;
            }

            public T genericMethod(T genericParameter)
            {
                Console.WriteLine("Parameter type: {0}, value: {1}", typeof(T).ToString(), genericParameter);
                Console.WriteLine("Return type: {0}, value: {1}", typeof(T).ToString(), genericMemberVariable);

                return genericMemberVariable;
            }

            public T genericProperty { get; set; }
        }
    }
}
