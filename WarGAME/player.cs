using System.Collections.Generic;

namespace WAR
{
    public class Player
    {
        public string Name {get;set;}
        public List<Card> Hand {get;set;}

        
        public void Draw(Deck deck)
        {
            Hand.Add(deck.Deal());
        }
        public Card Discard(int idx)
        {
            if (Hand.Count > idx && idx >=0){
                Card this_card = Hand[idx];
                Hand.RemoveAt(idx);
                return this_card;
            }
            else
            {
                return null;
            }
        }
        public Player(string name)
        {
            Name = name;
            Hand = new List <Card>();
        }
    }
}