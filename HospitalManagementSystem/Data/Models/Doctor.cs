using HospitalManagementSystem.Data.Base;

namespace HospitalManagementSystem.Data.Models
{

    public class Doctor : EntityBase
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Role { get; set; }
        public string Specialilst { get; set; }
        public string Department { get; set; }
    }

}
