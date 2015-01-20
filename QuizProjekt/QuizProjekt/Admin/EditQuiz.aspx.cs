using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QuizProjekt.Services;
using QuizProjekt.Models;
using QuizProjekt.Repository;

namespace QuizProjekt.Admin
{
    public partial class EditQuiz : System.Web.UI.Page
    {
        private int _quizId;
        private TestService _service = new TestService();
        protected void Page_Load(object sender, EventArgs e)
        {
            //raden nedan var bortkommenterad....
            _quizId = Request.QueryString["id"].ToInt();

            if (!Page.IsPostBack)
            {
                if (_quizId > 0)
                {
                    var quiz = _service.GetTest(_quizId);
                    if (quiz != null)
                    {
                        txtName.Text = quiz.Name;
                        txtDescription.Text = quiz.Description;

                        
                    }
                }
            }
        }
    }
}