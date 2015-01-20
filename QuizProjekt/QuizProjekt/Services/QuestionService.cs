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
        public Question GetQuestion(int id)
        {
            using (var context = new TestContext())
            {
                return context.Questions.Include(x => x.Alternatives).FirstOrDefault( x => x.Id == id);
            }

        }
    }
}