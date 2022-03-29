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
            do
            {
                Console.WriteLine("FullName daxil edin :");
                Student.FullName=Console.ReadLine();
                
            } while (!Student.CheckFullname(Student.FullName));
            do
            {
                Console.WriteLine("GroupNo daxil edin :");
               Student.GroupNo=Console.ReadLine();

            }while(!Student.CheckGroupNo(Student.GroupNo));  
            Console.WriteLine("Age daxil edin :");
            Student.Age=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("FullName :" + Student.FullName);
            Console.WriteLine("GruoNo :" + Student.GroupNo);
            Console.WriteLine("Age :" + Student.Age);
            Console.ReadLine();

        }
    }
}
