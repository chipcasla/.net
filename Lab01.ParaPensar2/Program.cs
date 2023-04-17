using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01.ParaPensar2
{
    class Program
    {
        static void Main(string[] args)
        {
            int anio = int.Parse(Console.ReadLine());

            if (anio % 4 == 0 && (anio % 100 != 0 || anio % 400 == 0) )
            {
                Console.WriteLine("Este año es bisiesto");

            }
            else
            {

                Console.WriteLine("Año no bisiesto");
            }



            
        }
    }
}
