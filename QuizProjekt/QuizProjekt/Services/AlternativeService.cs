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

        public void SaveAlternative(Alternative alternative)
        {
            using (var context = new TestContext())
            {
                if (alternative.Id == 0)
                {
                    context.Alternatives.Add(alternative);
                }
                else
                {
                    var a = context.Alternatives.FirstOrDefault(x => x.Id == alternative.Id);
                    if (a != null)
                    {
                        a.Text = alternative.Text;
                    }
                }
                context.SaveChanges();
            }
        }
    }
}