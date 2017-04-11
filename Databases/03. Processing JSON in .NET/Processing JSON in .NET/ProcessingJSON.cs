using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Processing_JSON_in.NET
{
    public class ProcessingJSON
    {
        public static void Main()
        {

            ProcessingJSON.DownloadTelerikVideosRss();
            ProcessingJSON.ParsingXmlToJSON();
            ProcessingJSON.SelectingAllVideosTitlesWithLINQFromTheJsonFile();
            ProcessingJSON.ParsingTheJsonFileToPocoFile();
            //ProcessingJSON.ParsingTheJsonFileToPocoFile();
        }

        public static void DownloadTelerikVideosRss()
        {
            // task 1 and 2
            string url = "https://www.youtube.com/feeds/videos.xml?channel_id=UCLC-vbm7OWvpbqzXaoAMGGw";
            string fileNameAndPathToSave = @"D:\telerik\Databases - 2016\03. Processing JSON in .NET\Processing JSON in .NET\videos.xml";
            WebClient webClient = new WebClient();
            webClient.DownloadFile(url, fileNameAndPathToSave);
            Console.WriteLine("Successfully downloaded file videos.xml! :)\n");
        }

        public static void ParsingXmlToJSON()
        {
            //task 3
            var url = @"D:\telerik\Databases - 2016\03. Processing JSON in .NET\Processing JSON in .NET\videos.xml";
            //var xml = File.ReadAllText(url);
            //var doc = XDocument.Parse(xml);
            var doc = XDocument.Load(url);
            string jsonFromXml = JsonConvert.SerializeXNode(doc, Formatting.Indented);
            string pathToSafe = @"D:\telerik\Databases - 2016\03. Processing JSON in .NET\Processing JSON in .NET\videos.json";
            File.WriteAllText(pathToSafe, jsonFromXml);
            Console.WriteLine("The file is saved in the project folder. You can find it there! :)\n");
        }

        public static void SelectingAllVideosTitlesWithLINQFromTheJsonFile()
        {
            //task 4
            string url = @"D:\telerik\Databases - 2016\03. Processing JSON in .NET\Processing JSON in .NET\videos.json";
            var json = File.ReadAllText(url);
            var jObject = JObject.Parse(json);

            var allTitles = from title in jObject["feed"]["entry"]
                            select (string)title["title"];
            Console.WriteLine("Task 4 printing all titles from the file.");
            Console.WriteLine("______________________________");
            foreach (var title in allTitles)
            {
                Console.WriteLine(title);
            }
            Console.WriteLine("______________________________");
        }

        public static void ParsingTheJsonFileToPocoFile()
        {
            //task 5
            string url = @"D:\telerik\Databases - 2016\03. Processing JSON in .NET\Processing JSON in .NET\videos.json";
            var json = File.ReadAllText(url);
            var poco = JsonConvert.DeserializeObject<RootObject>(json);
            Console.WriteLine(poco);
        }
    }
}