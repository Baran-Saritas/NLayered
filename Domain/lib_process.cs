using Core.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain 
{
    class lib_process : BaseEntity
    {
        [ForeignKey("Student")]
        [Required]
        public Guid StudentId { get; set; }
        public virtual Student student { get; set; }

        [ForeignKey("Book")]
        [Required]
        public Guid BookId { get; set; }
        public virtual Book book { get; set; }

        [Required]
        public string BookName { get; set; }
        [Required]
        public string Process { get; set; }




    }
}
