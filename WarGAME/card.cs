namespace WAR
{

    public class Card
    {
        public string  StringVal {get;set;}
        public string  Suits {get;set;}
        public int IntVal {get;set;}
    
        public Card (string strval, string suits, int val)
        {
            StringVal = strval;
            Suits = suits;
            IntVal = val;
            if (this.StringVal == "Ace"){
                this.IntVal = 14;
            }
        }

    }

}