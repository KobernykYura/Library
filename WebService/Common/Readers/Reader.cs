using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Common.Readers
{
    [Table("Readers")]
    public class Reader : ID
    {
        [DisplayName("Имя читателя")]
        public string Name { get; set; }
        [DisplayName("Фамилия читателя")]
        public string SecoundName { get; set; }
        [DisplayName("Пол читателя")]
        public string Sex { get; set; }

        [NotMapped]
        public int? Mounth { get; set; }
        [NotMapped]
        public int? Day { get; set; }
        [NotMapped]
        public int? Year { get; set; }

        [DisplayName("Дата регистрации")]        
        public string RegistrationDate => $"{Day}.{Mounth}.{Year}";
        [DisplayName("ФИ")]
        [NotMapped]
        public string FullName => $"{Name} {SecoundName}";
    }
}
