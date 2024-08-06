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
                        Console.WriteLine("Oro parece, plata no es. Abran las cortinas y verán lo que es");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine();
                        if (Respuesta.ToLower() == "el platano" || Respuesta.ToLower() == "un platano")
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
                        if (Respuesta.ToLower() == "el hipopótamo" || Respuesta.ToLower() == "un hipopótamo")
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
                        if (Respuesta.ToLower() == "el botón" || Respuesta.ToLower() == "un botón")
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
            if (preguntasIntermedias.Count == 0)
            {
                Console.WriteLine("¡No hay más preguntas en esta categoría!");
            }

            else
            {
                Random pregunta = new Random(); // Instancia para generar números aleatorios
                int preguntaAleatoria = pregunta.Next(preguntasIntermedias.Count); // Genera la pregunta aleatoria
                // Accedemos al número de pregunta aleatoria mediante el índice generado
                switch (preguntasIntermedias[preguntaAleatoria])
                {
                    case (1):
                        Console.WriteLine("Alto, alto como un pino, pero menos que un comino. ¿Qué soy?");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                        // Se evalúa si se dio una respuesta correcta o no
                        if (Respuesta.ToLower() == "el humo" || Respuesta.ToLower() == "humo")
                        {
                            // Se activa la variable que determina si se ganó la ronda
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            // En caso de que no haya acertado se le informa al usuario
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era !EL HUMNO¡ :D ");
                        }
                        break;
                    // Las demás preguntas deberán tener un formato similar
                    case (2):
                        Console.WriteLine("En el campo fui nacida, mis hermanas son las flores, los caballeros y damas me " +
                            " cortan siempre en amores. ¿Qué soy?");
                        Console.Write("Escribe tu respuesta: ");


                        Respuesta = Console.ReadLine().ToLower();
                        if (Respuesta == "La rosa" || Respuesta == "una rosa")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta!, la respuesta correcta era: !LA ROSA¡ :D ");
                        }
                        break;
                    case (3):
                        Console.WriteLine("Siempre mirando al sol y no soy un caracol. Giro y giro sin fin y no soy un " +
                            "bailarín. ¿Quien soy?");
                        Console.Write("Escribe tu respuesta: ");


                        Respuesta = Console.ReadLine().ToLower();
                        if (Respuesta == "El girasol" || Respuesta == "un girasol")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta!, la respuesta correcta era: !EL GIRASOL¡ :D ");
                        }
                        break;
                    case (4):
                        Console.WriteLine("Tengo cien hermanos, todos calvos, ninguna usa sombrero y todos usan zapatos. " +
                            "¿Qué soy?");
                        Console.Write("Escribe tu respuesta: ");


                        Respuesta = Console.ReadLine().ToLower();
                        if (Respuesta == "El peine" || Respuesta == "un peine")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta!, la respuesta correcta era: !EL PEINE¡ :D ");
                        }
                        break;
                    case (5):
                        Console.WriteLine("Lentes chiquitas, jóvenes o viejas, si quieres nos tomas y si no, nos dejas." +
                            "¿Qué soy?");
                        Console.Write("Escribe tu respuesta: ");


                        Respuesta = Console.ReadLine().ToLower();
                        if (Respuesta == "Las lentejas" || Respuesta == "lentejas")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta!, la respuesta correcta era: !LAS LENTEJAS¡ :D ");
                        }
                        break;
                    case (6):
                        Console.WriteLine("No es reloj, pero hace tic-tac, no es abogado, pero tiene un gran despacho. " +
                            "¿Qué soy?");
                        Console.Write("Escribe tu respuesta: ");


                        Respuesta = Console.ReadLine().ToLower();
                        if (Respuesta == "el corazón" || Respuesta == "corazón")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta!, la respuesta correcta era: !EL CORAZÓN¡ :D ");
                        }
                        break;
                    case (7):
                        Console.WriteLine("No es olla pero se tapa, no es caja pero se empaca. ¿Qué soy?");
                        Console.Write("Escribe tu respuesta: ");


                        Respuesta = Console.ReadLine().ToLower();
                        if (Respuesta == "el libro" || Respuesta == "libro")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta!, la respuesta correcta era: !EL LIBRO¡ :D ");
                        }
                        break;
                    case (8):
                        Console.WriteLine("No es león y tiene agarre, no es pato y tiene pata. ¿Qué soy?");
                        Console.Write("Escribe tu respuesta: ");


                        Respuesta = Console.ReadLine().ToLower();
                        if (Respuesta == "la taza" || Respuesta == "una taza")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta!, la respuesta correcta era: !LA TAZA¡ :D ");
                        }
                        break;
                    case (9):
                        Console.WriteLine("No es un tubo y tiene pasta, no es comestible pero se gasta. ¿Qué soy?");
                        Console.Write("Escribe tu respuesta: ");


                        Respuesta = Console.ReadLine().ToLower();
                        if (Respuesta == "la pasta de dientes" || Respuesta == "pasta de dientes")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta!, la respuesta correcta era: !LA PASTA DE DIENTES¡ :D ");
                        }
                        break;
                    case (10):
                        Console.WriteLine("Soy bonito por delante, algo feo por detrás, me transformo a cada instante, ya que" +
                            "imito a los demás. ¿Qué soy?");
                        Console.Write("Escribe tu respuesta: ");


                        Respuesta = Console.ReadLine().ToLower();
                        if (Respuesta == "el espejo" || Respuesta == "un espejo")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta!, la respuesta correcta era: !EL ESPEJO¡ :D ");
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
                switch (preguntasAvanzadas[preguntaAleatoria])
                {
                    case (1):
                        Console.WriteLine("¿Cuál es el instrumento que se mete y deja líquido dentro?");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                        // Se evalúa si se dio una respuesta correcta o no
                        if (Respuesta.ToLower() == "la jeringa" || Respuesta.ToLower() == "una jeringa")
                        {
                            // Se activa la variable que determina si se ganó la ronda
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            // En caso de que no haya acertado se le informa al usuario
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era !LA JERINGA¡ :D ");
                        }
                        break;
                    // Las demás preguntas deberán tener un formato similar
                    case (2):
                        Console.WriteLine("¿Qué tiene las mujeres en medio de las piernas?");
                        Console.Write("Escribe tu respuesta: ");



                        Respuesta = Console.ReadLine().ToLower();
                        if (Respuesta == "las rodillas" || Respuesta == "rodillas")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta!, la respuesta correcta era: LAS RODILLAS");
                        }
                        break;
                    case (3):
                        Console.WriteLine("Entra duro y seco y sale blandito y mojado ¿Qué es?");
                        Console.Write("Escribe tu respuesta: ");



                        Respuesta = Console.ReadLine().ToLower();
                        if (Respuesta == "el chicle" || Respuesta == "un chicle")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta!, la respuesta correcta era: EL CHICLE");
                        }
                        break;
                    case (4):
                        Console.WriteLine("Tengo un par, van colgando y al caminar se van desplazando ¿Qué son?");
                        Console.Write("Escribe tu respuesta: ");



                        Respuesta = Console.ReadLine().ToLower();
                        if (Respuesta == "los brazos" || Respuesta == "brazos")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta!, la respuesta correcta era: LOS BRAZOS");
                        }
                        break;
                    case (5):
                        Console.WriteLine("Una vez al día es manía, una vez por semana es cosa sana, una vez por mes " +
                            "es dejadez, una vez por año se te oxida el caño. ¿Qué es?");
                        Console.Write("Escribe tu respuesta: ");



                        Respuesta = Console.ReadLine().ToLower();
                        if (Respuesta == "bañarse" || Respuesta == "bañarse")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta!, la respuesta correcta era: BAÑARSE");
                        }
                        break;
                    case (6):
                        Console.WriteLine("Es largo y duro, lo utilizan los hombres y mujeres y siempre da batalla ¿Qué es?");
                        Console.Write("Escribe tu respuesta: ");



                        Respuesta = Console.ReadLine().ToLower();
                        if (Respuesta == "un rifle" || Respuesta == "el rifle")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta!, la respuesta correcta era: EL RIFLE");
                        }
                        break;
                    case (7):
                        Console.WriteLine("Es suave por dentro y peludo por fuera. Con un poco de esfuerzo lo podras meter " +
                            "dentro. ¿Qué es?");
                        Console.Write("Escribe tu respuesta: ");



                        Respuesta = Console.ReadLine().ToLower();
                        if (Respuesta == "un calcetin " || Respuesta == "el calcetin")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta!, la respuesta correcta era: EL CALCETÍN");
                        }
                        break;
                    case (8):
                        Console.WriteLine("Pelos por arriba y pelos por debajo, en el medio una rajita húmeda. ¿Qué es?");
                        Console.Write("Escribe tu respuesta: ");



                        Respuesta = Console.ReadLine().ToLower();
                        if (Respuesta == "el ojo" || Respuesta == "ojo")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta!, la respuesta correcta era: UEL OJO");
                        }
                        break;
                    case (9):
                        Console.WriteLine("Bolas grandes, colgantes, gordas y peludas que son voluminosas y hermosas. " +
                            "¿Qué es?");
                        Console.Write("Escribe tu respuesta: ");



                        Respuesta = Console.ReadLine().ToLower();
                        if (Respuesta == "los cocos" || Respuesta == "cocos")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta!, la respuesta correcta era: LOS COCOS (MAL PENSADO ;)");
                        }
                        break;
                    case (10):
                        Console.WriteLine("Bolas grandes, colgantes, gordas y peludas que son voluminosas y hermosas. " +
                            "¿Qué es?");
                        Console.Write("Escribe tu respuesta: ");



                        Respuesta = Console.ReadLine().ToLower();
                        if (Respuesta == "los cocos" || Respuesta == "cocos")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta!, la respuesta correcta era: LOS COCOS");
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