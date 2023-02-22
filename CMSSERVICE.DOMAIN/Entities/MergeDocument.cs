namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class MergeDocument : Entity, IAuditableEntity
    {
        public MergeDocument()
        {
            ClientAssignmentTasks = new HashSet<ClientAssignmentTask>();
            MergeDocumentCustoms = new HashSet<MergeDocumentCustom>();
        }

        public int? JobTypeId { get; set; }
        public string? Category1 { get; set; }
        public string? Category2 { get; set; }
        public string? CommonName { get; set; }
        public string MergeDocumentName { get; set; } = null!;
        public int? DistrictId { get; set; }
        public string? State { get; set; }
        public int? ClientId { get; set; }
        public int? LawPracticeId { get; set; }
        public string? TemplateLocation { get; set; }
        public string? CodePageLocation { get; set; }
        public int OutDocumentTypeId { get; set; }
        public string OutFormat { get; set; } = null!;
        public bool MakeForEachDendant { get; set; }
        public string? BlankDataValue { get; set; }
        public string? BitNoValue { get; set; }
        public string? BitYesValue { get; set; }
        public string? MergeThesePartyTypes { get; set; }
        public bool IncludeCurrentOccupent { get; set; }

        public virtual ICollection<ClientAssignmentTask> ClientAssignmentTasks { get; set; }
        public virtual ICollection<MergeDocumentCustom> MergeDocumentCustoms { get; set; }
    }
}
