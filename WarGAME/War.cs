using System.Collections.Generic;

namespace WAR
{
    class War 
    {
        public Player Player1 {get;set;}
        public Player Player2 {get;set;}
        public List<Card> Table {get;set;}
        
        
        
        public void StartGame(){
            Deck NewDeck = new Deck ();
            List<Card> GameTable = new List<Card>();
            Table = GameTable;
            NewDeck.Shuffle();
            for (int i = 0; i < 26; i++){
                Player1.Draw(NewDeck);
                Player2.Draw(NewDeck);
            }
        }

        public void Turn(){
            if (Player1.Hand.Count < 1){
                System.Console.WriteLine($"{Player1.Name}, you lose!!");
            }
            else if (Player2.Hand.Count < 1){
                System.Console.WriteLine($"{Player2.Name}, you lose!!");
            }
            else{
                Card Card1 = Player1.Hand[0];
                Card Card2 = Player2.Hand[0];
                Player1.Discard(0);
                Player2.Discard(0);
                Table.Add(Card1);
                Table.Add(Card2);
            }

            // if draw --> store Card1 and Card2 in a list, use this list on the next Turn 
        }

        public void Compare(){
            Card p1 = Table[Table.Count-2];
            Card p2 = Table[Table.Count-1];
            if (p1.IntVal > p2.IntVal){
                for (int i = 0; i < Table.Count; i++ ){
                    Player1.Hand.Add(Table[i]);
                }
                Table.Clear();
            } else if (p1.IntVal < p2.IntVal){
                for (int i = 0; i < Table.Count; i++ ){
                    Player2.Hand.Add(Table[i]);
                }
                Table.Clear();
            } else if(p1.IntVal == p2.IntVal){
                // this.Turn();
                // THIS is where we will call our StartWar method!!!
                this.DeclareWar();
            }
        }

        public void DeclareWar(){
            if (Player1.Hand.Count < 4){
                System.Console.WriteLine($"{Player1.Name}, you lose!!");
            }
            else if (Player2.Hand.Count < 4){
                System.Console.WriteLine($"{Player2.Name}, you lose!!");
            }
            else{
                this.Turn();cd
                System.Console.WriteLine("I");
                this.Turn();
                System.Console.WriteLine("Declare");
                this.Turn();
                System.Console.WriteLine("War!");
                this.Turn();
                this.Compare();
            }
        }

        public War(Player player1, Player player2){
            Player1 = player1;
            Player2 = player2;
        }
    }
}



// add all rules for WAR

