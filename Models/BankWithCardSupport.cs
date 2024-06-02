namespace Test.Models
{
    public class BankWithCardSupport:Bank
    {
       public CardType CardType { get; set; }

       public void CreateCard(CardType cardType)
        {
            CardType = cardType;
        }
    }
    public enum CardType
    {
        PremiumCard = 1,
        RegularCard 
    }
    
}
