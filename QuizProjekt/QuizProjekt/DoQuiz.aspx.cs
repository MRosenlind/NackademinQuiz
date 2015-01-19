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
        //private int _movieId;
        //private MovieService _service = new MovieService();
        protected void Page_Load(object sender, EventArgs e)
        {
            //_movieId = Request.QueryString["id"].ToInt();

            //if (!Page.IsPostBack)
            //{
            //    if (_movieId > 0)
            //    {
            //        var movie = _service.GetMovie(_movieId);
            //        if (movie != null)
            //        {
            //            txtTitle.Text = movie.Title;
            //            txtRelease.Text = movie.ReleaseYear.ToString();

            //            GridView1.DataSource = movie.Actors;
            //            GridView1.DataBind();
            //        }
            //    }
            //}
        }
    }
}