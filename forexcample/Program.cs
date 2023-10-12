// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

    using System;

    int totalJugador = 0;
    int totalDealer = 0;
    string message = "";
    string switchControl = "menu";
    int num = 0;
    int platzicoins = 0;
    string controlOtracarta = "";
    System.Random random = new System.Random();

//blackjack,, juntar 21 pidiendo, en caso de pasarte 21 pierdes, cartas o en caso de tener mas de 21 igual tener mayor puntuacion que el dealer

    while (true)
    {
        Console.WriteLine("Bienvenido al P L A T Z I N O ");
        Console.WriteLine("Cuantos PlatziCoins deseas?  " +
            "ingresa un numero entero \n" +
            "\n recuerda que necesitas una por ronda de juego");
        platzicoins = int.Parse( Console.ReadLine());

        for (int i = 0; i < platzicoins; i++)
        {
            totalDealer = 0;
            totalJugador = 0;
            switch (switchControl)
            {
                case "menu":
                    Console.WriteLine("bienvenido al c a s i n o");
                    Console.WriteLine("Escriba 21 para poder jugar al 21");
                    switchControl = Console.ReadLine();
                i = i - 1;
                    break;
                case "21":

                    do
                    {
                        num = random.Next(1, 12);
                        totalJugador = totalJugador + num;
                        Console.WriteLine("Toma tu carta jugador");
                        Console.WriteLine($"Te salio el: {num}");
                        Console.WriteLine("¿Deseas otra carta ?");
                        controlOtracarta = Console.ReadLine();

                    } while (controlOtracarta == "Si" ||
                             controlOtracarta == "si" ||
                             controlOtracarta == "yes" ||
                             controlOtracarta == "SI");

                    totalDealer = random.Next(14, 23);
                    Console.WriteLine($"El dealer tiene {totalDealer} !");
                    if (totalJugador > totalDealer && totalJugador < 22)
                    {
                        message = "venciste al dealer, felicidades";
                        switchControl = "menu";
                    }
                    else if (totalJugador >= 22)
                    {
                        message = "perdiste vs el dealer te pasaste de 21";
                        switchControl = "menu";
                    }
                    else if (totalJugador <= totalDealer)
                    {
                        message = "perdiste vs el dealer, lo siento";
                        switchControl = "menu";
                    }
                    else
                    {
                        message = "condicion no valida";
                        switchControl = "menu";
                    }
                    Console.WriteLine(message);
                    break;
                default:
                    Console.WriteLine("valor ingresado no valido en el C A S I N O");
                    break;
            }
        }
    }
