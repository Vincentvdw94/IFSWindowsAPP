using ifes.lib.domain;
using ifes.repo.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ifes.Extensions {
    public static class StartupExtensions {

        public static void RegisterRepositories(this IServiceCollection services) {

            services.AddScoped(typeof(IRepository<Food>), typeof(Repository<Food>));

        }

    }
    }
