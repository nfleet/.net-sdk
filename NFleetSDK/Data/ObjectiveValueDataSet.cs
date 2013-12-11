﻿using System.Collections.Generic;

namespace NFleet.Data
{
    public class ObjectiveValueDataSet : IResponseData, IVersioned
    {
        int IVersioned.VersionNumber { get; set; }
        public List<ObjectiveValueData> Items { get; set; }
        public List<Link> Meta { get; set; }

        public ObjectiveValueDataSet()
        {
            Items = new List<ObjectiveValueData>();
            Meta = new List<Link>();
        }
    }
}
