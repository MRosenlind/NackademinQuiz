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
    }
}