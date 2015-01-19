using QuizProjekt.Models;
using QuizProjekt.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QuizProjekt.Models;

namespace QuizProjekt.Admin
{
    public partial class AddAlternative : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLaggTill_Click(object sender, EventArgs e)
        {
            //var alternative = new Alternative();

            //alternative.Text = txtAlternative.Text;

            
            ////new QuizRepository().AddAlternative(alternative, int.Parse());
            //if (CheckBoxRattSvar != null)
            //{
             
            //}
            Response.Redirect("AddAlternative.aspx");
        }

        protected void btnAvsluta_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }
    }
}