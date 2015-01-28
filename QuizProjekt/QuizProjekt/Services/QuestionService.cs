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
                //return context.Questions
                //    .Where(x => x.Test.Id == testId && x.Id > questionId)
                //    .OrderBy(x => x.Id)
                //    .FirstOrDefault();

                //return context.Questions
                //    .Include(x => x.Alternatives)
                //    .Where(x => x.Test.Id == testId && x.Id > questionId)
                //    .OrderBy(x => x.Id)
                //    .FirstOrDefault();

                return
                    context.Questions.Include("Alternatives")
                        .OrderBy(x => x.Id)
                        .FirstOrDefault(x => x.Test.Id == testId && x.Id == questionId);

            }
        }
        public int GetNextQuestion(int testId)
        {
            using (var context = new TestContext())
            {

                return
                    context.Questions.Include("Alternatives")
                        .FirstOrDefault(x => x.Test.Id == testId).Id;

            }
        }
        public Question GetPreviousQuestion(int testId, int questionId)
        {
            using (var context = new TestContext())
            {
                return context.Questions
                    .Where(x => x.Test.Id == testId && x.Id > questionId)
                    .OrderBy(x => x.Id)
                    .FirstOrDefault();
            }
        }
        public void SaveQuestion(Question question)
        {
            using (var context = new TestContext())
            {
                if (question.Id == 0)
                {
                    context.Questions.Add(question);
                }
                else
                {
                    var q = context.Questions.FirstOrDefault(x => x.Id == question.Id);
                    if (q != null)
                    {
                        q.Text = question.Text;
                    }
                }
                context.SaveChanges();
            }
        }
        //public Question GetQuestions(int id)
        //{
        //    using (var context = new TestContext())
        //    {
        //        //return context.Questions.Where(x=>x.Id == id)
                public List<Question> GetQuestions(int quizId)
        {
            using (var context = new TestContext())
            {
                return context.Questions.Where(x => x.Test.Id == quizId).ToList();

            }

        }

            
        
    }
}