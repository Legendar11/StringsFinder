using StringsFinder.Algoritms.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace StringsFinder
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region Вспомогательные функции
        private IEnumerable<string> GetTextFilesInDirectory(string directoryPath)
        {
            const string defaultPatternForFiles = "*.*";
            const string textFileExtension = ".txt";

            foreach (var file in Directory
                .EnumerateFiles(directoryPath, defaultPatternForFiles, SearchOption.TopDirectoryOnly)
                .Where(x => Path.GetExtension(x) == textFileExtension))
            {
                yield return file;
            }
        }

        private IEnumerable<string> GetWordsInFile(string filePath)
        {
            char[] delims = { '.', '!', '?', ',', ';', '(', ')', '\t', '\n', '\r', ' ' };

            using (var reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var words = line.Split(delims, StringSplitOptions.RemoveEmptyEntries);

                    foreach (var word in words)
                    {
                        yield return word;
                    }
                }
            }
        }
        #endregion

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnByDefault_Click(object sender, EventArgs e)
        {
            txtDirectoryPath.Text = Environment.CurrentDirectory;
        }

        private void btnChooseDirectory_Click(object sender, EventArgs e)
        {
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtDirectoryPath.Text = fbd.SelectedPath;
            }
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = ofd.FileName;
            }
        }

        private void btnStartFind_Click(object sender, EventArgs e)
        {
            var filePath = txtFilePath.Text;
            var directoryPath = txtDirectoryPath.Text;

            var isValidPaths = true;
            if (string.IsNullOrWhiteSpace(directoryPath))
            {
                err.SetError(txtDirectoryPath, "Необходимо задать путь до директории");
                isValidPaths = false;
            }
            if (!Directory.Exists(directoryPath))
            {
                err.SetError(txtDirectoryPath, "Данной директории не существует");
                isValidPaths = false;
            }
            if (string.IsNullOrWhiteSpace(filePath))
            {
                err.SetError(txtFilePath, "Необходимо задать путь до файла");
                isValidPaths = false;
            }
            if (!File.Exists(filePath))
            {
                err.SetError(txtFilePath, "Данного файла не существует");
                isValidPaths = false;
            }
            if (!isValidPaths)
            {
                return;
            }

            var files = new List<string>();
            var words = new List<string>();

            lsbFiles.Items.Clear();
            foreach (var file in GetTextFilesInDirectory(directoryPath))
            {
                files.Add(file);
                lsbFiles.Items.Add(file);
            }

            lsbWords.Items.Clear();
            foreach (var word in GetWordsInFile(filePath))
            {
                words.Add(word);
                lsbWords.Items.Add(word);
            }

            if (files.Count == 0)
            {
                MessageBox.Show("В заданном каталоге не обнаружены текстовые файлы с расширением txt");
                return;
            }
            if (words.Count == 0)
            {
                MessageBox.Show("В заданном файле не обнаружены слова");
                return;
            }

            var form = new ResultForm(new InfoAboutSearch
            {
                FilePaths = files,
                Words = words,
                IgnoreCase = !chkIgnoreCase.Checked
            });
            form.Show();
        }
    }
}
