using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_Parcial_IV
{
    class Program
    {
        static void Main(string[] args)
        {
            Compra cmp = new Compra();

            Console.Write("Ingrese el monto de la compra: ");
            cmp.monto_compra = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Monto de la compra y descuento\n");

            
            cmp.ImprimirCondicion((monto) => monto >= 10000 &&  monto <= 20000, cmp.desc=0.10m);

            cmp.ImprimirCondicion((monto) => monto >= 20001 && monto <= 50000, cmp.desc = 0.30m);

            cmp.ImprimirCondicion((monto) => monto > 50000, cmp.desc = 0.50m);

            Console.ReadKey();
        }
    }
}
