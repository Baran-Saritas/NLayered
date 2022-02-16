using Core.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Book : BaseEntity
    {
        [Required]
        public string book_name { get; set; }
        [Required]
        public bool alinma_bilgisi { get; set; }
        public virtual ICollection<Lib_Processes> lib_Processes { get; set; }
    }
}
