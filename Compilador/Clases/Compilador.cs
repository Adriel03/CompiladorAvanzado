using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador.Clases
{
    public  class Comp
    {
        public anLex lexico;
        public anSin sintactico;
        public List<Salida> salidas;
        public Comp()
        {
            lexico = new anLex();
            sintactico = new anSin();
            salidas = new List<Salida>();
        }

        public void analizar(string cadena)
        {
            lexico.analizar(cadena, sintactico, salidas);
        }
    }
}
