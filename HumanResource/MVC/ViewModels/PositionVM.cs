using ApplicationService.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.ViewModels
{
    public class PositionVM
    {
        public int Id { get; set; }
        
        public string TypePosition { get; set; }
        [Required]
        public string Name { get; set; }
        public string Departament { get; set; }

        public PositionVM(){}

        public PositionVM(PositionDTO positionDTO)
        {
            Id = positionDTO.Id;
            TypePosition = positionDTO.TypePosition;
            Name = positionDTO.Name;
            Departament = positionDTO.Name;
        }
    }
}