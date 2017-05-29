using Common.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService.Controllers
{
    /// <summary>
    /// Controller for manipulate books in data base.
    /// </summary>
    public class BooksController : AbstractController<AbstractBook<object>>
    {
        public override List<AbstractBook<object>> GetList()
        {
            throw new NotImplementedException();
        }

        public override void Insert(AbstractBook<object> obj)
        {
            throw new NotImplementedException();
        }

        public override void Update(AbstractBook<object> obj)
        {
            throw new NotImplementedException();
        }
    }
}