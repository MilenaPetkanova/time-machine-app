namespace TimeMachine.Services.Models.TimeMachineUsers
{
    using System;
    using System.Collections.Generic;
    using TimeMachine.Services.Models.Stories;

    public class UserProfileViewModel
    {
        public bool IsProfilePrivate { get; set; }

        public string FullName { get; set; }

        public string CreatorFullName { get; set; }

        public DateTime CreateProfileOn { get; set; }

        public DateTime BirthDate { get; set; }

        public IEnumerable<StoryViewModel> Stories { get; set; }

        //public IEnumerable<PhotoViewModel> Photos { get; set; }

        //public IEnumerable<VideoViewModel> Videos { get; set; }
    }
}
