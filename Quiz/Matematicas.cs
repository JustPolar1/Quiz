using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Quiz
{
    internal class Matematicas : Quiz
    {
        private float respuestaMath;

        public float RespuestaMath { get => respuestaMath; set => respuestaMath = value; }
        private bool seguirCiclo = false;
        protected List<int> preguntasBasicas = new List<int>()
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10
        };
        protected List<int> preguntasIntermedias = new List<int>()
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10
        };
        protected List<int> preguntasAvanzadas = new List<int>()
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10
        };

        // Cada método de cada categoría generará UNA pregunta aleatoria de esa categoría dependiendo la dificultad
        public override void Basico(Concursante concursante)
        {
            // hola prueba


            // Primero se comprueba si quedan preguntas en esta categoría
            if (preguntasBasicas.Count == 0)
            {
                Console.WriteLine("¡No hay más preguntas en esta categoría!");
            }
            // Si aún hay entonces se seguirán generando preguntas
            else
            {
                Random pregunta = new Random(); // Instancia para generar números aleatorios
                int preguntaAleatoria = pregunta.Next(preguntasBasicas.Count); // Genera la pregunta aleatoria
                Console.WriteLine("¡Pregunta fácil!");
                // Accedemos al número de pregunta aleatoria mediante el índice generado
                while (seguirCiclo)
                {
                    try
                    {
                        switch (preguntasBasicas[preguntaAleatoria])
                        {
                            case (1):
                                Console.WriteLine("¿Cuál será el resultado de la siguiente operación?: 10 + 5");
                                Console.Write("Escribe tu respuesta: ");

                                RespuestaMath = float.Parse(Console.ReadLine()); // se lee la respuesta del usuario

                                Console.WriteLine();
                                // Se evalúa si se dio una respuesta correcta o no
                                if (RespuestaMath == 15)
                                {
                                    // Se activa la variable que determina si se ganó la ronda
                                    RespuestaCorrecta = true;
                                }
                                else
                                {
                                    // En caso de que no haya acertado se le informa al usuario
                                    Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era 15");
                                }
                                break;
                            // Las demás preguntas deberán tener un formato similar
                            case (2):
                                Console.WriteLine("¿Cuál es el resultado de la siguiente operación: 7 * 8?");
                                Console.Write("Escribe tu respuesta: ");

                                RespuestaMath = float.Parse(Console.ReadLine());
                                if (RespuestaMath == 56)
                                {
                                    RespuestaCorrecta = true;
                                }
                                else
                                {
                                    Console.WriteLine("¡Respuesta incorrecta!, la respuesta correcta era 56");
                                }
                                break;
                            case (3):
                                Console.WriteLine("¿Cuál será el resultado de la siguiente operación?: 20 / 0.5");
                                Console.Write("Escribe tu respuesta: ");

                                RespuestaMath = float.Parse(Console.ReadLine());
                                if (RespuestaMath == 40)
                                {
                                    RespuestaCorrecta = true;
                                }
                                else
                                {
                                    Console.WriteLine("¡Respuesta incorrecta!, la respuesta correcta era 40");
                                }
                                break;
                            case (5):
                                Console.WriteLine("¿Cuál será el resultado de la siguiente operación?: 1000 + 500 + 30 + 4");
                                Console.Write("Escribe tu respuesta: ");


                                Respuesta = Console.ReadLine().ToLower();
                                if (RespuestaMath == 1534)
                                {
                                    RespuestaCorrecta = true;
                                }
                                else
                                {
                                    Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era 1534");
                                }
                                break;
                            case (4):
                                Console.WriteLine("¿Cuántas unidades hay en 5 decenas?: ");
                                Console.Write("Escribe tu respuesta: ");


                                RespuestaMath = float.Parse(Console.ReadLine());
                                if (RespuestaMath == 50)
                                {
                                    RespuestaCorrecta = true;
                                }
                                else
                                {
                                    Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era 50");
                                }
                                break;
                            case (6):
                                Console.WriteLine("¿Cuántos metros tiene un kilómetro?");
                                Console.Write("Escribe tu respuesta: ");


                                RespuestaMath = float.Parse(Console.ReadLine());
                                if (RespuestaMath == 1000)
                                {
                                    RespuestaCorrecta = true;
                                }
                                else
                                {
                                    Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era 1000 metros");
                                }
                                break;
                            case (7):
                                Console.WriteLine("¿A cuántos años equivale un lustro?");
                                Console.Write("Escribe tu respuesta (únicamente números): ");


                                RespuestaMath = float.Parse (Console.ReadLine());
                                if (RespuestaMath == 5)
                                {
                                    RespuestaCorrecta = true;
                                }
                                else
                                {
                                    Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era 5 años");
                                }
                                break;
                            case (8):
                                Console.WriteLine("¿Cuál es el resultado de la siguiente operación?: 5.2 - 7.8");
                                Console.Write("Escribe tu respuesta: ");

                                RespuestaMath = float.Parse(Console.ReadLine());
                                if (RespuestaMath == -2.6f)
                                {
                                    RespuestaCorrecta = true;
                                }
                                else
                                {
                                    Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era -2.6");
                                }
                                break;
                            case (9):
                                Console.WriteLine("¿Cuánto es 40 * 0.5?");
                                Console.Write("Escribe tu respuesta: ");


                                RespuestaMath = float.Parse(Console.ReadLine());
                                if (RespuestaMath == 20)
                                {
                                    RespuestaCorrecta = true;
                                }
                                else
                                {
                                    Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era 20");
                                }
                                break;
                            case (10):
                                Console.WriteLine("¿Cuánto suman los ángulos de un triángulo?");
                                Console.Write("Escribe tu respuesta: ");

                                RespuestaMath = float.Parse(Console.ReadLine());
                                if (RespuestaMath == 180)
                                {
                                    RespuestaCorrecta = true;
                                }
                                else
                                {
                                    Console.WriteLine("¡Respuesta incorrecta! La respuesta era 180");
                                }
                                break;
                            default:
                                break;
                        }
                        seguirCiclo = false;
                    }
                    catch (FormatException) 
                    {
                        seguirCiclo = true;
                    }
                    catch (OverflowException)
                    {
                        seguirCiclo = true;
                    }
                }
                // Cuando se ganó la ronda se le informa al usuario y se le suma un punto al concursante
                if (RespuestaCorrecta)
                {
                    Console.WriteLine("¡Respuesta correcta!");
                    Console.WriteLine($"¡{concursante.Nombre} Recibe un punto!");
                    concursante.Puntos += 1;
                }
                // Se elimina el número de la pregunta anteriormente dada para evitar repetidos
                preguntasBasicas.RemoveAt(preguntaAleatoria);
            }


            // Protocolo de finalización de la fase, agregar siempre.
            Console.WriteLine();

            Console.Write("Enter para continuar ");
            Console.ReadLine();
            Console.Clear();
            // Se devuelve a su estado original la variable de respuesta correcta
            RespuestaCorrecta = false;
        }
        public override void Intermedio(Concursante concursante)
        {
            // Primero se comprueba si quedan preguntas en esta categoría
            if (preguntasIntermedias.Count == 0)
            {
                Console.WriteLine("¡No hay más preguntas en esta categoría!");
            }
            // Si aún hay entonces se seguirán generando preguntas
            else
            {
                Random pregunta = new Random(); // Instancia para generar números aleatorios
                int preguntaAleatoria = pregunta.Next(preguntasIntermedias.Count); // Genera la pregunta aleatoria
                Console.WriteLine("¡Pregunta intermedia!");
                // Accedemos al número de pregunta aleatoria mediante el índice generado
                switch (preguntasIntermedias[preguntaAleatoria])
                {
                    case (1):
                        Console.WriteLine("¿Cuál es el valor de x dada la siguiente ecuación?: 10 + x = 15");
                        Console.Write("Escribe tu respuesta: ");

                        RespuestaMath = float.Parse(Console.ReadLine()); // se lee la respuesta del usuario
                        Console.WriteLine();
                        // Se evalúa si se dio una respuesta correcta o no
                        if (RespuestaMath == 5)
                        {
                            // Se activa la variable que determina si se ganó la ronda
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            // En caso de que no haya acertado se le informa al usuario
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era 5");
                        }
                        break;
                    // Las demás preguntas deberán tener un formato similar
                    case (2): // Esta se deja
                        Console.WriteLine("¿Cuál es el valor de x dada la siguiente ecuación: x^2 = 9?");
                        Console.Write("Escribe tu respuesta (únicamente números): ");

                        RespuestaMath = float.Parse(Console.ReadLine());
                        if (RespuestaMath == 3)
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era 3");
                        }
                        break;
                    case (3):
                        Console.WriteLine("¿Cuál es el área de un triángulo con base de 10cm y altura de 5cm?");
                        Console.Write("Escribe tu respuesta: ");


                        Respuesta = Console.ReadLine();
                        if (Respuesta == "25cm^2" || Respuesta == "25 centimetros cuadrados")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era 25cm^2");
                        }
                        break;
                    case (4):
                        Console.WriteLine("¿si un número es multiplicado por 3 y se le suman 12 y el resultado es 24 cuál es el número?");
                        
                        Console.Write("Escribe tu respuesta (únicamente números): ");


                        RespuestaMath = float.Parse(Console.ReadLine());
                        if (RespuestaMath == 4)
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era 4");
                        }
                        break;
                    case (5):
                        Console.WriteLine("¿Cuál es el valor de la raíz de 144?");
                        
                        Console.Write("Escribe tu respuesta (únicamente números): ");


                        RespuestaMath = float.Parse(Console.ReadLine());
                        if (RespuestaMath == 12)
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era 12");
                        }
                        break;
                    case (6):
                        Console.WriteLine("¿Cuál es la mediana de los siguientes números 4,8,6,5,7?");
                        
                        Console.Write("Escribe tu respuesta (únicamente números): ");


                        RespuestaMath = float.Parse(Console.ReadLine());
                        if (RespuestaMath == 6)
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era 6");
                        }
                        break;
                    case (7):
                        Console.WriteLine("¿Cuál es el perímetro de un rectángulo con longitud de 10cm y ancho de 6cm?");
                       
                        Console.Write("Escribe tu respuesta (únicamente números): ");


                        RespuestaMath = float.Parse(Console.ReadLine());
                        if (RespuestaMath == 32)
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era 32cm");
                        }
                        break;
                    case (8): // Esta también se deja
                        Console.WriteLine("¿Si un cilindro tiene un radio de 3cm y una altura de 7cm cual es su volumen?");
                      
                        Console.Write("Escribe tu respuesta: ");


                        Respuesta = Console.ReadLine();
                        if (Respuesta == "197.92cm^3" || Respuesta == "197.92cm cubicos")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era 197.92cm^3");
                        }
                        break;
                    case (9):
                        Console.WriteLine("¿Cuál es el valor de la ecuación 2x-3=7?");
                       
                        Console.Write("Escribe tu respuesta: ");


                        RespuestaMath = float.Parse(Console.ReadLine());
                        if (RespuestaMath == 5)
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era 5");
                        }
                        break;
                    case (10):
                        Console.WriteLine("¿Cuál es el valor de la suma de los ángulos internos de un hexágono?");
                        
                        Console.WriteLine("Escribe tu respuesta (únicamente números)");


                        RespuestaMath = float.Parse(Console.ReadLine());
                        if (RespuestaMath == 720)
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era 720°");
                        }
                        break;
                    default:
                        break;
                }
                // Cuando se ganó la ronda se le informa al usuario y se le suma un punto al concursante
                if (RespuestaCorrecta)
                {
                    Console.WriteLine("¡Respuesta correcta!");
                    Console.WriteLine($"¡{concursante.Nombre} Recibe un punto!");
                    concursante.Puntos += 1;
                }
                // Se elimina el número de la pregunta anteriormente dada para evitar repetidos
                preguntasIntermedias.RemoveAt(preguntaAleatoria);
            }


            // Protocolo de finalización de la fase, agregar siempre.
            Console.WriteLine();

            Console.Write("Enter para continuar ");
            Console.ReadLine();
            Console.Clear();
            // Se devuelve a su estado original la variable de respuesta correcta
            RespuestaCorrecta = false;
        }
        public override void Avanzado(Concursante concursante)
        {
            // Primero se comprueba si quedan preguntas en esta categoría
            if (preguntasAvanzadas.Count == 0)
            {
                Console.WriteLine("¡No hay más preguntas en esta categoría!");
            }
            // Si aún hay entonces se seguirán generando preguntas
            else
            {
                Random pregunta = new Random(); // Instancia para generar números aleatorios
                int preguntaAleatoria = pregunta.Next(preguntasAvanzadas.Count); // Genera la pregunta aleatoria
                Console.WriteLine("¡Pregunta intermedia!");
                // Accedemos al número de pregunta aleatoria mediante el índice generado
                switch (preguntasAvanzadas[preguntaAleatoria])
                {
                    case (1):
                        Console.WriteLine("En un trángulo rectángulo, la hipotenusamide 10cm y uno de los catetos mide " +
                            "6cm. ¿Cuál es la longitud del otro cateto?");
                        Console.Write("Escribe tu respuesta (únicamente números): ");

                        RespuestaMath = float.Parse(Console.ReadLine()); // se lee la respuesta del usuario
                        Console.WriteLine();
                        // Se evalúa si se dio una respuesta correcta o no
                        if (RespuestaMath == 8)
                        {
                            // Se activa la variable que determina si se ganó la ronda
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            // En caso de que no haya acertado se le informa al usuario
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era 8cm");
                        }
                        break;
                    // Las demás preguntas deberán tener un formato similar
                    case (2): // Esta se deja
                        Console.WriteLine("Un ángulo agudo mide 30 grados. ¿Cuál es la medida de su complemento?");
                        Console.Write("Escribe tu respuesta (únicamente números): ");


                        RespuestaMath = float.Parse(Console.ReadLine());
                        if (RespuestaMath == 60)
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era 60 grados");
                        }
                        break;
                    case (3):
                        Console.WriteLine("En un triángulo equilátero, la longitud de cada lado es de 10 cm " 
                            +"¿Cuál es la altura del triángulo?");
                        Console.Write("Escribe tu respuesta: ");


                        RespuestaMath = float.Parse(Console.ReadLine());
                        if (RespuestaMath == 8.66f)
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era 8.66 cm");
                        }
                        break;
                    case (4):
                        Console.WriteLine("Resuelve la ecuación cuadrática: x^2 + 5x - 6 = 0");
                        Console.Write("Escribe tu respuesta (Ej. x = a, x = b IMPORTANTE: Respetar espacios y comas): ");


                        Respuesta = Console.ReadLine();
                        if (Respuesta == "x = -6, x = 1" || Respuesta == "x=-6,x=1" || Respuesta == "x=-6, x=1")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era x = -6, x = 1");
                        }
                        break;
                    case (5):
                        Console.WriteLine("Encuentra el valor de x en la ecuación: 2x + 5 = 11 - 3x");
                        Console.Write("Escribe tu respuesta (Ej. x = a IMPORTANTE: Respetar espacios): ");


                        Respuesta = Console.ReadLine();
                        if (Respuesta == "x = 2" || Respuesta == "x=2" || Respuesta == "2")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era x = 2");
                        }
                        break;
                    case (6):
                        Console.WriteLine("Resuelve el sistema de ecuaciones: x + 2y = 7, 3x - 2y = 5");
                       
                        Console.Write("Escribe tu respuesta (Ej. x = a, x = b IMPORTANTE: Respetar espacios y comas): ");


                        Respuesta = Console.ReadLine();
                        if (Respuesta == "x = 3, y = 2" || Respuesta == "x=3,y=2" || Respuesta == "x=3, y=2")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era x = 3, y = 2");
                        }
                        break;
                    case (7):
                        Console.WriteLine("Encuentra el valor de x en la ecuación: x^2 - 4x - 3 = 0");
                        Console.Write("Escribe tu respuesta (Ej. x = a, x = b IMPORTANTE: Respetar espacios y comas): ");


                        Respuesta = Console.ReadLine();
                        if (Respuesta == "x = -1, x = 3" || Respuesta == " x=-1,x=3" || Respuesta == " x=-1, x=3")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era x = -1, x = 3");
                        }
                        break;
                    case (8): // Esta también se deja
                        Console.WriteLine("Resuelve la ecuación exponencial: 2^x = 16");
                        Console.Write("Escribe tu respuesta (Ej. x = a IMPORTANTE: Respetar espacios): ");

                        Respuesta = Console.ReadLine();
                        if (Respuesta == "x = 4" ||  Respuesta == "x=4" || Respuesta == "4")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era x = 4");
                        }
                        break;
                    case (9):
                        Console.WriteLine(" Encuentra el valor de x en la ecuación: x^2 + 2x - 6 = 0");
                        Console.Write("Escribe tu respuesta (Ej. x = a, x = b IMPORTANTE: Respetar espacios y comas): ");


                        Respuesta = Console.ReadLine();
                        if (Respuesta == "x = -3, x = 2" || Respuesta == "x=-3,x=2" ||Respuesta == "x=-3, x=2")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era x = -3, x = 2");
                        }
                        break;
                    case (10):
                        Console.WriteLine("7. Resuelve el sistema de ecuaciones: x - 2y = -3 2x + 3y = 7");
                        Console.Write("Escribe tu respuesta (Ej. x = a, x = b IMPORTANTE: Respetar espacios y comas): ");

                        Respuesta = Console.ReadLine();
                        if (Respuesta == "x = 1, y = 2" || Respuesta == "x=1,y=2" || Respuesta == "x=1, y=2")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era x = 1, y = 2");
                        }
                        break;
                    default:
                        break;
                }
                // Cuando se ganó la ronda se le informa al usuario y se le suma un punto al concursante
                if (RespuestaCorrecta)
                {
                    Console.WriteLine("¡Respuesta correcta!");
                    Console.WriteLine($"¡{concursante.Nombre} Recibe un punto!");
                    concursante.Puntos += 1;
                }
                // Se elimina el número de la pregunta anteriormente dada para evitar repetidos
                preguntasAvanzadas.RemoveAt(preguntaAleatoria);
            }


            // Protocolo de finalización de la fase, agregar siempre.
            Console.WriteLine();

            Console.Write("Enter para continuar ");
            Console.ReadLine();
            Console.Clear();
            // Se devuelve a su estado original la variable de respuesta correcta
            RespuestaCorrecta = false;
        }
    }
}
