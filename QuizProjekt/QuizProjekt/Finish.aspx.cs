using QuizProjekt.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QuizProjekt.Repository;

namespace QuizProjekt
{
    public partial class Finish : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            var answers = new QuestionService().getAnswers();
            var questions = new QuestionService().GetQuestions(Request.QueryString["id"].ToInt());
            Answers.DataSource = answers;
            Answers.DataBind();

            var points = 0;
            foreach (var answer in answers)
            {
               var alt = questions.SelectMany(x => x.Alternatives).FirstOrDefault(x => x.Id == answer.Value);
                if (alt != null && alt.Correct)
                {
                    points++;
                }
                
            }
            lblScore.Text = points.ToString();
        }

        protected void btnStartpage_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}