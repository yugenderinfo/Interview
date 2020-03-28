using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            //reverse r = new reverse();
            //r.reverseNumber();

            //#region anonmyous
            //var anonymousData = new
            //{
            //    ForeName = "Jignesh",
            //    SurName = "Trivedi"
            //};
            //Console.WriteLine("First Name : " + anonymousData.ForeName);
            //#endregion

            //MyGenericClass<int> t = new MyGenericClass<int>(5);
            //  // t.genericMethod(5);
            //Console.WriteLine(t.genericMethod(5));

            MyGenericClass<string> ttt = new MyGenericClass<string>("yugender");
            // t.genericMethod(5);
            Console.WriteLine(ttt.genericMethod("yug"));

            // using class

            MyGenericClass<stdent> s = new MyGenericClass<stdent>(new stdent());
           // s.genericMethod(new stdent { name = "yug" });
            Console.WriteLine(s.genericMethod(new stdent { name = "yug" }));
        }



}
}
