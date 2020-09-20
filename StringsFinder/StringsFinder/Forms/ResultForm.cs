using StringsFinder.Algoritms;
using StringsFinder.Algoritms.Interfaces;
using StringsFinder.Algoritms.Models;
using System;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringsFinder
{
    public partial class ResultForm : Form
    {
        // TODO: использовать DI-контейнер.
        private IFinderInFiles finder = new AhoCorasickFinder();

        private InfoAboutSearch info;

        public ResultForm(InfoAboutSearch infoAboutSearch)
        {
            InitializeComponent();

            info = infoAboutSearch;
        }

        private void FillInputTablesByDefault()
        {
            dtgResult.Rows.Clear();
            foreach (var word in info.Words)
            {
                dtgResult.Rows.Add(word, 0);
            }

            treeView1.Nodes.AddRange(info.FilePaths.Select(x =>
            {
                var treeNode = new TreeNode(x);
                treeNode.Nodes.AddRange(info.Words
                    .Select(xx => new TreeNode($"{xx} : 0"))
                    .ToArray());
                return treeNode;
            })
            .ToArray());
        }
        
        private CancellationTokenSource cancelTokenSource;

        private void HandleHit(FindHit hit)
        {
            Action updateAction = new Action(() =>
            {
                #region Обновление данных в общем списке слов
                const int indexCellWithValue = 1;
                var curValue = (int)dtgResult.Rows[hit.IndexWordInInputArray].Cells[indexCellWithValue].Value;
                dtgResult.Rows[hit.IndexWordInInputArray].Cells[indexCellWithValue].Value = curValue + 1;
                #endregion

                #region Обновление данных в списке по файлам
                var curText = treeView1.Nodes[hit.IndexFileInInputArray].Nodes[hit.IndexWordInInputArray].Text;
                var splitted = curText.Split(':');
                var curNameInText = splitted[0].Trim();
                var curValueInText = int.Parse(splitted[1].Trim());
                treeView1.Nodes[hit.IndexFileInInputArray].Nodes[hit.IndexWordInInputArray].Text = $"{curNameInText} : {curValueInText + 1}";
                #endregion
            });

            if (cancelTokenSource.IsCancellationRequested)
                return;

            try
            {
                if (InvokeRequired)
                    Invoke(new Action(() =>
                    {
                        updateAction();
                    }));
                else
                    updateAction();
            }
            catch
            {

            }
        }

        private async void ShowResultForm_Load(object sender, EventArgs e)
        {
            try
            {
                FillInputTablesByDefault();

                cancelTokenSource = new CancellationTokenSource();
                await Task.Run(() =>
                {
                    finder.FindWordsInFiles(info, hit =>
                    {
                        HandleHit(hit);
                    });
                },
                cancelTokenSource.Token)
                .ContinueWith(x =>
                {
                    if (!cancelTokenSource.Token.IsCancellationRequested)
                    {
                        MessageBox.Show("Поиск успешно завершен");
                    }
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Во время расчета результатов произошла непридвиденная ошибка. Текст ошибки: {ex.Message}");
            }
        }

        private void ResultForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            cancelTokenSource.Cancel();
        }
    }
}
