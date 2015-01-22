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
        private int _testId;
        private int _questionId;
        private QuestionService _service = new QuestionService();
        protected void Page_Load(object sender, EventArgs e)
        {
            _testId = Request.QueryString["Id"].ToInt();
            _questionId = Request.QueryString["qId"].ToInt();

            if (!Page.IsPostBack)
            {
                if (_testId > 0)
               {
                  var question = _service.GetNextQuestion(_testId, _questionId);
                   if (question != null)
                   {
                       
                       lblQuestion.Text = question.Text;
                   
                   }
               }
            }
        }

        protected void btnNextQuestion_Click(object sender, EventArgs e)
        {
            Response.Redirect("DoQuiz.aspx?id=" + _testId + "&qId=" + (_questionId+1));
        }
    }
}