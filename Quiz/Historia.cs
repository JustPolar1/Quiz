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

                        Respuesta = Console.ReadLine().ToLower(); 
                        if (Respuesta == "a" || Respuesta == "emiliano zapata")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era a) Emiliano Zapata");
                        }
                        break;
                        
                    case (2):
                        Console.WriteLine("¿Cuál es el grupo indígena mas reconocido en México en los siglos 10 al 16?");
                        Console.WriteLine("\ta) Toltecas ");
                        Console.WriteLine("\tb) Mayas");
                        Console.WriteLine("\tc) Aztecas");
                        Console.WriteLine("\td) Todas las anteriores");
                        Console.Write("Escribe tu respuesta: ");

                        Respuesta = Console.ReadLine().ToLower();
                        if (Respuesta == "d" || Respuesta == "todas las anteriores")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era d) Todas las anteriores");
                        }
                        break;
                    case (3):
                        Console.WriteLine("Pregunta 3");
                        Console.WriteLine("¿A que imperio indigena se enfrentó y conquistó el español Hernán Cortés?");
                        Console.WriteLine("\ta) Imperio Mexica");
                        Console.WriteLine("\tb) Imperio Azteca");
                        Console.WriteLine("\tc) Imperio Purépechas");
                        Console.Write("Escribe tu respuesta: ");

                        Respuesta = Console.ReadLine().ToLower();
                        if (Respuesta == "b" || Respuesta == "imperio azteca")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era b) Imperio Azteca");
                        }
                        break;
                    default:
                        break;
                    case (4):
                        Console.WriteLine("¿En qué fecha empezó la Revolución Mexicana?");
                        Console.WriteLine("\ta) 20 de noviembre de 1912 ");
                        Console.WriteLine("\tb) 18 de noviembre de 1910");
                        Console.WriteLine("\tc) 20 de noviembre de 1910");
                        Console.WriteLine("\td) 18 de noviembre de 1912");
                        Console.Write("Escribe tu respuesta: ");


                        Respuesta = Console.ReadLine().ToLower();
                        if (Respuesta== "c" || Respuesta == "20 de noviembre de 1910")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era d) 20 de noviembre de 1910");
                        }
                        break;
                    case (5):
                        Console.WriteLine("¿Quién dió el 'Grito de Dolores'?");
                        Console.WriteLine("\ta) Ignacio Allende");
                        Console.WriteLine("\tb) Guadalupe Victoria");
                        Console.WriteLine("\tc) Miguel Hidalgo");
                        Console.WriteLine("\td) José María Morelos");
                        Console.Write("Escribe tu respuesta: ");


                        Respuesta = Console.ReadLine().ToLower();
                        if (Respuesta == "c" || Respuesta == "miguel hidalgo")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era c) Miguel Hidalgo");
                        }
                        break;
                    case (6):
                        Console.WriteLine("¿Cuánto duró la 'Guerra de Independencia'?");
                        Console.WriteLine("\ta) 10 años");
                        Console.WriteLine("\tb) 9 años");
                        Console.WriteLine("\tc) 12 años");
                        Console.WriteLine("\td) 11 años");
                        Console.Write("Escribe tu respuesta: ");


                        Respuesta = Console.ReadLine().ToLower();
                        if (Respuesta == "d" || Respuesta == "11 años")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era d) 11 años");
                        }
                        break;
                    case (7):
                        Console.WriteLine("¿Quién estuvo en un calabozo en la Ciudad de Chihuahua?");
                        Console.WriteLine("\ta) Miguel Hidalgo");
                        Console.WriteLine("\tb) Francisco Villa");
                        Console.WriteLine("\tc) Francisco I. Madero");
                        Console.WriteLine("\td) Josefa Ortiz de Domínguez");
                        Console.Write("Escribe tu respuesta: ");


                        Respuesta = Console.ReadLine().ToLower();
                        if (Respuesta == "a" || Respuesta == "miguel hidalgo")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era a) Miguel Hidalgo");
                        }
                        break;
                    case (8):
                        Console.WriteLine("¿Cuántos Niños Heroes eran?");
                        Console.WriteLine("\ta) 5");
                        Console.WriteLine("\tb) 6");
                        Console.WriteLine("\tc) 8");
                        Console.WriteLine("\td) 7");
                        Console.Write("Escribe tu respuesta: ");


                        Respuesta = Console.ReadLine().ToLower();
                        if (Respuesta == "b" || Respuesta == "6" || Respuesta == "seis")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era b) 6");
                        }
                        break;
                    case (9):
                        Console.WriteLine("¿Cuándo ocurrió la 'Guerra de los Pasteles'?");
                        Console.WriteLine("\ta) 21 de noviembre de 1838");
                        Console.WriteLine("\tb) 19 de noviembre de 1838");
                        Console.WriteLine("\tc) 19 de noviembre de 1840");
                        Console.WriteLine("\td) 21 de noviembre de 1840");
                        Console.Write("Escribe tu respuesta: ");


                        Respuesta = Console.ReadLine().ToLower();
                        if (Respuesta == "a" || Respuesta == "21 de noviembre de 1838")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era d)21 de noviembre de 1838");
                        }
                        break;
                    case (10):
                        Console.WriteLine("¿Cuánto duró el Porfiriato?");
                        Console.WriteLine("\ta) 30 años");
                        Console.WriteLine("\tb) 29 años");
                        Console.WriteLine("\tc) 31 años");
                        Console.WriteLine("\td) 35 años");
                        Console.Write("Escribe tu respuesta: ");


                        Respuesta = Console.ReadLine().ToLower();
                        if (Respuesta == "a" || Respuesta == "30 años")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era a) 30 años");
                        }
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