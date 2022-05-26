using System;
using System.Collections.Generic;

namespace WAR
{
    public class Deck
    {
        List<Card> cards {get;set;}
        public Deck ()
        {
            System.Console.WriteLine("created deck");
            cards = new List<Card>();
            Reset();
        }
        public Card Deal()
        {
                Card DealtCard = cards[0];
                cards.RemoveAt(0);
                return DealtCard;
    
        }
        public void Reset()
        {
            string [] suits = {"Spade", "Hearts", "Diamands", "Clubs"};
            string [] nums = {"Ace","2","3","4","5","6","7","8","9","10","Jack","Queen","King"};

            for (int i = 0; i < suits.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    cards.Add(new Card(nums[j], suits[i], j+1));
                }
            }
        }
        public void Shuffle() {
            Random r = new Random();
            for (int i = cards.Count -1; i > 0; i--)
            {
                int index = r.Next(i);
                
                Card temp = cards[index];
                cards[index] = cards [i];
                cards[i] = temp;
            }
        }
    }
}