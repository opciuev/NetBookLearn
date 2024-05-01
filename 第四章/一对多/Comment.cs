namespace 一对多
{
    public class Comment
    {

        public int Id { get; set; } //主键

        public Article Article { get; set; } //评论属于那篇文章

        public long ArticleId { get; set; }

        public string Message { get; set; } //评论内容

    }
}
