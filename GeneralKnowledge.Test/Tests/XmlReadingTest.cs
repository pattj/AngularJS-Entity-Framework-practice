using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace GeneralKnowledge.Test.App.Tests
{
    /// <summary>
    /// This test evaluates the 
    /// </summary>
    public class XmlReadingTest : ITest
    {
        public string Name { get { return "XML Reading Test";  } }

        public void Run()
        {

            // TODO: 
            // Determine for each parameter stored in the variable below, the average value, lowest and highest number.
            // Example output
            // parameter   LOW AVG MAX
            // temperature   x   y   z
            // pH            x   y   z
            // Chloride      x   y   z
            // Phosphate     x   y   z
            // Nitrate       x   y   z
            string xmlName = "SamplePoints";

                PrintOverview(xmlName);
        }

        private void PrintOverview(string xmlName)
        {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            ;
            XmlDocument doc = new XmlDocument();
            Dictionary<string, List<float>> myDict = new Dictionary<string, List<float>>();
            doc.Load(path + $"/Resources/{xmlName}.xml");

            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                foreach (XmlNode param in node)
                {
                    var field = param.Attributes["name"].Value;

                    try
                    {
                        myDict[field].Add(float.Parse(param.InnerText));
                    }
                    catch
                    {
                        myDict.Add(field, new List<float> { float.Parse(param.InnerText) });
                    }
                    // Console.WriteLine(param.Attributes["name"].Value);
                }
                // string text = node.InnerText;
                //Console.WriteLine(node.ChildNodes.Count);
            }

            Console.WriteLine("{0, -22}  {1,5:N1}", "parameter", "LOW     AVG     MAX");
            foreach (string key in myDict.Keys.ToList())
            {
                var result = string.Format("{0, -20}  {1, 5:0.00} {2,8:0.00} {3,6:0.00}", key, myDict[key].Min(), myDict[key].Average(), myDict[key].Max());

                Console.WriteLine(result);
            }
        }
    }
}
