using ifes.lib.domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Text;

namespace ifes.Data {
    public class ApplicationDbContext : DbContext {


        public DbSet<Food> Foods { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {
        }
    }
}

