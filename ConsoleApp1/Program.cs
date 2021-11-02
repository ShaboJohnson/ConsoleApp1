using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int a = 0;
                do
                {
                    string s1 = null;
                    Clear();
                    Write("\n\n\t-------------------------------\n");
                    Write("\t------ Menú de opciones -------\n");
                    Write("\t-------------------------------\n\n\n");
                    Write("\t1) Mostrar pelicula\n\n" + "\t2) Inventario\n\n" + "\t3) Ventas\n\n" + "\t4) Salir\n\n");
                    a = Convert.ToInt32(Console.ReadLine());

                    switch (a) {
                        case 1:
                            Write("\tMostrar pelicula");
                            WriteLine("\n\nPresiona cualquier tecla para continuar...");
                            break;
                        case 2:
                            Write("\tInventario");
                            WriteLine("\n\nPresiona cualquier tecla para continuar...");
                            break;
                        case 3:
                            Write("\t¿Desea cargar el carrito de guardado anteriormente? \n\t1)Si (S) \n\t2)No (N)");
                            s1 = ReadLine();
                            if s1 = "S"{
                                Write("Insertar carrito de compras txt");
                                else 
                            }
                            WriteLine("\n\nPresiona cualquier tecla para continuar...");
                            break;
                        case 4:
                            {
                                Write("\tHasta luego");
                                WriteLine("\n\nPresiona cualquier tecla para continuar...");
                                break;
                            }
                        default:
                            WriteLine("\tEscoja una opción válida");
                            WriteLine("\n\nPresiona cualquier tecla para continuar...");
                            ReadKey();
                            break;
                    }
                    
                    
                } while (a !=4); //Ciclo para que se ejecute el menú
            }
            }
        }
        }
