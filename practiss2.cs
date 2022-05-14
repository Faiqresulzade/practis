using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practis2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(master());
        }
          static bool master() 
          {
            Console.Write("birinci ededi daxil edin: ");
            string astr = Console.ReadLine();
            int a = int.Parse(astr);
            bool result = false;

            if (a % 21 ==0)
            {
                result = true;
                return result;

            }
            return result;
           
          }
    }
}
