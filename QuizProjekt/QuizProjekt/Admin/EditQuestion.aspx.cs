using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QuizProjekt.Models;
using QuizProjekt.Repository;
using QuizProjekt.Services;

namespace QuizProjekt.Admin
{
    public partial class EditQuestion : System.Web.UI.Page
    {
        private int _questionId;
        private AlternativeService _service = new AlternativeService();
        protected void Page_Load(object sender, EventArgs e)
        {
            _questionId = Request.QueryString["Id"].ToInt();

            if (!Page.IsPostBack)
            {
                if (_questionId > 0)
                {
                    var question = _service.GetAlternatives(_questionId);
                    if (question != null)
                    {


                    }
                }
            }
        }

        protected void btnSaveToStart_Click(object sender, EventArgs e)
        {
            var alternative = new Alternative
            {
                Text = txtAlternative.Text,
                Correct = chechBoxRight.Checked
  
            };
            _service.SaveAlternative(alternative,_questionId);

            Response.Redirect("EditQuestion.aspx?id="+ _questionId);
        }

        protected void btnSaveToAlternative_Click(object sender, EventArgs e)
        {
            //var question = new Question
            //{
            //    Id = _questionId,
            //    Text = txtQuestion.Text
            //};
            //_service.SaveQuestion(question);

            //Response.Redirect("AddAlternative.aspx?id="+ _questionId);
        }
    }
}