using System;

namespace blackjack21an
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Välkommen till menyn! Välj ett av följande alternativ");
            Console.WriteLine("1. Spela Blackjack");
            Console.WriteLine("2. ");

            int meny = int.Parse(Console.ReadLine());

            switch (meny)
            {
                case 1:
                    Random slump = new Random();
                    int spelarenspoäng = 0;
                    int Datornspoäng = 0;


                    Console.WriteLine("Huset dra ett kort till dig och ett till sig själv");
                    Console.WriteLine("\nDitt kort är värt " + (spelarenspoäng += slump.Next(1, 11)));
                    Console.WriteLine("\nDatorn kort är värt " + (Datornspoäng += slump.Next(1, 11)));

                    string beslut = "";
                    while (beslut !="N" && spelarenspoäng < 21)
                    {
                        Console.WriteLine("\nSpelarens poäng: " + spelarenspoäng);
                        Console.WriteLine("Datorns poäng: " + Datornspoäng);
                        Console.WriteLine("\nVill du dra ett till kort? J/N");

                     beslut = Console.ReadLine();

                        switch (beslut)
                        {
                            case "J":
                                int nyttvärde = slump.Next(1, 11);
                                spelarenspoäng += nyttvärde;
                                Console.WriteLine("Huset ger dig ett kort värt " + nyttvärde);
                                Console.WriteLine("\nSpelarens poäng: " + spelarenspoäng);
                                break;

                            case "N":
                                break;

                            default:
                                Console.WriteLine("Spelaren valde inte ett giltigt alternativ!");
                                break;
                        }
                    }
                    
                    if (spelarenspoäng > 21)
                    {
                        Console.WriteLine("Spelaren har överstidigt 21 poäng! Huset har vunnit.");
                    }

                    if (Datornspoäng > 21)
                    {
                        Console.WriteLine("Huset fick över 21 poäng! Du har vunnit.");
                        Console.WriteLine("Skriv in ditt namn");
                        string Vinnare = "";
                        Vinnare = Console.ReadLine();                      
                    }

                    while(Datornspoäng < spelarenspoäng && Datornspoäng <= 21)
                    {
                        int Datornnya = slump.Next(1, 11);
                        Datornspoäng += Datornnya;
                        Console.WriteLine("Huset drog ett kort värt " + Datornnya);
                    }
                    break;

            }


        }
    }
}

