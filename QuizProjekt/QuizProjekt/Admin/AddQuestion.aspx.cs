using QuizProjekt.Models;
using QuizProjekt.Repository;
using System;
using System.Collections.Generic;
using System.IO;
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


        protected void btnQuestSubmit_Click(object sender, EventArgs e)
        {
            var qId = Request.QueryString["Id"];

            var i = 0;

            int.TryParse(qId, out i);
            var question = new Question();
            question.Text = txtQuestion.Text;

            if (FileUpload1.HasFile)
            {
                question.Image = Path.GetExtension(FileUpload1.FileName);
            }

            QuizRepository.AddQuestion(question, i);


            Response.Redirect("AddAlternative.aspx?id=" + question.Id);
            
        }
        void SaveFile(int id)
        {
            string savePath = Server.MapPath("Upload//");
            string fileName = id + Path.GetExtension(FileUpload1.FileName);
            string pathToCheck = savePath + fileName;
            string tempfileName = "";

            if (System.IO.File.Exists(pathToCheck))
            {
                int counter = 2;
                while (System.IO.File.Exists(pathToCheck))
                {
                    tempfileName = counter.ToString() + fileName;
                    pathToCheck = savePath + tempfileName;
                    counter++;
                }

            }
           
            savePath += fileName;
            FileUpload1.SaveAs(savePath);
        }
    }
}