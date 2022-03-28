using AutoMapper;
using Benzeen.Practice.Infrastructure.Contracts.DataAccess;
using Benzeen.Practice.Infrastructure.Contracts.Service;
using Benzeen.Practice.Infrastructure.DTOs.Department;
using Benzeen.Practice.Infrastructure.DTOs.Employee;
using System;
using System.Collections.Generic;
using System.Text;

namespace Benzeen.Practice.Service
{
    public class DepartmentServices : IDepartmentService
    {
        private readonly IDepartmentDataAccess _departmentDataAccess;
        private readonly IMapper _mapper;
        public  DepartmentServices(IDepartmentDataAccess departmentData , IMapper mapper)
        {
            _departmentDataAccess = departmentData;
            _mapper = mapper;
        }
        public List<DepartmentDetailResponse> GetAll()
        {
            var departmentEntity = _departmentDataAccess.GetAll();
            var departmentResponse = _mapper.Map<List<DepartmentDetailResponse>>(departmentEntity);
            return departmentResponse;
        }
        public DepartmentResponse GetAllWithCount()
        {
            var departmentEntity = _departmentDataAccess.GetAllWithCount();
            var departmentResponse = _mapper.Map<DepartmentResponse>(departmentEntity);
            return departmentResponse; 
        }
        public int Delete(int id)
        {
            return _departmentDataAccess.Delete(id);
        }
        public int AddNew(DepartmentRequest request)
        {
            return _departmentDataAccess.AddNew(request);
        }
        public int Update(DepartmentRequest request)
        {
            return _departmentDataAccess.Update(request);
        }
        public DepartmentDetailResponse GetById(int id)
        {
            var departmentEntity = _departmentDataAccess.GetById(id);
            return _mapper.Map<DepartmentDetailResponse>(departmentEntity);

        }
       
    }
}
