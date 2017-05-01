using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Books;

namespace Common
{
    abstract public class AbstractBook<T>
    {
        List<BookRating> rating;

        enum BookRating
        {
            zerostar,
            twostar,
            threestar,
            fourstar,
            fivestar,
            expra
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public decimal Price { get; set; }
        public BookType TypeB { get; set; }
    }
}
