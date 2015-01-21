﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QuizProjekt.Services;
using QuizProjekt.Models;
using QuizProjekt.Repository;

namespace QuizProjekt.Admin
{
    public partial class EditQuiz : System.Web.UI.Page
    {
        private int _quizId;
        private TestService _service = new TestService();
        protected void Page_Load(object sender, EventArgs e)
        {
            //raden nedan var bortkommenterad....
            _quizId = Request.QueryString["Id"].ToInt();

            if (!Page.IsPostBack)
            {
                if (_quizId > 0)
                {
                    var test = _service.GetTest(_quizId);
                    if (test != null)
                    {
                        txtName.Text = test.Name;
                        txtDescription.Text = test.Description;

                        

                    }
                }
            }
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {

        }

        protected void btnToQuestions_Click(object sender, EventArgs e)
        {

        }
    }
}