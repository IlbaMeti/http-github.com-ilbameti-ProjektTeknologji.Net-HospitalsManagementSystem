using HospitalManagementSystem.Data.DTOs;
using HospitalManagementSystem.Data.Models;
using HospitalManagementSystem.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace HospitalManagementSystem.Controllers
{
    [Route("api")]
    [ApiController]
    public class HospitalsController : ControllerBase
    {
        //Marrim te gjithe spitalet nga databaza
        [HttpGet("hospitals")]
        public IActionResult GetAllHospitals()
        {
            var hospitalList = FakeDb.hospitalDb.ToList();

            return Ok(hospitalList);
        }

        [HttpGet("hospital/{id}")]
        public IActionResult GetHospitalById(int id)
        {
            var hospitalDb = FakeDb.hospitalDb.FirstOrDefault(x => x.Id == id);

            if (hospitalDb == null)
            {
                return NotFound(new { message = $"Hospital with id = {id} not found" });
            }
            else return Ok(hospitalDb);

        }

        [HttpDelete("hospital/{id}")]
        public IActionResult DeleteHospitalById(int id)
        {
            var hospitalDb = FakeDb.hospitalDb.FirstOrDefault(x => x.Id == id);
            if (hospitalDb == null)
            {
                return NotFound(new { message = $"Hospital with id = {id} not found" });
            }
            else FakeDb.hospitalDb.Remove(hospitalDb);

            return Ok(new { message = $"Hospital with id = {id} was removed" });
        }

        [HttpPost("hospital")]
        public IActionResult PostHospital([FromBody] HospitalDTO payload)
        {
            //1. Krijohet objekti
            var newHospital = new Hospital()
            {
                //Gjeneron Id per new Hospital 10-99
                Id = new Random().Next(10, 100),
                HospitalName = payload.HospitalName,
                EstablishedYear = payload.EstablishedYear,
                Address=payload.Address,
                ContactNumber=payload.ContactNumber,
                Email = payload.Email,
                Website = payload.Website
            };

            //2. Shtohet objekti ne DB
            FakeDb.hospitalDb.Add(newHospital);

            //3. Kthehet pergjigja
            return Ok(new { message = "New hospital created" });
        }

        [HttpPut("hospital/{id}")]
        public IActionResult UpdateCHospitalById(int id, [FromBody] HospitalDTO payload)
        {
            var hospitalDb = FakeDb.hospitalDb.FirstOrDefault(x => x.Id == id);

            if (hospitalDb == null)
            {
                return NotFound(new { message = $"Hospital with id = {id} not found" });
            }
            else
            {
                hospitalDb.HospitalName = payload.HospitalName;
                hospitalDb.EstablishedYear = payload.EstablishedYear;
                hospitalDb.Address = payload.Address;
                hospitalDb.ContactNumber = payload.ContactNumber;
                hospitalDb.Email = payload.Email;
                hospitalDb.Website = payload.Website;

                return Ok(new { message = $"Hospital with id = {id} was updated" });
            }
        }
    }
}
