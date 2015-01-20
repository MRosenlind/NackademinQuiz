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
        public Question GetNextQuestion(int id, int questionId)
        {
            using (var context = new TestContext())
            {
                return context.Questions.Where(x => x.Test.Id == id && x.Id > questionId).OrderBy(x => x.Id).FirstOrDefault();
                //return context.Questions.Where(x => x.Text.Contains(x.Text)).Where(x => x.Id == id).ToList();
            }

        }
    }
}