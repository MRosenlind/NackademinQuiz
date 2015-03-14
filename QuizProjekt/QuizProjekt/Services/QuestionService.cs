using QuizProjekt.Models;
using QuizProjekt.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using QuizProjekt.Models;


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
                        .FirstOrDefault(x => x.Test.Id == testId && x.Id > questionId);

            }
        }
        public int GetNextQuestion(int testId)
        {
            using (var context = new TestContext())
            {
            //    if ()
            //    {
                    
            //    }
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
                    .Where(x => x.Test.Id == testId && x.Id < questionId)
                    .OrderByDescending(x => x.Id)
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
                        q.Image = question.Image;
                    }
                }
                context.SaveChanges();
            }
        }
        
                public List<Question> GetQuestions(int quizId)
        {
            using (var context = new TestContext())
            {
                return context.Questions.Include("Alternatives").Where(x => x.Test.Id == quizId).ToList();

            }

        }
                public Dictionary<int, int> getAnswers()
                {
                    return HttpContext.Current.Session["Answers"] as Dictionary<int, int>;
                }

                public void SaveAnswer(int questionId, int alternativeId)
                {
                    // kolla om det redan finns en lista i session
                    var answers = HttpContext.Current.Session["Answers"] as Dictionary<int, int>;
                    // om inte, skapa en
                    if (answers == null)
                        answers = new Dictionary<int, int>();
                    // lägg till svaret
                    answers.Remove(questionId);
                    answers.Add(questionId, alternativeId);
                    // spara listan i session
                    HttpContext.Current.Session["Answers"] = answers;
                }
            
        
    }
}