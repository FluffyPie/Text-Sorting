using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace Text_Sorting
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        string ResultedText;
        private void ProceedButton_Click(object sender, EventArgs e)
        {
            ResultedText = String.Empty;
            string[] Lines = MainTextbox.Text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            List<string> List = new List<string>();
            for (int i = 0; i < Lines.Length; i++)
            {
                if(Lines[i] != String.Empty)
                List.Add(Lines[i] + Environment.NewLine);
            }
            List.Sort();
            foreach (string str in List)
                ResultedText = ResultedText + str;
            MainTextbox.Text = ResultedText;   
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The program was made specially for Fortpit. Enjoy, bud.");
        }

        private void Clipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(ResultedText);
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog.Filter = "Show txt files (*.txt)|*.txt|Show all files (*.*)|*.*|Show Word files (*.docx)|*.docx";
                OpenFileDialog.InitialDirectory = Environment.SpecialFolder.MyDocuments.ToString();
                OpenFileDialog.FileName = String.Empty;

                if (OpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (OpenFileDialog.FileName.Contains(".docx"))
                    {
                        Word.Application WordApp = new Word.Application();
                        Object fileName = OpenFileDialog.FileName;
                        WordApp.Documents.Open(ref fileName);
                        Word.Document doc = WordApp.ActiveDocument;
                        string parText = string.Empty;
                        for (int i = 1; i < doc.Paragraphs.Count; i++)
                        {
                            parText += doc.Paragraphs[i].Range.Text + Environment.NewLine;
                        }
                        WordApp.Quit();
                        MainTextbox.Text = parText;
                    }
                    else
                        MainTextbox.Text = File.ReadAllText(OpenFileDialog.FileName);
                }
            }
            catch
            {
                MessageBox.Show("Something went wrong...");
            }
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            MainTextbox.Text = string.Empty;
        }
    }
}
