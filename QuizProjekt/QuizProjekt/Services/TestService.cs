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
                return context.Tests.
                    FirstOrDefault(x => x.Id == id);

            }
        }
        public void SaveTest(Test test)
        {
            using (var context = new TestContext())
            {
                if (test.Id == 0)
                {
                    context.Tests.Add(test);
                }
                else
                {
                    var t = context.Tests.FirstOrDefault(x => x.Id == test.Id);
                    if (t != null)
                    {
                        t.Name = test.Name;
                        t.Description = test.Description;
                        t.Public = test.Public;
                    }
                }
                context.SaveChanges();
            }
        }
        public void Delete(int id)
        {
            using (var context = new TestContext())
            {
                var t = context.Tests.
                    FirstOrDefault(x => x.Id == id);
                context.Tests.Remove(t);
                context.SaveChanges();
            }
        }
    }
}