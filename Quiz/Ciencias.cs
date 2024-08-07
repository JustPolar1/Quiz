using System;
using System.Collections.Generic;

namespace Quiz
{
    internal class Ciencias : Quiz
    {
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
                        Console.WriteLine("pregunta 1: ¿Qué parte de la planta absorbe agua y nutrientes del suelo?");
                        Console.WriteLine("\ta) Hojas");
                        Console.WriteLine("\tb) Tallo");
                        Console.WriteLine("\tc) Raices");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (Respuesta.ToLower() == "c" || Respuesta.ToLower() == "Raices")
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
                        Console.WriteLine("pregunta 2: ¿Cuál es el órgano principal del sistema respiratorio?");
                        Console.WriteLine("\ta) Nariz");
                        Console.WriteLine("\tb) Pulmones");
                        Console.WriteLine("\tc) Boca");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (Respuesta.ToLower() == "b" || Respuesta.ToLower() == "Pulmones")
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
                        Console.WriteLine("pregunta 3: ¿Cómo se llama el proceso por el cual las plantas producen su propio alimento?");
                        Console.WriteLine("\ta) Fotosintesis");
                        Console.WriteLine("\tb) Digestion");
                        Console.WriteLine("\tc) Absorcion");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (Respuesta.ToLower() == "a" || Respuesta.ToLower() == "Fotosintesis")
                        {
                            // Se activa la variable que determina si se ganó la ronda
                            RespuestaCorrecta = true;
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

                        Respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (Respuesta.ToLower() == "c" || Respuesta.ToLower() == "Anfibio")
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
                        Console.WriteLine("pregunta 5:  ¿Qué parte del cuerpo humano se usa para pensar?");
                        Console.WriteLine("\ta) Faringe");
                        Console.WriteLine("\tb) Cerebro");
                        Console.WriteLine("\tc) Cerebelo");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (Respuesta.ToLower() == "b" || Respuesta.ToLower() == "Cerebro")
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
                        Console.WriteLine("pregunta 6: ¿Cómo se llama el cambio de una oruga a una mariposa?");
                        Console.WriteLine("\ta) Evolucion");
                        Console.WriteLine("\tb) Metamorfosis");
                        Console.WriteLine("\tc) crecimiento");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (Respuesta.ToLower() == "b" || Respuesta.ToLower() == "Metamorfosis")
                        {
                            // Se activa la variable que determina si se ganó la ronda
                            RespuestaCorrecta = true;
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

                        Respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (Respuesta.ToLower() == "b" || Respuesta.ToLower() == "Agua")
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
                        Console.WriteLine("pregunta 8:  ¿Qué tipo de animal pone huevos?");
                        Console.WriteLine("\ta) Aves");
                        Console.WriteLine("\tb) Equinos");
                        Console.WriteLine("\tc) Homo sapiens");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (Respuesta.ToLower() == "a" || Respuesta.ToLower() == "Aves")
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
                        Console.WriteLine("pregunta 9: ¿Qué necesitan las plantas para crecer además de agua y luz solar?");
                        Console.WriteLine("\ta) Frio");
                        Console.WriteLine("\tb) Nutrientes del suelo y dioxido de carbono");
                        Console.WriteLine("\tc) Arena");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (Respuesta.ToLower() == "b" || Respuesta.ToLower() == "Nutrientes del suelo y dioxido de carbono")
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
                        Console.WriteLine("pregunta 10:  ¿Cómo se llama el órgano que bombea sangre a todo el cuerpo?");
                        Console.WriteLine("\ta) Pancreas");
                        Console.WriteLine("\tb) Higado");
                        Console.WriteLine("\tc) Corazon");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (Respuesta.ToLower() == "c" || Respuesta.ToLower() == "Corazon")
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
                        Console.WriteLine("pregunta 1: ¿Cuál es el órgano encargado de filtrar la sangre en el cuerpo humano?");
                        Console.WriteLine("\ta) Higado");
                        Console.WriteLine("\tb) Riñones");
                        Console.WriteLine("\tc) Vesicula");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (Respuesta.ToLower() == "b" || Respuesta.ToLower() == "Riñones")
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
                        Console.WriteLine("pregunta 2: ¿Cómo se llama el tubo que conecta la boca con el estómago?");
                        Console.WriteLine("\ta) Intestino");
                        Console.WriteLine("\tb) Pulmones");
                        Console.WriteLine("\tc) Esofago");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (Respuesta.ToLower() == "c" || Respuesta.ToLower() == "Esofago")
                        {
                            // Se activa la variable que determina si se ganó la ronda
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            // En caso de que no haya acertado se le informa al usuario
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era Esofago");
                        }
                        break;
                    case (3):
                        Console.WriteLine("pregunta 3: ¿Qué órgano produce insulina en el cuerpo humano?");
                        Console.WriteLine("\ta) Pancreas");
                        Console.WriteLine("\tb) Estomago");
                        Console.WriteLine("\tc) Higado");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (Respuesta.ToLower() == "a" || Respuesta.ToLower() == "Pancreas")
                        {
                            // Se activa la variable que determina si se ganó la ronda
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            // En caso de que no haya acertado se le informa al usuario
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era Pancreas");
                        }
                        break;
                    case (4):
                        Console.WriteLine("pregunta 4: ¿Dónde se encuentran los alvéolos?");
                        Console.WriteLine("\ta) Pancreas");
                        Console.WriteLine("\tb) Pulmones");
                        Console.WriteLine("\tc) Colon");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (Respuesta.ToLower() == "b" || Respuesta.ToLower() == "Pulmones")
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
                        Console.WriteLine("pregunta 5: ¿Qué estructura del cerebro controla el equilibrio y la coordinación?");
                        Console.WriteLine("\ta) Hipotalamo");
                        Console.WriteLine("\tb) Cerebelo");
                        Console.WriteLine("\tc) Bulbo raquideo");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (Respuesta.ToLower() == "b" || Respuesta.ToLower() == "Cerebelo")
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
                        Console.WriteLine("pregunta 6: ¿Cómo se llama la capa externa de la piel?");
                        Console.WriteLine("\ta) Dermis");
                        Console.WriteLine("\tb) Epidermis");
                        Console.WriteLine("\tc) Musculo");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (Respuesta.ToLower() == "b" || Respuesta.ToLower() == "Epidermis")
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
                        Console.WriteLine("pregunta 7: ¿Qué tipo de células transportan oxígeno en la sangre?");
                        Console.WriteLine("\ta) Globulos rojos");
                        Console.WriteLine("\tb) Globulos blancos");
                        Console.WriteLine("\tc) Mitocondria");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (Respuesta.ToLower() == "a" || Respuesta.ToLower() == "Globulos rojos")
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
                        Console.WriteLine("pregunta 8:  ¿Qué órgano almacena la bilis?");
                        Console.WriteLine("\ta) Corazon");
                        Console.WriteLine("\tb) Mitocondria");
                        Console.WriteLine("\tc) Vesicula biliar");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (Respuesta.ToLower() == "c" || Respuesta.ToLower() == "Vesicula biliar")
                        {
                            // Se activa la variable que determina si se ganó la ronda
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            // En caso de que no haya acertado se le informa al usuario
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era Vesicula biliar");
                        }
                        break;
                    case (9):
                        Console.WriteLine("pregunta 9: ¿Cuál es la función principal del intestino delgado?");
                        Console.WriteLine("\ta) Insulina");
                        Console.WriteLine("\tb) Absorber nutrientes");
                        Console.WriteLine("\tc) Regular el oxigeno");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (Respuesta.ToLower() == "b" || Respuesta.ToLower() == "Absorber nutrientes")
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
                        Console.WriteLine("pregunta 10:  ¿Qué órgano se encarga de la producción de glóbulos blancos y rojos?");
                        Console.WriteLine("\ta) Sistema nervioso");
                        Console.WriteLine("\tb) Hipotalamo");
                        Console.WriteLine("\tc) Medula osea");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (Respuesta.ToLower() == "c" || Respuesta.ToLower() == "Medula osea")
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
                        if (Respuesta.ToLower() == "b" || Respuesta.ToLower() == "Mitocondria")
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
                        Console.WriteLine("pregunta 2: ¿Cómo se llama el proceso de división celular que resulta en células hijas idénticas?");
                        Console.WriteLine("\ta) Simbiosis");
                        Console.WriteLine("\tb) Interfase");
                        Console.WriteLine("\tc) Mitosis");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (Respuesta.ToLower() == "c" || Respuesta.ToLower() == "Mitosis")
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
                        Console.WriteLine("pregunta 3: ¿Qué elemento químico tiene el símbolo Fe?");
                        Console.WriteLine("\ta) Hierro");
                        Console.WriteLine("\tb) Cobre");
                        Console.WriteLine("\tc) Plata");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (Respuesta.ToLower() == "a" || Respuesta.ToLower() == "Hierro")
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
                        Console.WriteLine("pregunta 4:  ¿Cuál es la fórmula química del agua?");
                        Console.WriteLine("\ta) Ca");
                        Console.WriteLine("\tb) H20");
                        Console.WriteLine("\tc) Na");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (Respuesta.ToLower() == "b" || Respuesta.ToLower() == "H20")
                        {
                            // Se activa la variable que determina si se ganó la ronda
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            // En caso de que no haya acertado se le informa al usuario
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era H20");
                        }

                        break;
                    case (5):
                        Console.WriteLine("pregunta 5: ¿Qué orgánulo celular contiene el material genético en las células eucariotas?");
                        Console.WriteLine("\ta) Mitocondria");
                        Console.WriteLine("\tb) Nucleo");
                        Console.WriteLine("\tc) Aparato de Golgi");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (Respuesta.ToLower() == "b" || Respuesta.ToLower() == "Nucleo")
                        {
                            // Se activa la variable que determina si se ganó la ronda
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            // En caso de que no haya acertado se le informa al usuario
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era Nucleo");
                        }
                        break;
                    case (6):
                        Console.WriteLine("pregunta 6: ¿Qué enlace químico se forma entre dos átomos que comparten electrones?");
                        Console.WriteLine("\ta) Enlace equivalente");
                        Console.WriteLine("\tb) Enlace covalente");
                        Console.WriteLine("\tc) Enlace metalico");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (Respuesta.ToLower() == "b" || Respuesta.ToLower() == "Enlace covalente")
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
                        Console.WriteLine("pregunta 7: ¿Cuál es el pH de una solución neutra?");
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
                        Console.WriteLine("pregunta 8:   ¿Qué tipo de molécula es el ATP?");
                        Console.WriteLine("\ta) Acido sulfurico");
                        Console.WriteLine("\tb) Ozono");
                        Console.WriteLine("\tc) Adenosin trisfosfato");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (Respuesta.ToLower() == "c" || Respuesta.ToLower() == "Adenosin trifosfato")
                        {
                            // Se activa la variable que determina si se ganó la ronda
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            // En caso de que no haya acertado se le informa al usuario
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era Adenosin trifosfato");
                        }
                        break;
                    case (9):
                        Console.WriteLine("pregunta 9: ¿Qué proceso celular convierte el ADN en ARN?");
                        Console.WriteLine("\ta) Osmosis");
                        Console.WriteLine("\tb) Transcripcion");
                        Console.WriteLine("\tc) Mitosis");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (Respuesta.ToLower() == "b" || Respuesta.ToLower() == "Transcripcion")
                        {
                            // Se activa la variable que determina si se ganó la ronda
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            // En caso de que no haya acertado se le informa al usuario
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era Transcripcion");
                        }
                        break;
                    case (10):
                        Console.WriteLine("pregunta 10:  ¿Qué partícula subatómica tiene carga negativa?");
                        Console.WriteLine("\ta) Proton");
                        Console.WriteLine("\tb) Neutron");
                        Console.WriteLine("\tc) Electron");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                                                        // Se evalúa si se dio una respuesta correcta o no
                        if (Respuesta.ToLower() == "c" || Respuesta.ToLower() == "Electron")
                        {
                            // Se activa la variable que determina si se ganó la ronda
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            // En caso de que no haya acertado se le informa al usuario
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era Electron");
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
                preguntasBasicas.RemoveAt(preguntaAleatoria);

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