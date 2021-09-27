using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissor
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            String player;
            String computer;
            String answer;

            while (playAgain)
            {

                player = "";
                computer = "";
                answer = "";

                while (player != "BATU" && player != "KERTAS" && player != "GUNTING") {
                    Console.Write("Pilih Batu, Kertas, atau Gunting : ");
                    player = Console.ReadLine();
                    player = player.ToUpper();
                    
                }

                switch (random.Next(1, 4))
                {

                    case 1:
                        computer = "BATU";
                        break;

                    case 2:
                        computer = "KERTAS";
                        break;

                    case 3:
                        computer = "GUNTING";
                        break;
                }

                Console.WriteLine("Player: " + player);
                Console.WriteLine("Computer: " + computer);

                switch (player)
                {
                    case "BATU":
                        if (computer == "BATU")
                        {
                            Console.WriteLine("SERI ! :D");
                        }

                        else if (computer == "KERTAS")
                        {
                            Console.WriteLine("Kamu kalah ! :P xD");
                        }
                        else
                        {
                            Console.WriteLine("Kamu menang ! :') ");
                        }
                        break;

                    case "KERTAS":
                        if (computer == "BATU")
                        {
                            Console.WriteLine("Kamu menang ! :') ");
                        }
                        else if (computer == "KERTAS")
                        {
                            Console.WriteLine("SERI ! :D");
                        }

                        else
                        {
                            Console.WriteLine("Kamu kalah ! :P xD");
                        }
                        break;

                    case "GUNTING":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("Kamu kalah ! :P xD");
                        }

                        else if (computer == "KERTAS")
                        {
                            Console.WriteLine("Kamu menang ! :') ");
                        }
                        else
                        {
                            Console.WriteLine("SERI ! :D");
                        }
                        break;
                }

                Console.Write("Apakah ingin mencobanya lagi ? (Y/N): ");
                answer = Console.ReadLine();
                answer = answer.ToUpper();

                if (answer == "Y")
                {
                    playAgain = true;
                }
                else if (answer == "N")
                {
                    playAgain = false;
                }
                
            }
            Console.WriteLine("Terima kasih sudah memainkan ! :D");
            Console.ReadKey();

        }
        
    }
}
