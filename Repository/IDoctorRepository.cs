using curewellApp.Database;
using curewellApp.Models;

namespace curewellApp.Repository
{
    public interface IDoctorRepository
    {
        
        Task<List<Doctor>> GetAllDoctors();
        Task<List<Specialization>> GetAllSpecilization();       

        Task<Doctor> AddDoctor(Doctor doctor);

        Task<Doctor> EditDoctor(Doctor doctor);       

        Task<List<Doctor>> GetDoctorsBySpecilization(int Code);

    }
}