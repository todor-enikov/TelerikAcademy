using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace _02.XML_Processing_in.NET
{
    public class XMLProcessing
    {
        public static void Main()
        {
            var url = @"D:\telerik\Databases - 2016\02. XML Processing in .NET\02. XML Processing in .NET\Catalog.xml";

            //task 2
            XMLProcessing.ExtractAllDifferentArtistsWithXmlDocument(url);

            //task 3
            XMLProcessing.ExtractAllDifferentArtistsWithXpath(url);

            //task 5
            XMLProcessing.ExtractSongsFromCatalogWithXMLReader(url);

            //task 6
            XMLProcessing.ExtractSongsFromCatalogWithXDocumentAndLINQ(url);
        }

        public static void ExtractAllDifferentArtistsWithXmlDocument(string url)
        {
            var doc = new XmlDocument();
            doc.Load(url);

            var albums = doc.DocumentElement;

            Console.WriteLine("The artists in the collection are: (with XmlDocument)");
            Console.WriteLine("--------------------");
            foreach (XmlElement album in albums.ChildNodes)
            {
                var artist = album["artist"];
                Console.WriteLine(artist.InnerText);
            }
            Console.WriteLine("The number of the albums is {0}!", albums.ChildNodes.Count);
            Console.WriteLine("--------------------");
        }

        public static void ExtractAllDifferentArtistsWithXpath(string url)
        {
            var doc = new XmlDocument();
            doc.Load(url);
            string xPath = "/albums/album/artist";
            var artists = doc.SelectNodes(xPath);
            Console.WriteLine("The artists in the collection are: (with XPath)");
            Console.WriteLine("--------------------");
            foreach (XmlElement artist in artists)
            {
                Console.WriteLine(artist.InnerText);
            }
            Console.WriteLine("--------------------");
        }

        public static void ExtractSongsFromCatalogWithXMLReader(string url)
        {
            using(XmlReader reader = XmlReader.Create(url))
            {
                Console.WriteLine("List of all songs in the catalog: (with XMLReader)");
                Console.WriteLine("--------------------");
                while (reader.Read())
                {
                    //Console.WriteLine(reader.Name);
                    if (reader.Name == "title")
                    {
                        Console.WriteLine(reader.ReadInnerXml());
                    }
                }
                Console.WriteLine("--------------------");
            }
        }

        public static void ExtractSongsFromCatalogWithXDocumentAndLINQ(string url)
        {
            var doc = XDocument.Load(url);

            var songs = doc.Root.Elements("songs");
            //.Select(fullInformation => fullInformation.Elements("songs"))
            //.Select(specificSong => specificSong.Elements("song"));
            //.Select(titleInformation=>titleInformation.Element("title").Value);
            Console.WriteLine(songs.ToString());
            Console.WriteLine("List of all songs in the catalog: (with XDocument and LINQ)");
            foreach (var song in songs)
            {
                Console.WriteLine(song);
            }
        }
    }
}
