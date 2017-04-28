using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Library
{
    /// <summary>
    /// Абстрактный класс книг.
    /// </summary>
    public abstract class AbstractBook
    {
        enum Rating
        {
            terrible,
            onestar,
            twostars,
            threestars,
            fourstars,
            fivestars,
            extrachoice
        }
        enum CoverQuality
        {
            Leather,
            Soft,
            Hard
        }

        public int pages { get; }
        public string BookName { get; }
        public string BookAuthor { get; }
        public string PubLHouse { get; }
        public string UrlAddress { get; }
        public decimal Cost { get; }

        public abstract void Add();
        public abstract void Delete();
        public abstract void Change();

    }
}
