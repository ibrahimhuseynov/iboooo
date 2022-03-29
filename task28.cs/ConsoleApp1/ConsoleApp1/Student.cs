using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal static  class Student
    {
        public static  string FullName { get; set; }    
        public static int Age { get; set; }
        public  static string GroupNo { get; set; }
        public static bool CheckGroupNo( string Grupnomber)
        {
            if (char.IsUpper(Grupnomber[0]))
            {
                if(char.IsDigit(Grupnomber[1]))
                {
                    if (char.IsDigit(Grupnomber[2]))
                    {
                        if (char.IsDigit(Grupnomber[3]))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;   
        }
        public static bool  CheckFullname(this string str)
        {
            for(int i = 0; i < str.Length; i++)
            {
                if (char.IsUpper(str[0]))
                {
                    if(str[i]==' ')
                    {
                        if (char.IsUpper(str[i + 1]))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

    }
     
}
