using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Threading.Tasks;

namespace Common.Books
{
    [Table("NewBooks")]
    public class NewBook : AbstractBook<NewBook>
    {
        /// <summary>
        /// New design for new book.
        /// </summary>
        public string ModernDesign { get; set; }
        /// <summary>
        /// New material for new book.
        /// </summary>
        public string ModernMaterial { get; set; }
        /// <summary>
        /// Type of book.
        /// </summary>
        public BookType BookType { get; set; }
    }
}
