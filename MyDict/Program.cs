using System;
using System.Collections.Generic;
using System.Linq;

namespace MyDict
{
    class WordPlay
    {
        private Dictionary<string, string> Words = new Dictionary<string, string>();
        public WordPlay()
        {
            Words.Add("man", "kvinna");
            Words.Add("barn", "vuxen");
            Words.Add("tort", "vått");
            Words.Add("sol", "regn");
        }
        public bool ValidateNotSame(string word1, string word2)
        {
           return Words.Any(x=>x.Key == word1 && x.Value==word2);
        }
    }
    class Program
    {
        static WordPlay wp = new WordPlay();
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in första ordet: ");
            var word1 = Console.ReadLine();
            Console.WriteLine("Skriv in andra ordet: ");
            var word2 = Console.ReadLine();
            var isValid = wp.ValidateNotSame(word1, word2);
            Console.WriteLine(isValid? "Du testade rätt" : "Du testade fel");
        }
    }
}
