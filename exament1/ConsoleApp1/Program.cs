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
            Console.Write("Ingrese el precio del producto: ");
            double precio = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el código de descuento (1=Estudiante, 2=Empleado, 3=Cliente frecuente): ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            double descuento = 0;

            if (codigo == 1)
            {
                descuento = 0.10; 
            }
            else if (codigo == 2)
            {
                descuento = 0.15;
            }
            else if (codigo == 3)
            {
                descuento = 0.20; 
            }
            else
            {
                Console.WriteLine("Código inválido. No se aplicará descuento.");
                return; 
            }

            double precio_final = precio - (precio * descuento);

            if (precio > 500)
            {
                precio_final = precio_final - (precio_final * 0.05);
            }

            Console.WriteLine("El precio final a pagar es: " + precio_final.ToString("F2"));
        }
    }
}
