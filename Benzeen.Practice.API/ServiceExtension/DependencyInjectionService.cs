using Benzeen.Practice.Infrastructure.Contracts.DataAccess;
using Benzeen.Practice.Infrastructure.Contracts.Service;
using Benzeen.Practice.Service;
using Benzzeen.Practice.DataAccess;
using Microsoft.Extensions.DependencyInjection;

namespace Benzeen.Practice.API.ServiceExtension
{
    public static class DependencyInjectionService
    {
        public static IServiceCollection AddDependencyInjectionServices(this IServiceCollection services)
        {
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IEmployeeDataAccess, EmployeeDataAccess>();
            services.AddScoped<IDepartmentService, DepartmentServices>();
            services.AddScoped<IDepartmentDataAccess, DepartmentDataAccess>();
            services.AddScoped<IEmployeeAndDepartmentServies, EmployeeAndDepartmentServies>();
            services.AddScoped<IEmployeeAndDepartmentDataAccess, EmployeeAndDepartmentDataAccess>();
            return services;
        }
    }
}
