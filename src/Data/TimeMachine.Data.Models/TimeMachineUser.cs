namespace TimeMachine.Web.Areas.Identity.Data
{
    using System;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Identity;
    using TimeMachine.Data.Models.UserProfile;

    public class TimeMachineUser : IdentityUser
    {
        public TimeMachineUser()
        {
            this.Stories = new List<Story>();
            this.Photos = new List<Photo>();
            this.Letters = new List<Letter>();
        }

        public bool IsProfilePrivate { get; set; }

        public string FullName { get; set; }

        public string CreatorFullName { get; set; }

        public DateTime BirthDate { get; set; }

        public IList<Story> Stories { get; set; }

        public IList<Photo> Photos { get; set; }

        public IList<Letter> Letters { get; set; }
    }
}
