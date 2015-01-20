using QuizProjekt.Services;
using QuizProjekt.Repository;
using QuizProjekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuizProjekt
{
    public partial class DoQuiz : System.Web.UI.Page
    {
        private int _questionId;
        private QuestionService _service = new QuestionService();
        protected void Page_Load(object sender, EventArgs e)
        {
            _questionId = Request.QueryString["Id"].ToInt();

            if (!Page.IsPostBack)
            {
                if (_questionId > 0)
               {
                  var quiz = _service.GetNextQuestion(_questionId, 0);
                   if (quiz != null)
                   {
                       lblQuestion.Text = quiz.Text;
                   
                   }
               }
            }
        }
    }
}