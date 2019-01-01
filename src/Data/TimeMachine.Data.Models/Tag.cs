namespace TimeMachine.Data.Models
{
    using TimeMachine.Data.Models.Contracts;
    using TimeMachine.Data.Models.Posts;

    public class Tag : BaseModel<int>, ITag
    {
        public string Name { get; set; }

        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}
