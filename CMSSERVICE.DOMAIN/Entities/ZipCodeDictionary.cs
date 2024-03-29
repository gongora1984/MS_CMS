﻿namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class ZipCodeDictionary : Entity, IAuditableEntity
    {
        public string? Zip { get; set; }
        public string? Type { get; set; }
        public string? PrimaryCity { get; set; }
        public string? State { get; set; }
        public string? County { get; set; }
        public string? Country { get; set; }
    }
}
