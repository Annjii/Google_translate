using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oppsconceps
{
    class Exercise1
    {
        static object Main(string[] args)
        {
            object userName = string.userName;
            int userAge;
            string.friendsName;
            int friendsAge;

            Console.WriteLine("Enter your name: ");
            userName = Console.ReadLine();
            Console.WriteLine("Enter your Age: ");
            userAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your name is" + userName + " and you are " + userAge + " years old");
            Console.WriteLine();


            Console.WriteLine("Enter your friend's Name: ");
            friendsName = Console.ReadLine();
            Console.WriteLine("Enter your friendsAge: ");
            friendsAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your friend's Name " + friendsName + " and they are " + friendsAge + " years old");
            Console.WriteLine();

            Console.WriteLine("There are" + (userAge + friendsAge) + " years between two of you ");
            Console.ReadLine();

        }
    }
}
