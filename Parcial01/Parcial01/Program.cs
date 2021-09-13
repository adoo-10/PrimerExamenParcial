using Parcial01.Entidades;
using Parcial01.Negocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PROCESO DE REGISTRO NECESARIO.");
            Console.WriteLine("Escriba su nombre. ");
            string nombre = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Escriba su contraseña. ");
            int contraseña = Convert.ToInt32(Console.ReadLine());

            Usuario usuario = new Usuario(nombre, contraseña);
            ClsUsuario clsUsuario = new ClsUsuario();
            Console.WriteLine(clsUsuario.funcionAcceso(nombre, contraseña));
            Console.WriteLine(usuario.ToString());
            

            if ((nombre == "Adiel Carcamo") && (contraseña == 123))
            {
                int x = 1;
                while (x == 1)
                {
                    Console.WriteLine("PROCESO DE COMPRA");
                    Console.WriteLine("Ingrese el id de su producto: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese el nombre de su producto: ");
                    string nombrep = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Ingrese la descripcion de su producto: ");
                    string descripcion = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Ingrese el precio de su producto: ");
                    double precio = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese la cantidad que adquirio de producto: ");
                    int cantidad = Convert.ToInt32(Console.ReadLine());

                    Venta venta = new Venta(id, nombrep, descripcion, precio, cantidad);
                    ClsVenta clsVenta = new ClsVenta();
                    Console.WriteLine(clsVenta.funcionCobro(precio, cantidad));
                    Console.WriteLine(venta.ToString());

                }
            }
            else
                Console.WriteLine("Para realizar la compra sus datos deben de ser correctos. ");
            Console.WriteLine("Presione cualquier tecla e inicie de nuevo su proceso de registro. ");
            Console.ReadLine();


        }
    }
}
