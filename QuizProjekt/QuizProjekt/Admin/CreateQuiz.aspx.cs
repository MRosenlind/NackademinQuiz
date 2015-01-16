using QuizProjekt.Models;
using QuizProjekt.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuizProjekt.Admin
{
    public partial class CreateQuiz : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            var quiz = new Test();

            quiz.Name = txtName.Text;
            quiz.Description = txtDescription.Text;
           
            new QuizRepository().AddQuiz(quiz);
            Response.Redirect("AddQuestion.aspx");
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
           // DdlQuizList.SelectedValue
            Response.Redirect("EditQuiz.aspx");
        }

    }
}