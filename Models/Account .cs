namespace Test.Models
{
    public class Account
    {
        public long Id { get; set; } 

        public int UserId { get; set; }

        public int Ballance { get; set; } = 0;

        public bool IsBlocked { get; set; } = false;

        public void Deposit(int ammount)
        {
            if (IsDepositAllow(ammount))
            {
                Ballance += ammount;
            }
        }      

        public void Withdrawal(int ammount)
        {
            if (IsWithdrawalAllow(ammount) == true)
            {
                Ballance -= ammount;
            }
        }

        private bool IsWithdrawalAllow(int ammount)
        {
            return ammount <= Ballance  && !IsBlocked;
        }

        private bool IsDepositAllow(int ammount)
        {
            return !IsBlocked;
        }
    }


}
