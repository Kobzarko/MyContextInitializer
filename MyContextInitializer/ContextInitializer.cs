using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MyContextInitializer
{
    public class ContextInitializer : DropCreateDatabaseAlways<UserContext>
    {
        protected override void Seed(UserContext db)
        {
            User user1 = new User { Name = "Vasya", Age = 22 };
            User user2 = new User { Name = "Kolya", Age = 38 };

            db.Users.Add(user1);
            db.Users.Add(user2);
            db.SaveChanges();
        }
    }
}
