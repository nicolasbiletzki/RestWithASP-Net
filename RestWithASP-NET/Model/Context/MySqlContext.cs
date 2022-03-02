using Microsoft.EntityFrameworkCore;

namespace RestWithASP_NET.Model.Context
{
    public class MySqlContext : DbContext
    {
        public MySqlContext()
        {

        }

        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options) 
        {

        }

        public DbSet<Person> Persons { get; set; }

    }
}
