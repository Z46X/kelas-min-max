  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktikum5
{
    class Program
    {
        static void Main(string[] args)
        {
            kelas kelas1 = new kelas();
            Console.WriteLine("Minimum #1 : {0}", kelas1.FindMinimum(3, 1));
            Console.WriteLine("Minimum #2 : {0}", kelas1.FindMinimum(3, 2, 4));
            Console.WriteLine();
            Console.WriteLine("Maximum #1 : {0}", kelas1.FindMaximum(3, 1));
            Console.WriteLine("Maximum #2 : {0}", kelas1.FindMaximum(3, 2, 4));
            Console.ReadKey();
        }
    }
}
