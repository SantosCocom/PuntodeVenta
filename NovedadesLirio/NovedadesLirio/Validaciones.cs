using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herramientas
{
    class Validaciones
    {
       
        public char valida(string tipo, char caracter)
        {
             string cadenavalida="";
            
            tipo= tipo.ToUpper();
            char x = '\0';
           
            switch (tipo)
            {
                case "N":
                    cadenavalida = "0123456789\b";
                    break;
                case "T":
                    cadenavalida = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ\b ";
                    break;
                case "U":
                    cadenavalida = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ0123456789\b ";
                    break;
                case "B":
                    cadenavalida = "01\b";
                    break;
				case "G":
                    cadenavalida = "abcdABCD\b";
                    break;

                    

            }


            if (cadenavalida.Contains(caracter))
            {
                x=caracter;

            }
            return char.ToUpper(x);
            

        }
    }
}

