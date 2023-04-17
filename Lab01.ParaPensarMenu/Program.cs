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
            string opc;
            do
            {
                Console.Write("Elija un ejercicio del 1 al 9: ");
                opc = Console.ReadLine();
                switch (opc)
                {
                    case "1":
                        ejercicio1();
                        break;
                    case "2":
                        ejercicio2();
                        break;
                    case "3":
                        ejercicio3();
                        break;
                    default:
                        break;
                }

            } while (opc != "0");



        }

        public static void ejercicio3()
        {
            int numero_pre = 0;
            int numero = 1;
            int suma = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write(numero + " ");
                suma = numero + numero_pre;
                numero_pre = numero;
                numero = suma;


            }
        }
        public static void ejercicio1()
        {
            Console.Write("Ingrese un numero: ");
            int numero1 = int.Parse(System.Console.ReadLine());
            Console.Write("Ingrese otro numero: ");
            int numero2 = int.Parse(System.Console.ReadLine());
            int resultado = numero1 + numero2;

            System.Console.WriteLine("El resultado de la suma de " + numero1 + " y " + numero2 + " es " + resultado);
        }

        public static void ejercicio2()
        {
            Console.Write("Ingrese un año: ");
            int anio = int.Parse(Console.ReadLine());

            if (anio % 4 == 0 && (anio % 100 != 0 || anio % 400 == 0))
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
