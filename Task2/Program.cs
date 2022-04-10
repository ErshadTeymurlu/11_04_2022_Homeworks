using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Task2.Models;
using Newtonsoft.Json;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HttpClient httpClient = new HttpClient();
            string data = httpClient.GetStringAsync("https://jsonplaceholder.typicode.com/posts").Result;
            List<Post> posts = JsonConvert.DeserializeObject<List<Post>>(data);
            foreach (var item in posts)
            {
                Console.WriteLine(item.title);
            }
            Console.ReadLine();
        }
    }
}
