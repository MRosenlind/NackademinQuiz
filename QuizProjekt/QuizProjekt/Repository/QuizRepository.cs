using QuizProjekt.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace QuizProjekt.Repository
{
    public class QuizRepository
    {
        public static List<Test> GetAllQuizes()
        {
            var context = new TestContext();
            return context.Tests.ToList();
            
        }
        public void AddQuiz(Test quiz)
        {
            var context = new TestContext();
            context.Tests.Add(quiz);
            context.SaveChanges();
        }
        public static void AddQuestion(Question question, int testId)
        {
            var context = new TestContext();
            var test = context.Tests.FirstOrDefault(x => x.Id == testId);
            if (test!= null)
            {
                test.Questions.Add(question);
                context.SaveChanges();
            }

        }

    }
}