namespace TimeMachine.Data.Models.Posts
{
    using TimeMachine.Data.Models.Contracts;

    public class Story : Post, IStory
    {
        public string TextContent { get; set; }
    }
}
