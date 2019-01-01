namespace TimeMachine.Data.Models
{
    using System;
    using System.Collections.Generic;
    using TimeMachine.Data.Models.Contracts;
    using TimeMachine.Data.Models.Posts;
    using TimeMachine.Web.Areas.Identity.Data;

    public class ReaderProfile : BaseModel<int>, IPersonProfile, IReaderProfile
    {
        public ReaderProfile()
        {
            this.Posts = new List<Post>();
        }

        public DateTime CreateProfileOn { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName => $"{this.FirstName} {this.LastName}";

        public DateTime BirthdayDate { get; set; }

        public int Age => DateTime.Now.Year - this.BirthdayDate.Year;

        public IList<Post> Posts { get; set; }

        public string TimeMachineUserId { get; set; }
        public TimeMachineUser TimeMachineUser { get; set; }
    }
}
