using ApplicationService.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
        //Employee
        [OperationContract]
        List<EmployeeDTO> GetEmployees(string searchEmp);


        [OperationContract]
        string PostEmployee(EmployeeDTO employeeDto);

        [OperationContract]
        EmployeeDTO GetEmployeeByID(int id);

        [OperationContract]
        string PutEmployee(EmployeeDTO employeeDTO);

        [OperationContract]
        string DeleteEmployee(int id);

        //Position 
        [OperationContract]
        List<PositionDTO> GetPositions(string searchPos);

        [OperationContract]
        PositionDTO GetPositionByID(int id);

        [OperationContract]
        string PostPosition(PositionDTO positionDto);

        [OperationContract]
        string PutPosition(PositionDTO positionDTO);

        
        [OperationContract]
        string DeletePosition(int id);

        //Contract
        [OperationContract]
        List<ContractDTO> GetContracts(string searchContr);

        [OperationContract]
        ContractDTO GetContractByID(int id);

        [OperationContract]
        string PostContract(ContractDTO contractDto);

        [OperationContract]
        string PutContract(ContractDTO contractDTO);

        [OperationContract]
        string DeleteContract(int id);
    }

    
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
