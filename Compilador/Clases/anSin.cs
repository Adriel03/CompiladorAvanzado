using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador.Clases
{
    public class ElementoPila
    { 
        public int id { get; set; }
        public string operador { set ; get; }

        public ElementoPila()
        {
            id = 0;
            operador = "";
        }
        public ElementoPila(int id, string operador)
        {
            this.id = id;
            this.operador = operador;
        }
    }



    
    public class Pila
    {
        List<ElementoPila> filo;
        public Pila()
        {
        
            filo = new List<ElementoPila>();
            filo.Add(new ElementoPila(2,"$"));
            filo.Add(new ElementoPila(0, "0"));
        }

        public void push(ElementoPila e)
        {
            filo.Add(e);
        }
        public ElementoPila pop()
        {
            ElementoPila res = filo.ElementAt(filo.Count - 1);
            filo.RemoveAt(filo.Count - 1);
            return res;
        }

        public ElementoPila top()
        {
            return filo.ElementAt(filo.Count - 1);
        }
    }
    public class anSin
    {
        private Pila pila;
        private int[,] matriz;
        bool aceptado;
        public List<ElementoPila> elementos;

        public anSin()
        {
            aceptado = false;
            pila = new Pila();
            matriz = new int[5,4];
            elementos = new List<ElementoPila>();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                    matriz[i,j] = 0;
            }

            matriz[0, 0] = 2;
            matriz[0, 3] = 1;
            matriz[1, 2] = -1;
            matriz[2, 1] = 3;
            matriz[2, 2] = -3;
            matriz[3, 0] = 2;
            matriz[3, 3] = 4;
            matriz[4, 2] = -2;
        }

        public void analizar(List<Salida> lista)
        {
            while (!aceptado)
            {
                int res = matriz[pila.top().id, 2];
                
                if (res == 0)
                {
                    aceptado = false;
                    break;
                }
                else if (res == -1)
                {
                    aceptado = true;
                    lista.Add(new Salida(pila.top().operador, "$", "R0"));
                }
                else if (res == -2)
                {
                    r1(lista);
                }
                else if (res == -3)
                {
                    r2(lista);
                }
            }
        }

        public void apilar(ElementoPila entrada, List<Salida> lista)
        {            
            int res = matriz[pila.top().id,entrada.id];
            if (res > 0)
            {
                entrada.id = res;
                pila.push(entrada);
                lista.Add(new Salida(pila.top().operador, entrada.operador, "D" + res.ToString()));
            }
            else if (res == 0)
            {
                aceptado = false;
                lista.Add(new Salida(pila.top().operador, entrada.operador, "Error sintactico"));
            }
            else if(res == -1)
            {
                aceptado=true;
                lista.Add(new Salida(pila.top().operador, entrada.operador, "R0"));
            }
            else if(res == -2)
            {
                r1(lista);
            }else if(res == -3)
            {
                r2(lista);
            }
        }

        public void r1(List<Salida> lista)
        {
            ElementoPila temp =  pila.pop();
            elementos.Add(temp);
            pila.push(new ElementoPila(1, "E1"));
            lista.Add(new Salida(temp.operador, "$", "R1"));
        }

        public void r2(List<Salida> lista)
        {
            ElementoPila temp = pila.pop();
            elementos.Add(temp);
            temp = pila.pop();
            elementos.Add(temp);
            temp = pila.pop();
            elementos.Add(temp);
            pila.push(new ElementoPila(4,"E4"));
            lista.Add(new Salida(temp.operador, "$", "R2"));
        }
    }
}
