using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_Parcial_IV
{
    public delegate bool compara(decimal dato);
    class Compra
    { 
        public decimal monto_compra { get; set; }

        public decimal descuento { get; set; }

        public decimal desc{ get; set; }
        public decimal monto_total { get; set; }


        public void ImprimirCondicion(compara comp, decimal desc)
        {
            if (comp(monto_compra))
            {
                
                descuento = monto_compra * desc;
                monto_total = monto_compra - descuento;
                Console.WriteLine("Monto de la compra: {0},   Descuento:{1}", monto_compra, descuento, "\n");
                Console.WriteLine("\nMonto total a pagar: {0} ", monto_total);
            }
        }
    }

   
   
    
    
}
