using Microsoft.EntityFrameworkCore;

namespace 单向导航属性
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //User u1 = new User { Name = "杨中科" };
            //Leave leave = new Leave
            //{
            //    Requester = u1,
            //    From = new DateTime(2021, 8, 9),
            //    To = new DateTime(2021, 8, 9),
            //    Remarks = "家里装修,回家处理",
            //    Status = 0
            //};

            //using (TestDbContext ctx = new TestDbContext())
            //{
            //    ctx.Users.Add(u1);
            //    ctx.Leaves.Add(leave);
            //    await ctx.SaveChangesAsync();
            //}

            using (TestDbContext ctx = new TestDbContext())
            {
                User u = await ctx.Users.SingleAsync(u => u.Name == "杨中科");

                foreach (var l in ctx.Leaves.Where(l=>l.Requester==u))
                {
                    Console.WriteLine(l.Remarks);
                }
            }
        }
    }
}
