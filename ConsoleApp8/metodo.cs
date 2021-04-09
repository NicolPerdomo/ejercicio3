using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp8
{
    class metodo
    {
        static Class1 pant = new Class1();
        public List<estudiante> ListaEstudiantes = new List<estudiante>();
        static validaciones val = new validaciones();
        public void agregar()
        {


            Console.Clear();
            pant.pantalla2();

            double no1, no2, no3, noFinal;
            bool validoNombre = false, ValidoCorreo = false, ValidoCodigo = false, ValidoNot1 = false, ValidoNot2 = false, ValidoNot3 = false;
            string nombre, correo, codigo, nota1, nota2, nota3;
            
            do
            {
                Console.SetCursorPosition(35, 2);
                Console.WriteLine("digite el nombre del estudiante");
                Console.SetCursorPosition(45, 3); nombre =Console.ReadLine();
                if (val.vacio(nombre))
                    if(val.texto(nombre))
                    validoNombre = true;
        } while (!validoNombre);


            do {
                Console.SetCursorPosition(35, 7);
                Console.WriteLine("digite el correo del estudiante");
                Console.SetCursorPosition(45, 8); correo = Console.ReadLine();
                if (val.vacio(correo))
                    if (val.texto(correo))
                        ValidoCorreo = true;
            } while (!ValidoCorreo);


            do {
                Console.SetCursorPosition(35, 12);
                Console.WriteLine("digite el codigo del estudiante");
                Console.SetCursorPosition(45, 13); codigo = Console.ReadLine();
                if (val.vacio(codigo))
                    if (val.numeros(codigo))
                        ValidoCodigo = true;
            } while (!ValidoCodigo);

            do
            {
                Console.SetCursorPosition(35, 17);
                Console.WriteLine("digite nota 1 del estudiante");
                Console.SetCursorPosition(45, 18); nota1 =(Console.ReadLine());
                if (val.vacio(nota1))
                    if (val.numeros(nota1))
                        ValidoNot1 = true;
            } while (!ValidoNot1);
            no1 = double.Parse(nota1);
            do
            {
                Console.SetCursorPosition(35, 22);
                Console.WriteLine("digite nota 2 del estudiante");
                Console.SetCursorPosition(45, 23); nota2 =(Console.ReadLine());
                if (val.vacio(nota2))
                    if (val.numeros(nota2))
                        ValidoNot2 = true;
            } while (!ValidoNot2);
            no2 = double.Parse(nota2);
            do
            {
                Console.SetCursorPosition(35, 27);
                Console.WriteLine("digite nota 3 del estudiante");
                Console.SetCursorPosition(45, 28); nota3 = (Console.ReadLine());
                if (val.vacio(nota3))
                    if (val.numeros(nota3))
                        ValidoNot3 = true;
            } while (!ValidoNot3);
            no3 = double.Parse(nota3);
            noFinal = (no1 + no2 + no3) / 3;
            estudiante Student = new estudiante();
            Student.Codigo = Convert.ToInt32(codigo);
            Student.Nombre=nombre;
            Student.Correo = correo;
            Student.Nota1 = no1;
            Student.Nota2 = no2;
            Student.Nota3 = no3;
            Student.NotaFin = Math.Round(noFinal, 1);
            if (noFinal >= 3.5)
                Student.Aprobado = true;
            else
                Student.Aprobado = false;
            ListaEstudiantes.Add(Student);


        }
        public void listar()
        {
            int y=6;
            Console.Clear();
            Console.WriteLine("listar");
            Console.SetCursorPosition(2, 5); Console.Write("Codigo");
            Console.SetCursorPosition(11, 5); Console.Write("Nombre");
            Console.SetCursorPosition(38, 5); Console.Write("Correo");
            Console.SetCursorPosition(61, 5); Console.Write("Nota 1");
            Console.SetCursorPosition(70, 5); Console.Write("Nota 2");
            Console.SetCursorPosition(79, 5); Console.Write("Nota 3");
            Console.SetCursorPosition(88, 5); Console.Write("Nota Final");
            Console.SetCursorPosition(101, 5); Console.Write("Aprobado");
            foreach (estudiante itemEstudiante in ListaEstudiantes)
            {
                y++;

                Console.SetCursorPosition(3, y); Console.Write(itemEstudiante.Codigo);
                Console.SetCursorPosition(10, y); Console.Write(itemEstudiante.Nombre);
                Console.SetCursorPosition(37, y); Console.Write(itemEstudiante.Correo);
                Console.SetCursorPosition(63, y); Console.Write(itemEstudiante.Nota1);
                Console.SetCursorPosition(72, y); Console.Write(itemEstudiante.Nota2);
                Console.SetCursorPosition(81, y); Console.Write(itemEstudiante.Nota3);
                Console.SetCursorPosition(91, y); Console.Write(itemEstudiante.NotaFin);
                Console.SetCursorPosition(102, y); Console.Write(itemEstudiante.Aprobado);
            }
        }
        public void buscar()
        {
            string codigo;
            bool codigoValido=false;
            Console.WriteLine("buscar");
            do
            {
                Console.Clear();
                pant.pantalla4();
                Console.SetCursorPosition(26,8);
                Console.WriteLine("digite el codigo del estudiante que que desea buscar");
                Console.SetCursorPosition(50, 10); codigo = Console.ReadLine();
                if (val.vacio(codigo))
                    if (val.numeros(codigo))
                        codigoValido = true;
            } while (!codigoValido);
            int y = 6;
            if (existe(Convert.ToInt32(codigo)))
            {
                Console.Clear();
                Console.WriteLine("estudiante encontrado");
                Console.SetCursorPosition(2, 5); Console.Write("Codigo");
                Console.SetCursorPosition(11, 5); Console.Write("Nombre");
                Console.SetCursorPosition(38, 5); Console.Write("Correo");
                Console.SetCursorPosition(61, 5); Console.Write("Nota 1");
                Console.SetCursorPosition(70, 5); Console.Write("Nota 2");
                Console.SetCursorPosition(79, 5); Console.Write("Nota 3");
                Console.SetCursorPosition(88, 5); Console.Write("Nota Final");
                Console.SetCursorPosition(101, 5); Console.Write("Aprobado");

                foreach (estudiante itemEstudiante in ListaEstudiantes)
                {
                    y++;
                    estudiante student = obtenerDatos(Convert.ToInt32(codigo));
                    Console.SetCursorPosition(3, y); Console.Write(itemEstudiante.Codigo);
                    Console.SetCursorPosition(10, y); Console.Write(itemEstudiante.Nombre);
                    Console.SetCursorPosition(37, y); Console.Write(itemEstudiante.Correo);
                    Console.SetCursorPosition(63, y); Console.Write(itemEstudiante.Nota1);
                    Console.SetCursorPosition(72, y); Console.Write(itemEstudiante.Nota2);
                    Console.SetCursorPosition(81, y); Console.Write(itemEstudiante.Nota3);
                    Console.SetCursorPosition(91, y); Console.Write(itemEstudiante.NotaFin);
                    Console.SetCursorPosition(102, y); Console.Write(itemEstudiante.Aprobado);
                }
            }
            else
                Console.SetCursorPosition(42, 12);
            Console.WriteLine("no se encontro estudiante");


            

            
        }

        public bool existe(int codigo)
        {
            bool aux = false;
            foreach(estudiante item in ListaEstudiantes)
            {
                if (item.Codigo == codigo)
                    return aux = true;
            }
            return aux;

        }
        public estudiante obtenerDatos  (int codigo)
        {
            foreach (estudiante itemEstudiante in ListaEstudiantes)
            {
                if (itemEstudiante.Codigo == codigo)
                    return itemEstudiante;


            }   return null; 
        }
       


    }




}
