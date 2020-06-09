using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wörterbuch
{
    public partial class Form1 : Form
    {

        Dictionary<string, string> translations = new Dictionary<string, string>();
        List<string> alphabet = new List<string>() { "", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

        public Form1()
        {
            InitializeComponent();
            lbAlphabet.DataSource = alphabet;
        }

        /// <summary>
        /// Add's a new word to dictionary
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd(object sender, EventArgs e)
        {
            var germanWord = tbGerman.Text;
            var englishWord = tbEnglish.Text;

            try
            {
                if (!string.IsNullOrEmpty(germanWord) && !string.IsNullOrEmpty(englishWord))
                {
                    translations.Add(germanWord, englishWord);
                    UpdateTranslations();
                    tbGerman.Text = null;
                    tbEnglish.Text = null;
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Dieses Wort existiert bereits!");
            }
        }

        /// <summary>
        /// Updates the output of the translations Listbox
        /// </summary>
        private void UpdateTranslations()
        {
            lbTranslation.DataSource = translations.Keys.OrderBy(x => x).ToList();
        }

        private void lbTranslation_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedWord = lbTranslation.SelectedItem as string;

            if (!string.IsNullOrEmpty(selectedWord) && translations.ContainsKey(selectedWord))
            {
                tbEnglisch.Text = translations[selectedWord];
            }
        }

        /// <summary>
        /// Exports the dictionary to a CSV 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExport_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllLines(Properties.Resources.FilePath, translations.Select(d => $"{d.Key};{d.Value};"));
        }

        /// <summary>
        /// Imports the dictionary from a CSV:  German;English
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                translations.Clear();
                System.IO.File.ReadAllLines(
                   Properties.Resources.FilePath)
                    .Select(c => new { German = c.Split(';')[0], English = c.Split(';')[1] })
                    .ToList()
                    .ForEach(x =>
                        translations.Add(x.German, x.English));

                UpdateTranslations();

            }
            catch (System.IO.FileNotFoundException ex)
            {
                Console.WriteLine(ex);
            }
        }


        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            lbTranslation.DataSource = translations.Where(x => x.Key.Contains(tbSearch.Text)).Select(x => x.Key).ToList();
        }

        private void lbAlphabet_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var selectetLetter = lbAlphabet.SelectedItem as string;
            if (selectetLetter != "")
            {
                lbTranslation.DataSource = translations.Where(x => x.Key.StartsWith(selectetLetter)).Select(x => x.Key).ToList();
            } else if (selectetLetter == "")
            {
                UpdateTranslations();
            }
        }
    }
}
