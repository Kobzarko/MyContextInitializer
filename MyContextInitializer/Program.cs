using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MyContextInitializer
{
    class Program
    {
        static void Main(string[] args)
        {
            using (UserContext db = new UserContext())
            {
                var users = db.Users;
                foreach (var item in users)
                {
                    Console.WriteLine($"name - {item.Name}; Age - {item.Age};");
                }
            }

            Console.ReadKey();

        }
    }
}
