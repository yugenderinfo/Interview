using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.InterfaceDAL
{
   public  interface IBook<T>
    {
        void add(T book);

        void delete();

        T get();
    }
}
