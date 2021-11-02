using System;

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
                    Console.Clear();
                    Console.Write("\n\n\t-------------------------------\n");
                    Console.Write("\t------ Menú de opciones -------\n");
                    Console.Write("\t-------------------------------\n\n\n");
                    Console.Write("\t1) Mostrar pelicula\n\n" + "\t2) Inventario\n\n" + "\t3) Ventas\n\n" + "\t4) Salir\n\n");
                    a = Convert.ToInt32(Console.ReadLine());

                    switch (a) {
                        case 1:
                            Console.Write("\tMostrar pelicula");
                            Console.WriteLine("\n\nPresiona cualquier tecla para continuar...");
                            break;
                        case 2:
                            Console.Write("\tInventario");
                            Console.WriteLine("\n\nPresiona cualquier tecla para continuar...");
                            break;
                        case 3:
                            Console.Write("\t¿Desea cargar el carrito de guardado anteriormente? \n\t1)Si (S) \n\t2)No (N)");
                            s1 = Console.ReadLine();
                            if s1 = "S"{
                                Console.Write("Insertar carrito de compras txt");
                                else 
                            }
                            Console.WriteLine("\n\nPresiona cualquier tecla para continuar...");
                            break;
                        case 4:
                            {
                                Console.Write("\tHasta luego");
                                Console.WriteLine("\n\nPresiona cualquier tecla para continuar...");
                                break;
                            }
                        default:
                            Console.WriteLine("\tEscoja una opción válida");
                            Console.WriteLine("\n\nPresiona cualquier tecla para continuar...");
                            break;
                    }
                    Console.ReadKey();
                } while (a !=4);
            }
            }
        }
        }
