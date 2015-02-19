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

            var qId = Request.QueryString["Id"];

            var i = 0;

            int.TryParse(qId, out i);
            var question = new Question();
            question.Text = txtQuestion.Text;

            QuizRepository.AddQuestion(question, i);



            Response.Redirect("EditQuiz.aspx?id=" + _quizId);
        }
      

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            _service.Delete(_quizId);
            Response.Redirect("~/Default.aspx");
        }

        protected void Startsidan_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }


    }
}