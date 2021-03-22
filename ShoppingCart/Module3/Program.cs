using System;
using Module3.DTOS;

namespace Module3
{
    class Program
    {
        static void Main(string[] args)
        {
            UsersDTO newDTOUsers = new UsersDTO();
            newDTOUsers.UsersId = 1;
            newDTOUsers.name = "Alan";
            newDTOUsers.age = "20";
            newDTOUsers.birthday = "April 7th of the year 2000";

            Console.WriteLine("My User ID is:" + newDTOUsers.UsersId); 
            Console.WriteLine("My name is:" + newDTOUsers.name);
            Console.WriteLine("My age is:" + newDTOUsers.age);
            Console.WriteLine("I was born on " + newDTOUsers.birthday);
        }
    }
}
