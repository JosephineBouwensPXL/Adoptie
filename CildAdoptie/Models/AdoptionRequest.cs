using Microsoft.AspNetCore.Mvc;

namespace CildAdoptie.Models
{
    public class AdoptionRequest
    {
        public Guid Id { get; set; }
        public string ApplicantName { get; set; }
        public string ContactInfo { get; set; }
        public Guid ChildId { get; set; }
    }
}
