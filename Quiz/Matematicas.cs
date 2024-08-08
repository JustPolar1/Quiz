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
                                Console.WriteLine("¿Qué es un melómano?");
                                Console.Write("Escribe tu respuesta: ");


                                Respuesta = Console.ReadLine().ToLower();
                                if (Respuesta == "c" || Respuesta == "musica" || Respuesta == "amante de la musica" || Respuesta == "música" || Respuesta == "amante de la música")
                                {
                                    RespuestaCorrecta = true;
                                }
                                else
                                {
                                    Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era c) Amante de la música");
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
                        Console.WriteLine("¿Cuál es el valor de x dada la siguiente ecuacion?: 10 + x = 15");
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
                        Console.WriteLine("¿Cual es el valor de x dada la siguiente ecuacion: x^2 = 9?");
                        Console.Write("Escribe tu respuesta: ");

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
                        Console.WriteLine("¿Cual es el area de un triangulo con base de 10cm y altura de 5cm?");
                        Console.Write("Escribe tu respuesta: ");


                        RespuestaMath = float.Parse(Console.ReadLine());
                        if (RespuestaMath == 25)
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era 25cm^2");
                        }
                        break;
                    case (4):
                        Console.WriteLine("¿si un numero es multiplicado por 3 y se le suman 12 y el resultado es 24 cual es el numero?");
                        
                        Console.Write("Escribe tu respuesta: ");


                        RespuestaMath = float.Parse(Console.ReadLine());
                        if (RespuestaMath == 4 )
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era 4");
                        }
                        break;
                    case (5):
                        Console.WriteLine("¿Cual es el valor de la raiz de 144?");
                        
                        Console.Write("Escribe tu respuesta: ");


                        RespuestaMath = float.Parse(Console.ReadLine());
                        if (RespuestaMath == 12)
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era doce");
                        }
                        break;
                    case (6):
                        Console.WriteLine("¿Cual es la mediana de los siguientes numeros 4,8,6,5,7?");
                        
                        Console.Write("Escribe tu respuesta: ");


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
                        Console.WriteLine("¿Cual es el perimetro de un rectangulo con longitud de 10cm y ancho de 6cm?");
                       
                        Console.Write("Escribe tu respuesta: ");


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


                        RespuestaMath = float.Parse(Console.ReadLine());
                        if (RespuestaMath == 197.92f)
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era 197.92cm^3");
                        }
                        break;
                    case (9):
                        Console.WriteLine("¿Cuál es el valor de la ecuacion 2x-3=7?");
                       
                        Console.Write("Escribe tu respuesta: ");


                        RespuestaMath = float.Parse(Console.ReadLine());
                        if (RespuestaMath == 5)
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era cinco (5)");
                        }
                        break;
                    case (10):
                        Console.WriteLine("¿Cual es el valor de la suma de los angulos internos de un hexagono?");
                        
                        Console.WriteLine("Escribe tu respuesta");


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
                        Console.WriteLine("¿Qué unidad de medida mide fuerza?");
                        Console.WriteLine("\ta) Kilogramos");
                        Console.WriteLine("\tb) Pascuales");
                        Console.WriteLine("\tc) Voltaje");
                        Console.WriteLine("\td) Newtons");
                        Console.Write("Escribe tu respuesta: ");

                        RespuestaMath = float.Parse(Console.ReadLine()); // se lee la respuesta del usuario
                        Console.WriteLine();
                        // Se evalúa si se dio una respuesta correcta o no
                        if (Respuesta == "c" || Respuesta == "newton" || Respuesta == "newtons")
                        {
                            // Se activa la variable que determina si se ganó la ronda
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            // En caso de que no haya acertado se le informa al usuario
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era d) Newtons");
                        }
                        break;
                    // Las demás preguntas deberán tener un formato similar
                    case (2): // Esta se deja
                        Console.WriteLine("¿Cuál es el valor de la constante pi?");
                        Console.WriteLine("\ta) 1.6180");
                        Console.WriteLine("\tb) 2.7182");
                        Console.WriteLine("\tc) 3.1416");
                        Console.WriteLine("\tc) 3/4");
                        Console.Write("Escribe tu respuesta: ");


                        RespuestaMath = float.Parse(Console.ReadLine());
                        if (Respuesta == "c" || Respuesta == "3.1416" || Respuesta == "3.14")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era c) 3.1416");
                        }
                        break;
                    case (3):
                        Console.WriteLine("¿Quién fue Thomas Alva Edison?");
                        Console.WriteLine("\ta) Un físico que desarrolló la teoría de la relatividad");
                        Console.WriteLine("\tb) Un inventor y empresario estadounidense conocido por sus trabajos en electricidad y comunicaciones");
                        Console.WriteLine("\tc) Un matemático que descubrió el teorema de los números primos");
                        Console.WriteLine("\td) Un químico que desarrolló la teoría de los gases ideales");
                        Console.Write("Escribe tu respuesta: ");


                        RespuestaMath = float.Parse(Console.ReadLine());
                        if (Respuesta == "b")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era b) Un inventor y empresario estadounidense conocido por sus trabajos en electricidad y comunicaciones");
                        }
                        break;
                    case (4):
                        Console.WriteLine("¿Qué es un plano inclinado?");
                        Console.WriteLine("\ta) Un tipo de fuerza que actúa en dirección perpendicular al suelo");
                        Console.WriteLine("\tb) Una superficie plana que está inclinada con respecto a la horizontal y se utiliza para levantar objetos con menor esfuerzo");
                        Console.WriteLine("\tc) Un dispositivo que convierte la energía cinética en energía potencial");
                        Console.WriteLine("\td) Una técnica para medir la velocidad de un objeto en movimiento");
                        Console.Write("Escribe tu respuesta: ");


                        RespuestaMath = float.Parse(Console.ReadLine());
                        if (Respuesta == "b")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era b) Una superficie plana que está inclinada con respecto a la horizontal y se utiliza para levantar objetos con menor esfuerzo");
                        }
                        break;
                    case (5):
                        Console.WriteLine("¿Qué significan las siglas CPU en las computadoras?");
                        Console.WriteLine("\ta) Central Processing Unit (Unidad Central de Procesamiento)");
                        Console.WriteLine("\tb) Computer Peripheral Unit (Unidad Periférica de Computadora)");
                        Console.WriteLine("\tc) Central Programming Unit (Unidad Central de Programación)");
                        Console.Write("Escribe tu respuesta: ");


                        RespuestaMath = float.Parse(Console.ReadLine());
                        if (Respuesta == "a" || Respuesta == "unidad central de procesamiento" || Respuesta == "central processing unit")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era a) Central Processing Unit (Unidad Central de Procesamiento)");
                        }
                        break;
                    case (6):
                        Console.WriteLine("¿Qué es el sistema binario");
                        Console.WriteLine("\ta) Un sistema de numeración que utiliza diez dígitos del 0 al 9");
                        Console.WriteLine("\tb) Un sistema de codificación de caracteres basado en letras y símbolos");
                        Console.WriteLine("\tc) Un sistema de numeración que utiliza dos dígitos: 0 y 1");
                        Console.WriteLine("\td) Un sistema de medidas que se utiliza en la ingeniería electrónica");
                        Console.Write("Escribe tu respuesta: ");


                        RespuestaMath = float.Parse(Console.ReadLine());
                        if (Respuesta == "c")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era a) Un sistema de numeración que utiliza dos dígitos: 0 y 1");
                        }
                        break;
                    case (7):
                        Console.WriteLine("¿Qué significan las siglas IP");
                        Console.WriteLine("\ta) Input Port (Puerto de Entrada)");
                        Console.WriteLine("\tb) Internal Processor (Procesador Interno)");
                        Console.WriteLine("\tc) Information Pathway (Vía de Información)");
                        Console.WriteLine("\td) Internet Protocol (Protocolo de Internet)");
                        Console.Write("Escribe tu respuesta: ");


                        RespuestaMath = float.Parse(Console.ReadLine());
                        if (Respuesta == "d" || Respuesta == "internet protocol" || Respuesta == "protocolo de internet")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era d) Internet Protocol (Protocolo de Internet)");
                        }
                        break;
                    case (8): // Esta también se deja
                        Console.WriteLine("¿Es cierto que la gran muralla china puede verse desde el espacio?: ");
                        Console.Write("¿Sí o no?: ");

                        RespuestaMath = float.Parse(Console.ReadLine());
                        if (Respuesta == "no")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta!Aunque es un mito popular, la Gran Muralla China no es fácilmente visible desde el espacio sin ayuda");
                        }
                        break;
                    case (9):
                        Console.WriteLine("¿El pintor Vincent van Gogh cortó su propia oreja?");
                        Console.Write("¿Sí o no?: ");


                        RespuestaMath = float.Parse(Console.ReadLine());
                        if (Respuesta == "si" || Respuesta == "sí")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta! Van Gogh se cortó una parte de su oreja en un episodio de crisis mental.");
                        }
                        break;
                    case (10):
                        Console.WriteLine("La primera película de animación en color fue \"Blancanieves y los siete enanitos\"?");
                        Console.Write("¿Sí o no?: ");

                        RespuestaMath = float.Parse(Console.ReadLine());
                        if (Respuesta == "no")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta! \"Blancanieves y los siete enanitos\" fue la primera película de animación en largometraje, pero no fue la primera en color.\nLa primera película de animación en color fue \"Steamboat Willie\" de Disney.");
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
