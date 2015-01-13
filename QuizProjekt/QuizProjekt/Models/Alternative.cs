using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuizProjekt.Models
{
    public class Alternative
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public bool Correct { get; set; }
        public virtual Question Questions { get; set; }
    }
}