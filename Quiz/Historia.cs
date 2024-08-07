using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    internal class Historia : Quiz
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
                        if (Respuesta == "c" || Respuesta == "20 de noviembre de 1910")
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
                        Console.WriteLine("¿Cuales fueron los ultimos dos paises que lograron la independencia de España a finales del siglo XIX?");
                        Console.WriteLine("\ta) Cuba y Venezuela");
                        Console.WriteLine("\tb) Paraguay y Colombia");
                        Console.WriteLine("\tc) Cuba y Puerto Rico");
                        Console.WriteLine("\td) Puerto Rico y Guatemala");
                        Console.Write("Escribe tu respuesta: ");

                        Console.WriteLine();

                        Respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                        // Se evalúa si se dio una respuesta correcta o no
                        if (Respuesta.ToLower() == "c" || Respuesta.ToLower() == "cuba y puerto rico" || Respuesta.ToLower() == "puerto rico y cuba")
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
                        Console.WriteLine("¿Quien pronuncio la frase 'Maldito sea el soldado que vuelva las armas contra su pueblo'?");
                        Console.WriteLine("\ta) José de San Martin");
                        Console.WriteLine("\tb) Simón Bolovar");
                        Console.WriteLine("\tc) Hugo Chávez");
                        Console.WriteLine("\td) Antonio José de Sucre");
                        Console.Write("Escribe tu respuesta: ");


                        Respuesta = Console.ReadLine().ToLower();
                        if (Respuesta == "b" || Respuesta == "simon bolivar" || Respuesta == "simón bolivar")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta!, la respuesta correcta era b) Simón Bolivar ");
                        }
                        break;
                    case (3):
                        Console.WriteLine("¿Cómo se llamaban los hijos de españoles nacidos en los territorios colonizados?");
                        Console.WriteLine("\ta) Zambos");
                        Console.WriteLine("\tb) Criollos");
                        Console.WriteLine("\tc) Mulatos");
                        Console.WriteLine("\td) Castizo");
                        Console.Write("Escribe tu respuesta: ");


                        Respuesta = Console.ReadLine().ToLower();
                        if (Respuesta == "b" || Respuesta == "criollos")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta!, la respuesta correcta era b) Criollos");
                        }
                        break;
                    case (4):
                        Console.WriteLine("¿Quién de estos mandatarios ha permanecido más tiempo en el poder?");
                        Console.WriteLine("\ta) Fidel Castro");
                        Console.WriteLine("\tb) Francoise Duvalier");
                        Console.WriteLine("\tc) Getúlio Vargas");
                        Console.WriteLine("\td) Porfirio Díaz");
                        Console.Write("Escribe tu respuesta: ");


                        Respuesta = Console.ReadLine().ToLower();
                        if (Respuesta == "a" || Respuesta == "fidel castro" || Respuesta == "fidel" || Respuesta == "castro")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta!, la respuesta correcta era a) Fidel Castro");
                        }
                        break;
                    case (5):
                        Console.WriteLine("¿Quién fue el líder de la independencia de Venezuela?");
                        Console.WriteLine("\ta) José de San Martín");
                        Console.WriteLine("\tb) Bernardo O’Higgins");
                        Console.WriteLine("\tc) Antonio José de Sucre");
                        Console.WriteLine("\td) Simón Bolivar");
                        Console.Write("Escribe tu respuesta: ");


                        Respuesta = Console.ReadLine().ToLower();
                        if (Respuesta == "d" || Respuesta == "simon bolivar" || Respuesta == "simón bolivar")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta!, la respuesta correcta era d) Simón Bolivar");
                        }
                        break;
                    case (6):
                        Console.WriteLine("¿Cuál fue la civilización precolombina que construyo Machu Picchu?");
                        Console.WriteLine("\ta) Azteca");
                        Console.WriteLine("\tb) Maya");
                        Console.WriteLine("\tc) Inca");
                        Console.WriteLine("\td) Olmeca");
                        Console.Write("Escribe tu respuesta: ");


                        Respuesta = Console.ReadLine().ToLower();
                        if (Respuesta == "c" || Respuesta == "inca")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta!, la respuesta correcta era c) Inca");
                        }
                        break;
                    case (7):
                        Console.WriteLine("¿Qué país latinoamericano fue el último en abolir la esclavitud?");
                        Console.WriteLine("\ta) México");
                        Console.WriteLine("\tb) Brasil");
                        Console.WriteLine("\tc) Argentina");
                        Console.WriteLine("\td) Chile");
                        Console.Write("Escribe tu respuesta: ");


                        Respuesta = Console.ReadLine().ToLower();
                        if (Respuesta == "b" || Respuesta == "brasil")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta!, la respuesta correcta era b) Brasil");
                        }
                        break;
                    case (8):
                        Console.WriteLine("¿Qué tratado puso fin a la Guerra Hispanoamericana?");
                        Console.WriteLine("\ta) Tratado de Versalles");
                        Console.WriteLine("\tb) Tratado de París");
                        Console.WriteLine("\tc) Tratado de Tordesillas");
                        Console.WriteLine("\td) Tratado de Guadalupe Hidalgo");
                        Console.Write("Escribe tu respuesta: ");


                        Respuesta = Console.ReadLine().ToLower();
                        if (Respuesta == "b" || Respuesta == "tratado de paris" || Respuesta == "tratado de parís")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta!, la respuesta correcta era b) Tratado de París");
                        }
                        break;
                    case (9):
                        Console.WriteLine("¿Qué país fue gobernado por Augusto Pinochet entre 1973 y 1990?");
                        Console.WriteLine("\ta) Argentina");
                        Console.WriteLine("\tb) Perú");
                        Console.WriteLine("\tc) Chile");
                        Console.WriteLine("\td) Bolivia");
                        Console.Write("Escribe tu respuesta: ");


                        Respuesta = Console.ReadLine().ToLower();
                        if (Respuesta == "c" || Respuesta == "chile")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta!, la respuesta correcta era c) Chile");
                        }
                        break;
                    case (10):
                        Console.WriteLine("¿Quién fue el líder de la Revolución Haitiana?");
                        Console.WriteLine("\ta) Toussaint Louverture");
                        Console.WriteLine("\tb) Jean-Jacques Dessalines");
                        Console.WriteLine("\tc) Henri Christophe");
                        Console.WriteLine("\td) Alexandre Pétion");
                        Console.Write("Escribe tu respuesta: ");


                        Respuesta = Console.ReadLine().ToLower();
                        if (Respuesta == "a" || Respuesta == "toussaint louverture")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta!, la respuesta correcta era a) Toussaint Louverture");
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
                // Protocolo de finalización de la fase, agregar siempre.
                Console.WriteLine();

                Console.Write("Enter para continuar ");
                Console.ReadLine();
                Console.Clear();
                // Se devuelve a su estado original la variable de respuesta correcta
                RespuestaCorrecta = false;
            }
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
                int preguntaAleatoria = pregunta.Next(preguntasBasicas.Count); // Genera la pregunta aleatoria
                // Accedemos al número de pregunta aleatoria mediante el índice generado
                switch (preguntasAvanzadas[preguntaAleatoria])
                {
                    case (1):
                        Console.WriteLine("¿En que año comenzó la Primera Guerra Mundial");
                        Console.WriteLine("\ta) 1912");
                        Console.WriteLine("\tb) 1914");
                        Console.WriteLine("\tc) 1916");
                        Console.WriteLine("\td) 1918");
                        Console.Write("Escribe tu respuesta: ");
                        Console.WriteLine();

                        Respuesta = Console.ReadLine(); // se lee la respuesta del usuario
                        // Se evalúa si se dio una respuesta correcta o no
                        if (Respuesta.ToLower() == "b" || Respuesta.ToLower() == "1914")
                        {
                            // Se activa la variable que determina si se ganó la ronda
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            // En caso de que no haya acertado se le informa al usuario
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era b) 1914");
                        }
                        break;
                    // Las demás preguntas deberán tener un formato similar
                    case (2):
                        Console.WriteLine("¿Cuál fue el nombre del plan alemán para invadir Francia a través de" + 
                            "Bélgica durante la Primera Guerra Mundial?");
                        Console.WriteLine("\ta) Plan Schlieffen");
                        Console.WriteLine("\tb) Operación Barbarroja");
                        Console.WriteLine("\tc) Plan Dawes");
                        Console.WriteLine("\td) Operación Overlord");
                        Console.Write("Escribe tu respuesta: ");



                        Respuesta = Console.ReadLine().ToLower();
                        if (Respuesta == "a" || Respuesta == " plan schlieffen")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta!, la respuesta correcta era b) Plan Schlieffen");
                        }
                        break;
                    case (3):
                        Console.WriteLine("¿Cuál fue el nombre de tratado que puso fin oficialmente a la Primera Guerra Mundial?");
                        Console.WriteLine("\ta) Tratado de Versalles");
                        Console.WriteLine("\tb) Tratado de París");
                        Console.WriteLine("\tc) Tratado de Tordesillas");
                        Console.WriteLine("\td) Tratado de Ginebra");
                        Console.Write("Escribe tu respuesta: ");



                        Respuesta = Console.ReadLine().ToLower();
                        if (Respuesta == "a" || Respuesta == "tratado de versalles")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta!, la respuesta correcta era a) Tratado de Versalles");
                        }
                        break;
                    case (4):
                        Console.WriteLine("¿En qué año comenzó la Segunda Guerra Mundial?");
                        Console.WriteLine("\ta) 1937");
                        Console.WriteLine("\tb) 1938");
                        Console.WriteLine("\tc) 1939");
                        Console.WriteLine("\td) 1940");
                        Console.Write("Escribe tu respuesta: ");



                        Respuesta = Console.ReadLine().ToLower();
                        if (Respuesta == "c" || Respuesta == "1939")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta!, la respuesta correcta era c) 1939");
                        }
                        break;
                    case (5):
                        Console.WriteLine("¿Qué país fue invadido por Alemania para iniciar la Segunda Guerra Mundial?");
                        Console.WriteLine("\ta) Francia");
                        Console.WriteLine("\tb) Checoslovaquia");
                        Console.WriteLine("\tc) Austria");
                        Console.WriteLine("\td) Polonia");
                        Console.Write("Escribe tu respuesta: ");



                        Respuesta = Console.ReadLine().ToLower();
                        if (Respuesta == "d" || Respuesta == "polonia")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta!, la respuesta correcta era d) Polonia");
                        }
                        break;
                    case (6):
                        Console.WriteLine("¿Cuál fue el nombre en clave de la invasión aliada en Normandía en 1944");
                        Console.WriteLine("\ta) Operación Torch");
                        Console.WriteLine("\tb) Operación Barbarroja");
                        Console.WriteLine("\tc) Operación Overlord");
                        Console.WriteLine("\td) Operación Market Garden");
                        Console.Write("Escribe tu respuesta: ");



                        Respuesta = Console.ReadLine().ToLower();
                        if (Respuesta == "c" || Respuesta == "operación overlord" || Respuesta == "operación overlord")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta!, la respuesta correcta era c) Operación Overlord");
                        }
                        break;
                    case (7):
                        Console.WriteLine("¿En qué año tuvo lugar la Revolución Rusa?");
                        Console.WriteLine("\ta) 1905");
                        Console.WriteLine("\tb) 1914");
                        Console.WriteLine("\tc) 1917");
                        Console.WriteLine("\td) 1921");
                        Console.Write("Escribe tu respuesta: ");



                        Respuesta = Console.ReadLine().ToLower();
                        if (Respuesta == "c " || Respuesta == "1917")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta!, la respuesta correcta era c) 1917");
                        }
                        break;
                    case (8):
                        Console.WriteLine("¿Cuál fue el nombre del proyecto secreto estadounidense para" + 
                            "desarrollar la bomba atómica durante la Segunda Guerra Mundial");
                        Console.WriteLine("\ta) Proyecto Manhattan");
                        Console.WriteLine("\tb) Proyecto Mercury");
                        Console.WriteLine("\tc) Proyecto Apolo");
                        Console.WriteLine("\td) Proyecto Trinity");
                        Console.Write("Escribe tu respuesta: ");



                        Respuesta = Console.ReadLine().ToLower();
                        if (Respuesta == "a" || Respuesta == "proyecto manhattan")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta!, la respuesta correcta era a) Proyecto Manhattan");
                        }
                        break;
                    case (9):
                        Console.WriteLine("¿En qué año cayó el Muro de Berlín, marcando el fin simbólico de la Guerra Fría?" +
                            "¿Qué es?");
                        Console.WriteLine("\ta) 1987");
                        Console.WriteLine("\tb) 1988");
                        Console.WriteLine("\tc) 1989");
                        Console.WriteLine("\td) 1990");
                        Console.Write("Escribe tu respuesta: ");



                        Respuesta = Console.ReadLine().ToLower();
                        if (Respuesta == "c" || Respuesta == "1989")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta!, la respuesta correcta era c) 1989");
                        }
                        break;
                    case (10):
                        Console.WriteLine("¿Qué evento llevó a los Estados Unidos a entrar en la Segunda Guerra Mundial?");
                        Console.WriteLine("\ta) La invasión de Polonia");
                        Console.WriteLine("\tb) El ataque a Pearl Harbor");
                        Console.WriteLine("\tc) La batalla de Midway");
                        Console.WriteLine("\td) El día D");
                        Console.Write("Escribe tu respuesta: ");



                        Respuesta = Console.ReadLine().ToLower();
                        if (Respuesta == "b" || Respuesta == "el ataque a pearl harbor")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta!, la respuesta correcta era b) El ataque a Pearl Harbor");
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
