﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace Common.LoginData
{
    public class LoginData
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Login { get; set; }
        public string Password { get; set; }
    }
}