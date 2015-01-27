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
            _quizId = Request.QueryString["Id"].ToInt();

            if (!Page.IsPostBack)
            {
                if (_quizId > 0)
                {
                    var test = _service.GetTest(_quizId);
                    if (test != null)
                    {
                        txtName.Text = test.Name;
                        txtDescription.Text = test.Description;
                        checkBoxPublic.Checked = test.Public;
                    }
                }
            }
        }

        protected void btnSaveBack_Click(object sender, EventArgs e)
        {
            

            var Test = new Test
            {
                Id = _quizId,
                Name = txtName.Text,
                Description = txtDescription.Text,
                Public = checkBoxPublic.Checked
            };

            

            _service.SaveTest(Test);

            Response.Redirect("EditQuiz.aspx?id=" + _quizId);
        }

        protected void btnSaveToQuestions_Click(object sender, EventArgs e)
        {
            var test = new Test
            {
                Id = _quizId,
                Name = txtName.Text,
                Description = txtDescription.Text,
                Public = checkBoxPublic.Checked
            };

            _service.SaveTest(test);

            Response.Redirect("EditQuestion.aspx?id=" + _quizId);
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            _service.Delete(_quizId);
            Response.Redirect("~/Default.aspx");
        }


    }
}