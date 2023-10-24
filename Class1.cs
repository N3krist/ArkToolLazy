using System;

namespace ArkToolLazy1
    {
        class Class1
        {
            static void Main(string[] args)
            {
                WriteGreetings();
                WriteMaxLevel(MaxLevelCalculation());
                Console.ReadKey();

            }

            public static void WriteGreetings()
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\t\t\t\t\tHello you wonderful lazy people ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\t\t\t\t\tLooks like ur as lazy as me so here we go\n\n\n");

            }



            public static int MaxLevelCalculation()
            {
                int maxLevel = 1, stamina, melee, hp, weight, food, oxy, speed;
                int stamina1, melee1, hp1, weight1, food1, oxy1, speed1;
                int stamina2, melee2, hp2, weight2, food2, oxy2, speed2;


                Console.WriteLine("Just give me the Levels of each stat and i give you the possible Max-Level of ur Baby");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Give me the Health of the first Dino :");
                try
                {
                    hp1 = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Looks like u didnt give me a Number!");
                    return -1;
                }
                catch (ArgumentNullException)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Empty like the void !");
                    return -1;
                }
                catch (OverflowException)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("little big right ?");
                    return -1;
                }
                Console.WriteLine("next is Stamina :");
                try
                {
                    stamina1 = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Looks like u didnt give me a Number!");
                    return -1;
                }
                catch (ArgumentNullException)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Empty like the void !");
                    return -1;
                }
                catch (OverflowException)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("little big right ?");
                    return -1;
                }
                Console.WriteLine("an now Oxygen pls :");
                try
                {
                    oxy1 = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Looks like u didnt give me a Number!");
                    return -1;
                }
                catch (ArgumentNullException)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("ArgumentNullException");
                    return -1;
                }
                catch (OverflowException)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("little big right ?");
                    return -1;
                }
                Console.WriteLine("Food pls :");
                try
                {
                    food1 = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Looks like u didnt give me a Number!");
                    return -1;
                }
                catch (ArgumentNullException)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Empty like the void !");
                    return -1;
                }
                catch (OverflowException)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("little big right ?");
                    return -1;
                }
                Console.WriteLine("Weight pls :");
                try
                {
                    weight1 = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Looks like u didnt give me a Number!");
                    return -1;
                }
                catch (ArgumentNullException)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Empty like the void !");
                    return -1;
                }
                catch (OverflowException)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("little big right ?");
                    return -1;
                }
                Console.WriteLine("Damage pls :");
                try
                {
                    melee1 = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Looks like u didnt give me a Number!");
                    return -1;
                }
                catch (ArgumentNullException)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Empty like the void !");
                    return -1;
                }
                catch (OverflowException)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("little big right ?");
                    return -1;
                }
                Console.WriteLine("at last Speed pls :");
                try
                {
                    speed1 = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Looks like u didnt give me a Number!");
                    return -1;
                }
                catch (ArgumentNullException)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Empty like the void !");
                    return -1;
                }
                catch (OverflowException)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("little big right ?");
                    return -1;
                }
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("so now too the second Dino.\nPls give me the Health of the second Dino :");
                try
                {
                    hp2 = int.Parse(Console.ReadLine());
                    hp = hp1 > hp2 ? hp1 : hp2;
                    //Ternärer ?: -Operator
                    //    Ternär bedeutet, daß der Operator drei Argumente benötigt.Dieser kann dazu dienen, 
                    //    innerhalb von Ausdrücken Teilausdrücke bedingt auszuwerten.
                    //    Ist der vor dem Fragezeichen stehende Ausdruck true ,
                    //    so wird der Teilausdruck vor dem Doppelpunkt, sonst 
                    //    derjenige nach dem Doppelpunkt ausgewertet.

                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Looks like u didnt give me a Number!");
                    return -1;
                }
                catch (ArgumentNullException)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Empty like the void !");
                    return -1;
                }
                catch (OverflowException)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("little big right ?");
                    return -1;
                }
                Console.WriteLine("next is Stamina :");
                try
                {
                    stamina2 = int.Parse(Console.ReadLine());
                    stamina = stamina1 > stamina2 ? stamina1 : stamina2;
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Looks like u didnt give me a Number!");
                    return -1;
                }
                catch (ArgumentNullException)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Empty like the void !");
                    return -1;
                }
                catch (OverflowException)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("little big right ?");
                    return -1;
                }
                Console.WriteLine("an now Oxygen pls :");
                try
                {
                    oxy2 = int.Parse(Console.ReadLine());
                    oxy = oxy1 > oxy2 ? oxy1 : oxy2;
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Looks like u didnt give me a Number!");
                    return -1;
                }
                catch (ArgumentNullException)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Empty like the void !");
                    return -1;
                }
                catch (OverflowException)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("little big right ?");
                    return -1;
                }
                Console.WriteLine("Food pls :");
                try
                {
                    food2 = int.Parse(Console.ReadLine());
                    food = food1 > food2 ? food1 : food2;
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Looks like u didnt give me a Number!");
                    return -1;
                }
                catch (ArgumentNullException)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Empty like the void !");
                    return -1;
                }
                catch (OverflowException)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("little big right ?");
                    return -1;
                }
                Console.WriteLine("Weight pls :");
                try
                {
                    weight2 = int.Parse(Console.ReadLine());
                    weight = weight1 > weight2 ? weight1 : weight2;
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Looks like u didnt give me a Number!");
                    return -1;
                }
                catch (ArgumentNullException)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Empty like the void !");
                    return -1;
                }
                catch (OverflowException)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("little big right ?");
                    return -1;
                }
                Console.WriteLine("Damage pls :");
                try
                {
                    melee2 = int.Parse(Console.ReadLine());
                    melee = melee1 > melee2 ? melee1 : melee2;

                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Looks like u didnt give me a Number!");
                    return -1;
                }
                catch (ArgumentNullException)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Empty like the void !");
                    return -1;
                }
                catch (OverflowException)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("little big right ?");
                    return -1;
                }
                Console.WriteLine("at last Speed pls :");
                try
                {
                    speed2 = int.Parse(Console.ReadLine());
                    speed = speed1 > speed2 ? speed1 : speed2;
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Looks like u didnt give me a Number!");
                    return -1;
                }
                catch (ArgumentNullException)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Empty like the void !");
                    return -1;
                }
                catch (OverflowException)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("little big right ?");
                    return -1;
                }


                maxLevel = maxLevel + hp + stamina + oxy + food + weight + speed + melee;

                return maxLevel;
            }

            public static void WriteMaxLevel(int maxLevel)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\n\n\n\n\t\t\t\t\tThe Max-Level of the Baby is : " + maxLevel);
                Console.WriteLine("\t\t\t\t\tThx for using this little tool");
                System.Console.ReadKey();
            }

        }

    }

