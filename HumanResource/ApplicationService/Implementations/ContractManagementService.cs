using ApplicationService.DTOs;
using Data.Context;
using Data.Entities;
using Repository.Implementations;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationService.Implementations
{
    public class ContractManagementService
    {
        private HRDbContext ctx = new HRDbContext();
        
        public List<ContractDTO> Get(string searchContr)
        {
            List<ContractDTO> contractDTOs = new List<ContractDTO>();
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                foreach (var item in unitOfWork.ContractRepository.Get(c=>c.TypeContract.Contains(searchContr)))
                {
                    contractDTOs.Add(new ContractDTO
                    {
                        Id = item.Id,
                        NameContractor = item.NameContractor,
                        TypeContract = item.TypeContract,
                        DateContract = item.DateContract,
                        Adress = item.Adress
                    });

                }
            }
            return contractDTOs;
        }

        public ContractDTO GetById(int id)
        {
            ContractDTO contractDTO = new ContractDTO();
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                Contract contract = unitOfWork.ContractRepository.GetByID(id);
                if (contract != null)
                {
                    contractDTO.Id = contractDTO.Id;
                    contractDTO.NameContractor = contractDTO.NameContractor;
                    contractDTO.TypeContract = contractDTO.TypeContract;
                    contractDTO.DateContract = contractDTO.DateContract;
                    contractDTO.Adress = contractDTO.Adress;

                }
            }
            return contractDTO;
        }

        public bool Update(ContractDTO contractDTO)
        {
            Contract contract = new Contract
            {
                Id = contractDTO.Id,
                NameContractor = contractDTO.NameContractor,
                TypeContract = contractDTO.TypeContract,
                DateContract = contractDTO.DateContract,
                Adress = contractDTO.Adress
            };

            try
            {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    unitOfWork.ContractRepository.Update(contract);
                    unitOfWork.Save();
                }

                return true;
            }
            catch
            {
                return false;
            }
        }


        public bool Save(ContractDTO contractDto) 
        {
            Contract contract = new Contract
            {
                NameContractor = contractDto.NameContractor,
                TypeContract = contractDto.TypeContract,
                DateContract = contractDto.DateContract,
                Adress = contractDto.Adress
            };

            try
            {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    unitOfWork.ContractRepository.Insert(contract);
                    unitOfWork.Save();
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    Contract contract = unitOfWork.ContractRepository.GetByID(id);
                    unitOfWork.ContractRepository.Delete(contract);
                    unitOfWork.Save();
                }

                return true;

            }
            catch
            {
                return false;

            }
        }
    }
}
