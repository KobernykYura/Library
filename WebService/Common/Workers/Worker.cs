using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Common.Workers
{
    [Table("Workers")]
    public class Worker : ID
    {
        /// <summary>
        /// Worker's name.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Sex of worker.
        /// </summary>
        public string Sex { get; set; }
        /// <summary>
        /// Worker's salary.
        /// </summary>
        public decimal Salary { get; set; }
        /// <summary>
        /// Id of worker's department.
        /// </summary>
        public Department DepartmentID;
        /// <summary>
        /// Age of worker.
        /// </summary>
        public int Age;
    }
}
