using Microsoft.EntityFrameworkCore;
using millioner.Model;
using millioner.VM;
using System;
using System.Collections.Generic;
using System.Text;

namespace millioner
{
    class MillionerDBContext: DbContext
    {
        public DbSet<Question>  Questions { get; set; }
        public DbSet<Answer>  Answers { get; set; }

        public MillionerDBContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=Millioner.db");
        }
     

    }
}
