using System;

namespace Struct
{
    internal class WorkItem
    {
        private static int currentId;

        protected int Id { get; set; }
        protected string Title { get; set; }
        protected string Description { get; set; }
        protected TimeSpan JobLength { get; set; }

        public WorkItem()
        {
            this.Id = 0;
            this.Title = "El chupa cabras";
            this.Description = "Se come las cabras";
            this.JobLength = new TimeSpan();
        }

        public WorkItem(string title, string desc, TimeSpan jobLen)
        {
            this.Id = GetNextId();
            this.Title = title;
            this.Description = desc;
            this.JobLength = jobLen;
        }

        static WorkItem()
        {
            currentId = 0;
        }

        protected int GetNextId()
        {
            return currentId++;
        }

        public override string ToString()
        {
            return string.Format("{0}-{1}", this.Id, this.Title);
        }
    }
}
