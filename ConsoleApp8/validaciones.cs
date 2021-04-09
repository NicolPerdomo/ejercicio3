using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class validaciones
    {
        static Class1 pant3 = new Class1();
        public bool vacio (string texto)
        {

            if (texto.Equals(""))
             {
                pant3.pantalla3();
                Console.SetCursorPosition(81,11);
                Console.WriteLine("    el campo esta vacio    ");
                return false;
            }
            else
                return true;

        }
        public bool texto(string text)
        {
            Regex regla = new Regex("^[a-zA-Z ]*$");
            if (regla.IsMatch(text))
            {
                return true;
            }

            else
                pant3.pantalla3();
            Console.SetCursorPosition(86,11 );
            Console.WriteLine("  la entrada debe ser texto  ");
            return false;

        }
        public bool numeros (string num)
        {
            Regex regla = new Regex("[0-9]{1,9}(\\.[0-9]{0,2})?$");
            if (regla.IsMatch(num))
            {
                return true;
            }
            else
                Console.SetCursorPosition(80, 11);
            Console.WriteLine("  la entrada debe ser numerica");
            return false;

        }




    }
}
