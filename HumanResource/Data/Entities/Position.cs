using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Position : BaseEntity
    {
        public string TypePosition { get; set; }
        [Required]
        [StringLength(60)]
        public string Name { get; set; }
        public string Departament { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
