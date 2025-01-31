using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationService.DTOs
{
   public class PositionDTO
    {
        public int Id { get; set; }
        public string TypePosition { get; set; }
        
        public string Name { get; set; }

        public string Department { get; set; }
        
    }
}
