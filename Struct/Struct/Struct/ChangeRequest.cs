using System;

namespace Struct
{
    internal class ChangeRequest : WorkItem
    {
        protected int OriginalItemID { get; set; }

        public ChangeRequest()
        {
        }

        public ChangeRequest(string title, string desc, TimeSpan jobLen, int originalID)
        {
            this.Id = GetNextId();
            this.Title = title;
            this.Description = desc;
            this.JobLength = jobLen;
            this.OriginalItemID = originalID;
        }

        public void Update(string title, TimeSpan joblen)
        {
            this.Title = title;
            this.JobLength = joblen;
        }
    }
}
