using Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Student :BaseEntity
    {
        public string first_name { get; set; }
        public string last_name { get; set; }
        public int number { get; set; }

    }
}
