using HospitalManagementSystem.Data.Base;

public class Patient : EntityBase
{
    public object PatientsID { get; set; }
    public object LastName { get; set; }
    public string PatientsName { get; internal set; }
    public string PatientDescription { get; internal set; }
}