using Module3.MyClasses;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Module7
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Users> usersList = new List<Users>();

                Users userOne = new Users();
                userOne.name = "Alan";
                userOne.age = "20";
                userOne.birthday = "April 7th";
                userOne.UsersId = 123;
                usersList.Add(userOne);

                Users userTwo = new Users();
                userTwo.name = "Axel";
                userTwo.age = "23";
                userTwo.birthday = "March 15th";
                userTwo.UsersId = 135;
                usersList.Add(userTwo);

                Users userThree = new Users();
                userThree.name = "Kevin";
                userThree.age = "18";
                userThree.birthday = "January 12th";
                userThree.UsersId = 321;
                usersList.Add(userThree);

                Users userFour = new Users();
                userFour.name = "Miguel";
                userFour.age = "25";
                userFour.birthday = "December 10th";
                userFour.UsersId = 576;
                usersList.Add(userFour);

                Users userFive = new Users();
                userFive.name = "Jhon";
                userFive.age = "27";
                userFive.birthday = "July 21st";
                userFive.UsersId = 821;
                usersList.Add(userFive);

                Users userSix = new Users();
                userSix.name = "Chris";
                userSix.age = "31";
                userSix.birthday = "June 17th";
                userSix.UsersId = 725;
                usersList.Add(userSix);

                Users userSeven = new Users();
                userSeven.name = "Maria";
                userSeven.age = "26";
                userSeven.birthday = "September 22nd";
                userSeven.UsersId = 486;
                usersList.Add(userSeven);

                Users userEight = new Users();
                userEight.name = "Ivan";
                userEight.age = "17";
                userEight.birthday = "May 15th";
                userEight.UsersId = 674;
                usersList.Add(userEight);

                Users userNine = new Users();
                userNine.name = "Angel";
                userNine.age = "28";
                userNine.birthday = "August 26th";
                userNine.UsersId = 963;
                usersList.Add(userNine);

                Users userTen = new Users();
                userTen.name = "Roxanne";
                userTen.age = "24";
                userTen.birthday = "October 24th";
                userTen.UsersId = 482;
                usersList.Add(userTen);

                usersList = usersList.Where(Users => Users.name == "Axel").ToList();

                if (usersList.Count > 0)
                {
                    Console.WriteLine("User Information:");
                    string format = ("User properties: " + "Name:{0},Age:{1}, Birthday:{2}, UserId:{3}");

                    foreach (var info in usersList)
                    {
                        Console.WriteLine(format, info.name, info.age, info.birthday, info.UsersId);
                    }

                }
                else
                {
                    throw new NoUserFound("User not found");
                }
            }
            catch(NoUserFound exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                Console.WriteLine("End");
            }
        }
    }
}

public class NoUserFound : Exception
{
    public NoUserFound(string error) : base(error)
    {

    }
}
