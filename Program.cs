using System;

namespace Programming_Languages
{
    class Program
    {
        static void Main(string[] args)
        {
             List<Language> languages = File.ReadAllLines("./languages.tsv")
            .Skip(1)
            .Select(line => Language.FromTsv(line))
            .ToList();
        }
    }
}
