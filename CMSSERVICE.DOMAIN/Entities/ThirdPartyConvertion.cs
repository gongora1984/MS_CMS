namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class ThirdPartyConvertion : Entity, IAuditableEntity
    {
        public int LawPracticeId { get; set; }
        public string? ThirdPartyName { get; set; }
        public string? ConvertionTag { get; set; }
        public string? ConvertionKey { get; set; }
        public string? ConvertionValue { get; set; }
        public string? ConvertionValue2 { get; set; }
        public string? ConvertionValue3 { get; set; }
        public bool HasMultiValues { get; set; }
        public bool ContainsKey { get; set; }
        public bool CaseSensitive { get; set; }
    }
}
