using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.InterfaceDAL
{
    class Book<T> : IBook<T>
    {
        T book;
       
        public void add(T book)
        {
            this.book = book;
        }

        public void delete()
        {
            this.book = default(T);
        }

        public T get()
        {
            return this.book;
        }
    }
}
