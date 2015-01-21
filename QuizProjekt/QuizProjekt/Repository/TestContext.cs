using QuizProjekt.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace QuizProjekt.Repository
{
    public class TestContext: DbContext
    {
        public TestContext(): base("Test")
        {

        }
        public DbSet<Test> Tests { get; set;}

        public DbSet<Question> Questions { get; set; }
        public DbSet<Alternative> Alternatives { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Question>()
                .HasRequired(x => x.Test)
                .WithMany(x => x.Questions)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<Alternative>()
                .HasRequired(x => x.Question)
                .WithMany(x => x.Alternatives)
                .WillCascadeOnDelete(true);
        }
    }
}