﻿using System.Collections.Generic;

namespace NFleet.Data
{
    public class TaskUpdateRequest : IVersioned
    {
        public int UserId { get; set; }
        public int ProblemId { get; set; }
        public int TaskId { get; set; }
        public string Name { get; set; }
        public string Info { get; set; }
        public int VersionNumber { get; set; }
        public List<TaskEventUpdateRequest> TaskEvents { get; set; }

        public TaskUpdateRequest()
        {
            TaskEvents = new List<TaskEventUpdateRequest>();
        }
    }
}