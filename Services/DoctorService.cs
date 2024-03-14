using curewellApp.Database;
using curewellApp.Models;
using curewellApp.Repository;
using Microsoft.EntityFrameworkCore;

namespace curewellApp.Services
{
    public class DoctorService: IDoctorService
    {
        private readonly IDoctorRepository doctorRepository;

        public DoctorService(IDoctorRepository _doctorRepository)
        {
            doctorRepository=_doctorRepository;
        }

        public async Task<Doctor> AddDoctor(Doctor doctor)
        {           
            return await doctorRepository.AddDoctor(doctor);
        }

        public async Task<Doctor> EditDoctor(Doctor doctor)
        {            
            return  await doctorRepository.EditDoctor(doctor);
        }

        public async Task<List<Doctor>> GetAllDoctors()
        {
            return  await doctorRepository.GetAllDoctors();
        }

        public async Task<List<Specialization>> GetAllSpecilization()
        {
            return await doctorRepository.GetAllSpecilization();
        }
      

        public async Task<List<Doctor>> GetDoctorsBySpecilization(int Code)
        {
           return await doctorRepository.GetDoctorsBySpecilization(Code);
        }
    }

}
