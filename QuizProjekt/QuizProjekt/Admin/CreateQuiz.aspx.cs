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

            //var qid = Request.QueryString["qid"];

            //var i = 0;

            //int.TryParse(qid, out i);
            var quiz = QuizRepository.AddQuiz(txtName.Text, txtDescription.Text);
            Response.Redirect("AddQuestion.aspx?qid="+quiz.Id);
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            //var a = DdlQuizList.SelectedValue;
            
            Response.Redirect("EditQuiz.aspx");
        }

    }
}