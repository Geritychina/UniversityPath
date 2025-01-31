using ApplicationService.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.ViewModels
{
    public class EmployeeVM
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }
        public string City { get; set; }
        public string PositionTitle { get; set; }
        public string Department { get; set; }
        public int PositionId { get; set; }
        public int ContractId { get; set; }

        public PositionVM PositionVM { get; set; }
        public ContractVM ContractVM { get; set; }
        public EmployeeVM() { }

        public EmployeeVM(EmployeeDTO employeeDTO)
        {
            Id = employeeDTO.Id;
            Name = employeeDTO.Name;
            Birthday = employeeDTO.Birthday;
            City = employeeDTO.City;
            PositionTitle = employeeDTO.PositionTitle;
            PositionId = employeeDTO.PositionId;
            PositionVM = new PositionVM
            {
                Id = employeeDTO.PositionId,
                TypePosition = employeeDTO.Position.TypePosition,
                Name = employeeDTO.Position.Name,
                Departament = employeeDTO.Position.Department

            };
            ContractId = employeeDTO.ContractId;
            ContractVM = new ContractVM
            {
                Id = employeeDTO.ContractId,
                NameContractor = employeeDTO.Contract.NameContractor,
                TypeContract = employeeDTO.Contract.TypeContract,
                DateContract = employeeDTO.Contract.DateContract,
                Adress = employeeDTO.Contract.Adress
            };
        }
    }
}