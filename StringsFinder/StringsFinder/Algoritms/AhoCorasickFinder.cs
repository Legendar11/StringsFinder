using NReco.Text;
using StringsFinder.Algoritms.Interfaces;
using StringsFinder.Algoritms.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace StringsFinder.Algoritms
{
    public class AhoCorasickFinder : IFinderInFiles
    {
        public void FindWordsInFiles(InfoAboutSearch info, Action<FindHit> whenFind = null)
        {
            // индексируем входные слова
            var keywords = info.Words
                .Select((x, i) => new KeyValuePair<string, int>(x, i));
            var arrayWords = info.Words.ToArray();

            // индексируем входные файлы
            var filePathsWithIndex = info.FilePaths.Select((x, i) => (Filename: x, Index: i));

            // Алгоритм Ахо-Корасика для поиска множества подстрок в строках
            var matcher = new AhoCorasickDoubleArrayTrie<int>(keywords, info.IgnoreCase);

            // производим параллельный поиск во всех файлах
            Parallel.ForEach(filePathsWithIndex, x =>
            {
                const int maxLinesInBuffer = 1024;
                var buffer = new List<string>(maxLinesInBuffer);

                // считываем файл, используя буфер, в буфере хранится maxLinesInBuffer строк
                // TODO: уйти от алгоритма работы со строками, использовать чтение блоков байт, вынести в конфинг размер считываемого блока
                using (var stream = new StreamReader(File.Open(x.Filename, FileMode.Open, FileAccess.Read, FileShare.Read)))
                {
                    string line;
                    do
                    {
                        line = stream.ReadLine();
                        if (line != null)
                            buffer.Add(line);

                        if (line == null || buffer.Count == maxLinesInBuffer)
                        {
                            var text = string.Join(string.Empty, buffer);

                            matcher.ParseText(text, (hit) =>
                            {
                                var word = arrayWords[hit.Value];

                                whenFind(new FindHit
                                {
                                    FilePath = x.Filename,
                                    IndexFileInInputArray = x.Index,
                                    Word = word,
                                    IndexWordInInputArray = hit.Value
                                });
                                return true;
                            });
                            buffer.Clear();
                        }
                    } while (line != null);
                }
            });
        }
    }
}
