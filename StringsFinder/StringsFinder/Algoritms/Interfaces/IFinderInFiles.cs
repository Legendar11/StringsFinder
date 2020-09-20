using StringsFinder.Algoritms.Models;
using System;

namespace StringsFinder.Algoritms.Interfaces
{
    /// <summary>
    /// Функционал поиска слов в файлах.
    /// </summary>
    public interface IFinderInFiles
    {
        /// <summary>
        /// Выполнить поиск.
        /// </summary>
        /// <param name="info">Входная информация</param>
        /// <param name="whenFind">Функция обратного вызова при нахождении совпадения.</param>
        void FindWordsInFiles(InfoAboutSearch info, Action<FindHit> whenFind = null);
    }
}
