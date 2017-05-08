using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Common.Books
{
    public class BookType : ID
    {
        [DisplayName("Стиль книги")]
        public string BTypeName { get; set; }
    }
}
