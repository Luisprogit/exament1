using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

internal class Program
{
    
    public static void ejer2()
    {
        int nota;

        while (true)
        {
            Console.Write("Ingrese una nota (0-20): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out nota))
            {
                if (nota >= 0 && nota <= 20)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Respuesta inválida. La nota debe estar entre 0 y 20.");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero.");
            }
        }

        string clasificacion;

        if (nota >= 0 && nota <= 10)
        {
            clasificacion = "Desaprobado";
            Console.WriteLine($"\nClasificación: {clasificacion}");
            Console.WriteLine("Necesita reforzar.");
        }
        else if (nota >= 11 && nota <= 13)
        {
            clasificacion = "Regular";
            Console.WriteLine($"\nClasificación: {clasificacion}");
            Console.WriteLine("Necesita reforzar.");
        }
        else if (nota >= 14 && nota <= 17)
        {
            clasificacion = "Bueno";
            Console.WriteLine($"\nClasificación: {clasificacion}");
            if (nota % 2 == 0)
            {
                Console.WriteLine("Buen desempeño con nota par.");
            }
        }
        else 
        {
            clasificacion = "Excelente";
            Console.WriteLine($"\nClasificación: {clasificacion}");
            if (nota % 2 == 0)
            {
                Console.WriteLine("Buen desempeño con nota par.");
            }
        }

        double raiz = Math.Sqrt(nota);
        double cubo = Math.Pow(nota, 3);

        Console.WriteLine($"Raíz cuadrada de la nota: {raiz:F1}");
        Console.WriteLine($"La nota al cubo es: {cubo}");
    }

    
    public static void ejer1()
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




















