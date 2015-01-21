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
        private QuestionService _service = new QuestionService();
        protected void Page_Load(object sender, EventArgs e)
        {
            _questionId = Request.QueryString["Id"].ToInt();

            if (!Page.IsPostBack)
            {
                if (_questionId > 0)
                {
                    var question = _service.GetNextQuestion(_questionId, 0);
                    if (question != null)
                    {
                        txtQuestion.Text = question.Text;
                        

                    }
                }
            }
        }

        protected void btnSaveToStart_Click(object sender, EventArgs e)
        {

        }

        protected void btnSaveToAlternative_Click(object sender, EventArgs e)
        {

        }
    }
}