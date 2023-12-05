using Core.Services;
using Core;
using Data;
using Services;

namespace BSSWebAPI.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureAllServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IUnitOfWork<>), typeof(UnitOfWork<>));
            services.AddTransient<IFoodService, FoodService>();
            services.AddTransient<ITableService, TableService>();
            services.AddTransient<IEmployeeService, EmployeeService>();
            services.AddTransient<IOrderService, OrderService>();
            services.AddTransient<IEmployeeTableService, EmployeeTableService>();
        }
    }
}
