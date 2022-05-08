using System;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using MediatR;

namespace HR.LeaveManagement.Application
{
    public static class ApplicationServiceRegistration
    {
        public static void ConfigureApplicationServices(this IServiceCollection service)
        {
            service.AddAutoMapper(Assembly.GetExecutingAssembly());
            service.AddMediatR(Assembly.GetExecutingAssembly());
        }
    }
}
