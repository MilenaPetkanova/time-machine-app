namespace TimeMachine.Data.Models.UserProfile
{
    using System.Collections.Generic;
    using TimeMachine.Data.Common;
    using TimeMachine.Web.Areas.Identity.Data;

    public class UserProfile : BaseModel<int>
    {
        public UserProfile()
        {
            this.Stories = new List<Story>();         
            this.Photos = new List<Photo>();         
            this.Letters = new List<Letter>();         
        }

        public int?  UserId { get; set; }
        public TimeMachineUser User { get; set; }

        public IList<Story> Stories { get; set; }

        public IList<Photo> Photos { get; set; }

        public IList<Letter> Letters { get; set; }
    }
}
