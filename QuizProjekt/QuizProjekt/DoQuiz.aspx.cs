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
            btnFinish.Visible = false;
            //if (!Page.IsPostBack)
            //{
            //    btnPreviousQuestion.Visible = false;
            //}
            //else
            //    btnPreviousQuestion.Visible = true;
            
            _testId = Request.QueryString["Id"].ToInt();
            if(Request.QueryString["qId"] != null)
                _questionId = Request.QueryString["qId"].ToInt();
            else
                _questionId = _service.GetNextQuestion(_testId);
            
            if (!Page.IsPostBack)
            {
                
                if (_testId > 0)
               {
                  var question = _service.GetNextQuestion(_testId, _questionId);
                  
                   if (question != null)
                   {
                       var alternatives = question.Alternatives.Where(x => x.Question.Id == _questionId);
                       lblQuestion.Text = question.Text;
                       RadioButtonList1.DataSource = alternatives;
                       RadioButtonList1.DataBind();
                   }
                   
                   if (question == null)
                   {
                       btnFinish.Visible = true;
                       //Response.Redirect("Default.aspx");
                   }
               }
            }
          
        }

        protected void btnNextQuestion_Click(object sender, EventArgs e)
        {
            
            Response.Redirect("DoQuiz.aspx?id=" + _testId + "&qId=" + (_questionId+1));
        }

        protected void btnPreviousQuestion_Click(object sender, EventArgs e)
        {
            Response.Redirect("DoQuiz.aspx?id=" + _testId + "&qId=" + (_questionId - 1));
        }

        protected void btnFinish_Click(object sender, EventArgs e)
        {

        }
    }
}