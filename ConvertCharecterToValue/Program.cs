using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertCharecterToValue
{
    class Program
    {
        static void Main(string[] args)
        {
            char charecter;
            int value;
            charecter = Convert.ToChar(Console.ReadLine());
            value = Convert.ToInt32(charecter);
            Console.WriteLine(value);
            Console.ReadKey();

        }
    }
}
