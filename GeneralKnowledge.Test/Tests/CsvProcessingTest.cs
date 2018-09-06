using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using GeneralKnowledge.Test.App.Models;
using CsvHelper;

namespace GeneralKnowledge.Test.App.Tests
{
    /// <summary>
    /// CSV processing test
    /// </summary>
    public class CsvProcessingTest : ITest
    {
        public void Run()
        {
            // TODO: 
            // Create a domain model via POCO classes to store the data available in the CSV file below
            // Objects to be present in the domain model: Asset, Country and Mime type
            // Process the file in the most robust way possible
            // The use of 3rd party plugins is permitted

            List<TestData> result = parseRecordsTestData();

            //Assume 0 based array and that the header row is skipped
            Console.WriteLine(result[6].Asset_Id);


        }

        public static List<TestData> parseRecordsTestData()
        {
            List<TestData> result = new List<TestData>();
            var textReader = new StringReader(Resources.AssetImport);
            var csv = new CsvReader(textReader);
            csv.Configuration.HasHeaderRecord = false;

            //skip header row
            csv.Read();

            //while reading each row of the csv
            while (csv.Read())

            {
                //get a row and insert it into the list
                var record = csv.GetRecord<TestData>();
                result.Add(record);
            }

            return result;

        }

 
    }



}
