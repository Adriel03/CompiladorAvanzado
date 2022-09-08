using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador.Clases
{

    public class Lexema
    {
        public string simbolo { set; get; }
        public int tipo { set; get; }
        public string ejemplo { set; get; }

        public Lexema(string simbolo, int tipo, string ejemplo)
        {
            this.simbolo = simbolo;
            this.tipo = tipo;
            this.ejemplo = ejemplo;
        }
        public Lexema()
        {
            simbolo = "";
            tipo = 0;
            ejemplo = "";
        }
        public static bool sim1(char c)
        {
            if (c == '+' || c == '-' || c == '*' || c == '/' || c == ',' || c == ';'
                ||c == '{'|| c =='}'|| c=='('||c==')'||c=='$')
                return true;
            else return false;
        }

        public static bool sim2(char c)
        {
            if (c == '&' || c == '|' )
                return true;
            else return false;
        }

        public static bool sim3(char c)
        {
            if (c == '<' || c == '>' || c == '=' || c == '!' )
                return true;
            else return false;
        }

        public static bool sim(char c)
        {
            if (sim1(c) || sim2(c) || sim3(c)) return true;
            else return false;
        }

<<<<<<< HEAD
        public void clasificar(string cadena, bool numero, bool punto, anSin sin, List<Salida> lista)
=======
        public void clasificar(string cadena, bool numero, bool punto)
>>>>>>> 01eea31e66e6daebeef2051cd739b3cb466e6d4e
        {
            if (numero == true)
            {
                if (punto == true)
                {
                    simbolo = "real";
                    ejemplo = cadena;
                    tipo = 1;
                }
                else


                {
                    simbolo = "entero" +
                        "";
                    ejemplo = cadena;
                    tipo = 2;
                }
            }
            else if (cadena == "$")
            {
                simbolo = cadena;
                tipo = 23;
<<<<<<< HEAD
                sin.apilar(new ElementoPila(2,cadena),lista);
=======
>>>>>>> 01eea31e66e6daebeef2051cd739b3cb466e6d4e
            } else if (cadena == "else")
            {
                simbolo = cadena;
                tipo = 22;
            } else if (cadena == "return")
            {
                simbolo = cadena;
                tipo = 21;
            }else if (cadena == "while")
            {
                simbolo = cadena;
                tipo = 20;
            }else if (cadena == "if")
            {
                simbolo = cadena;
                tipo = 19;
            }else if (cadena == "=")
            {
                simbolo = cadena;
                tipo = 18;
            }else if (cadena == "{")
            {
                simbolo = cadena;
                tipo = 17;
            } else if (cadena == "}")
            {
                simbolo = cadena;
                tipo = 16;
            } else if (cadena == "(")
            {
                simbolo = cadena;
                tipo = 15;
            } else if (cadena == ")")
            {
                simbolo = cadena;
                tipo = 14;
            } else if (cadena == ",")
            {
                simbolo = cadena;
                tipo = 13;
            }else if (cadena == ";")
            {
                simbolo = cadena;
                tipo = 12;
            }else if (cadena == "=="||cadena=="!=")
            {
                simbolo = "opIgualdad";
                ejemplo = cadena;
                tipo = 11;
            }else if (cadena == "!")
            {
                simbolo = "opNot";
                ejemplo = cadena;
                tipo = 10;
            }else if (cadena == "&&")
            {
                simbolo = "opAnd";
                ejemplo = cadena;
                tipo = 9;
            }else if (cadena == "||")
            {
                simbolo = "opOr";
                ejemplo = cadena;
                tipo = 8;
            }else if (cadena == "<"||cadena==">"||cadena == "<="||cadena == ">=")
            {
                simbolo = "opRelac";
                ejemplo = cadena;
                tipo = 7;
            }else if (cadena == "*"||cadena == "/")
            {
                simbolo = "opMul";
                ejemplo = cadena;
                tipo = 6;
            }else if (cadena == "+"||cadena == "-")
            {
                simbolo = "opSuma";
                ejemplo = cadena;
                tipo = 5;
<<<<<<< HEAD
                sin.apilar(new ElementoPila(1,cadena),lista);
=======
>>>>>>> 01eea31e66e6daebeef2051cd739b3cb466e6d4e
            }else if (cadena == "int"||cadena == "float"||cadena == "void"||cadena=="char"||cadena=="bool"||cadena=="string")
            {
                simbolo = "tipo";
                ejemplo = cadena;
                tipo = 4;
            }else if (cadena[0] == '"')
            {
                simbolo = "cadena";
                ejemplo = cadena;
                tipo = 3;
            }
            else
            {
                simbolo = "identificador";
                ejemplo = cadena;
                tipo = 0;
<<<<<<< HEAD
                sin.apilar(new ElementoPila(0,cadena), lista);
=======
>>>>>>> 01eea31e66e6daebeef2051cd739b3cb466e6d4e
            }
        }

        public static bool blanco(char c)
        {
            if (c == ' ' || c == 13 || c == '\t'|| c=='\0'|| c==10) return true;
            else return false;
        }
    }

<<<<<<< HEAD
    public class anLex
=======
    internal class anLex
>>>>>>> 01eea31e66e6daebeef2051cd739b3cb466e6d4e
    {
        public List<Lexema> lexemas;
        public anLex()
        {
            lexemas = new List<Lexema>();
        }
<<<<<<< HEAD
        public void analizar(string cadena, anSin sin, List<Salida> lista)
=======

        public void analizar(string cadena)
>>>>>>> 01eea31e66e6daebeef2051cd739b3cb466e6d4e
        {
            string estado = "", palabra = "";
            cadena += ' ';
            int fin = cadena.Length, i=0;
            bool entero = false, decim = false;
            while(i<fin)
            {
                if (estado == "")
                {
                    if (Lexema.blanco(cadena[i]))
                    {
                        estado = "";
                        i++;
                    }
                    else if (char.IsLetter(cadena[i]))
                        estado = "Ql";
                    else if (char.IsDigit(cadena[i]))
                        estado = "Qn";
                    else if (Lexema.sim1(cadena[i]))
                        estado = "Qs1";
                    else if (Lexema.sim2(cadena[i]))
                        estado = "Qs2";
                    else if (Lexema.sim3(cadena[i]))
                        estado = "Qs4";
                    else if (cadena[i] == '"')
                        estado = "Qc";
                    else estado = "Qe";
                }
                else if (estado == "Ql")
                {
                    if (char.IsLetterOrDigit(cadena[i]))
                        estado = "Ql";
                    else if (Lexema.sim(cadena[i]) ||
                        Lexema.blanco(cadena[i]))
                        estado = "Qi";
                    else estado = "Qe";
                } else if (estado == "Qn")
                {
                    entero = true;
                    if (char.IsLetter(cadena[i]))
                        estado = "Qe";
                    else if (char.IsDigit(cadena[i]))
                        estado = "Qn";
                    else if (cadena[i] == '.')
                        estado = "Q.";
                    else if (Lexema.sim(cadena[i]) ||
                        Lexema.blanco(cadena[i]))
                        estado = "Qi";
                    else estado = "Qe";
                } else if (estado == "Q.")
                {
                    decim = true;
                    if (char.IsDigit(cadena[i]))
                        estado = "Q.";
                    else if (Lexema.sim(cadena[i]) ||
                        Lexema.blanco(cadena[i]))
                        estado = "Qi";
                    else estado = "Qe";
                } else if (estado == "Qs1")
                {
                    if (char.IsLetterOrDigit(cadena[i]) ||
                        Lexema.sim(cadena[i]) ||
                        Lexema.blanco(cadena[i]))
                        estado = "Qi";
                    else estado = "Qe";
                } else if (estado == "Qs2")
                {
                    if (Lexema.sim2(cadena[i]))
                        estado = "Qs3";
                    else
                        estado = "Qe";
                } else if (estado == "Qs3")
                {
                    if (Lexema.sim(cadena[i]) ||
                        char.IsLetterOrDigit(cadena[i]) ||
                        Lexema.blanco(cadena[i]))
                        estado = "Qi";
                    else estado = "Qe";
                } else if (estado == "Qs4")
                {
                    if (cadena[i] == '=')
                        estado = "Q5";
                    else if (char.IsLetterOrDigit(cadena[i]) ||
                        Lexema.sim(cadena[i]) ||
                        Lexema.blanco(cadena[i]))
                        estado = "Qi";
                    else estado = "Qe";
                } else if (estado == "Qs5")
                {
                    if (char.IsLetterOrDigit(cadena[i]) ||
                        Lexema.sim(cadena[i]) ||
                        Lexema.blanco(cadena[i]))
                        estado = "Qi";
                    else estado = "Qe";
                } else if (estado == "Qc")
                {
                    if (cadena[i] == '"')
                        estado = "Qi";
                    else estado = "Qc";
                } else if (estado == "Qi")
                {
                    Lexema temp = new Lexema();
<<<<<<< HEAD
                    temp.clasificar(palabra, entero, decim, sin, lista);
=======
                    temp.clasificar(palabra, entero, decim);
>>>>>>> 01eea31e66e6daebeef2051cd739b3cb466e6d4e
                    lexemas.Add(temp);
                    palabra = "";
                    estado = "";
                    entero = false;
                    decim = false;
                }
                else if (estado == "Qe") {
                    i++;
                }

                
                if (i<fin&& estado != "Qi" && estado != "")
                {
                    if (!Lexema.blanco(cadena[i])) palabra += cadena[i];
                    i++;
                }
            }
<<<<<<< HEAD
            sin.analizar(lista);
=======
>>>>>>> 01eea31e66e6daebeef2051cd739b3cb466e6d4e
        }

    }
}
