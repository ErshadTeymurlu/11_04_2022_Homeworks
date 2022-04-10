using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Task1.Models;
namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Which year's currencies do yo want to see?: ");
            string year = Console.ReadLine();
            HttpClient http = new HttpClient();
            string data = http.GetStringAsync("https://www.cbar.az/currencies/08.04."+year+".xml").Result;
            XmlSerializer xml = new XmlSerializer(typeof(ValCurs));
            StringReader stringReader = new StringReader(data);
            ValCurs valCurs = (ValCurs)xml.Deserialize(stringReader);          
            string content = JsonConvert.SerializeObject(valCurs);
            StreamWriter sw = new StreamWriter(@"C:\Users\HP\source\repos\Task1\Files\Valute.json");
            sw.Write(content);
            sw.Close();
        }
    }
}
