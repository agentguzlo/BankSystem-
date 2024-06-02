namespace Test.Models
{
    public class Trasaction
    {
        
        public Trasaction (long accountId, int ammount, TrasactionType trasactionType)
        {
            Ammount = ammount
            //TODO ти присвоїв не всі значення. Дороби
        }


        public long Id { get; set; }

        public long AccountId { get; set; }

        public TrasactionType TrasactionType { get; set; }

        public int Ammount { get; set; }

        public DateTime TransactionDate { get; set; } = DateTime.Now;

    }

    public enum TrasactionType
    {
        Deposit = 1,
        Withdrawal = 2        
    }
}
