using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Books
{
    abstract public class AbstractBook<T> : ID
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

        public string Name { get; set; }
        public string AuthorName { get; set; }
        public decimal Price { get; set; }
        public BookType BookType { get; set; }
    }
}
