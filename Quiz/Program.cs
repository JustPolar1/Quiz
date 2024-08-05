using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Definición de variables útiles para el programa
            bool multijugador = false; // Nos hará saber si el juego es multijugador o singleplayer
            bool seguirCiclo = true; // Varialbe útil para saber cuándo parar nuestros ciclos en la interfaz
            int respuesta; // Variable para guardar las respuestas del usuario

            // Se le da la opción al usuario de jugar en modo multijugador o solitario
            Console.WriteLine("¡Bienvenido al juego de Quizzes interactivo!");
            do
            {
                try
                {
                    Console.WriteLine("¿En qué modo de juego te gustaría jugar?");
                    Console.WriteLine("\t1. Solitario");
                    Console.WriteLine("\t2. Multijugador");
                    Console.Write("Escribe el número de la opción que quieres jugar: ");
                    respuesta = int.Parse(Console.ReadLine());
                    Console.Clear();

                    switch (respuesta)
                    {
                        case 1: // Modo solitario
                            multijugador = false;
                            Console.WriteLine("¡Genial! elegiste el modo solitario");
                            seguirCiclo = false;
                            break;
                        case 2: // Modo multijugador
                            multijugador = true;
                            Console.WriteLine("!Genial¡ elegiste el modo multijugador");
                            seguirCiclo = false;
                            break;
                        default:
                            Console.WriteLine($"Hermano, el número: {respuesta} no es una respuesta, por fa elige entre el 1 y el 2");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Favor de escribir solo los números 1 o 2");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Escribiste muchos números, casi haces explotar tu pc, no lo vuelvas a hacer");
                }
                finally
                {
                    Console.WriteLine();
                    Console.Write("Presiona cualquier tecla para continuar: ");
                    Console.ReadKey();

                    Console.Clear();
                }
            } while (seguirCiclo);

            Console.ReadKey();
        }
    }
}
