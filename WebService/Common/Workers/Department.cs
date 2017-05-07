using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Common.Workers
{
    [Table("Departments")]
    public class Department : ID
    {
        /// <summary>
        /// Name for department.
        /// </summary>
        [DisplayName("Название департамента")]
        public string Name { get; set; }
    }
}
