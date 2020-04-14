using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class maxRepeating
    {
        static char maxRepeatingTest(string str)
        {
            int len = str.Length;
            int count = 0;
            char res = str[0];

            // Find the maximum repeating  
            // character starting from str[i] 
            for (int i = 0; i < len; i++)
            {
                int cur_count = 1;
                for (int j = i + 1; j < len; j++)
                {
                    if (str[i] != str[j])
                        break;
                    cur_count++;
                }

                // Update result if required 
                if (cur_count > count)
                {
                    count = cur_count;
                    res = str[i];
                }
            }
            return res;
        }
    }
}
