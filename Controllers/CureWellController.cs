using curewellApp.Models;
using curewellApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace curewellApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CureWellController : ControllerBase
    {
        private readonly IDoctorService doctorService;
        private readonly ISurgeryService surgeryService;
        public CureWellController(IDoctorService _doctorService, ISurgeryService _surgeryService)
        {
            doctorService=_doctorService;
            surgeryService=_surgeryService;
        }

        [HttpGet("GetAllDoctors")]
        public async Task<IList<Doctor>> GetAllDoctors()
        {
            var result = await doctorService.GetAllDoctors();
            return result;
        }

         [HttpGet("GetDoctorBySpecilizationCode/{id}")]
        public async Task<IList<Doctor>> GetDoctorBySpecilizationCode(int id)
        {
            var result = await doctorService.GetDoctorsBySpecilization(id);
            return result;
        }

        //ActionResult

        [HttpGet("GetAllSpecilizations")]
        
        public async Task<IList<Specialization>> GetAllSpecilizations()
        {
            var result = await doctorService.GetAllSpecilization();
            return result;
        }

        [HttpGet("GetAllSurgeryTypeForToday")]
        public async Task<IList<Surgery>> GetAllSurgeryTypeForToday()
        {
            var result = await surgeryService.GetAllSurgeyTypeForToday();
            return result;
        }

        [HttpPost("AddDoctor")]
        public async Task<IActionResult> AddDoctor( Doctor doctor)
        {
            var result = await doctorService.AddDoctor(doctor);
            return Ok(result);
        }

        [HttpPost("AddSurgery")]
        public async Task<IActionResult> AddSurgery( Surgery surgery)
        {
            var result = await surgeryService.AddSurgey(surgery);
            return Ok(result);
        }

        [HttpPut("UpdateDoctor/{id}")]
        public async Task<IActionResult> UpdateDoctor(int id, Doctor doctor)
        {
            if(id!=doctor.DoctorID)
                return BadRequest();
            var result = await doctorService.GetAllDoctors();
            var doc= result.FirstOrDefault(x=>x.DoctorID==id);
            if(doc==null)
                return NotFound();
            var response = await doctorService.EditDoctor(doctor);
            return Ok(response);
        }        

    }
}