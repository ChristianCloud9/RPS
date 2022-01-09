using System;

namespace RockPaperSc
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCPU;
            int randomInt;
            
            bool playAgian = true;

            while (playAgian)
            {
                int scorePlayer = 0;
                int ScoreCPU = 0;


                while (scorePlayer < 3 && ScoreCPU < 3)
                {
                    


                    Console.Write("Choose between ROCK, PAPER and SCISSORS: ");


                    
                    inputPlayer = Console.ReadLine();
                    inputPlayer = inputPlayer.ToUpper();

                    


                    Random rnd = new Random();

                    randomInt = rnd.Next(1, 4);

                    switch (randomInt)
                    {
                        case 1:
                            inputCPU = "ROCK";
                            Console.WriteLine("Computer chose ROCK");
                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("Draw! \n\n");
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("PLAYER WINS!!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("CPU WINS!!\n\n");
                                ScoreCPU++;

                            }


                            break;
                        case 2:
                            inputCPU = "PAPER";
                            Console.WriteLine("Computer chose PAPAER");
                            if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("Draw! \n\n");
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("Player WINS!!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("CPU WINS!!\n\n");
                                ScoreCPU++;
                            }
                            break;
                        case 3:
                            inputCPU = "SCISSORS";
                            Console.WriteLine("Computer chose SCISSORS");
                            if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("Draw! \n\n");
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("Player WINS!!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("CPU WINS!!\n\n");
                                ScoreCPU++;
                            }
                            break;

                        default:
                            Console.WriteLine("Invalid Entry");
                            break;
                    }

                    Console.WriteLine("\n\nScores: \tPlayer:\t{0}\tCPU:\t{1}", scorePlayer, ScoreCPU);
                }

                if (scorePlayer == 3)
                {
                    Console.WriteLine("Player WON!");
                }
                else if (ScoreCPU == 3)
                {
                    Console.WriteLine("CPU WON!");
                }
                
                Console.WriteLine("Do you want to play again?(y/n)");
                string loop = Console.ReadLine();
                if (loop == "y")
                {
                    playAgian = true;
                    Console.Clear();
                }
                else if (loop == "n")
                {
                    playAgian = false;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }




            }
        }
    }
}
