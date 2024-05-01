using Guid主键;
using Microsoft.EntityFrameworkCore;

using TestDbContext ctx = new TestDbContext();

ctx.Database.ExecuteSqlRaw("DELETE FROM author");

Console.WriteLine("*****1******");
Author a1 = new Author { Name = "杨中科" };
Console.WriteLine($"Add前,Id={a1.Id}");
ctx.author.Add(a1);
Console.WriteLine($"Add后,保存前Id={a1.Id}");
await ctx.SaveChangesAsync();
Console.WriteLine($"保存后,Id={a1.Id}");

Console.WriteLine("*****2******");
Author a2 = new Author { Name = "Zack Yang" };
a2.Id=Guid.NewGuid();
Console.WriteLine($"保存前Id={a2.Id}");
ctx.author.Add(a2);
await ctx.SaveChangesAsync();
Console.WriteLine($"保存后,Id={a2.Id}");
