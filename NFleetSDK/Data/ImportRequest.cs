﻿namespace NFleet.Data
{
    public class ImportRequest
    {
        public VehicleSetImportRequest Vehicles { get; set; }
        public TaskSetImportRequest Tasks { get; set; }
        public ImportDepotSetRequest Depots { get; set; }
        public RoadSetImportRequest Roads { get; set; }
        public MapImportRequest Map { get; set; }
        public ModificationSetImportRequest Modifications { get; set; }
        public ModificationAreaSetImportRequest ModificationAreas { get; set; }
    }
}