using System;
using System.ComponentModel;
using System.Runtime;
using System.Runtime.InteropServices;
using System.Threading;

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

            dynamic categoria = null; // Esta variable almacenará la categoría que actualmente se está jugando
            Random nAleatorio = new Random(); // Variable que generará números aleatorios
            int n; // Útil para guardar el número generado por nAleatorio, luego restarlo con los quizes disponibles
            int faciles; // Número de preguntas fáciles que se generarán
            int medias; // Número de preguntas intermedias que se generarán
            int dificiles; // Número de preguntas difíciles que se generarán

            int nQuizes = 6; // Número de quizes que hay en una ranodm

            // Se definen los objetos de los jugadores fuera del bloque `if` para que sean accesibles en toda la función
            Concursante jugador1 = null;
            Concursante jugador2 = null;

            // Objetos para cada quiz
            Quiz culturaGeneral = new Quiz();
            Acertijos acertijo = new Acertijos();
            Ciencias ciencia = new Ciencias();
            Historia historia = new Historia();
            Matematicas matematicas = new Matematicas();

            for (int i = 0; i < 30; i++)
            {
               Console.WriteLine(nAleatorio.Next(6));
            }
            Console.ReadKey();

            Console.WriteLine("¡Bienvenido al juego de Quizzes interactivo!");
            do // Ciclo principal, donde todo el programa se ejecuta
            {
                nQuizes = 6;
                seguirCiclo = true;
                cambio = false;
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

                while (ronda == 1 && seguirCiclo) // Ciclo de opciones de modo de juego
                {
                    try
                    {
                        // Se le da la opción al usuario de jugar en modo multijugador o solitario
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
                seguirCiclo = true;
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
                    Console.Write("¡Bienvenido, jugador 2! ¿Cuál es tu nombre?: ");
                    jugador2.Nombre = Console.ReadLine();

                    Console.WriteLine($"¡Buen nombre, {jugador2.Nombre}!\nPresiona cualquier tecla para continuar: ");
                    Console.ReadKey(true);
                }
                do // Ciclo de opciones para la elección de una categoría
                {
                    try
                    {
                        Console.Clear();
                        Console.WriteLine("¿En qué categoría te gustaría jugar?");
                        Console.WriteLine("\t1. Cultura General");
                        Console.WriteLine("\t2. Acertijos");
                        Console.WriteLine("\t3. Ciencias");
                        Console.WriteLine("\t4. Historia");
                        Console.WriteLine("\t5. Matemáticas");
                        Console.Write("Escribe aquí el número de la opción que quieras: ");
                        switch (int.Parse(Console.ReadLine()))
                        {
                            case 1:
                                Console.Clear();
                                categoria = culturaGeneral;
                                Console.WriteLine("Elegiste cultura general, ¡veamos cuánto sabes realmente del mundo! :D");
                                break;
                            case 2:
                                Console.Clear();
                                categoria = acertijo;
                                Console.WriteLine("Bienvenido al Quiz de las adivinanzas, donde tu desespero es nuestra alegria");
                                break;
                            case 3:
                                Console.Clear();
                                categoria = ciencia;
                                Console.WriteLine("¿Entonces te gustan las ciencias? en ese caso ¡Bario Molibdeno y Sulfuro!");
                                break;
                            case 4:
                                Console.Clear();
                                categoria = historia;
                                Console.WriteLine("¡Historia será!");
                                break;
                            case 5:
                                Console.Clear();
                                categoria = matematicas;
                                Console.WriteLine("¡Elegiste Matemáticas! ¿Sabes por qué el quiz de matemáticas estaba triste? ¡Porque tenía muchos problemas! :D");
                                break;
                            default:
                                Console.Clear();
                                Console.WriteLine("Esa no es una opción, por favor escribe únicamente el NÚMERO de la opción que prefieres");
                                continue;
                        };
                        seguirCiclo = false;
                    }
                    catch (FormatException)
                    {
                        Console.Clear();
                        Console.WriteLine("Por favor, escribe únicamente números");
                    }
                    catch (OverflowException)
                    {
                        Console.Clear();
                        Console.WriteLine("Escribiste demasiados números");
                    }
                    finally
                    {
                        Console.WriteLine();
                        Console.Write("Presiona cualquier tecla para continuar: ");
                        Console.ReadKey(true);
                        Console.Clear();
                    }
                } while (seguirCiclo);
                if (ronda == 1) // Las instrucciones solo se mostrarán en la primera ronda
                {
                    Console.Clear();
                    Console.WriteLine("Instrucciones:");
                    Console.WriteLine("A continuación se mostrarán rondas de 5 preguntas de la categoría seleccionada para cada jugador");
                    Console.WriteLine("La dificultad de cada pregunta será completamente aleatoria, y cada jugador recibirá la misma dificultad de preguntas");
                    Console.WriteLine("Cada respuesta correcta sumará 1 punto en el marcador del jugador correspondiente");
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

                // el juego:
                n = nAleatorio.Next(nQuizes); // 2
                nQuizes -= n; //  5 - 2
                faciles = n; // 2

                n = nAleatorio.Next(nQuizes); // 0 
                nQuizes -= n; // 3
                medias = n; // 0
                
                dificiles = nQuizes - 1; // 3

                for (; faciles > 0; faciles--)
                {
                    Console.Clear();
                    if (multijugador)
                    {
                        Console.WriteLine("Marcador:");
                        Console.WriteLine($"{jugador1.Nombre}: {jugador1.Puntos}\t{jugador2.Nombre}: {jugador2.Puntos}");
                        Console.WriteLine($"\n¡{jugador1.Nombre}! te toca a ti");
                    }
                    categoria.Basico(jugador1);
                    if (multijugador)
                    {
                        Console.WriteLine("Marcador:");
                        Console.WriteLine($"{jugador1.Nombre}: {jugador1.Puntos}\t{jugador2.Nombre}: {jugador2.Puntos}");
                        Console.WriteLine($"\n¡{jugador2.Nombre}! te toca a ti");
                        categoria.Basico(jugador2);
                        Console.Clear();
                    }
                }
                for (; medias > 0; medias--)
                {
                    Console.Clear();
                    if (multijugador)
                    {
                        Console.WriteLine("Marcador:");
                        Console.WriteLine($"{jugador1.Nombre}: {jugador1.Puntos}\t{jugador2.Nombre}: {jugador2.Puntos}");
                        Console.WriteLine($"\n¡{jugador1.Nombre}! te toca a ti");
                    }
                    categoria.Intermedio(jugador1);
                    if (multijugador)
                    {
                        Console.WriteLine("Marcador:");
                        Console.WriteLine($"{jugador1.Nombre}: {jugador1.Puntos}\t{jugador2.Nombre}: {jugador2.Puntos}");
                        Console.WriteLine($"\n¡{jugador2.Nombre}! te toca a ti");
                        categoria.Intermedio(jugador2);
                        Console.Clear();
                    }
                }
                for (; dificiles > 0; dificiles--)
                {
                    Console.Clear();
                    if (multijugador)
                    {
                        Console.WriteLine("Marcador:");
                        Console.WriteLine($"{jugador1.Nombre}: {jugador1.Puntos}\t{jugador2.Nombre}: {jugador2.Puntos}");
                        Console.WriteLine($"\n¡{jugador1.Nombre}! te toca a ti");
                    }
                    categoria.Avanzado(jugador1);
                    if (multijugador)
                    {
                        Console.WriteLine("Marcador:");
                        Console.WriteLine($"{jugador1.Nombre}: {jugador1.Puntos}\t{jugador2.Nombre}: {jugador2.Puntos}");
                        Console.WriteLine($"\n¡{jugador2.Nombre}! te toca a ti");
                        categoria.Avanzado(jugador2);
                        Console.Clear();
                    }
                }

                if (multijugador)
                {
                    if (jugador1.Puntos == jugador2.Puntos)
                    {
                        Console.WriteLine($"¡Hubo un empate! Los dos ganan :D");
                        Console.ReadKey(true);
                    } 
                    if (jugador1.Puntos > jugador2.Puntos)
                    {
                        Console.WriteLine($"¡{jugador1.Nombre} ha ganado esta ronda con: {jugador1.Puntos} puntos!");
                        jugador1.Racha++;
                        if (jugador1.Racha > 1)
                        {
                            Console.WriteLine($"¡{jugador1.Nombre} lleva una racha de: {jugador1.Racha}");
                            Console.ReadKey(true);
                        }
                    }
                    else if (jugador1.Puntos < jugador2.Puntos)
                    {
                        Console.WriteLine($"¡{jugador2.Nombre} ha ganado esta ronda con: {jugador2.Puntos} puntos!");
                        jugador2.Racha++;
                        if (jugador2.Racha > 1)
                        {
                            Console.WriteLine($"¡{jugador2.Nombre} lleva una racha de: {jugador2.Racha}");
                        }
                        Console.ReadKey(true);
                    }
                }
                else
                {
                    Console.WriteLine($"¡Muy bien, {jugador1.Nombre}! contestaste correctamente {jugador1.Puntos} de 5");
                    Console.WriteLine();
                    Console.Write("Presiona cualquier tecla para continuar: ");

                    Console.ReadKey(true);
                }
                ronda++;
                Console.Clear();

                jugador1.Puntos = 0;
                jugador2.Puntos = 0;

                Console.Write("Presiona 0 si te gustaría salir del juego: ");
                if (Console.ReadKey(true).KeyChar.ToString() == "0")
                {
                    terminar = true;
                    Console.WriteLine("¡Adiós!");
                    Console.WriteLine();
                    for (int i = 0; i < 3; i++)
                    {
                        Console.Write(".");
                        Thread.Sleep(1000);
                    }
                }

            } while (!terminar); // Todo el programa se ejecutará hasta que la variable de terminar sea verdadera
        }
    }
}
