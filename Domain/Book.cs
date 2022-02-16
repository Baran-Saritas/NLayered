using Core.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Book : BaseEntity
    {
        [Required]
        public string book_name { get; set; }
        [Required]
        public bool alinma_bilgisi { get; set; }

        public virtual ICollection<lib_process> lib_processes { get; set; }
    }
}
