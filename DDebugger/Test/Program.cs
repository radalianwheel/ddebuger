using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
            Task.Run(() =>
            {
                throw new Exception("HAHAHAH");
            });
            while (true)
            {
                Console.ReadKey();
            }
        }
    }
}
