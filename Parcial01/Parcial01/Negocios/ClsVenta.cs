using Parcial01.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial01.Negocios
{
    class ClsVenta
    {
        Venta venta = new Venta();

        public string funcionCobro(double precio, int cantidad)
        {
           
            double resultado = precio * cantidad;
            if (resultado > 50)
            {
                double descuento = resultado * 0.1;
                double descuentof = resultado - descuento;
                Console.WriteLine("Felicidades, por su compra a recibido descuento del 10% \n" + "El valor de su producto sin descuento es de: $" + resultado + " Con el descuento aplicado el nuevo valor de su producto es de: $" + descuentof);
            }
            else
                return "Su precio a cancelar es de: $" + resultado;

            return null;
        }
    }
}
