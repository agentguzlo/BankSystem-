namespace Test.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Adress { get; set; }

        public string Number { get; set; }

        public List<Account> Accounts { get; set; } = new List<Account>();

        public void AddAccount()
        {
            Accounts.Add(new Account() { Id = LibraryDb.GetIdForNewAccount(), UserId = Id });
        }
    }
}
