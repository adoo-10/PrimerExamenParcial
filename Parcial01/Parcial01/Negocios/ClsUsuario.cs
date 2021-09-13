

using Parcial01.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial01.Negocios
{
    class ClsUsuario
    {
        Usuario usuario = new Usuario();
        Program program = new Program();

        public string funcionAcceso(string nombre, int contraseña)
        {

            if ((nombre == "Adiel Carcamo") && (contraseña == 123 ))
            {
                return "Puede accerder a realizar su compra";
            }
            else
                return "Sus datos son incorrectos";
              
        }

       

    }
}
