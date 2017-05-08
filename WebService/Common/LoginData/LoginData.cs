using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;


namespace Common.LoginData
{
    [Table("Logins")]
    public class LoginData : ID
    {
        [DisplayName("Login")]
        public string Login { get; set; }
        [DisplayName("Password")]
        public string Password { get; set; }
    }
}
