using ApplicationService.DTOs;
using ApplicationService.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
   
    public class Service1 : IService1
    {
       

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        private EmployeeManagamentService employeeService = new EmployeeManagamentService();//Employee

        public List<EmployeeDTO> GetEmployees(string searchEmp)
        {
            return employeeService.Get(searchEmp);
        }

        public EmployeeDTO GetEmployeeByID(int id)
        {
            return employeeService.GetById(id);
        }

        private PositionManagementService positionService = new PositionManagementService();//Position
        public List<PositionDTO> GetPositions(string searchPos)
        {
            return positionService.Get(searchPos);
        }

        public PositionDTO GetPositionByID(int id)
        {
            return positionService.GetById(id);
        }

        private ContractManagementService contractService = new ContractManagementService(); //Contract
        public List<ContractDTO> GetContracts(string searchContr)
        {
            return contractService.Get(searchContr);
        }

        public ContractDTO GetContractByID(int id)
        {
            return contractService.GetById(id);
        }

        public string PostEmployee(EmployeeDTO employeeDto)
        {
            if (!employeeService.Save(employeeDto))
            {
                return "Employee is not inserted!";
            }
            else
            {
                return "Employee is inserted!";
            }
        }

        public string PostPosition(PositionDTO positionDto)
        {
            if (!positionService.Save(positionDto))
            {
                return "Position is not inserted!";
            }
            else
            {
                return "Position is  inserted!";
            }
        }
        public string PostContract(ContractDTO contractDto)
        {
            if (!contractService.Save(contractDto))
            {
                return "Contract is not inserted!";
            }
            else
            {
                return "Contract is inserted!";
            }
        }

        public string DeleteEmployee(int id)
        {
            if (!employeeService.Delete(id))
            {
                return "Emplloyee is not deleted!";
            }
            else
            {
                return "Employee is deleted!";
            }
        }

        public string DeletePosition(int id)
        {
            if (!positionService.Delete(id))
            {
                return "Position is not deleted!";
            }
            else
            {
                return "Position is deleted!";
            }
        }

        public string DeleteContract(int id)
        {
            if (!contractService.Delete(id))
            {
                return "Contract is not deleted!";
            }
            else
            {
                return "Contract is deleted!";
            }
        }

        public string PutEmployee(EmployeeDTO employeeDTO)
        {
            if (!employeeService.Update(employeeDTO))
            {
                return "Employee is not updated!";
            }
            else
            {
                return "Employee is updated!";
            }
        }

        public string PutPosition(PositionDTO positionDTO)
        {
            if (!positionService.Update(positionDTO))
            {
                return "Position is not updated!";
            }
            else
            {
                return "Position is updated!";
            }
        }

        public string PutContract(ContractDTO contractDTO)
        {
            if (!contractService.Update(contractDTO))
            {
                return "Contract is not updated!";
            }
            else
            {
                return "Contract is updated!";
            }
        }

       
    }
}
