﻿using QuizProjekt.Services;
using QuizProjekt.Repository;
using QuizProjekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuizProjekt
{
    public partial class DoQuiz : System.Web.UI.Page
    {
      // private int score;
     

        private int _testId;
        private int _questionId;
        private QuestionService _service = new QuestionService();

       // private AlternativeService _aservice = new AlternativeService();
        protected void Page_Load(object sender, EventArgs e)
        {
            lblFinish.Visible = false;
            btnFinish.Visible = false;

            var question = _service.GetNextQuestion(_testId, _questionId);
            var previousquestion = _service.GetPreviousQuestion(_testId, _questionId);
            _testId = Request.QueryString["Id"].ToInt();
            
            if (!Page.IsPostBack)
            {
                _questionId = Request.QueryString["qId"].ToInt();

                if (_testId > 0)
               {
                   if (string.IsNullOrEmpty(Request.QueryString["direction"]))
                   {


                       if (question != null)
                       {
                           var alternatives = question.Alternatives.Where(x => x.Question.Id == _questionId);
                           lblQuestion.Text = question.Text;
                           RadioButtonList1.DataSource = alternatives;
                           RadioButtonList1.DataBind();

                           ViewState["QuestionId"] = question.Id;

                           //btnPreviousQuestion.Visible = true;
                       }

                       else
                       {
                           lblFinish.Visible = true;
                           btnFinish.Visible = true;
                       }

                       //if (_questionId <=2)
                       //    btnPreviousQuestion.Visible = false;

                   }
                   
                }
            }
            
        }

        protected void btnNextQuestion_Click(object sender, EventArgs e)
        {
            
            Response.Redirect("DoQuiz.aspx?id=" + _testId + "&qId=" + (ViewState["QuestionId"]));
        }

        protected void btnPreviousQuestion_Click(object sender, EventArgs e)
        {
            Response.Redirect("DoQuiz.aspx?direction=back&id=" + _testId + "&qId=" + (ViewState["QuestionId"]));
        }

        protected void btnFinish_Click(object sender, EventArgs e)
        {
            Response.Redirect("Finish.aspx");
        }
    }
}