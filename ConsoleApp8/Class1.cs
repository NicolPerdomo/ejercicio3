using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Class1
    {
        public void pantalla()
        {
            for (int i = 25; i <= 80; i++)
            {
                Console.SetCursorPosition(i, 0); Console.Write("▒");
                Console.SetCursorPosition(i, 8); Console.Write("═");
                Console.SetCursorPosition(i, 14); Console.Write("═");
                Console.SetCursorPosition(i, 18); Console.Write("═");
                Console.SetCursorPosition(i, 25); Console.Write("▒");


            }
            for (int i = 0; i <= 25; i++)

            {
                Console.SetCursorPosition(25, i); Console.Write("░");
                Console.SetCursorPosition(80, i); Console.Write("░");

            }



        }

        public void pantalla2()
        {
            for (int i = 25; i <= 80; i++)
            {

                Console.SetCursorPosition(i, 0); Console.Write("▒");
                Console.SetCursorPosition(i, 5); Console.Write("═");
                Console.SetCursorPosition(i, 10); Console.Write("═");
                Console.SetCursorPosition(i, 15); Console.Write("═");
                Console.SetCursorPosition(i, 20); Console.Write("═");
                Console.SetCursorPosition(i, 25); Console.Write("═");
                Console.SetCursorPosition(i, 30); Console.Write("▒");


            }
            for (int i = 0; i <= 30; i++)

            {
                Console.SetCursorPosition(25, i); Console.Write("░");
                Console.SetCursorPosition(80, i); Console.Write("░");

            }
        }
            public void pantalla3()
            {
                for (int i = 81; i <= 115; i++)
                {

                    Console.SetCursorPosition(i, 10); Console.Write("▒");
                    Console.SetCursorPosition(i, 12); Console.Write("▒");


                }
                for (int i = 10; i <= 12; i++)

                {
                    Console.SetCursorPosition(81,i); Console.Write("░");
                    Console.SetCursorPosition(115,i); Console.Write("░");


                }


            }
        public void pantalla4()
        {
            for (int i = 25; i <= 80; i++)
            {

                Console.SetCursorPosition(i,0 ); Console.Write("▒");
                Console.SetCursorPosition(i, 25); Console.Write("▒");


            }
            for (int i = 0; i <= 25; i++)

            {
                Console.SetCursorPosition(25, i); Console.Write("░");
                Console.SetCursorPosition(80, i); Console.Write("░");


            }


        }
    }

    }


