using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Department d = new Department("FST", "777");
            Faculty f = new Faculty("Rahim", "98");
            Faculty f2 = new Faculty("karim", "9999");
            Faculty f3 = new Faculty("Barun", "0087");
            Faculty f4 = new Faculty("ROY", "007");
            Faculty f5 = new Faculty("Upal", "5678");
            d.AddFaculty(f, f2, f3, f4, f5);
            d.ShowAllFaculty();
            d.RemoveFaculty(f3);
            Console.WriteLine();
            d.ShowAllFaculty();


        }
    }
}
