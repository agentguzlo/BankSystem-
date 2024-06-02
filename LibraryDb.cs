using System.Security.AccessControl;
using System.Transactions;
using Test.Models;
    
namespace Test
{

    public class LibraryDb
    {
        private static LibraryDb instance;

        private static int lastAccountId = 1;

        public  static int GetIdForNewAccount()
        {
            return lastAccountId++;
        }

        public List<User> Users { get; set; }

        public List<Transaction> Transactions { get; set; }

        public List<Account> Accounts { get; set; } 

        private LibraryDb()
        {
            Users = new List<User>();

            Transactions = new List<Transaction>();

            Accounts = new List<Account>();

            for (int i = 0; i < 100; i++)
            {
                Users.Add(new User() { Id = i, Name = $"name {i}", Adress = $"Adress {i}", Number = $"Number {i}"});
            }
        }

        public static LibraryDb Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LibraryDb();
                }
                
                return instance;
            }
        }
    }
}

