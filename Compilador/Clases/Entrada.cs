using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador.Clases
{
    public class Entrada
    {
        private string nombre { set; get; }
        private int tipo { set; get; }
        public Entrada(string nombre, int tipo)
        {
            this.nombre = nombre;
            this.tipo = tipo;
        }

        override public string ToString()
        {
            return nombre + " " + tipo.ToString();
        }
    }
}
