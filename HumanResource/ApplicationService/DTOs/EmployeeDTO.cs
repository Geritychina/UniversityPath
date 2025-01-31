using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationService.DTOs
{
   public class EmployeeDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string City { get; set; }
        public string PositionTitle { get; set; }
        public string Department { get; set; }
        public int PositionId { get; set; }
        public virtual PositionDTO Position { get; set; }
        public int ContractId { get; set; }
        public virtual ContractDTO Contract { get; set; }
    }
}
