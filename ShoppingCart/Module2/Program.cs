using System;

namespace Module2
{
    class Program
    {
        static void Main(string[] args)
        {
            Users user = new Users("Alan","20","April 7th of the year 2000");

            string format = "My name is {0}, I am {1} years old and I was born on {2}.";

            Console.WriteLine(String.Format(format, user.name,user.age,user.birthday));

        }
    }
    public class Users
    {
        public string name { get; set; }
        public string age { get; set; }
        public string birthday { get; set; }
        public Users(string newName, string newAge, string newBirthday)
        {
            this.name = newName;
            this.age = newAge;
            this.birthday = newBirthday;
        }
    }
    public class Roles
    {
        public string beginner { get; set; }
        public string expirinced { get; set; }
        public string veteran { get; set; }
    }
    public class Images
    {
        public string brightImage { get; set; }
        public string darkImage { get; set; }
    }
    public class Posts
    {
        public string funny { get; set; }
        public string sports { get; set; }
        public string educational { get; set; }
        
    }
    public class Comments
    {
        public string shortComments { get; set; }
        public string longComments { get; set; }
    }
}
