using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5_LFVV_1244416
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num;
            int x = 0;
            Console.WriteLine("Ejercicio 1");
            Console.Write("Ingrese Número Entero: ");
            num = Console.ReadLine();

            if (int.TryParse(num,out x))
            {
                x=Convert.ToInt32(num);
                if (x > 0)
                {
                    Console.WriteLine("Es un número positivo");
                }
                else if (x < 0)
                {
                    Console.WriteLine("Es un número negativo");
                }
                else if (x == 0)
                {
                    Console.WriteLine("Es Cero");
                }
            }
            else
            {
                Console.WriteLine("El valor es una letra");
            }

            int dia;
            Console.WriteLine("\nEjercicio 2");
            Console.Write("Ingrese Número De Día: ");
            dia = int.Parse(Console.ReadLine());
            if (dia <= 0 || dia >7)
            {
                Console.WriteLine("Error: El número a ingresar debe estar contenido entre 1 y 7");
            }
            else if (dia >=1 && dia <= 7)
            {
                switch(dia)
                {
                    case 1:
                        Console.WriteLine("DIA: Lunes");
                        break;
                    case 2:
                        Console.WriteLine("DIA: Martes");
                        break;
                    case 3:
                        Console.WriteLine("DIA: Miércoles");
                        break;
                    case 4:
                        Console.WriteLine("DIA: Jueves");
                        break;
                    case 5:
                        Console.WriteLine("DIA: Viernes");
                        break;
                    case 6:
                        Console.WriteLine("DIA: Sábado");
                        break;
                    case 7:
                        Console.WriteLine("DIA: Domingo");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
