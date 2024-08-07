using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    internal class Matematicas : Quiz
    {
        // Cada método de cada categoría generará UNA pregunta aleatoria de esa categoría dependiendo la dificultad
        private float RespuestaMath;
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
                switch (preguntasBasicas[preguntaAleatoria])
                {
                    case (1):
                        Console.WriteLine("¿Cuantos lados tiene un hexagono?");
                        Console.Write("Escribe tu respuesta: ");

                        RespuestaMath = float.Parse(Console.ReadLine()); // se lee la respuesta del usuario

                        Console.WriteLine();
                        // Se evalúa si se dio una respuesta correcta o no
                        if (RespuestaMath == 6)
                        {
                            // Se activa la variable que determina si se ganó la ronda
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            // En caso de que no haya acertado se le informa al usuario
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era !6");
                        }
                        break;
                    // Las demás preguntas deberán tener un formato similar
                    case (2):
                        Console.WriteLine("¿Cauntos lados tiene un pentagono?");
                        Console.Write("Escribe tu respuesta: ");

                        RespuestaMath = float.Parse(Console.ReadLine());
                        if (RespuestaMath == 5)
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta!, la respuesta correcta era: 5");
                        }
                        break;
                    case (3):
                        Console.WriteLine("Juan compro 2 cajas de lapices por 100 pesos, si caja caja tiene " +
                            "10 lapices. ¿Cuanto cuesta cada una lapiz?");
                        Console.Write("Escribe tu respuesta: ");

                        RespuestaMath = float.Parse(Console.ReadLine());
                        if (RespuestaMath == 5)
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta!, la respuesta correcta era:" + 5);
                        }
                        break;
                    case (4):
                        Console.WriteLine("¿Cómo se le llama el triangulo que tiene sus tres lados iguales?");
                        Console.Write("Escribe tu respuesta: ");


                        RespuestaMath = float.Parse(Console.ReadLine());
                        if (Respuesta == "triangulo equilatero")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era b) Pacífico");
                        }
                        break;
                    case (5):
                        Console.WriteLine("¿Cuantos vertices tiene un cubo?");
                        Console.Write("Escribe tu respuesta: ");


                        RespuestaMath = float.Parse(Console.ReadLine());
                        if (RespuestaMath == 8)
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era 8");
                        }
                        break;
                    case (6):
                        Console.WriteLine("Si Lucas mide 1.80 metro de altura y Andrea mide 0.30 metros mas baja que" +
                            "el ¿Cuanto mide Andrea?");
                        Console.Write("Escribe tu respuesta: ");


                        RespuestaMath = float.Parse(Console.ReadLine());
                        if (RespuestaMath == 1.50)
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era 1.50");
                        }
                        break;
                    case (7):
                        Console.WriteLine("Maria quiere comprar galletas para regalar en su cumpleaños, si compra 5" +
                            "paquetes y cada paquete trae 6 galletas ¿Cuantas galletas compro en total?");
                        Console.Write("Escribe tu respuesta: ");


                        RespuestaMath = float.Parse(Console.ReadLine());
                        if (RespuestaMath == 30)
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era 30");
                        }
                        break;
                    case (8):
                        Console.WriteLine("¿Cauntos metros tiene un kilometro?");
                        Console.Write("Escribe tu respuesta: ");


                        RespuestaMath = float.Parse(Console.ReadLine());
                        if (RespuestaMath == 1000)
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era 1000");
                        }
                        break;
                    case (9):
                        Console.WriteLine("¿Cuanto es 3 centenas?");
                        Console.Write("Escribe tu respuesta: ");


                        RespuestaMath = float.Parse(Console.ReadLine());
                        if (RespuestaMath == 300)
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era 300");
                        }
                        break;
                    case (10):
                        Console.WriteLine("¿Cuanto es una docena?");
                        Console.Write("Escribe tu respuesta:");


                        RespuestaMath = float.Parse(Console.ReadLine());
                        if (RespuestaMath == 12)
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta es 12");
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
                        Console.WriteLine("¿Cuáles son los cuatro lóbulos en los que se divide el cerebro?");
                        Console.Write("Escribe tu respuesta: ");


                        RespuestaMath = float.Parse(Console.ReadLine());
                        if (Respuesta == "d" || Respuesta == "frontal, temporal, parietal y occipital")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era d) Frontal, temporal, parietal y occipital");
                        }
                        break;
                    case (4):
                        Console.WriteLine("¿Cómo se le llama a la pérdida de memoria?");
                        Console.WriteLine("\ta) Amnesia");
                        Console.WriteLine("\tb) Contusión");
                        Console.WriteLine("\tc) Resaca");
                        Console.WriteLine("\td) Alzheimer");
                        Console.Write("Escribe tu respuesta: ");


                        RespuestaMath = float.Parse(Console.ReadLine());
                        if (Respuesta == "a" || Respuesta == "amnesia")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era a) Amnesia");
                        }
                        break;
                    case (5):
                        Console.WriteLine("¿Cómo se llama esa sensación de que una experiencia se ha vivido anteriormente?");
                        Console.WriteLine("\ta) Nostalgia");
                        Console.WriteLine("\tb) Recuerdos");
                        Console.WriteLine("\tc) Deja Vu");
                        Console.Write("Escribe tu respuesta: ");


                        RespuestaMath = float.Parse(Console.ReadLine());
                        if (Respuesta == "c" || Respuesta == "deja vu")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era c) Leonardo Da Vinci");
                        }
                        break;
                    case (6):
                        Console.WriteLine("¿Qué mide el Producto Interno Bruto de un país");
                        Console.WriteLine("\ta) La producción total de bienes y servicios en un país durante un período de tiempo");
                        Console.WriteLine("\tb) La riqueza de cada habitante");
                        Console.WriteLine("\tc) Tasa de inflación");
                        Console.WriteLine("\td) El saldo de la balanza en bolsa");
                        Console.Write("Escribe tu respuesta: ");


                        RespuestaMath = float.Parse(Console.ReadLine());
                        if (Respuesta == "a")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era a) La producción total de bienes y servicios en un país durante un período de tiempo");
                        }
                        break;
                    case (7):
                        Console.WriteLine("¿Qué es el déficit fiscal");
                        Console.WriteLine("\ta) El exceso de ingresos del gobierno sobre sus gastos");
                        Console.WriteLine("\tb) La diferencia entre los ingresos y gastos del gobierno cuando los ingresos superan a los gastos");
                        Console.WriteLine("\tc) El exceso de gastos del gobierno sobre sus ingresos");
                        Console.WriteLine("\td) La reducción en el nivel de deuda pública");
                        Console.Write("Escribe tu respuesta: ");


                        RespuestaMath = float.Parse(Console.ReadLine());
                        if (Respuesta == "c")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era c) El exceso de gastos del gobierno sobre sus ingresos");
                        }
                        break;
                    case (8): // Esta también se deja
                        Console.WriteLine("¿Qué es un monopolio?");
                        Console.WriteLine("\ta) Un mercado en el que hay solo un vendedor y muchos compradores");
                        Console.WriteLine("\tb) Un mercado con muchos vendedores y compradores, donde todos los productos son idénticos");
                        Console.WriteLine("\tc) Un mercado en el que hay varios vendedores que ofrecen productos diferenciados");
                        Console.Write("Escribe tu respuesta: ");


                        RespuestaMath = float.Parse(Console.ReadLine());
                        if (Respuesta == "a")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era a) Un mercado en el que hay solo un vendedor y muchos compradores");
                        }
                        break;
                    case (9):
                        Console.WriteLine("¿Cuál es la función de los fertilizantes en jardinería?");
                        Console.WriteLine("\ta) Mejorar la textura del suelo y aumentar el crecimiento de malas hierbas");
                        Console.WriteLine("\tb) Proporcionar nutrientes esenciales a las plantas para su crecimiento y desarrollo");
                        Console.WriteLine("\tc) Reducir la cantidad de agua necesaria para el riego");
                        Console.WriteLine("\td) Evitar que las plantas florezcan");
                        Console.Write("Escribe tu respuesta: ");


                        RespuestaMath = float.Parse(Console.ReadLine());
                        if (Respuesta == "b")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era b) Proporcionar nutrientes esenciales a las plantas para su crecimiento y desarrollo");
                        }
                        break;
                    case (10):
                        Console.WriteLine("¿Qué es la siembra directa?");
                        Console.WriteLine("\ta) Plantar semillas en el suelo sin prepararlo adecuadamente");
                        Console.WriteLine("\tb) Sembrar las semillas directamente en el lugar donde crecerán sin trasplante posterior");
                        Console.WriteLine("\tc) Cultivar plantas en macetas antes de trasladarlas al jardín");
                        Console.WriteLine("\td) Plantar semillas en un invernadero antes de moverlas al jardín");


                        RespuestaMath = float.Parse(Console.ReadLine());
                        if (Respuesta == "b")
                        {
                            RespuestaCorrecta = true;
                        }
                        else
                        {
                            Console.WriteLine("¡Respuesta incorrecta! la respuesta correcta era b) Sembrar las semillas directamente en el lugar donde crecerán sin trasplante posterior");
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
