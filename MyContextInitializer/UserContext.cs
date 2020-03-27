using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyContextInitializer
{
    public class UserContext : DbContext
    {
        // Чтобы инициализатор сработал, надо его вызвать. 
        // Один из способов вызова инициализатора предполагает вызов
        // его в статическом конструкторе класса контекста
        static UserContext()
        {
            Database.SetInitializer<UserContext>(new ContextInitializer());
        }

        public UserContext():base("DefaultConnection")
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
