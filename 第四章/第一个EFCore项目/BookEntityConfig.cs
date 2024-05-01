using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace 第一个EFCore项目
{
    //IEntityTypeConfiguration接口用于配置实体类与数据库表的映射关系。
    internal class BookEntityConfig : IEntityTypeConfiguration<Book>
    {
        //Configure方法中对实体类和数据库表的关系做详细的配置
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            //数据库中名字为T_Books的表
            builder.ToTable("T_Books");
            builder.Property(e => e.Title).HasMaxLength(50).IsRequired();
            builder.Property(e=>e.AuthorName).HasMaxLength(20).IsRequired();
            //这里没有配置的属性，EF Core会默认把属性的名字作为列名
        }
    }
}
