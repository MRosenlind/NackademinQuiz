﻿using QuizProjekt.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuizProjekt
{
    public partial class Finish : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Answers.DataSource = new QuestionService().getAnswers();
            Answers.DataBind();
        }

        protected void btnStartpage_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}