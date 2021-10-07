using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProgrammingLanguages
{
  class Program
  {
    static void Main()
    {
      List<Language> languages = File.ReadAllLines("./languages.tsv")
        .Skip(1)
        .Select(line => Language.FromTsv(line))
        .ToList();

        var query = from l in languages
                    select new { l.Year, l.Name, l.ChiefDeveloper };
        /*Exercise 2 print*/
        /*foreach (var l in query) {
          Console.WriteLine($"Year: {l.Year}, Name: {l.Name}, Chief Develoeper: {l.ChiefDeveloper}");
        }*/

        var findCSharp = from l in languages
                         where l.Name == "C#"
                         select l;
        
        var microsoftLang = from l in languages
                            where l.ChiefDeveloper.Contains("Microsoft")
                            select l;
        /*Exercise 4 print*/
        /*foreach (var lang in microsoftLang) {
          Console.WriteLine($"Year: {lang.Year}, Name: {lang.Name}, Chief Develoeper: {lang.ChiefDeveloper}");*/

        var lispLang = from l in languages
                       where l.Predecessors.Contains("Lisp")
                       select l;
        

        var scriptLang = from l in languages
                       where l.Name.Contains("Script")
                       select l;
        
        var countLang = languages.Count();
        
        var countLangInt = languages.Where(l => (l.Year >= 1995 & l.Year <= 2005)).Count();

        Console.WriteLine(countLangInt);

    }
  }
}
