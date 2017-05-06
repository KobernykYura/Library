using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Threading.Tasks;

namespace Common.Workers
{
    class Department : ID
    {
        /// <summary>
        /// Name for department.
        /// </summary>
        [DisplayName("Название департамента")]
        public string Name { get; set; }
    }
}
