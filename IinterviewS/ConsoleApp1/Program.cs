using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using ConsoleApp1.InterfaceDAL;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //var builder = new ConfigurationBuilder()
            //   .SetBasePath(Directory.GetCurrentDirectory())
            //   .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            //   .AddUserSecrets<Program>()
            //   .AddEnvironmentVariables();

            //IConfigurationRoot configuration = builder.Build();
            //var mySettingsConfig = new MySettingsConfig();
            //configuration.GetSection("MySettings").Bind(mySettingsConfig);

            //Console.WriteLine("Setting from appsettings.json: " + mySettingsConfig.AccountName);
            //Console.WriteLine("Setting from secrets.json: " + mySettingsConfig.ApiSecret);
            //Console.WriteLine("Connection string: " + configuration.GetConnectionString("DefaultConnection"));

            //Console.ReadKey();

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

            // MyGenericClass<string> ttt = new MyGenericClass<string>("yugender");
            // // t.genericMethod(5);
            // Console.WriteLine(ttt.genericMethod("yug"));

            // // using class

            // MyGenericClass<stdent> s = new MyGenericClass<stdent>(new stdent());
            //// s.genericMethod(new stdent { name = "yug" });
            // Console.WriteLine(s.genericMethod(new stdent { name = "yug" }));

            #region abstrct
            // Note abstrct class canot have the instanceiate
            //Testabstract tb = new Testabstract(); //             Error CS0144  Cannot create an instance of the abstract class or interface 'Testabstract'

            //simpleabstract sb = new simpleabstract() ;
            //sb.AddTwoNumbers(4, 5); // no abstrct
            //sb.TestAdd(4,5);
            #endregion

            // find the N  3rdth largeest number in the arry

            //int[] arr = {12, 45, 1, -1, 45, 54, 23, 5, 0, -10};
            //find3largest(arr);



          //  gen2<A> a = new gen2<A>();
          //  a.GetAllItems("A");

          //var map=  getTest2.EnumNamedValues<getTest2.Rainbow>();


            //itemservice pencil = new itemservice("Pencil");

            //Container<itemservice> container = new Container<itemservice>();
            //container.Set(pencil);

            //Book<string> stringBook = new Book<string>();
            //stringBook.add("Clean Code");


            //Book<int> stringBook2 = new Book<int>();
            //stringBook2.add(12321);

            Book<DateTime> stringBook3 = new Book<DateTime>();
             stringBook3.add(System.DateTime.Now);
           

        }

        static void find3largest(int[] arr)
        {
            Array.Sort(arr); // It uses Tuned Quicksort with  
                             // avg. case Time complexity = O(nLogn) 
            int n = arr.Length;
            int check = 0, count = 1;

            for (int i = 1; i <= n; i++)
            {
                if (count < 4)
                {
                    if (check != arr[n - i])
                    {
                        // to handle duplicate values 
                        Console.Write(arr[n - i] + " ");
                        check = arr[n - i];
                        count++;
                    }
                }
                else
                    break;
            }
        }

    }
}
