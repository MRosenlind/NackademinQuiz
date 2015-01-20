using QuizProjekt.Models;
using QuizProjekt.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace QuizProjekt.Services
{
    public class QuestionService
    {
        public Question GetNextQuestion(int testId, int questionId)
        {
            using (var context = new TestContext())
            {
                return context.Questions
                    .Include(x => x.Alternatives)
                    .Where(x => x.Test.Id == testId && x.Id > questionId)
                    .OrderBy(x => x.Id)
                    .FirstOrDefault();
            }

        }
    }
}