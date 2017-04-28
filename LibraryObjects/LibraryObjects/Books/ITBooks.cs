using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryObjects.Books
{
    class ITBooks : AbstractBook<ITBooks>
    {
        public override void Change()
        {
            throw new NotImplementedException();
        }
    }
}
