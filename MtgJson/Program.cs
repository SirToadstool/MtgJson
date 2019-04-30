using MtgJson.Objects;
using Newtonsoft.Json;
using System;
using System.IO;

namespace MtgJson
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string fileText = File.ReadAllText(@"C:\Users\mmcdonald\Desktop\mtgJson.json");
            Cards cards = JsonConvert.DeserializeObject<Cards>(fileText);
            Console.ReadLine();
        }
    }

    public class Cards
    {
        public Card[] cards { get; set; }
    }
}