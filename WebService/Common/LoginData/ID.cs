using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Common.LoginData
{
    public class ID
    {
        [Key]
        public int Id { get; set; }
    }
}
