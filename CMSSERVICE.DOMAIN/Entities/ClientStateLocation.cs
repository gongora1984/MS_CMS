namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class ClientStateLocation : Entity, IAuditableEntity
    {
        public string StateId { get; set; } = null!;
        public string? EntityName { get; set; }
        public string? DivisionName { get; set; }
        public string? WitnessName { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? City { get; set; }
        public string? Zip { get; set; }
        public string? WitnessBar { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        public string? Email { get; set; }
        public string? PaymentName { get; set; }
        public string? PaymentAdd1 { get; set; }
        public string? PaymentAdd2 { get; set; }
        public string? PaymentCity { get; set; }
        public string? PaymentState { get; set; }
        public string? PaymentZip { get; set; }
        public string? PaymentEmail { get; set; }
        public string? PaymentPhone { get; set; }
        public string? PaymentFax { get; set; }
        public int ClientId { get; set; }

        public virtual Client Client { get; set; } = null!;
    }
}
