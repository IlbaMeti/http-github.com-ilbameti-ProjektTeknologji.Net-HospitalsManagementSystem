using HospitalManagementSystem.Data.Base;

namespace HospitalManagementSystem.Data.Models
{
    public class MedicalService:EntityBase
    {
        public string ServiceName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public List<string> Category { get; set; }
        public List<string> Doctors { get; set; }
    }
}
