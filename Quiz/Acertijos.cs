using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    internal class Acertijos : Quiz
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
                Console.WriteLine("Hola, Bienvenido al Quiz de las adivinanzas, donde tu desespero es nuestra alegria");
                Console.WriteLine("Bienvenido al final fácil, ¿listo?, comencemos ;)");
                Random pregunta = new Random();
                int preguntaAleatoria = pregunta.Next(preguntasBasicas.Count);
                switch (preguntasBasicas[preguntaAleatoria])
                {
                    case (1):
                        Console.WriteLine("Blanco es, la gallina lo pone, con aceite se fríe y con pan se come. ¿Qué cosa es?");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine();
                        if (Respuesta.ToLower() == "el huevo" || Respuesta.ToLower() == "un huevo")
                        {

                            RespuestaCorrecta = true;
                        }
                        else
                        {

                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta es !EL HUEVO¡ :D");
                        }
                        break;

                    case (2):
                        Console.WriteLine("Oro parece, plata no es. Abran las cortinas y veran lo que es");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine();
                        if (Respuesta.ToLower() == "El platano" || Respuesta.ToLower() == "un platano")
                        {

                            RespuestaCorrecta = true;
                        }
                        else
                        {

                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta es !EL PLATANO¡ :D ");
                        }
                        break;
                    case (3):
                        Console.WriteLine("Tiene dientes y no come, tiene cabeza y no es hombre. ¿Qué es?");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine();
                        if (Respuesta.ToLower() == "el huevo" || Respuesta.ToLower() == "un huevo")
                        {

                            RespuestaCorrecta = true;
                        }
                        else
                        {

                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta es !EL HUEVO¡ :D");
                        }
                        break;

                    case (4):
                        Console.WriteLine("Tengo hipo al decir mi nombre ¿Quien soy?");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine();
                        if (Respuesta.ToLower() == "el hipopotamo" || Respuesta.ToLower() == "un hipopotamo")
                        {

                            RespuestaCorrecta = true;
                        }
                        else
                        {

                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta es !EL HIPOPOTAMO¡ :D");
                        }

                        break;
                    case (5):
                        Console.WriteLine("Mi nombre empieza con bo, no soy bota ni botijo, !bobo, tonto¡, si ya te lo he dicho. ¿Qué soy?");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine();
                        if (Respuesta.ToLower() == "el boton" || Respuesta.ToLower() == "un boton")
                        {

                            RespuestaCorrecta = true;
                        }
                        else
                        {

                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta es !EL BOTÓN¡ :D");
                        }

                        break;
                    case (6):
                        Console.WriteLine("¿Qué es algo y a la vez nada?");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine();
                        if (Respuesta.ToLower() == "el pez" || Respuesta.ToLower() == "un pez")
                        {

                            RespuestaCorrecta = true;
                        }
                        else
                        {

                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta es !EL PEZ¡ :D");
                        }

                        break;
                    case (7):
                        Console.WriteLine("Si quiero caminar salto, y si quiero parar me agacho. ¿Que soy?");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine();
                        if (Respuesta.ToLower() == "el canguro" || Respuesta.ToLower() == "un canguro")
                        {

                            RespuestaCorrecta = true;
                        }
                        else
                        {

                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta es !EL CANGURO¡ :D");
                        }

                        break;
                    case (8):
                        Console.WriteLine("¿Quien hace en los troncos su oscura casita, y allí esconde, avara, cuanto necesita?");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine();
                        if (Respuesta.ToLower() == "La ardilla" || Respuesta.ToLower() == "una ardilla")
                        {

                            RespuestaCorrecta = true;
                        }
                        else
                        {

                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta es !LA ARDILLA¡ :D");
                        }

                        break;
                    case (9):
                        Console.WriteLine("Abierto siempre estoy pata todos los niños. Cerrado y solo me quedo los domingos. ¿Qué soy?");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine();
                        if (Respuesta.ToLower() == "la escuela" || Respuesta.ToLower() == "el colegio")
                        {

                            RespuestaCorrecta = true;
                        }
                        else
                        {

                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta es !LA ESCUELA/COLEGIO¡ :D");
                        }

                        break;
                    case (10):
                        Console.WriteLine("¿Que viene una vez en un minuto, dos veces en un momento y nunca en 1,000 años?");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine();
                        if (Respuesta.ToLower() == "La m" || Respuesta.ToLower() == "m")
                        {

                            RespuestaCorrecta = true;
                        }
                        else
                        {

                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta es !LA LETRA M¡ :D");
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