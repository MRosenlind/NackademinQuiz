using QuizProjekt.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace QuizProjekt.Repository
{
    public static class QuizRepository
    {
        public static List<Test> GetAllQuizes()
        {
            List<Test> tests;
            using (var ctx = new TestContext())
            {
                tests = ctx.Tests.ToList();
            }
            return tests;
        }
        public static Test AddQuiz(string name, string description, bool isPublic = true)
        {
            var test = new Test
            {
                Name = name,
                Description = description,
                Public = isPublic,
                Questions = new List<Question>()
            };

            using (var ctx = new TestContext())
            {
                ctx.Tests.Add(test);
                ctx.SaveChanges();

                return test;
            }
        }
        public static Question AddQuestion(string text, int testId)
        {
            var question = new Question
            {
                Text = text,
                Alternatives = new List<Alternative>()
            };

            using (var ctx = new TestContext())
            {
                var theTest = ctx.Tests.FirstOrDefault(t => t.Id == testId);
                if (theTest == null) return null;

                theTest.Questions.Add(question);
                ctx.SaveChanges();

                return question;

            }
        }
        public static Alternative AddAlternative(string text, int questionsId, bool correct = false)
        {
            // Skapa ett alternativ
            var alternative = new Alternative
            {
                Text = text,
                Correct = correct
            };

            // Ta fram fråga och lägg till alternativet i databasen.
            using (var ctx = new TestContext())
            {
                var question = ctx.Questions.FirstOrDefault(x => x.Id == questionsId);
                if (question != null)
                {
                    //alternative.Question = question;
                    question.Alternatives.Add(alternative);

                    // Genomför ändringarna i databasen
                    ctx.SaveChanges();

                    return alternative;
                }
                return null;
            }
        }

    }
}