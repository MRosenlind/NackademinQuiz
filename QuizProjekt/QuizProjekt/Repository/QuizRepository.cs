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
        public List<Test> GetAllQuizes()
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
        public void AddQuestion(Question question, int testId)
        {
            var context = new TestContext();
            var test = context.Tests.FirstOrDefault(x => x.Id == testId);
            if (test!= null)
            {
                test.Questions.Add(question);
                context.SaveChanges();
            }

        }
        public void AddAlternative(Alternative alternative, int questionsId)
        {
            var context = new TestContext();
            var question = context.Questions.FirstOrDefault(x => x.Id == questionsId);
            if (question != null)
            {
                question.Alternatives.Add(alternative);
                context.SaveChanges();
            }
        }

    }
}