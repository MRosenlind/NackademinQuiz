using QuizProjekt.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuizProjekt
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            QuizList.DataSource = new QuizRepository().GetAllQuizes();
            QuizList.DataBind();
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin/CreateQuiz.aspx");
        }
    }
}