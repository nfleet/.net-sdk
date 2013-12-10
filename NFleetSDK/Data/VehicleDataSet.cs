﻿using System.Collections.Generic;

namespace NFleet.Data
{
    public class VehicleDataSet : IResponseData, IVersioned
    {
        int IVersioned.VersionNumber { get; set; }
        public List<VehicleData> Items { get; set; }
        public List<Link> Meta { get; set; }

        public VehicleDataSet()
        {
            Items = new List<VehicleData>();
            Meta = new List<Link>();
        }
    }
}
