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
    public class EmployeeManagamentService
    {
        private HRDbContext ctx = new HRDbContext();

        public List<EmployeeDTO> Get(string searchEmp)
        {
            List<EmployeeDTO> employeeDtos = new List<EmployeeDTO>();
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                foreach (var item in unitOfWork.EmployeeRepository.Get(e=>e.Name.Contains(searchEmp)))
                {
                    employeeDtos.Add(new EmployeeDTO
                    {
                        Id = item.Id,
                        Name = item.Name,
                        Birthday = item.Birthday,
                        City = item.City,
                        PositionTitle = item.PositionTitle,
                        Department = item.Department,
                        PositionId = item.PositionId,
                        Position = new PositionDTO
                        {
                            Id = item.PositionId,
                            TypePosition = item.Position.TypePosition,
                            Name = item.Position.Name,
                            Department = item.Position.Departament
                        },
                        ContractId = item.ContractId,
                        Contract = new ContractDTO
                        {
                            Id = item.Contract.Id,
                            NameContractor = item.Contract.NameContractor,
                            TypeContract = item.Contract.TypeContract,
                            DateContract = item.Contract.DateContract,
                            Adress = item.Contract.Adress

                        }
                    });
                }
            }
            return employeeDtos;
        }

        public EmployeeDTO GetById(int id)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                Employee item = unitOfWork.EmployeeRepository.GetByID(id);

                EmployeeDTO employeeDTO = new EmployeeDTO
                {
                    Id = item.Id,
                    Name = item.Name,
                    Birthday = item.Birthday,
                    City = item.City,
                    PositionTitle = item.PositionTitle,
                    Department = item.Department,
                    PositionId = item.PositionId,
                    ContractId = item.ContractId,
                    Position = new PositionDTO
                    {
                        Id = item.PositionId,
                        TypePosition = item.Position.TypePosition,
                        Name = item.Position.Name,
                        Department = item.Position.Departament
                    },
                    Contract = new ContractDTO
                    {
                        Id = item.Contract.Id,
                        NameContractor = item.Contract.NameContractor,
                        TypeContract = item.Contract.TypeContract,
                        DateContract = item.Contract.DateContract,
                        Adress = item.Contract.Adress

                    }
                };
                return employeeDTO;
            }

        }

        public bool Update(EmployeeDTO employeeDTO)
        {
            Employee employee = new Employee
            {
              
                Id = employeeDTO.Id,
                Name = employeeDTO.Name,
                Birthday = employeeDTO.Birthday,
                City = employeeDTO.City,
                PositionTitle = employeeDTO.PositionTitle,
                Department = employeeDTO.Department,
                PositionId = employeeDTO.PositionId,
                ContractId = employeeDTO.ContractId
            };

            try
            {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    unitOfWork.EmployeeRepository.Update(employee);
                    unitOfWork.Save();
                }


                return true;
            }
            catch
            {
                return false;
            }
        }


        public bool Save(EmployeeDTO employeeDTO)
        {
            if (employeeDTO.Position == null || employeeDTO.Position.Id == 0 || employeeDTO.Contract == null || employeeDTO.ContractId == 0)
            {
                return false;
            }

            Employee employee = new Employee
            {
                Name = employeeDTO.Name,
                Birthday = employeeDTO.Birthday,
                City = employeeDTO.City,
                PositionTitle = employeeDTO.PositionTitle,
                Department = employeeDTO.Department,
                PositionId = employeeDTO.PositionId,
                ContractId = employeeDTO.ContractId
            };

            try
            {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    unitOfWork.EmployeeRepository.Insert(employee);
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
                    Employee employee = unitOfWork.EmployeeRepository.GetByID(id);
                    unitOfWork.EmployeeRepository.Delete(employee);
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

