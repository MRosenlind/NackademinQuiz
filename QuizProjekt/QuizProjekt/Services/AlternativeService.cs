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
        public List<Question> GetAlternatives(int alternativeId)
        {
            using (var context = new TestContext())
            {
                return context.Questions.Where(x => x.Test.Id == alternativeId).ToList();

            }

        }

        //public void SaveAlternatives(Alternative alternative)
        //{
        //    using (var context = new TestContext())
        //    {
        //        if (alternative.Id == 0)
        //        {
        //            context.Alternatives.Add(alternative);
        //        }
        //        else
        //        {
        //            var a = context.Alternatives.FirstOrDefault(x => x.Id == alternative.Id);
        //            if (a != null)
        //            {
        //                a.Text = alternative.Text;
        //            }
        //        }
        //        context.SaveChanges();
        //    }
        //}

        public void SaveAlternative(Alternative alternative, int questionId)
        {
            using (var context = new TestContext())
            {
                if (alternative.Id == 0)
                {
                    var question = context.Questions.FirstOrDefault(x => x.Id == questionId);
                    if (question != null)
                    {
                        question.Alternatives.Add(alternative);
                    }
                }
                context.SaveChanges();
            }
        }
    }
}