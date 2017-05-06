using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Books
{
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
    }
}
