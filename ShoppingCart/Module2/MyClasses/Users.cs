using System;
using System.Collections.Generic;
using System.Text;

namespace Module2.MyClasses
{
    public class Users
    {
        public int UsersId { get; set; }
        public string name { get; set; }
        public string age { get; set; }
        public string birthday { get; set; }
        public string Role { get; set; }
        public Users(string newName, string newAge, string newBirthday)
        {
            this.name = newName;
            this.age = newAge;
            this.birthday = newBirthday;
        }
    }


}
