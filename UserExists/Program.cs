using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserExists
{
    class Program
    {
        static void Main(string[] args)
        {
            DataAccess db = new DataAccess();

            var email = Console.ReadLine();
            var userID = db.Registraion(email);
            var count = userID.Count;

            if (count != 0)
            {
                Console.WriteLine("This email already exists");
                Console.WriteLine("Do you want to login?");
            }
            else
            {
                Console.WriteLine("Your registration is complete");
            }
            //Console.WriteLine(count);

            //foreach (var item in userID)
            //{
                
            //    Console.WriteLine(item.peopleID);
                
            //}
            //Console.WriteLine(userID.peopleID);

            Console.ReadLine();
        }
    }
}
