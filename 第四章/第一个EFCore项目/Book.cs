namespace 第一个EFCore项目
{
    public class Book
    {
        public long Id { get; set; } //主键
        public string Title { get; set; } //标题

        public DateTime PubTime { get; set; } //发布时间

        public double Price { get;set; } //单价

        public string AuthorName { get; set; }
    }
}
