using System;
using System.Collections.Generic;

namespace Quiz
{
    internal class Ciencias : Quiz
    {
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
                switch (preguntasBasicas[preguntaAleatoria])
                {
                    case (1):
                        Console.WriteLine("¿Qué parte de la planta absorbe agua y nutrientes del suelo?");
                        Console.WriteLine("\ta) Hojas");
                        Console.WriteLine("\tb) Tallo");
                        Console.WriteLine("\tc) Raices");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no

                        if (Respuesta.ToLower() == "c" || Respuesta.ToLower() == "raices")
                        {
                            // Se activa la variable que determina si se ganó la ronda
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            // En caso de que no haya acertado se le informa al usuario
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era Raices");
                        }
                        break;
                    // Las demás preguntas deberán tener un formato similar
                    case (2):
                        Console.WriteLine("¿Cuál es el órgano principal del sistema respiratorio?");
                        Console.WriteLine("\ta) Nariz");
                        Console.WriteLine("\tb) Pulmones");
                        Console.WriteLine("\tc) Boca");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (Respuesta.ToLower() == "b" || Respuesta.ToLower() == "pulmones")
                        {
                            // Se activa la variable que determina si se ganó la ronda
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            // En caso de que no haya acertado se le informa al usuario
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era Pulmones");
                        }
                        break;
                    case (3):
                        Console.WriteLine("¿Cómo se llama el proceso por el cual las plantas producen su propio alimento?");
                        Console.WriteLine("\ta) Fotosíntesis");
                        Console.WriteLine("\tb) Digestión");
                        Console.WriteLine("\tc) Absorción");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (Respuesta.ToLower() == "a" || Respuesta.ToLower() == "fotosintesis" || Respuesta.ToLower() == "fotosíntesis")
                        {
                            // Se activa la variable que determina si se ganó la ronda
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            // En caso de que no haya acertado se le informa al usuario
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era Fotosíntesis");
                        }
                        break;
                    case (4):
                        Console.WriteLine("¿Qué tipo de animal es una rana?");
                        Console.WriteLine("\ta) Terrestre");
                        Console.WriteLine("\tb) Marino");
                        Console.WriteLine("\tc) Anfibio");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (Respuesta.ToLower() == "c" || Respuesta.ToLower() == "anfibio")
                        {
                            // Se activa la variable que determina si se ganó la ronda
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            // En caso de que no haya acertado se le informa al usuario
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era Anfibio");
                        }

                        break;
                    case (5):
                        Console.WriteLine("¿Qué parte del cuerpo humano se usa para pensar?");
                        Console.WriteLine("\ta) Faringe");
                        Console.WriteLine("\tb) Cerebro");
                        Console.WriteLine("\tc) Cerebelo");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (Respuesta.ToLower() == "b" || Respuesta.ToLower() == "cerebro")
                        {
                            // Se activa la variable que determina si se ganó la ronda
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            // En caso de que no haya acertado se le informa al usuario
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era Cerebro");
                        }
                        break;
                    case (6):
                        Console.WriteLine("¿Cómo se llama el cambio de una oruga a una mariposa?");
                        Console.WriteLine("\ta) Evolución");
                        Console.WriteLine("\tb) Metamorfosis");
                        Console.WriteLine("\tc) crecimiento");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (Respuesta.ToLower() == "b" || Respuesta.ToLower() == "metamorfosis")
                        {
                            // Se activa la variable que determina si se ganó la ronda
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            // En caso de que no haya acertado se le informa al usuario
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era metamorfosis");
                        }
                        break;
                    case (7):
                        Console.WriteLine("¿Cuál es el hábitat natural de los peces?");
                        Console.WriteLine("\ta) Cielo");
                        Console.WriteLine("\tb) suelo");
                        Console.WriteLine("\tc) Agua");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (Respuesta.ToLower() == "c" || Respuesta.ToLower() == "agua")
                        {
                            // Se activa la variable que determina si se ganó la ronda
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            // En caso de que no haya acertado se le informa al usuario
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era Agua");
                        }
                        break;
                    case (8):
                        Console.WriteLine("¿Qué tipo de animal pone huevos?");
                        Console.WriteLine("\ta) Aves");
                        Console.WriteLine("\tb) Equinos");
                        Console.WriteLine("\tc) Homo sapiens");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (Respuesta.ToLower() == "a" || Respuesta.ToLower() == "aves")
                        {
                            // Se activa la variable que determina si se ganó la ronda
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            // En caso de que no haya acertado se le informa al usuario
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era Aves");
                        }
                        break;
                    case (9):
                        Console.WriteLine("¿Qué necesitan las plantas para crecer además de agua y luz solar?");
                        Console.WriteLine("\ta) Frio");
                        Console.WriteLine("\tb) Nutrientes del suelo y dioxido de carbono");
                        Console.WriteLine("\tc) Arena");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (Respuesta.ToLower() == "b" || Respuesta.ToLower() == "nutrientes del suelo y dioxido de carbono")
                        {
                            // Se activa la variable que determina si se ganó la ronda
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            // En caso de que no haya acertado se le informa al usuario
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era Nutrientes del suelo y dioxido de carbono");
                        }
                        break;
                    case (10):
                        Console.WriteLine("¿Cómo se llama el órgano que bombea sangre a todo el cuerpo?");
                        Console.WriteLine("\ta) Pancreas");
                        Console.WriteLine("\tb) Higado");
                        Console.WriteLine("\tc) Corazon");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (Respuesta.ToLower() == "c" || Respuesta.ToLower() == "corazon")
                        {
                            // Se activa la variable que determina si se ganó la ronda
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            // En caso de que no haya acertado se le informa al usuario
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era Corazon");
                        }
                        break;
                    default:
                        Console.WriteLine("Error en la evaluación de la respuesta.");
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
                switch (preguntasIntermedias [preguntaAleatoria])
                {
                    case (1):
                        Console.WriteLine("¿Cuál es el órgano encargado de filtrar la sangre en el cuerpo humano?");
                        Console.WriteLine("\ta) Hígado");
                        Console.WriteLine("\tb) Riñones");
                        Console.WriteLine("\tc) Vesícula");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (Respuesta.ToLower() == "b" || Respuesta.ToLower() == "riñones")
                        {
                            // Se activa la variable que determina si se ganó la ronda
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            // En caso de que no haya acertado se le informa al usuario
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era Riñones");
                        }
                        break;
                    // Las demás preguntas deberán tener un formato similar
                    case (2):
                        Console.WriteLine("¿Cómo se llama el tubo que conecta la boca con el estómago?");
                        Console.WriteLine("\ta) Intestino");
                        Console.WriteLine("\tb) Pulmones");
                        Console.WriteLine("\tc) Esófago");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (Respuesta.ToLower() == "c" || Respuesta.ToLower() == "esofago" || Respuesta.ToLower() == "esófago")
                        {
                            // Se activa la variable que determina si se ganó la ronda
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            // En caso de que no haya acertado se le informa al usuario
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era Esófago");
                        }
                        break;
                    case (3):
                        Console.WriteLine("¿Qué órgano produce insulina en el cuerpo humano?");
                        Console.WriteLine("\ta) Páncreas");
                        Console.WriteLine("\tb) Estómago");
                        Console.WriteLine("\tc) Hígado");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (Respuesta.ToLower() == "a" || Respuesta.ToLower() == "pancreas" || Respuesta.ToLower() == "páncreas")
                        {
                            // Se activa la variable que determina si se ganó la ronda
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            // En caso de que no haya acertado se le informa al usuario
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era Páncreas");
                        }
                        break;
                    case (4):
                        Console.WriteLine("¿Dónde se encuentran los alvéolos?");
                        Console.WriteLine("\ta) Páncreas");
                        Console.WriteLine("\tb) Pulmones");
                        Console.WriteLine("\tc) Colon");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (Respuesta.ToLower() == "b" || Respuesta.ToLower() == "pulmones")
                        {
                            // Se activa la variable que determina si se ganó la ronda
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            // En caso de que no haya acertado se le informa al usuario
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era Pulmones");
                        }

                        break;
                    case (5):
                        Console.WriteLine("¿Qué estructura del cerebro controla el equilibrio y la coordinación?");
                        Console.WriteLine("\ta) Hipotalamo");
                        Console.WriteLine("\tb) Cerebelo");
                        Console.WriteLine("\tc) Bulbo raquideo");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o n
                        if (Respuesta.ToLower() == "b" || Respuesta.ToLower() == "cerebelo")
                        {
                            // Se activa la variable que determina si se ganó la ronda
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            // En caso de que no haya acertado se le informa al usuario
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era Cerebelo");
                        }
                        break;
                    case (6):
                        Console.WriteLine("¿Cómo se llama la capa externa de la piel?");
                        Console.WriteLine("\ta) Dermis");
                        Console.WriteLine("\tb) Epidermis");
                        Console.WriteLine("\tc) Musculo");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (Respuesta.ToLower() == "b" || Respuesta.ToLower() == "epidermis")
                        {
                            // Se activa la variable que determina si se ganó la ronda
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            // En caso de que no haya acertado se le informa al usuario
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era Epidermis");
                        }
                        break;
                    case (7):
                        Console.WriteLine("¿Qué tipo de células transportan oxígeno en la sangre?");
                        Console.WriteLine("\ta) Glóbulos rojos");
                        Console.WriteLine("\tb) Glóbulos blancos");
                        Console.WriteLine("\tc) Mitocondria");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o 
                        if (Respuesta.ToLower() == "a" || Respuesta.ToLower() == "globulos rojos" || Respuesta.ToLower() == "glóbulos rojos")
                        {
                            // Se activa la variable que determina si se ganó la ronda
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            // En caso de que no haya acertado se le informa al usuario
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era Globulos rojos");
                        }
                        break;
                    case (8):
                        Console.WriteLine("¿Qué órgano almacena la bilis?");
                        Console.WriteLine("\ta) Corazón");
                        Console.WriteLine("\tb) Mitocondria");
                        Console.WriteLine("\tc) Vesícula biliar");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o n
                        if (Respuesta.ToLower() == "c" || Respuesta.ToLower() == "vesicula biliar" || Respuesta.ToLower() == "vesícula biliar")
                        {
                            // Se activa la variable que determina si se ganó la ronda
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            // En caso de que no haya acertado se le informa al usuario
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era Vesícula biliar");
                        }
                        break;
                    case (9):
                        Console.WriteLine("¿Cuál es la función principal del intestino delgado?");
                        Console.WriteLine("\ta) Insulina");
                        Console.WriteLine("\tb) Absorber nutrientes");
                        Console.WriteLine("\tc) Regular el oxígeno");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (Respuesta.ToLower() == "b" || Respuesta.ToLower() == "absorber nutrientes")
                        {
                            // Se activa la variable que determina si se ganó la ronda
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            // En caso de que no haya acertado se le informa al usuario
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era Absorber nutrientes");
                        }
                        break;
                    case (10):
                        Console.WriteLine("¿Qué órgano se encarga de la producción de glóbulos blancos y rojos?");
                        Console.WriteLine("\ta) Sistema nervioso");
                        Console.WriteLine("\tb) Hipotalamo");
                        Console.WriteLine("\tc) Medula ósea");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (Respuesta.ToLower() == "c" || Respuesta.ToLower() == "medula osea" || Respuesta.ToLower() == "medula ósea")
                        {
                            // Se activa la variable que determina si se ganó la ronda
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            // En caso de que no haya acertado se le informa al usuario
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era Medula osea");
                        }
                        break;
                    default:
                        Console.WriteLine("Error en la evaluación de la respuesta.");
                        Console.ReadKey();
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
                Console.WriteLine("¡Pregunta avanzada!");
                // Accedemos al número de pregunta aleatoria mediante el índice generado
                switch (preguntasAvanzadas[preguntaAleatoria])
                {
                    case (1):
                        Console.WriteLine("pregunta 1: ¿Cuál es el orgánulo responsable de la producción de energía en la célula?");
                        Console.WriteLine("\ta) Nucleo");
                        Console.WriteLine("\tb) Mitocondria");
                        Console.WriteLine("\tc) Lisomas");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (Respuesta.ToLower() == "b" || Respuesta.ToLower() == "mitocondria")
                        {
                            // Se activa la variable que determina si se ganó la ronda
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            // En caso de que no haya acertado se le informa al usuario
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era Mitocondria");
                        }
                        break;
                    // Las demás preguntas deberán tener un formato similar
                    case (2):
                        Console.WriteLine("¿Cómo se llama el proceso de división celular que resulta en células hijas idénticas?");
                        Console.WriteLine("\ta) Simbiosis");
                        Console.WriteLine("\tb) Interfase");
                        Console.WriteLine("\tc) Mitosis");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (Respuesta.ToLower() == "c" || Respuesta.ToLower() == "mitosis")
                        {
                            // Se activa la variable que determina si se ganó la ronda
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            // En caso de que no haya acertado se le informa al usuario
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era Mitosis");
                        }
                        break;
                    case (3):
                        Console.WriteLine("¿Qué elemento químico tiene el símbolo Fe?");
                        Console.WriteLine("\ta) Hierro");
                        Console.WriteLine("\tb) Cobre");
                        Console.WriteLine("\tc) Plata");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (Respuesta.ToLower() == "a" || Respuesta.ToLower() == "hierro")
                        {
                            // Se activa la variable que determina si se ganó la ronda
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            // En caso de que no haya acertado se le informa al usuario
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era Hierro");
                        }
                        break;
                    case (4):
                        Console.WriteLine("¿Cuál es la fórmula química del agua?");
                        Console.WriteLine("\ta) Ca");
                        Console.WriteLine("\tb) H2O");
                        Console.WriteLine("\tc) Na");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (Respuesta.ToLower() == "b" || Respuesta.ToLower() == "h2o")
                        {
                            // Se activa la variable que determina si se ganó la ronda
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            // En caso de que no haya acertado se le informa al usuario
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era H2O");
                        }

                        break;
                    case (5):
                        Console.WriteLine("¿Qué orgánulo celular contiene el material genético en las células eucariotas?");
                        Console.WriteLine("\ta) Mitocondria");
                        Console.WriteLine("\tb) Núcleo");
                        Console.WriteLine("\tc) Aparato de Golgi");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (Respuesta.ToLower() == "b" || Respuesta.ToLower() == "nucleo" || Respuesta.ToLower() == "núcleo")
                        {
                            // Se activa la variable que determina si se ganó la ronda
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            // En caso de que no haya acertado se le informa al usuario
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era Núcleo");
                        }
                        break;
                    case (6):
                        Console.WriteLine("¿Qué enlace químico se forma entre dos átomos que comparten electrones?");
                        Console.WriteLine("\ta) Enlace equivalente");
                        Console.WriteLine("\tb) Enlace covalente");
                        Console.WriteLine("\tc) Enlace metálico");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (Respuesta.ToLower() == "b" || Respuesta.ToLower() == "enlace covalente")
                        {
                            // Se activa la variable que determina si se ganó la ronda
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            // En caso de que no haya acertado se le informa al usuario
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era Enlace covalente");
                        }
                        break;
                    case (7):
                        Console.WriteLine("¿Cuál es el pH de una solución neutra?");
                        Console.WriteLine("\ta) 7");
                        Console.WriteLine("\tb) 14");
                        Console.WriteLine("\tc) 0");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (Respuesta.ToLower() == "a" || Respuesta.ToLower() == "7")
                        {
                            // Se activa la variable que determina si se ganó la ronda
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            // En caso de que no haya acertado se le informa al usuario
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era 7");
                        }
                        break;
                    case (8):
                        Console.WriteLine("¿Qué tipo de molécula es el ATP?");
                        Console.WriteLine("\ta) Ácido sulfúrico");
                        Console.WriteLine("\tb) Ozono");
                        Console.WriteLine("\tc) Adenosín trisfosfato");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (Respuesta.ToLower() == "c" || Respuesta.ToLower() == "adenosin trifosfato" || Respuesta.ToLower() == "adenosín trifosfato")
                        {
                            // Se activa la variable que determina si se ganó la ronda
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            // En caso de que no haya acertado se le informa al usuario
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era Adenosín trifosfato");
                        }
                        break;
                    case (9):
                        Console.WriteLine("¿Qué proceso celular convierte el ADN en ARN?");
                        Console.WriteLine("\ta) Ósmosis");
                        Console.WriteLine("\tb) Transcripción");
                        Console.WriteLine("\tc) Mitósis");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (Respuesta.ToLower() == "b" || Respuesta.ToLower() == "transcripcion" || Respuesta.ToLower() == "transcripción")
                        {
                            // Se activa la variable que determina si se ganó la ronda
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            // En caso de que no haya acertado se le informa al usuario
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era Transcripción");
                        }
                        break;
                    case (10):
                        Console.WriteLine("¿Qué partícula subatómica tiene carga negativa?");
                        Console.WriteLine("\ta) Protón");
                        Console.WriteLine("\tb) Neutrón");
                        Console.WriteLine("\tc) Electrón");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (Respuesta.ToLower() == "c" || Respuesta.ToLower() == "electron" || Respuesta.ToLower() == "electrón")
                        {
                            // Se activa la variable que determina si se ganó la ronda
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            // En caso de que no haya acertado se le informa al usuario
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era Electrón");
                        }
                        break;
                    default:
                        Console.WriteLine("Error en la evaluación de la respuesta.");
                        Console.ReadKey();
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
}