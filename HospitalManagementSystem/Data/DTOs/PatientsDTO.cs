namespace HospitalManagementSystem.Data.DTOs
{
    public class PatientsDTO
    {
        public static object PatientsID { get; internal set; }
        public string PatientsId { get; set; }

        public string PatientsName { get; set; }

        public string PatientsType { get; set; } = string.Empty;

        public string PatientsDescription { get; set; }

    }
}
