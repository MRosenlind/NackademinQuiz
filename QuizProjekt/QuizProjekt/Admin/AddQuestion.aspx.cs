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

        //protected void CheckForQuizParameter()
        //{
        //    var qid = Request.QueryString["qid"];

        //    var i = 0;

        //    int.TryParse(qid, out i);

        //    if (i == 0) { }
        //}

        protected void Button1_Click(object sender, EventArgs e)
        {

            
           
            // TODO: gör int.TryParse på dropdownlistans värde
            //QuizRepository.AddQuestion(txtQuestion.Text, int.Parse( DropDownList1.SelectedValue));

            
            Response.Redirect("AddAlternative.aspx");
        }
    }
}