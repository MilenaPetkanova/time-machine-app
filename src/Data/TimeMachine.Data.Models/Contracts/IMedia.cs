namespace TimeMachine.Data.Models.Contracts
{
    using System;

    public interface IMedia
    {
        string Url { get; set; }

        string Title { get; set; }

        string Caption { get; set; }

        DateTime UploadedOn { get; set; }

        DateTime CapturedOn { get; set; }
    }
}
