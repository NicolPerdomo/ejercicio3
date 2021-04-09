using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace ConsoleApp8
{
    class Program
    {
        static List<estudiante> ListaEstudiantes = new List<estudiante>();
        static Class1 posicion = new Class1();
         static validaciones val = new validaciones();
        static metodo met = new metodo();
        static void Main(string[] args)

        {
            int opcion;
            string aux;
            bool valido=false;
            do

            {

                Console.Clear();
                posicion.pantalla();
                Console.SetCursorPosition(45, 2);
            Console.WriteLine("1.agregar estudiantes");
                Console.SetCursorPosition(45, 4);
                Console.WriteLine("2.listar estudiantes");
                Console.SetCursorPosition(45, 6);

                Console.WriteLine("3.buscar estudiantes");
                Console.SetCursorPosition(45, 10);
                Console.WriteLine("4.guardar estudiantes");
                Console.SetCursorPosition(45, 12);
                Console.WriteLine("5.cargar estudiantes");
                Console.SetCursorPosition(50, 16);
                Console.WriteLine("0.salir");
                do
                {
                    Console.SetCursorPosition(45, 20);
                    Console.WriteLine("digite una opcion");
                    Console.SetCursorPosition(45, 21);
                    aux =Console.ReadLine();
                    if (val.vacio(aux))
                        if(val.numeros(aux))
                        valido = true;
                   
                } while (!valido);

                opcion = Convert.ToInt32(aux);

            switch (opcion)
            {
                case 1:
                    met.agregar();
                    break;
                case 2:
                    met.listar();
                    break;
                case 3:
                    met.buscar();
                    break;
                case 5:
                        LeerXml();
                        break;
                case 4:
                        EscribirXml();
                        break;



                case 0:
                        Console.SetCursorPosition(45, 22);
                        Console.WriteLine("saliendo de la aplicacion");
                        break;
                
                default:
                        Console.SetCursorPosition(45, 22);
                        Console.WriteLine("opcion no valida") ;

                    break;
            }
                Console.SetCursorPosition(45, 23);
                Console.WriteLine("presione enter para continuar...");
                Console.ReadKey();
            } while (opcion!=0);

        }
        static void EscribirXml()
        {
            XmlSerializer codificador = new XmlSerializer(typeof(List<estudiante>));
            TextWriter escribirXml = new StreamWriter("D:/net/listaEstudiantes.xml");
            codificador.Serialize(escribirXml, ListaEstudiantes);
            escribirXml.Close();

            Console.SetCursorPosition(49, 23); Console.WriteLine("Archivo Guardado");
        }

        static void LeerXml()
        {
            ListaEstudiantes.Clear();
            if (File.Exists("D:/net/listaEstudiantes.xml"))
            {
                XmlSerializer codificador = new XmlSerializer(typeof(List<estudiante>));
                FileStream leerXml = File.OpenRead("D:/net/listaEstudiantes.xml");
                ListaEstudiantes = (List<estudiante>)codificador.Deserialize(leerXml);
                leerXml.Close();
            }
            Console.SetCursorPosition(49, 23); Console.WriteLine("Archivo Cargado");
        }
    }
}
