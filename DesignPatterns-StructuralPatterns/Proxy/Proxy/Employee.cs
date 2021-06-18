namespace Proxy
{
   public class Employee
    {
        public Employee(string username, string password, string role)
        {
            this.Username = username;
            this.Password = password;
            this.Role = role;
        }

        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
