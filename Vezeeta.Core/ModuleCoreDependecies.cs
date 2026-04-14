using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Vezeeta.Core.Behaviours;

namespace Vezeeta.Core
{
    public static class ModuleCoreDependecies
    {
        public static IServiceCollection AddCoreDependecy(this IServiceCollection services)
        {
            //mediatR
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));



            //Fluent Validation
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
