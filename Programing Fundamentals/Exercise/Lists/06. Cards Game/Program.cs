using System;
using System.Collections.Generic;
using System.Linq;

namespace CardsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> playerOneDeck = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> playerTwoDeck = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (playerOneDeck.Count > 0 && playerTwoDeck.Count > 0)
            {

                int player1card = playerOneDeck[0];
                int player2card = playerTwoDeck[0];

                if (player1card > player2card)
                {
                    playerOneDeck.RemoveAt(0);
                    playerTwoDeck.RemoveAt(0);

                    playerOneDeck.Add(player1card);
                    playerOneDeck.Add(player2card);
                }
                else if (player1card < player2card)
                {
                    playerOneDeck.RemoveAt(0);
                    playerTwoDeck.RemoveAt(0);

                    playerTwoDeck.Add(player2card);
                    playerTwoDeck.Add(player1card);

                }
                else
                {
                    playerOneDeck.RemoveAt(0);
                    playerTwoDeck.RemoveAt(0);
                    continue;
                }
                
            }
            if (playerOneDeck.Count == 0)
            {
                Console.WriteLine($"Second player wins! Sum: {playerTwoDeck.Sum()}");
                return;
            }
            else if (playerTwoDeck.Count == 0)
            {
                Console.WriteLine($"First player wins! Sum: {playerOneDeck.Sum()}");
                return;
            }
        }
    }
}
