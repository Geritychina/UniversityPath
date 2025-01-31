using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationService.DTOs
{
   public class ContractDTO
    {
        public int Id { get; set; }
        
        public string NameContractor { get; set; }
        public string TypeContract { get; set; }
        public DateTime DateContract { get; set; }
        public string Adress { get; set; }
        

    }
}
