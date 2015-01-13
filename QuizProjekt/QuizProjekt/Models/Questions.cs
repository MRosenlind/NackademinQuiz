using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuizProjekt.Models
{
    public class Question
    {
        public string Text { get; set; }
        public virtual ICollection<Alternative> Alternatives { get; set; }


    }
}