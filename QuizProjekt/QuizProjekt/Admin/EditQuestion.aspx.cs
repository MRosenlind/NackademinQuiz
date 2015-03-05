using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QuizProjekt.Models;
using QuizProjekt.Repository;
using QuizProjekt.Services;

namespace QuizProjekt.Admin
{
    public partial class EditQuestion : System.Web.UI.Page
    {
        private int _questionId;
        private AlternativeService _service = new AlternativeService();
        protected void Page_Load(object sender, EventArgs e)
        {
            _questionId = Request.QueryString["Id"].ToInt();

            if (!Page.IsPostBack)
            {
                if (_questionId > 0)
                {
                    var question = _service.GetAlternatives(_questionId);
                    if (question != null)
                    {


                    }
                }
            }
        }

        protected void btnSaveToStart_Click(object sender, EventArgs e)
        {
            var alternative = new Alternative
            {
                Text = txtAlternative.Text,
                Correct = chechBoxRight.Checked
  
            };
            _service.SaveAlternative(alternative,_questionId);



            Response.Redirect("EditQuestion.aspx?id="+ _questionId);
        }

        protected void btnStartsida_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }

        protected void btnQuestSubmit_Click(object sender, EventArgs e)
        {
            var qId = Request.QueryString["Id"];

            var i = 0;

            int.TryParse(qId, out i);
            var question = new Question();
            question.Id = i;
            //question.Image = i + ".jpg";


            if (FileUpload1.HasFile)
            {
                //question.Image = Path.GetExtension(FileUpload1.FileName);
                question.Image = i + ".jpg";
                string uploadFolder = Request.PhysicalApplicationPath + "/Upload/";
            


            FileUpload1.SaveAs(uploadFolder + i + ".jpg");
    
            QuizRepository.AddQuestion(question, i);
            }

            Response.Redirect("AddAlternative.aspx?id=" + question.Id);

        }
        void SaveFile(int id)
        {
            string savePath = Server.MapPath("/Upload/");
            string fileName = id + Path.GetExtension(FileUpload1.FileName);

            savePath += fileName;
            FileUpload1.SaveAs(savePath);
        }

        protected void SaveImageBtn_Click(object sender, EventArgs e)
        {
            var qId = Request.QueryString["Id"];

            var i = 0;

            int.TryParse(qId, out i);
            var question = new Question();
            question.Id = i;
            //question.Image = i + ".jpg";


            if (FileUpload1.HasFile)
            {
                //question.Image = Path.GetExtension(FileUpload1.FileName);
                question.Image = i + ".jpg";
                string uploadFolder = Server.MapPath("/Upload");



                FileUpload1.SaveAs(Path.Combine(uploadFolder, i + ".jpg"));

                QuizRepository.AddQuestion(question, i);
            }
        }
        
    }
}