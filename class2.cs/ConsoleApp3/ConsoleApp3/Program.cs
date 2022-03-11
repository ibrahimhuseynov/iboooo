using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product prd=new Product();
            prd.name = "kartof";
            prd.BrandName = "bakY";
            prd.price = 0.80;
            Product prd1=new Product();
            prd.name = "sogan";
            prd.BrandName = "ismayilli";
            prd.price = 0.5;
        }
        static string[] arry(double min = 0, double max = 10)
        {
            Product[] array = new Product[2];
            for (int i = 0; i < array.Length; i++)
            {
               if(array[i] < min)
            }
        }
    }
}
