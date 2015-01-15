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
    public partial class AddQuestion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var question = new Question();

            question.Text = txtQuestion.Text;
            
           
            // TODO: gör int.TryParse på dropdownlistans värde
            new QuizRepository().AddQuestion(question, int.Parse( DropDownList1.SelectedValue));

            
            Response.Redirect("AddQuestion.aspx");
        }
    }
}