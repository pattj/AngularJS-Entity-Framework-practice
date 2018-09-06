using GeneralKnowledge.Test.App.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebExperience.Test.Models
{
    public class TestContext :DbContext
    {

        public TestContext(): base("TestContext")
        {
            Database.SetInitializer(
    new CreateDatabaseIfNotExists<TestContext>());


        }

        public DbSet<Asset> Assets { get; set; }

    }
}