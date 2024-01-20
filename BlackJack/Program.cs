using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;

namespace BlackJack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //setup for objects
            string name = "";
            int score = 0;



            //loop to control gameplay
            string playerChoice = "y";
        
            while (playerChoice == "y")
            {        
                //game title
                Console.WriteLine("\n--- LETS PLAY BLACKJACK !!! ---");
                Console.WriteLine();

                //get players name
                Console.Write("Enter Name >> ");
                name = Console.ReadLine();

                //create player object
                Player p1 = new Player(name,score);

                //create dealer player object
                Player dealer = new Player("Dealer",score);



                //game here
                Random rng = new Random();

                p1.Score = rng.Next(0,10);
                Console.WriteLine("{0}'s score is {1}", p1.Name , p1.Score);

                dealer.Score = rng.Next(0, 10);
                Console.WriteLine("{0}'s score is {1}", dealer.Name, dealer.Score);

                p1.Score += rng.Next(0, 10);
                Console.WriteLine("{0}'s score is {1}", p1.Name, p1.Score);

                dealer.Score += rng.Next(0, 10);
                Console.WriteLine("{0}'s score is {1}", dealer.Name, dealer.Score);

                //find and display winner
                if (p1.Score > dealer.Score)
                    Console.WriteLine("The winner is {0}", p1.Name);
                else if (dealer.Score > p1.Score)
                    Console.WriteLine("The winner is {0}", dealer.Name);
                else Console.WriteLine("Its a draw boyo");

                //ask to play again
                Console.Write("Do you want to play again: y/n >> ");
                playerChoice = Console.ReadLine();
                
            } //end of loop

            Console.WriteLine("\n--- GAME OVER ---");
            Console.ReadLine(); //pause

        }  //end of main method

        //methods


    } //end of program class

} //end of namespace
