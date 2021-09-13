using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial01.Entidades
{
    class Venta
    {
        private int id;
        private string nombrep;
        private string descripcion;
        private double precio;
        private int cantidad;

        public int Id { get => id; set => id = value; }
        public string Nombrep { get => nombrep; set => nombrep = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }

        public Venta(int id, string nombrep, string descripcion, double precio, int cantidad)
        {
            this.Id = id;
            this.Nombrep = nombrep;
            this.Descripcion = descripcion;
            this.Precio = precio;
            this.Cantidad = cantidad;
        }

        public Venta() { }

        public override string ToString()
        {
            return "El nombre de su producto es : " + nombrep +
                "\nEl id de su producto es: " + id +
                "\nSu descripcion es: " + descripcion +
                "\nCon un precio de $: " + precio +
                "\nCompro: " + cantidad + " unidades";
        }


    }
        
    
}
