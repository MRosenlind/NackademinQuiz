using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuizProjekt.Repository
{
    public static class Extensions
    {
        public static int ToInt(this string s, int defaultValue = 0)
        {
            int i;
            return int.TryParse(s, out i) ? i : defaultValue;
        }
    }
}