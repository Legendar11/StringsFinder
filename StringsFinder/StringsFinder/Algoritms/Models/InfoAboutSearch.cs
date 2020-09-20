using System.Collections.Generic;

namespace StringsFinder.Algoritms.Models
{
    // TODO: использовать Stream для файлов, а не коллекции строк.

    /// <summary>
    /// Информация о поиске.
    /// </summary>
    public class InfoAboutSearch
    {
        /// <summary>
        /// Слова, которые требуется найти.
        /// </summary>
        public IEnumerable<string> Words { get; set; }

        /// <summary>
        /// Путь до файлов, в которых требуется произвести поиск.
        /// </summary>
        public IEnumerable<string> FilePaths { get; set; }

        /// <summary>
        /// Учитывать ли регистр при поиске.
        /// </summary>
        public bool IgnoreCase { get; set; }
    }
}
