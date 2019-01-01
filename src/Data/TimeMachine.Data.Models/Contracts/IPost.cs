namespace TimeMachine.Data.Models.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface IPost
    {
        DateTime CreatedOn { get; }

        IList<Tag> Tags { get; set; }
    }
}
