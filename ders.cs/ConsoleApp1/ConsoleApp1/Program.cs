using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Ayin adini daxil edin :");
            string ad=Convert.ToString(Console.ReadLine());
            switch (ad)
            {
                case "yanvar":
                    Console.WriteLine("31");
                    break;
                case "fevral":
                    Console.WriteLine("28");
                    break;
                case "mart":
                    Console.WriteLine("31");
                    break;
                case "aprel":
                    Console.WriteLine("30");
                    break;
                case "may":
                    Console.WriteLine("31");
                    break;
                case "iyun":
                    Console.WriteLine("30");
                    break;
                case "iyul":
                    Console.WriteLine("31");
                    break;
                case "avqust":
                    Console.WriteLine("31");
                    break;
                case "sentiyabr":
                    Console.WriteLine("30");
                    break;
                case "oktyabr":
                    Console.WriteLine("31");
                    break;
                case "noyabr":
                    Console.WriteLine("30");
                    break;
                case "dekabr":
                    Console.WriteLine("31");
                    break;
                        default:
                    Console.WriteLine("bele bir ay yoxdur :" );
                    break;
            }
            Console.Read(); 
        }
    }
}
