using System;
using System.Threading;

namespace ConsoleApp1
{
    internal class Program
    {



       static void show(string[] menyu, int a)
        {
            for (int i = 0; i < 5; i++)
            {
                if (a == i) Console.ForegroundColor = ConsoleColor.Red;
                else Console.ResetColor();
                Console.WriteLine(menyu[i]);
            }
        }


        static double toplama(double say1  , double say2)
        {
            return say1 + say2;
        }
        static double cixma(double say1, double say2)
        {
            return say1 - say2;
        }
        static double vurma(double say1, double say2)
        {
            return say1 * say2;
        }
        static double bolme(double say1, double say2)
        {
            return say1 / say2;
        }





        static void Main(string[] args)
        {
            string[] menyu = { "toplama", "cixma", "vurma", "bolme", "exit" };

            int a = 0;

            show(menyu, a);

            while (true)
            {
                Console.Clear();
                show(menyu, a);
                var secim = Console.ReadKey();
                if (secim.Key == ConsoleKey.DownArrow)
                {
                    if (a == 4) a = 0;
                    else a++;
                }
                else if (secim.Key == ConsoleKey.UpArrow)
                {
                    if (a == 0) a = 4;
                    else a--;
                }
                       

                if (secim.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    Console.ResetColor();
                    if (a == 4)
                    { 
                        Console.WriteLine("EXIT...");
                        a = 0;
                        break;
                    }


                    Console.Write("1ci ededi daxil edin: ");
                    double say1;
                    double say2;
                    say1 = Double.Parse(Console.ReadLine());
                    Console.Write("2ci ededi daxil edin: ");
                    say2 = Double.Parse(Console.ReadLine());


                    switch (a)
                    {
                        case 0:
                            Console.WriteLine($"Netice: {toplama(say1, say2)}");
                            break;
                        case 1:
                            Console.WriteLine($"Netice: {cixma(say1, say2)}");
                            break;
                        case 2:
                            Console.WriteLine($"Netice: {vurma(say1, say2)}");
                            break;
                        case 3:
                            Console.WriteLine($"Netice: {bolme(say1, say2)}");
                            break;
                    }
                    a = 0;
                    Thread.Sleep(2000);

                 
                }




            }











        }







    }
}
