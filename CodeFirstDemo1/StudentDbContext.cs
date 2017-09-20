namespace CodeFirstDemo1
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class StudentDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

    }

}