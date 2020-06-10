using System;
using System.Collections.Generic;
using System.Linq;

namespace WoerterbuchLogic
{
    public class WoerterbuchController
    {
        /// <summary>
        /// Path to csv file 
        /// </summary>
        private string Path;
        public WoerterbuchController(string path)
        {
            this.Path = path;
        }

        public Dictionary<string, List<string>> WordsDict { get; set; } = new Dictionary<string, List<string>>();


        /// <summary>
        /// read the file to the dictionary
        /// wordsDict
        /// </summary>
        public void ReadDictionary()
        {
            WordsDict.Clear();
            System.IO.File.ReadAllLines(
               Path)
                .Select(c => new { German = c.Split(';')[0], English = c.Split(';')[1], Dutch = c.Split(';')[2] })
                .ToList()
                .ForEach(x =>
                    WordsDict.Add(x.German, new List<string>() { x.English, x.Dutch }));
        }

        /// <summary>
        /// writes the dictionary to file
        /// </summary>
        public void WriteToFile()
        {
            System.IO.File.WriteAllLines(Path, WordsDict.Select(d => $"{d.Key};{d.Value[0]};{d.Value[1]};"));
        }

        /// <summary>
        /// filters the dictionary and returns a list
        /// </summary>
        /// <param name="filterString"></param>
        /// <param name="hasToStartsWith"></param>
        /// <returns></returns>
        public List<string> FindResults(string filterString, string hasToStartsWith)
        {
            List<string> list = new List<string>();
            try
            {
                list = WordsDict.Where(x => x.Key.Contains(filterString) && x.Key.StartsWith(hasToStartsWith)).Select(x => x.Key).ToList(); ;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex);
            }
            return list;
        }

        /// <summary>
        /// returns the alphabet for the filtering
        /// </summary>
        /// <returns></returns>
        public List<string> GetAlphabet()
        {
            return new List<string>() { "", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" }; ;
        }

        public void AddWords(string german, List<string> translations)
        {
            try
            {
                if (!string.IsNullOrEmpty(german) && !string.IsNullOrEmpty(translations[0]) && !string.IsNullOrEmpty(translations[1]))
                {
                    WordsDict.Add(german, translations);
                }
                else
                {
                    throw new Exception("Eingabe Falsch!");
                }
            }
            catch (ArgumentException)
            {
                throw new Exception("Dieses Wort existiert bereits!");
            }
        }
    }
}
