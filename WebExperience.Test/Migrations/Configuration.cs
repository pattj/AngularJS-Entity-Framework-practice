namespace WebExperience.Test.Migrations
{
    using CsvHelper;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.IO;
    using System.Linq;
    using WebExperience.Test.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebExperience.Test.Models.TestContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebExperience.Test.Models.TestContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            List<Asset> result = new List<Asset>();
            var textReader = new StringReader(Resources.AssetImport);
            var csv = new CsvReader(textReader);
            csv.Configuration.HasHeaderRecord = false;

            //skip header row
            csv.Read();

            //while reading each row of the csv
            while (csv.Read())

            {
                //get a row and insert it into the list
                var record = csv.GetRecord<Asset>();
                result.Add(record);
            }

            context.Assets.AddRange(result);
        }
    }
}
