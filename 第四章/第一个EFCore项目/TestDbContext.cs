using Microsoft.EntityFrameworkCore;

namespace 第一个EFCore项目
{
    //继承自DbContext的类叫做“上下文”
    public class TestDbContext:DbContext
    {
        //对应数据库中的T_Books表
        public DbSet<Book> Books { get; set; }

        //OnConfiguring方法用于程序要连接的数据库进行配置
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connStr = "Data Source=127.0.0.1,59157;Initial Catalog=demo;User Id=sa;Password=123456";
            optionsBuilder.UseSqlServer(connStr,options=>options.EnableRetryOnFailure(maxRetryCount:5,
                maxRetryDelay:TimeSpan.FromSeconds(30),
                errorNumbersToAdd:null));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //加载当前程序集中所有实现了IEntityTypeConfiguration接口的累
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        }
    }
}
