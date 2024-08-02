using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    internal class Historia:Quiz
    {
        public override void Basico(Concursante concursante)
        {
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
                        Console.WriteLine("¿Quién fue el líder revolucionario que luchó por la reforma agraria y la justicia social en México?");
                        Console.WriteLine("\ta) Emiliano Zapata ");
                        Console.WriteLine("\tb) Porfirio Días");
                        Console.WriteLine("\tc) Francisco Villa");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine(); 
                        if (Respuesta.ToLower() == "a" || Respuesta.ToLower() == "Emiliano Zapata")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era Emiliano Zapata");
                        }
                        break;
                        
                    case (2):
                        Console.WriteLine("¿Cuál es el grupo indígena mas reconocido en México en los siglos 10 al 16?");
                        Console.WriteLine("\ta) Toltecas ");
                        Console.WriteLine("\tb) Mayas");
                        Console.WriteLine("\tc) Aztecas");
                        Console.WriteLine("\td) Todas las anteriores");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine();
                        if (Respuesta.ToLower() == "d" || Respuesta.ToLower() == "Todas las anteriores")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era Todas las anteriores");
                        }
                        break;
                    case (3):
                        Console.WriteLine("Pregunta 3");
                        Console.WriteLine("¿A que imperio indigena se enfrentó y conquistó el español Hernán Cortés?");
                        Console.WriteLine("\ta) Imperio Mexica");
                        Console.WriteLine("\tb) Imperio Azteca");
                        Console.WriteLine("\tc) Imperio Purépechas");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine();
                        if (Respuesta.ToLower() == "b" || Respuesta.ToLower() == "Imperio Azteca")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era Imperio Azteca");
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
    }
}
