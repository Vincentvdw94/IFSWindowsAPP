using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ifes.Application {
    public static class ApplicationRegistrations {
        public static void RegisterApplication(this IServiceCollection services) {
            // services.AddAutoMapper(Assembly.GetAssembly(typeof(ApplicationRegistrations)));
            services.AddMediatR(Assembly.GetAssembly(typeof(ApplicationRegistrations)));
        }
    }
}
