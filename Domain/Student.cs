using Core.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Student :BaseEntity
    {
        [Required]
        public string first_name { get; set; }
        [Required]
        public string last_name { get; set; }
        [Required]
        public string number { get; set; }
        public virtual ICollection<Lib_Processes> Lib_Processes { get; set; }

    }
}
