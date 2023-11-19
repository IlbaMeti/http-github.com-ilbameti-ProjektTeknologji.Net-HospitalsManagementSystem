using HospitalManagementSystem.Data.DTOs;
using HospitalManagementSystem.Data.Models;
using HospitalManagementSystem.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {

        //Marrim Doktoret nga DB
        [HttpGet("doctor")]
        public IActionResult GetAllDoctor()
        {
            var doctorList = FakeDb.DoctorDb.ToList();

            return Ok(doctorList);
        }

        [HttpGet("doctor/{id}")]
        public IActionResult GetDoctorById(int id)
        {
            var DoctorDb = FakeDb.DoctorDb.FirstOrDefault(x => x.Id == id);

            if (DoctorDb == null)
            {
                return NotFound(new { message = $"Doctor with id = {id} not found" });
            }
            else return Ok(DoctorDb);

        }

        [HttpDelete("doctor/{id}")]
        public IActionResult DeleteDoctorById(int id)
        {
            var DoctorDb = FakeDb.DoctorDb.FirstOrDefault(x => x.Id == id);
            if (DoctorDb == null)
            {
                return NotFound(new { message = $"Doctor with id = {id} not found" });
            }
            else FakeDb.DoctorDb.Remove(DoctorDb);

            return Ok(new { message = $"Doctor with id = {id} was removed" });
        }

        [HttpPost("doctor")]
        public IActionResult PostDoctor([FromBody] DoctorDTO payload)
        {
            //1. Krijohet objekti
            var newDoctor = new Doctor()
            {
                //Gjeneron Id per new Doctor 10-99
                Id = new Random().Next(10, 100),
                Name = payload.Name,
                Surname = payload.Surname,
                Role = payload.Role,
                Specialilst = payload.Specialilst,
                Department = payload.Department,
            };

            //2. Shtohet objekti ne DB
            FakeDb.DoctorDb.Add(newDoctor);

            //3. Kthehet pergjigja
            return Ok(new { message = "New Doctor added" });
        }

        [HttpPut("doctor/{id}")]
        public IActionResult UpdateDoctorById(int id, [FromBody] DoctorDTO payload)
        {
            var DoctorDb = FakeDb.DoctorDb.FirstOrDefault(x => x.Id == id);

            if (DoctorDb == null)
            {
                return NotFound(new { message = $"Doctor with id = {id} not found" });
            }
            else
            {
                DoctorDb.Name = payload.Name;
                DoctorDb.Surname = payload.Surname;
                DoctorDb.Role = payload.Role;
                DoctorDb.Specialilst = payload.Specialilst;
                DoctorDb.Department = payload.Department;


                return Ok(new { message = $"Doctor with id = {id} was updated" });
            }
        }
    }
}
