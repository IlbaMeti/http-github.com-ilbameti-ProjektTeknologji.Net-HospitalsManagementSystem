using HospitalManagementSystem.Data.DTOs;
using HospitalManagementSystem.Data.Models;
using HospitalManagementSystem.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManagementSystem.Controllers
{
    [Route("api")]
    [ApiController]
    public class MedicalServicesController : ControllerBase
    {
        //Marrim te gjithe sherbimet mjekesore nga databaza
        [HttpGet("medicalServices")]
        public IActionResult GetAllMedicalServices()
        {
            var medicalServicesList = FakeDb.medicalServiceDb.ToList();
            return Ok(medicalServicesList);
        }

        [HttpGet("medicalServices/{id}")]
        public IActionResult GetMedicalServiceById(int id)
        {
            var medicalServiceFromDb = FakeDb.medicalServiceDb.FirstOrDefault(x => x.Id == id);

            if (medicalServiceFromDb == null)
            {
                return NotFound(new { message = $"Medical service with id = {id} not found" });
            }
            else return Ok(medicalServiceFromDb);
        }

        [HttpDelete("medicalServices/{id}")]
        public IActionResult DeleteMedicalServiceById(int id)
        {
            var medicalServiceFromDb = FakeDb.medicalServiceDb.FirstOrDefault(x => x.Id == id);

            if (medicalServiceFromDb == null)
            {
                return NotFound(new { message = $"Medical service with id = {id} not found" });
            }
            else
            {
                FakeDb.medicalServiceDb.Remove(medicalServiceFromDb);

                var latestList = FakeDb.medicalServiceDb.ToList();
                return Ok(new { message = $"MedicalService with id = {id} was removed" });
            }
        }

        [HttpPost("medicalService/{id}")]
        public IActionResult PostMedicalService([FromBody] MedicalServiceDTO payload)
        {
            //1. Krijohet objekti
            var newMedicalService = new MedicalService()
            {
                //Gjeneron Id per new medical service 10-99
                Id = new Random().Next(10, 100),

                ServiceName = payload.ServiceName,
                Description = payload.Description,
                Price = payload.Price,
                Category = payload.Category,
                Doctors = payload.Doctors,
            };

            //2. Shtohet objekti ne DB
            FakeDb.medicalServiceDb.Add(newMedicalService);

            return Ok(new { message = "PostMedicalService" });
        }

        [HttpPut("medicalService")]
        public IActionResult UpdateMedicalService([FromBody] MedicalServiceDTO newData, int id)
        {
            //1. Merr te dhenat e vjetra nga db
            var medicalSeviceFromDb = FakeDb.medicalServiceDb.FirstOrDefault(x => x.Id == id);

            if (medicalSeviceFromDb == null)
            {
                return NotFound(new { message = "Medical service could not be updated" });
            }

            //2. Perditeso te dhenat
            medicalSeviceFromDb.ServiceName = newData.ServiceName;
            medicalSeviceFromDb.Description = newData.Description;
            medicalSeviceFromDb.Price = newData.Price;
            medicalSeviceFromDb.Category = newData.Category;
            medicalSeviceFromDb.Doctors = newData.Doctors;

            //3. Ruaj te dhenat ne database

            return Ok(new { message = "Medical service updated" });

        }
    }
}
