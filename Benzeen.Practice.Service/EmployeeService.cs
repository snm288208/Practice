using AutoMapper;
using Benzeen.Practice.Infrastructure.Contracts.DataAccess;
using Benzeen.Practice.Infrastructure.Contracts.Service;
using Benzeen.Practice.Infrastructure.DTOs.Employee;
using System;
using System.Collections.Generic;

namespace Benzeen.Practice.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeDataAccess _employeeDataAccess;
        private readonly IMapper _mapper;

        public EmployeeService(IEmployeeDataAccess employeeDataAccess, IMapper mapper)
        {
            _employeeDataAccess = employeeDataAccess;
            _mapper = mapper;
        }

        public EmployeeResponse GetAllWithCount()
        {
            var employeeEntity = _employeeDataAccess.GetAllWithCount();
            
            var employeeResponse =_mapper.Map<EmployeeResponse>(employeeEntity);

            return employeeResponse;
        }
        public EmployeeDetailsResponse GetById(int id )
        {
            var employeedetailsEntity = _employeeDataAccess.GetById(id);
            var employeedetailsResponse = _mapper.Map<EmployeeDetailsResponse>(employeedetailsEntity);
            return employeedetailsResponse;

        }
        public List<EmployeeDetailsResponse> GetAll()
        {
            var employeeDetailsEntity = _employeeDataAccess.GetAll();
            var employeeDetailsResponse = _mapper.Map<List<EmployeeDetailsResponse>>(employeeDetailsEntity);

            return employeeDetailsResponse;

        }
        public int DeleteEmployee(int id)
        {
            var employee = _employeeDataAccess.DeleteEmployee(id);
            return employee;
        }
       public int AddEmployee(EmployeeRequest request)
        {
            var emoloyee = _employeeDataAccess.AddEmployee(request);
            return emoloyee;
        }
        public int UpdateEmployee(EmployeeRequest request)
        {
            return _employeeDataAccess.UpdateEmployee(request);
        }
    }
}
