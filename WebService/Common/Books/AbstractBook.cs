using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Common.Books
{
    /// <summary>
    /// Abstract class for books. Parent class for book classes.
    /// </summary>
    /// <typeparam name="T">Abstract type.</typeparam>
    abstract public class AbstractBook<T> : ID
    {
        //[NotMapped]
        ///// <summary>
        ///// Book raiting list.
        ///// </summary>
        //List<BookRating> rating;

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
        /// Year of book printing. 
        /// </summary>
        public int? Year { get; set; }
    }
}
