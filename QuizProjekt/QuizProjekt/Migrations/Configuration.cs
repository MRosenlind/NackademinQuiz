using QuizProjekt.Models;
using QuizProjekt.Repository;

namespace QuizProjekt.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public class Configuration : DbMigrationsConfiguration<QuizProjekt.Repository.TestContext>
    {
        public Configuration()
        {
            //QuizRepository.GetAllQuizes();
            AutomaticMigrationsEnabled = true;
            ContextKey = "QuizProjekt.Repository.TestContext";
        }

        protected override void Seed(QuizProjekt.Repository.TestContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );{
            //

            //context.

            //var questions = new[]
            //{
            //    new Question {Text = "Vad kallas h�stens sk�gg?"},
            //    new Question {Text = "Vanligaste f�rgen?"}
            //};
            //questions[0].Alternatives = new[]
            //{
            //    new Alternative {Text = "Sk�gg s�klart", Correct = true},
            //};


            //var q = new Test()
            //{
            //    Name = "Amazing horse superstars Vol. 4",
            //    Description = "N�nting om h�star f�fan",
            //    Public = true
            //};


        }
    }
}
