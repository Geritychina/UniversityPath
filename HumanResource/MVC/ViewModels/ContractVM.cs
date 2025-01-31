using ApplicationService.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.ViewModels
{
    public class ContractVM
    {
        public int Id { get; set; }
        [Required]
        public string NameContractor { get; set; }
        public string TypeContract { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateContract { get; set; }
        public string Adress { get; set; }

        public ContractVM(){}

        public ContractVM(ContractDTO contractDTO)
        {
            Id = contractDTO.Id;
            NameContractor = contractDTO.NameContractor;
            TypeContract = contractDTO.TypeContract;
            DateContract = contractDTO.DateContract;
            Adress = contractDTO.Adress;

        }
    }
}