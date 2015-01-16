using QuizProjekt.Models;
using QuizProjekt.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace QuizProjekt.Services
{
    public class TestService
    {
        public Test GetTest(int id)
        {
            using (var context = new TestContext())
            {
                return context.Tests.Include(x => x.Name).FirstOrDefault(x => x.Id == id);

            }
        }

    }
}