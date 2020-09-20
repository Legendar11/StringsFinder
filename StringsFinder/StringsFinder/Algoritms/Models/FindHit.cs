namespace StringsFinder.Algoritms.Models
{
    /// <summary>
    /// Информация о нахождении вхождения слова в файл.
    /// </summary>
    public class FindHit
    {
        /// <summary>
        /// Путь до файла.
        /// </summary>
        public string FilePath { get; set; }

        /// <summary>
        /// Индекс файла во входном массиве.
        /// </summary>
        public int IndexFileInInputArray { get; set; }

        /// <summary>
        /// Слово, вхождение для которого было найдено.
        /// </summary>
        public string Word { get; set; }

        /// <summary>
        /// Индекс слова во входном массиве.
        /// </summary>
        public int IndexWordInInputArray { get; set; }
    }
}
