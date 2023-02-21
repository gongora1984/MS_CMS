using CMSSERVICE.DOMAIN.Primitives;

namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class Bkrproperty : Entity, IAuditableEntity
    {
        public int BkrpropertyId { get; set; }
        public string? PropertyName { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Zip { get; set; }
        public string? BkycourtAddress1 { get; set; }
        public string? BkycourtAddress2 { get; set; }
        public string? BkycourtCity { get; set; }
        public string? BkycourtState { get; set; }
        public string? BkycourtZip { get; set; }
        public string? BkycourtPhone { get; set; }
        public string? BkycourtEmail { get; set; }
        public string? BkyClientPaymentAddress1 { get; set; }
        public string? BkyClientPaymentAddress2 { get; set; }
        public string? BkyClientPaymentPhone { get; set; }
        public string? BkyClientPaymentZip { get; set; }
        public string? BkyClientPaymentCity { get; set; }
        public string? BkyClientPaymentEmail { get; set; }
        public string? BkyClientPaymentState { get; set; }
        public int CaseBkrid { get; set; }

        public virtual CaseBkr CaseBkr { get; set; } = null!;
    }
}
