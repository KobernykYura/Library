using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryObjects.Books
{
    /// <summary>
    /// Abstract class for books.
    /// </summary>
    public abstract class AbstractBook<T>
    {
        List<T> BooksList;

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

        public object Foto { get; set; }

        public int Pages { get; set; }
        public int Year { get; set; }
        public string BookName { get; set; }
        public string BookAuthor { get; set; }
        public string PubLHouse { get; set; }
        public string Discription { get; set; }
        public string UrlAddress { get; set; }
        public decimal Cost { get; set; }

        public virtual void Add(T obj)
        {
            BooksList.Add(obj);
        }

        public virtual void Delete(T obj)
        {
            BooksList.Remove(obj);
            BooksList.TrimExcess();
        }
       
        public virtual string Preview()
        {
            return Discription;
        }

        public abstract void Change();

    }
}
