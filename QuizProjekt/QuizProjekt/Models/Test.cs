using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuizProjekt.Models
{
    /// <summary>
    /// Represents a quiz topic, like "Amazing killer butterflys"
    /// </summary>
    public class Test
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public bool Public { get; set; }

        public virtual ICollection<Question> Questions { get; set; }
    }
}