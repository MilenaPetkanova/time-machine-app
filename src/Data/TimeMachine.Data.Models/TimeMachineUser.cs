namespace TimeMachine.Web.Areas.Identity.Data
{
    using System;
    using Microsoft.AspNetCore.Identity;
    using TimeMachine.Data.Models.UserProfile;

    public class TimeMachineUser : IdentityUser
    {
        public string FullName { get; set; }

        public string CreatorFullName { get; set; }

        public DateTime BirthDate { get; set; }

        public int? UserProfileId { get; set; }
        public UserProfile UserProfile { get; set; }
    }
}
