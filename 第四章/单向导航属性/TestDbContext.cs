using Microsoft.EntityFrameworkCore;

namespace 单向导航属性
{
    internal class TestDbContext: DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Leave> Leaves { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connStr = "Data Source=127.0.0.1,59157;Initial Catalog=demo;User Id=sa;Password=123456";
            optionsBuilder.UseSqlServer(connStr, options => options.EnableRetryOnFailure(maxRetryCount: 5,
                maxRetryDelay: TimeSpan.FromSeconds(30),
                errorNumbersToAdd: null));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //加载当前程序集中所有实现了IEntityTypeConfiguration接口的累
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        }
    }
}
