namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class ClientAssignmentTaskCheckListCr : Entity, IAuditableEntity
    {
        public ClientAssignmentTaskCheckListCr()
        {
            ClientAssignmentCheckListCrs = new HashSet<ClientAssignmentCheckListCr>();
        }

        public string? ConditionName { get; set; }
        public string? SelectValueSql { get; set; }
        public bool? IsSql { get; set; }
        public bool IsTextBox { get; set; }
        public bool IsDropDown { get; set; }
        public string? DropDownSql { get; set; }
        public string CompareType { get; set; } = null!;

        public virtual ICollection<ClientAssignmentCheckListCr> ClientAssignmentCheckListCrs { get; set; }
    }
}
