using System.Web.ModelBinding;
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
            using (var context = new TestContext()) 
            {
                return context.Tests.ToList(); 
            }
            
            
        }
        public static void AddQuiz(Test quiz)
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
        public static void AddAlternative(Alternative alternative, int questionId)
        {
            var context = new TestContext();
            var question = context.Questions.FirstOrDefault(x => x.Id == questionId);
            if (question != null)
            {
                question.Alternatives.Add(alternative);
                context.SaveChanges();
            }

        }
        public static Test GetTest(int id)
        {
            using (var context = new TestContext())
            {
                return context.Tests.FirstOrDefault(x => x.Id == id);

            }
        }
        public static Dictionary<int,int> getAnswers()
        {
            return HttpContext.Current.Session["Answers"] as Dictionary<int, int>;
        }

        public static void SaveAnswer(int questionId, int alternativeId)
        {
            // kolla om det redan finns en lista i session
            var answers = HttpContext.Current.Session["Answers"] as Dictionary<int, int>;
            // om inte, skapa en
            if (answers == null) 
                answers = new Dictionary<int, int>();
            // lägg till svaret
            answers.Remove(questionId);
            answers.Add(questionId,alternativeId);
            // spara listan i session
            HttpContext.Current.Session["Answers"] = answers;
        }


    }
}