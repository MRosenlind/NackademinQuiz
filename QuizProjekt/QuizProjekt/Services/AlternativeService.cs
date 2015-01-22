using QuizProjekt.Models;
using QuizProjekt.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuizProjekt.Services
{
    public class AlternativeService
    {
        public List<Alternative> GetAlternatives(int questionId)
        {
            using (var context = new TestContext())
            {
                return context.Alternatives.Where(x => x.Question.Id == questionId).ToList();

            }

        }
    }
}