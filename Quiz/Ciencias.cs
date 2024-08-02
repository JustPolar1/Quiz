using System;
using System.Collections.Generic;

namespace Quiz
{
    internal class Ciencias: Quiz
    {
        // Variable que almacenará las respuestas del usuario
        private string respuesta;
        private bool respuestaCorrecta = false;

        // Variable que almacenará el número de preguntas aleatorias
        private List<int> preguntasBasicas = new List<int>()
        {
        1, 2, 3, 4, 5, 6, 7, 8, 9, 10
        };

        // Cada método de cada categoría generará UNA pregunta aleatoria de esa categoría dependiendo la dificultad
        public override void Basico(Concursante concursante)
        {
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
                                                                               // Accedemos al número de pregunta aleatoria mediante el índice generado
                switch (preguntasBasicas[preguntaAleatoria])
                {
                    case (1):
                        Console.WriteLine("pregunta 1: ¿Qué parte de la planta absorbe agua y nutrientes del suelo?");
                        Console.WriteLine("\ta) Hojas");
                        Console.WriteLine("\tb) Tallo");
                        Console.WriteLine("\tc) Raices");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (respuesta.ToLower() == "c" || respuesta.ToLower() == "Raices")
                        {
                            // Se activa la variable que determina si se ganó la ronda
                            respuestaCorrecta = true;
                        }
                        else
                        {
                            // En caso de que no haya acertado se le informa al usuario
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era Raices");
                        }
                        break;
                    // Las demás preguntas deberán tener un formato similar
                    case (2):
                        Console.WriteLine("pregunta 2: ¿Cuál es el órgano principal del sistema respiratorio?");
                        Console.WriteLine("\ta) Nariz");
                        Console.WriteLine("\tb) Pulmones");
                        Console.WriteLine("\tc) Boca");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (respuesta.ToLower() == "b" || respuesta.ToLower() == "Pulmones")
                        {
                            // Se activa la variable que determina si se ganó la ronda
                            respuestaCorrecta = true;
                        }
                        else
                        {
                            // En caso de que no haya acertado se le informa al usuario
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era Pulmones");
                        }
                        break;
                    case (3):
                        Console.WriteLine("pregunta 3: ¿Cómo se llama el proceso por el cual las plantas producen su propio alimento?");
                        Console.WriteLine("\ta) Fotosintesis");
                        Console.WriteLine("\tb) Digestion");
                        Console.WriteLine("\tc) Absorcion");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (respuesta.ToLower() == "a" || respuesta.ToLower() == "Fotosintesis")
                        {
                            // Se activa la variable que determina si se ganó la ronda
                            respuestaCorrecta = true;
                        }
                        else
                        {
                            // En caso de que no haya acertado se le informa al usuario
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era Fotosintesis");
                        }
                        break;
                    case (4):
                        Console.WriteLine("pregunta 4: ¿Qué tipo de animal es una rana?");
                        Console.WriteLine("\ta) Terrestre");
                        Console.WriteLine("\tb) Marino");
                        Console.WriteLine("\tc) Anfibio");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (respuesta.ToLower() == "c" || respuesta.ToLower() == "Anfibio")
                        {
                            // Se activa la variable que determina si se ganó la ronda
                            respuestaCorrecta = true;
                        }
                        else
                        {
                            // En caso de que no haya acertado se le informa al usuario
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era Anfibio");
                        }

                        break;
                    case (5):
                        Console.WriteLine("pregunta 5:  ¿Qué parte del cuerpo humano se usa para pensar?");
                        Console.WriteLine("\ta) Faringe");
                        Console.WriteLine("\tb) Cerebro");
                        Console.WriteLine("\tc) Cerebelo");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (respuesta.ToLower() == "b" || respuesta.ToLower() == "Cerebro")
                        {
                            // Se activa la variable que determina si se ganó la ronda
                            respuestaCorrecta = true;
                        }
                        else
                        {
                            // En caso de que no haya acertado se le informa al usuario
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era Cerebro");
                        }
                        break;
                    case (6):
                        Console.WriteLine("pregunta 6: ¿Cómo se llama el cambio de una oruga a una mariposa?");
                        Console.WriteLine("\ta) Evolucion");
                        Console.WriteLine("\tb) Metamorfosis");
                        Console.WriteLine("\tc) crecimiento");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (respuesta.ToLower() == "b" || respuesta.ToLower() == "Metamorfosis")
                        {
                            // Se activa la variable que determina si se ganó la ronda
                            respuestaCorrecta = true;
                        }
                        else
                        {
                            // En caso de que no haya acertado se le informa al usuario
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era Fotosintesis");
                        }
                        break;
                    case (7):
                        Console.WriteLine("pregunta 7: ¿Cuál es el hábitat natural de los peces?");
                        Console.WriteLine("\ta) Cielo");
                        Console.WriteLine("\tb) suelo");
                        Console.WriteLine("\tc) Agua");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (respuesta.ToLower() == "b" || respuesta.ToLower() == "Agua")
                        {
                            // Se activa la variable que determina si se ganó la ronda
                            respuestaCorrecta = true;
                        }
                        else
                        {
                            // En caso de que no haya acertado se le informa al usuario
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era Agua");
                        }
                        break;
                    case (8):
                        Console.WriteLine("pregunta 8:  ¿Qué tipo de animal pone huevos?");
                        Console.WriteLine("\ta) Aves");
                        Console.WriteLine("\tb) Equinos");
                        Console.WriteLine("\tc) Homo sapiens");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (respuesta.ToLower() == "a" || respuesta.ToLower() == "Aves")
                        {
                            // Se activa la variable que determina si se ganó la ronda
                            respuestaCorrecta = true;
                        }
                        else
                        {
                            // En caso de que no haya acertado se le informa al usuario
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era Aves");
                        }
                        break;
                    case (9):
                        Console.WriteLine("pregunta 9: ¿Qué necesitan las plantas para crecer además de agua y luz solar?");
                        Console.WriteLine("\ta) Frio");
                        Console.WriteLine("\tb) Nutrientes del suelo y dioxido de carbono");
                        Console.WriteLine("\tc) Arena");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (respuesta.ToLower() == "b" || respuesta.ToLower() == "Nutrientes del suelo y dioxido de carbono")
                        {
                            // Se activa la variable que determina si se ganó la ronda
                            respuestaCorrecta = true;
                        }
                        else
                        {
                            // En caso de que no haya acertado se le informa al usuario
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era Nutrientes del suelo y dioxido de carbono");
                        }
                        break;
                    case (10):
                        Console.WriteLine("pregunta 10:  ¿Cómo se llama el órgano que bombea sangre a todo el cuerpo?");
                        Console.WriteLine("\ta) Pancreas");
                        Console.WriteLine("\tb) Higado");
                        Console.WriteLine("\tc) Corazon");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (respuesta.ToLower() == "c" || respuesta.ToLower() == "Corazon")
                        {
                            // Se activa la variable que determina si se ganó la ronda
                            respuestaCorrecta = true;
                        }
                        else
                        {
                            // En caso de que no haya acertado se le informa al usuario
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era Corazon");
                        }
                        break;
                    default:
                        break;
                }
                // Cuando se ganó la ronda se le informa al usuario y se le suma un punto al concursante
                if (respuestaCorrecta)
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
            respuestaCorrecta = false;
        }
        public virtual void Intermedio(Concursante concursante)
        {
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
                                                                               // Accedemos al número de pregunta aleatoria mediante el índice generado
                switch (preguntasBasicas[preguntaAleatoria])
                {
                    case (1):
                        Console.WriteLine("pregunta 1: ¿Cuál es el órgano encargado de filtrar la sangre en el cuerpo humano?");
                        Console.WriteLine("\ta) Higado");
                        Console.WriteLine("\tb) Riñones");
                        Console.WriteLine("\tc) Vesicula");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (respuesta.ToLower() == "b" || respuesta.ToLower() == "Riñones")
                        {
                            // Se activa la variable que determina si se ganó la ronda
                            respuestaCorrecta = true;
                        }
                        else
                        {
                            // En caso de que no haya acertado se le informa al usuario
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era Riñones");
                        }
                        break;
                    // Las demás preguntas deberán tener un formato similar
                    case (2):
                        Console.WriteLine("pregunta 2: ¿Cómo se llama el tubo que conecta la boca con el estómago?");
                        Console.WriteLine("\ta) ");
                        Console.WriteLine("\tb) Pulmones");
                        Console.WriteLine("\tc) Esofago");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (respuesta.ToLower() == "b" || respuesta.ToLower() == "Pulmones")
                        {
                            // Se activa la variable que determina si se ganó la ronda
                            respuestaCorrecta = true;
                        }
                        else
                        {
                            // En caso de que no haya acertado se le informa al usuario
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era Pulmones");
                        }
                        break;
                    case (3):
                        Console.WriteLine("pregunta 3: ¿Cómo se llama el proceso por el cual las plantas producen su propio alimento?");
                        Console.WriteLine("\ta) Fotosintesis");
                        Console.WriteLine("\tb) Digestion");
                        Console.WriteLine("\tc) Absorcion");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (respuesta.ToLower() == "a" || respuesta.ToLower() == "Fotosintesis")
                        {
                            // Se activa la variable que determina si se ganó la ronda
                            respuestaCorrecta = true;
                        }
                        else
                        {
                            // En caso de que no haya acertado se le informa al usuario
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era Fotosintesis");
                        }
                        break;
                    case (4):
                        Console.WriteLine("pregunta 4: ¿Qué tipo de animal es una rana?");
                        Console.WriteLine("\ta) Terrestre");
                        Console.WriteLine("\tb) Marino");
                        Console.WriteLine("\tc) Anfibio");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (respuesta.ToLower() == "c" || respuesta.ToLower() == "Anfibio")
                        {
                            // Se activa la variable que determina si se ganó la ronda
                            respuestaCorrecta = true;
                        }
                        else
                        {
                            // En caso de que no haya acertado se le informa al usuario
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era Anfibio");
                        }

                        break;
                    case (5):
                        Console.WriteLine("pregunta 5:  ¿Qué parte del cuerpo humano se usa para pensar?");
                        Console.WriteLine("\ta) Faringe");
                        Console.WriteLine("\tb) Cerebro");
                        Console.WriteLine("\tc) Cerebelo");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (respuesta.ToLower() == "b" || respuesta.ToLower() == "Cerebro")
                        {
                            // Se activa la variable que determina si se ganó la ronda
                            respuestaCorrecta = true;
                        }
                        else
                        {
                            // En caso de que no haya acertado se le informa al usuario
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era Cerebro");
                        }
                        break;
                    case (6):
                        Console.WriteLine("pregunta 6: ¿Cómo se llama el cambio de una oruga a una mariposa?");
                        Console.WriteLine("\ta) Evolucion");
                        Console.WriteLine("\tb) Metamorfosis");
                        Console.WriteLine("\tc) crecimiento");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (respuesta.ToLower() == "b" || respuesta.ToLower() == "Metamorfosis")
                        {
                            // Se activa la variable que determina si se ganó la ronda
                            respuestaCorrecta = true;
                        }
                        else
                        {
                            // En caso de que no haya acertado se le informa al usuario
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era Fotosintesis");
                        }
                        break;
                    case (7):
                        Console.WriteLine("pregunta 7: ¿Cuál es el hábitat natural de los peces?");
                        Console.WriteLine("\ta) Cielo");
                        Console.WriteLine("\tb) suelo");
                        Console.WriteLine("\tc) Agua");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (respuesta.ToLower() == "b" || respuesta.ToLower() == "Agua")
                        {
                            // Se activa la variable que determina si se ganó la ronda
                            respuestaCorrecta = true;
                        }
                        else
                        {
                            // En caso de que no haya acertado se le informa al usuario
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era Agua");
                        }
                        break;
                    case (8):
                        Console.WriteLine("pregunta 8:  ¿Qué tipo de animal pone huevos?");
                        Console.WriteLine("\ta) Aves");
                        Console.WriteLine("\tb) Equinos");
                        Console.WriteLine("\tc) Homo sapiens");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (respuesta.ToLower() == "a" || respuesta.ToLower() == "Aves")
                        {
                            // Se activa la variable que determina si se ganó la ronda
                            respuestaCorrecta = true;
                        }
                        else
                        {
                            // En caso de que no haya acertado se le informa al usuario
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era Aves");
                        }
                        break;
                    case (9):
                        Console.WriteLine("pregunta 9: ¿Qué necesitan las plantas para crecer además de agua y luz solar?");
                        Console.WriteLine("\ta) Frio");
                        Console.WriteLine("\tb) Nutrientes del suelo y dioxido de carbono");
                        Console.WriteLine("\tc) Arena");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (respuesta.ToLower() == "b" || respuesta.ToLower() == "Nutrientes del suelo y dioxido de carbono")
                        {
                            // Se activa la variable que determina si se ganó la ronda
                            respuestaCorrecta = true;
                        }
                        else
                        {
                            // En caso de que no haya acertado se le informa al usuario
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era Nutrientes del suelo y dioxido de carbono");
                        }
                        break;
                    case (10):
                        Console.WriteLine("pregunta 10:  ¿Cómo se llama el órgano que bombea sangre a todo el cuerpo?");
                        Console.WriteLine("\ta) Pancreas");
                        Console.WriteLine("\tb) Higado");
                        Console.WriteLine("\tc) Corazon");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (respuesta.ToLower() == "c" || respuesta.ToLower() == "Corazon")
                        {
                            // Se activa la variable que determina si se ganó la ronda
                            respuestaCorrecta = true;
                        }
                        else
                        {
                            // En caso de que no haya acertado se le informa al usuario
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era Corazon");
                        }
                        break;
                    default:
                        break;
                }
                // Cuando se ganó la ronda se le informa al usuario y se le suma un punto al concursante
                if (respuestaCorrecta)
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
            respuestaCorrecta = false;
        }
    }
        public virtual void Avanzado(Concursante concursante)
        {

        }
    }
}
