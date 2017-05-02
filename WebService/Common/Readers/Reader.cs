using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Design;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Common.Readers
{

    public class Reader : ID
    {
        public string Name { get; set; }
        public string SecoundName { get; set; }
        public string Sex { get; set; }
        public string Mounth { get; set; }
        public int Day { get; set; }
        public int Year { get; set; }
        public string RegistrationDate => $"{Day}.{Mounth}.{Year}";
        public string FullName => $"{Name} {SecoundName}";
    }
}
