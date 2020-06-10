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
        WoerterbuchLogic.WoerterbuchController controller = new WoerterbuchLogic.WoerterbuchController("C:\\Users\\daniel\\Desktop\\CodingCampus\\Spezialisierung_C#\\dictionary.csv");
        //Dictionary<string, List<string>> translations = new Dictionary<string, List<string>>();

        public Form1()
        {
            InitializeComponent();
            lbAlphabet.DataSource = controller.GetAlphabet();
            //controller.WordsDict = translations;
        }

        /// <summary>
        /// Add's a new word to dictionary
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd(object sender, EventArgs e)
        {
            var germanWord = tbGerman.Text;
            var englishWord = tbEnglishIn.Text;
            var dutchword = tbDutchIn.Text;

            try
            {
                controller.AddWords(germanWord, new List<string>() { englishWord, dutchword });
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            UpdateTranslations();
            tbGerman.Text = null;
            tbEnglishIn.Text = null;
            tbDutchIn.Text = null;
        }

        /// <summary>
        /// Updates the output of the translations Listbox
        /// </summary>
        private void UpdateTranslations()
        {
            var selectetLetter = lbAlphabet.SelectedItem as string;
            var filterString = tbSearch.Text;

            lbTranslation.DataSource = controller.FindResults(filterString, selectetLetter);

        }

        private void lbTranslation_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var selectedWord = lbTranslation.SelectedItem as string;

            if (!string.IsNullOrEmpty(selectedWord) && controller.WordsDict.ContainsKey(selectedWord))
            {
                tbEnglishOut.Text = controller.WordsDict.FirstOrDefault(x => x.Key == selectedWord).Value[0].ToString();
                tbDutchOut.Text = controller.WordsDict.FirstOrDefault(x => x.Key == selectedWord).Value[1].ToString();
            }
        }

        /// <summary>
        /// Exports the dictionary to a CSV 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExport_Click(object sender, EventArgs e)
        {
            controller.WriteToFile();
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
                controller.ReadDictionary();
                UpdateTranslations();
            }
            catch (System.IO.FileNotFoundException ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void lbAlphabet_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTranslations();
        }

        private void tbSearch_TextChanged_1(object sender, EventArgs e)
        {
            UpdateTranslations();
        }

    }
}
