using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryObjects.Workers
{
    /// <summary>
    /// Abstract class for workers
    /// </summary>
    class AbstractPerson<T>
    {
        List<T> Persons;

        public int ID { get; set; }

        public string Name { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public string Department { get; set; }
        public int Age { get; set; }

    }
}
