using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;

namespace BlackJack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //setup
            string playerChoice = "y", stickTwist = "";

            //create player and dealer objects
            Player p1 = new Player("Player 1", 0);
            Player Dealer = new Player("Dealer", 0);

            //loop to control gameplay

            while (playerChoice == "y")
            {        
                //game title
                Console.WriteLine("\n--- LETS PLAY BLACKJACK !!! ---");
                Console.WriteLine();

                //reset scores if repeating
                p1.Score = 0;
                Dealer.Score = 0;
                
                //create new Deck object to use DealCard() method
                Deck Deck = new Deck();

                //player 1 plays

                    //deal 2 cards using Deck.DealCard() method
                    for (int i = 0; i < 2; i++)
                    {
                        p1.Score += Deck.DealCard(p1.Score);
                    }

                    //display player 1 score
                    Console.WriteLine("Player 1 score : {0}", p1.Score);

                    //ask to stick or twist
                    Console.Write("Do you want to stick or twist : s/t >> ");
                    stickTwist = Console.ReadLine();

                    if(stickTwist == "t")  
                        while (stickTwist != "s" || p1.Score < 21)
                        {
                            p1.Score += Deck.DealCard(p1.Score);
                         Console.WriteLine("Player 1 score : {0}", p1.Score);
                            Console.Write("Do you want to stick or twist : s/t >> ");
                            stickTwist = Console.ReadLine();
                        }
                
                
                //dealer plays

                

                if (p1.Score > 21)
                    Console.WriteLine(p1.Name + " BUST!!");

                //calculate and display winner
                

                Console.Write("Do you want to play again: y/n ? >> ");
                playerChoice = Console.ReadLine();

            } //end of gameplay loop

            Console.WriteLine("\n--- Have a Nice Day! ---");
            Console.ReadLine(); //pause

        }  //end of main method

        
    } //end of program class

} //end of namespace
