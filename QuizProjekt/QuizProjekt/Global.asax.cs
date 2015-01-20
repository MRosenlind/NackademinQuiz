using System.Data.Entity;
using System.Diagnostics;
using QuizProjekt.Migrations;
using QuizProjekt.Models;
using QuizProjekt.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace QuizProjekt
{
    public class Global : System.Web.HttpApplication
    {

        //protected void Application_Start(object sender, EventArgs e)
        //{
        //   //Database.SetInitializer(new MigrateDatabaseToLatestVersion<TestContext,QuizProjekt.Migrations.Configuration>());
        //    Database.SetInitializer(new CreateDatabaseIfNotExists<TestContext>());
        //   using (var ctx = new TestContext())
        //   {
        //       foreach (var test in ctx.Tests)
        //       {
        //           Debug.Write(test.Name);
        //       }
        //   }

        //}

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}