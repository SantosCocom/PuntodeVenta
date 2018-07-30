using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herramientas
{
    public static class Validaciones
    {
       
        public static char valida(string tipo, char caracter)
        {
             string cadenavalida="";
            
            tipo= tipo.ToUpper();
            char x = '\0';
           
            switch (tipo)
            {
                case "N":
                    cadenavalida = "0123456789'\b'";
                    break;
                case "T":
                    cadenavalida = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ'\b'' '";
                    break;
                case "U":
                    cadenavalida = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ0123456789'\b'' '";
                    break;
                case "B":
                    cadenavalida = "01";
                    break;


                    

            }


            if (cadenavalida.Contains(caracter))
            {
                x=caracter;

            }
            return char.ToUpper(x);
            

        }


        public static char validaReal(TextBox txtGenerico, char caracter)
        { 
             string cadenavalida="";
            
            
            char x = '\0';
            string aux = txtGenerico.Text;
            if (aux.Contains("."))
                  cadenavalida = "0123456789\b";
            else
                cadenavalida = "0123456789\b.";



            if (cadenavalida.Contains(caracter))
            {
                x = caracter;

            }
            return char.ToUpper(x);

        }

        public static char validaCorreo(TextBox txtGenerico, char caracter)
        {
            string cadenavalida = "";


            char x = '\0';
            string aux = txtGenerico.Text;
            if (aux.Contains("@"))
                cadenavalida = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ0123456789\b.";
            else
                cadenavalida = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ0123456789\b.@";



            if (cadenavalida.Contains(caracter))
            {
                x = caracter;

            }
            return char.ToUpper(x);

        }
        
    }
}

