using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Workers
{
    class Worker : ID
    {
        public string Name { get; set; }
        public string Sex { get; set; }
        public decimal Salary { get; set; }
        public Department DepartmentID;
    }
}
