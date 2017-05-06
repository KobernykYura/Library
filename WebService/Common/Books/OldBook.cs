using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Books
{
    public class OldBook : AbstractBook<OldBook>
    {
        /// <summary>
        /// Old design for old book.
        /// </summary>
        public string OldDesign { get; set; }
        /// <summary>
        /// Old material of book cover.
        /// </summary>
        public string OldMaterial { get; set; }
    }
}
