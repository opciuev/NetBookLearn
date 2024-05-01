using Microsoft.EntityFrameworkCore;

namespace 一对多
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            //一对多关系配置
            //Article a1 = new Article
            //{
            //    Title = "微软发布.NET 6大版本的首个预览",
            //    Content = "微软昨日在一篇官网博客中宣布了.NET 6首个预览版本的到来。"
            //};

            //Comment c1 = new Comment { Message = "支持" };
            //Comment c2 = new Comment { Message = "微软太牛了" };
            //Comment c3 = new Comment { Message = "支持！" };

            //a1.Comments.Add(c1);
            //a1.Comments.Add(c2);
            //a1.Comments.Add(c3);
            //using (TestDbContext ctx = new TestDbContext()) {

            //    ctx.Articles.Add(a1);
            //    await ctx.SaveChangesAsync();
            //}


            //关联数据的获取
            //using TestDbContext ctx = new TestDbContext();
            //Article a=ctx.Articles.Include(a=>a.Comments).Single(a=>a.Id==1);
            //Console.WriteLine(a.Title);
            //foreach (Comment comment in a.Comments)
            //{
            //    Console.WriteLine(comment.Id +": "+comment.Message);
            //}

            //未使用`Include`的查询结果
            //using TestDbContext ctx = new TestDbContext();
            //Article a = ctx.Articles.Single(a => a.Id == 1);
            //Console.WriteLine(a.Title);
            //foreach (Comment c in a.Comments)
            //{
            //    Console.WriteLine(c.Id+":"+c.Message);
            //}

            //Article a1 = new Article();
            //a1.Title = "新版.NET 5正式发布，你应该了解的事情";
            //a1.Content = ".NET 5 是.NET Core 3.1 和.NET Framework 4.8 的后继产品。";
            //Comment c1 = new Comment() { Message = "已经在用了", Article = a1 };
            //Comment c2 = new Comment() { Message = "我们公司项目已经开始迁移到.NET 5了", Article = a1 };
            //using TestDbContext ctx = new TestDbContext();
            //ctx.Comments.Add(c1);
            //ctx.Comments.Add(c2);

            //await ctx.SaveChangesAsync();

            using TestDbContext ctx = new TestDbContext();
            foreach(Comment c in ctx.Comments)
            {
                Console.WriteLine($"{c.Id}:{c.Message};{c.ArticleId}");
            }

        }
    }
}