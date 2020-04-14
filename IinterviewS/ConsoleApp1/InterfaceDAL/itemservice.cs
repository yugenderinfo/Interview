using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.InterfaceDAL
{
    class itemservice : IItem
    {
        private string name;

        public itemservice(String name)
        {
            this.name = name;
        }
        public string showName()
        {
            return name;
        }
    }

    class Container<T> where T : IItem
    {
        private T t;

        public void Set(T t)
        {
            this.t = t;
        }
        public T Get()
        {
            return t;
        }
    }
}
