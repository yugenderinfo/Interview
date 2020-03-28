using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class reverse
    {
        // revers number 
        public void reverseNumber()
        {
            Console.WriteLine("Enter a No. to reverse");
            int Number = int.Parse(Console.ReadLine());
            int Reverse = 0;
            while (Number > 0)
            {
                int remainder = Number % 10;
                Reverse = (Reverse * 10) + remainder;
                Number = Number / 10;
            }
            Console.WriteLine("Reverse No. is {0}", Reverse);

        }

        // Reverse String 
        public void stringreverse()
        {
            string str = "", reverse = "";
            int Length = 0;
            Console.WriteLine("Enter a Word");
            //Getting String(word) from Console  
            str = Console.ReadLine();
            //Calculate length of string str  
            Length = str.Length - 1;
            while (Length >= 0)
            {
                reverse = reverse + str[Length];
                Length--;
            }
            //Displaying the reverse word  
            Console.WriteLine("Reverse word is {0}", reverse);
            Console.ReadLine();
        }

    }
}
