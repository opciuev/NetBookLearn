using 第一个EFCore项目;

//插入数据
using TestDbContext ctx = new TestDbContext();
//var b1 = new Book
//{
//    AuthorName = "杨中科",
//    Title = "零基础趣学C语言",
//    Price = 59.8,
//    PubTime = new DateTime(2019, 3, 1)
//};
//var b2 = new Book
//{
//    AuthorName = "Robert Sedgewick",
//    Title = "算法(第四版)",
//    Price = 99,
//    PubTime = new DateTime(2010, 10, 1)
//};
//var b3 = new Book
//{
//    AuthorName = "吴军",
//    Title = "数学之美",
//    Price = 69,
//    PubTime = new DateTime(2020, 5, 1)
//};
//var b4 = new Book
//{
//    AuthorName = "杨中科",
//    Title = "程序员的SQL金典",
//    Price = 52,
//    PubTime = new DateTime(2008, 9, 1)
//};
//var b5 = new Book
//{
//    AuthorName = "吴军",
//    Title = "文明之光",
//    Price = 246,
//    PubTime = new DateTime(2017, 3, 1)
//};

////Books属性对应数据库中的T_Books表
////Boos属性是DbSet<Book>属性
////操作Books属性，向数据库中增加数据
////ctx.Books.Add(b1);
//ctx.Books.Add(b2);
//ctx.Books.Add(b3);
//ctx.Books.Add(b4);
//ctx.Books.Add(b5);
////修改Books属性中的数据只是修改了内存的数据
////需要调用异步方法SaveChangesAsync吧修改保存到数据库。
////同步方法SaveChanges
//await ctx.SaveChangesAsync();

////查询数据
//Console.WriteLine("所有书");
//foreach (Book book in ctx.Books)
//{
//    Console.WriteLine($"Id={book.Id},Title={book.Title},Price={book.Price}");

//}
//Console.WriteLine();
//Console.WriteLine("所有价格高于80元的书");
////DbSet实现了IEnumerable<T>接口，
////因此我们可以使用LINQ操作对DbSet
//IEnumerable<Book> books2 = ctx.Books.Where(b => b.Price > 80);
//foreach (var b in books2)
//{
//    Console.WriteLine($"Id={b.Id},Title={b.Title},Price={b.Price}");
//}

//Single、FristOrDefault查询
//Book b1 = ctx.Books.Single(b => b.Title == "零基础趣学C语言");
//Console.WriteLine($"Id={b1.Id},Title={b1.Title},Price={b1.Price}");
//Book? b2 = ctx.Books.FirstOrDefault(b => b.Id == 9);
//if (b2 == null)
//    Console.WriteLine("没有Id=9的数据");
//else
//    Console.WriteLine($"Id={b2.Id},Title={b2.Title},Price={b2.Price}");

//OrderBy 排序
//IEnumerable<Book> books = ctx.Books.OrderByDescending(b => b.Price);
//foreach (var b in books)
//{
//    Console.WriteLine($"Id={b.Id},Title={b.Title},Price={b.Price}");
//}


//GroupBy分组
//var groups = ctx.Books.GroupBy(b => b.AuthorName).Select(g => new { AuthorName = g.Key, BookCount = g.Count(), MaxPrice = g.Max(b => b.Price) });
//foreach (var g in groups)
//{
//    Console.WriteLine($"作者:{g.AuthorName},图书数量:{g.BookCount},最高价格:{g.MaxPrice}");
//}

//修改数据
//如果要对数据进行修改
//需要把要修改的数据查询出来
//对查询出来的数据进行修改
//再执行SaveChangesAsync保存修改
//var b = ctx.Books.Single(b => b.Title == "数学之美");
//Console.WriteLine(b.AuthorName);
//b.AuthorName = "Jun Wu";
//await ctx.SaveChangesAsync();
//Console.WriteLine(b.AuthorName);

//删除数据
//要数据删除
//要先把待删除的数据查询出来
//调用DbSet或DbContext的Rmove方法吧数据删除
//再执行SaveChangesAsync方法
//var b = ctx.Books.Single(b => b.Title == "数学之美");
//ctx.Remove(b);//也可以写成
////ctx.Books.Remove(b);
//await ctx.SaveChangesAsync();

Book b = new Book
{
    AuthorName = "Zack Yang",
    Title = "Zack,Cool guy!",
    Price = 9.9,
    PubTime = new DateTime(2020, 12, 30)
};
ctx.Books.Add(b);
Console.WriteLine($"保存前,Id={b.Id}");
await ctx.SaveChangesAsync();
Console.WriteLine($"保存后,Id={b.Id}");