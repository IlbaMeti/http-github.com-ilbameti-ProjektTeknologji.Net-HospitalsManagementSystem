using HospitalManagementSystem.Data.DTOs;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class PatientsController : ControllerBase
{
    // Your controller actions will go here

    [HttpPost]
    public IActionResult AddPatient([FromBody] PatientsDTO patientsDTO)
    {
        // Convert DTO to Model and save to database or perform other actions
        var patient = new Patient
        {
            PatientsID = PatientsDTO.PatientsID,
            
            DateCreated = DateTime.Now,
            
            

            // Map other properties
        };

        // Add logic to save the patient to the database or perform other actions

        return Ok("Patient added successfully");
    }

    // Add other actions as needed
}
