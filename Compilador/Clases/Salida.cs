using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador.Clases
{
    public class Salida
    {
        public string pila { get; set; }
        public string entrada { get; set; }
        public string sale { get; set; }
        public Salida(string pila, string entrada, string sale)
        {
            this.pila = pila;
            this.entrada = entrada;
            this.sale = sale;
        }   
    }
}
