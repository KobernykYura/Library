using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Books
{
    /// <summary>
    /// Abstract class for books. Parent class for book classes.
    /// </summary>
    /// <typeparam name="T">Abstract type.</typeparam>
    abstract public class AbstractBook<T> : ID
    {
        /// <summary>
        /// Book raiting list.
        /// </summary>
        List<BookRating> rating;

        enum BookRating
        {
            zerostar,
            onestar,
            twostar,
            threestar,
            fourstar,
            fivestar,
            expra = 10
        }
        /// <summary>
        /// Book name.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Book author name.
        /// </summary>
        public string AuthorName { get; set; }
        /// <summary>
        /// Price of book.
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// Type of book.
        /// </summary>
        public BookType BookType { get; set; }
    }
}
