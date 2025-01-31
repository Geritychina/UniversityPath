using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
   public  class Contract : BaseEntity
    {
        [Required]
        [StringLength(60)]
        public string NameContractor { get; set; }
        public string TypeContract { get; set; }
        public DateTime DateContract { get; set; }

        public string Adress { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }

    }
}
