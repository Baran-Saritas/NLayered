using Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Book : BaseEntity
    {
        public string book_name { get; set; }
        public bool alinma_bilgisi { get; set; }


    }
}
