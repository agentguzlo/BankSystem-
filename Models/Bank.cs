namespace Test.Models
{
    public class Bank
    {
        public int Id { get; set; }

        public string Name { get; set; }

        List<User> Users { get; set; }

        public void AddUser()
        {
            Users.Add(new User { });
        }
    }
}   
