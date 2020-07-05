using Microsoft.EntityFrameworkCore;

namespace ifes.Data {
    public class IdendityDbContext<T> {
        private DbContextOptions<ApplicationDbContext> options;

        public IdendityDbContext(DbContextOptions<ApplicationDbContext> options) {
            this.options = options;
        }
    }
}