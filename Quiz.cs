﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    internal class Quiz
    {
        // Variable que almacenará las respuestas del usuario
        private string respuesta;
        private bool respuestaCorrecta = false;
        // Variable que almacenará el número de preguntas aleatorias
        // ESTO DEJARLO COMO PROTECTED
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

        public string Respuesta { get => Respuesta; set => Respuesta = value; }
        public bool RespuestaCorrecta { get => respuestaCorrecta; set => respuestaCorrecta = value; }

        // Cada método de cada categoría generará UNA pregunta aleatoria de esa categoría dependiendo la dificultad
        public virtual void Basico(Concursante concursante)
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
                // Accedemos al número de pregunta aleatoria mediante el índice generado
                switch (preguntasBasicas[preguntaAleatoria])
                {
                    case (1):
                        Console.WriteLine("¿Cuál es la capital de Uruguay?");
                        Console.WriteLine("\ta) Montevideo");
                        Console.WriteLine("\tb) Uruguay");
                        Console.WriteLine("\tc) Buenos Aires");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                        // Se evalúa si se dio una respuesta correcta o no
                        if (Respuesta.ToLower() == "a" || Respuesta.ToLower() == "Montevideo")
                        {
                            // Se activa la variable que determina si se ganó la ronda
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            // En caso de que no haya acertado se le informa al usuario
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era Montevideo");
                        }
                        break;
                    // Las demás preguntas deberán tener un formato similar
                    case (2):
                        Console.WriteLine("¿En qué país está el famosos Machu Pichu?");
                        Console.WriteLine("\ta) Chile");
                        Console.WriteLine("\tb) Estados Unidos");
                        Console.WriteLine("\tc) Perú");
                        Console.WriteLine("\td) México");

                        Respuesta = Console.ReadLine().ToLower();
                        if (Respuesta == "c" || Respuesta == "peru" || Respuesta == "perú")
                        {
                            respuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta!, la respuesta correcta era: Perú");
                        }
                        break;
                    case (3):
                        Console.WriteLine("");
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
                        Console.WriteLine("¿Cuál es la capital de Uruguay?");
                        Console.WriteLine("\ta) Montevideo");
                        Console.WriteLine("\tb) Uruguay");
                        Console.WriteLine("\tc) Buenos Aires");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();


                        respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                        // Se evalúa si se dio una respuesta correcta o no
                        if (respuesta.ToLower() == "a" || respuesta.ToLower() == "Montevideo")
                        {
                            // Se activa la variable que determina si se ganó la ronda
                            respuestaCorrecta = true;
                        }
                        else
                        {
                            // En caso de que no haya acertado se le informa al usuario
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era Montevideo");
                        }
                        break;
                    // Las demás preguntas deberán tener un formato similar
                    case (2):
                        Console.WriteLine("Pregunta 2");
                        break;
                    case (3):
                        Console.WriteLine("Pregunta 3");
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
        public virtual void Avanzado(Concursante concursante) 
        {
            // EN VEZ DE USAR `preguntasBasicas` USAR `preguntasAvanzadas`             
        }
    }
}
