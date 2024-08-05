using System;

namespace Quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Definición de variables útiles para el programa
            bool multijugador = false; // Nos hará saber si el juego es multijugador o singleplayer
            bool seguirCiclo = true; // Variable útil para saber cuándo parar nuestros ciclos en la interfaz
            bool terminar = false; // Variable de salida del programa principal
            bool cambio = false; // Variable para saber si el usuario desea hacer cambios en los nombres
            int respuesta; // Variable para guardar las respuestas del usuario
            int ronda = 1; // El número de rondas que llevamos

            // Se definen los objetos de los jugadores fuera del bloque `if` para que sean accesibles en toda la función
            Concursante jugador1 = null;
            Concursante jugador2 = null;

            // Se le da la opción al usuario de jugar en modo multijugador o solitario
            Console.WriteLine("¡Bienvenido al juego de Quizzes interactivo!");
            do // Ciclo principal, donde todo el programa se ejecuta
            {
                if (ronda != 1)
                {
                    Console.WriteLine("¡Buena ronda! ¿te gustaría cambiar el modo de juego? Escribe 1 si es el caso, sino solo presiona cualquier tecla");
                    Console.Write("¿Qué te gustaría hacer?: ");

                    switch (Console.ReadKey().Key)
                    {
                        case ConsoleKey.NumPad1:
                        case ConsoleKey.D1:
                            Console.Clear();
                            multijugador = !multijugador;
                            // Operación ternaria dentro del writeline,
                            // el primer mensaje se muestra si la variable es true, la siguiente sino
                            Console.WriteLine(multijugador ? "¡Cambiaste a modo multijugador!" : "¡Cambiaste a modo solitario!");
                            cambio = true;
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine(multijugador ? "¡Sigues en: multijugador!" : "¡Sigues en: solitario!");
                            break;
                    }
                    Console.WriteLine();
                    Console.Write("Presiona cualquier tecla para continuar: ");
                    Console.ReadKey(true);
                    Console.Clear();
                }

                while (ronda == 1) // Ciclo de opciones de modo de juego
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
                                Console.WriteLine("¡Genial! elegiste el modo multijugador");
                                seguirCiclo = false;
                                break;
                            default:
                                Console.WriteLine($"Hermano, el número: {respuesta} no es una respuesta, por fa elige entre el 1 y el 2");
                                break;
                        }
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.Clear();
                        Console.WriteLine("Favor de escribir solo los números 1 o 2");
                    }
                    catch (OverflowException)
                    {
                        Console.Clear();
                        Console.WriteLine("Escribiste muchos números, casi haces explotar tu pc, no lo vuelvas a hacer");
                    }
                    finally
                    {
                        Console.WriteLine();
                        Console.Write("Presiona cualquier tecla para continuar: ");
                        Console.ReadKey();

                        Console.Clear();
                    }
                }
                // En la primera ronda siempre se le preguntará al jugador su nombre
                if (ronda == 1)
                {
                    Console.Write("Jugador 1, ¿Cuál es tu nombre?: ");
                    jugador1 = new Concursante(Console.ReadLine());
                    if (multijugador)
                    {
                        Console.Write("Jugador 2, ¿Cuál es tu nombre?: ");
                        jugador2 = new Concursante(Console.ReadLine());
                    }
                    else
                    {
                        // Siempre se creará un objeto para el segundo jugador para facilitarnos la vida
                        jugador2 = new Concursante("Solovino");
                    }
                }
                if (multijugador && cambio)
                {
                    Console.WriteLine("¡Bienvenido, jugador 2! ¿Cuál es tu nombre?: ");
                    jugador2.Nombre = Console.ReadLine();

                    Console.WriteLine($"¡Buen nombre, {jugador2.Nombre}!\nPresiona cualquier tecla para continuar: ");
                    Console.ReadKey(true);
                }

                if (ronda == 1) // Solo se mostrará en la primera ronda
                {
                    Console.Clear();
                    Console.WriteLine("Instrucciones:");
                    Console.WriteLine("A continuación se mostrarán rondas de 5 preguntas de la categoría seleccionada para cada jugador");
                    Console.WriteLine("La dificultad de cada pregunta será completamente aleatoria, y cada jugador recibirá la misma dificultad de preguntas");
                    Console.WriteLine("Cada respuesta correcta se sumará 1 punto en el marcador");
                    Console.WriteLine("El jugador con el mayor puntuaje será declarado ganador de esta ronda!");
                    Console.WriteLine();
                    Console.WriteLine("¡Buena suerte!");
                    Console.ReadKey(true);
                }

                /* Lo que se implementará:
                 * A continuación seguiría implementar la jugabilidad, tengo pensado que hayan 3 variables
                 * que almacenen un número aleatorio, estas variable almacenarán el número de preguntas de 
                 * cada dificultad que se dará en la ronda actual
                 * Posibles problemas:
                 * Que alguna de las variables sobre pase el número de preguntas disponibles en una dificultad
                 * de una categoría, esto puede ser problemático, habría que crear un protocolo en ese caso
                 * El número máximo de rondas que se puede jugar por categoría es de 6 rondas, pues las
                 * 30 pregunas se habrían terminado en ese caso
                 */

                ronda++;
                Console.ReadKey(true);
                Console.Clear();
            } while (!terminar); // Todo el programa se ejecutará hasta que la variable de terminar sea verdadera
        }
    }
}
