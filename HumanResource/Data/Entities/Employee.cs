using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Employee : BaseEntity
    {
        [Required]
        [StringLength(60)]
        public string Name { get; set; }
        public DateTime Birthday { get; set; }

        public string City { get; set; }
        public string PositionTitle { get; set; }

        public string Department { get; set; }
        public int PositionId { get; set; }
        public virtual Position Position { get; set; }

        public int ContractId { get; set; }
        public virtual Contract Contract { get; set; }
    }
}
