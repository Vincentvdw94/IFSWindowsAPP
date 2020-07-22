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
            services.AddScoped(typeof(IRepository<Beverage>), typeof(Repository<Beverage>));
            services.AddScoped(typeof(IRepository<Seat>), typeof(Repository<Seat>));
            services.AddScoped(typeof(IRepository<Passenger>), typeof(Repository<Passenger>));
            services.AddScoped(typeof(IRepository<Audio>), typeof(Repository<Audio>));
            services.AddScoped(typeof(IRepository<Video>), typeof(Repository<Video>));

        }

    }
    }
