using curewellApp.Database;
using curewellApp.Models;
using Microsoft.EntityFrameworkCore;

namespace curewellApp.Repository
{
    public class DoctorRepository: IDoctorRepository
    {
        private readonly CureWellDbContext context;

        public DoctorRepository(CureWellDbContext _context)
        {
            context=_context;
        }

        public async Task<Doctor> AddDoctor(Doctor doctor)
        {
           var result = context.Doctors.Add(doctor);
            await context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Doctor> EditDoctor(Doctor doctor)
        {
            context.Doctors.Update(doctor);
            await context.SaveChangesAsync();
            return doctor;
        }

        public async Task<List<Doctor>> GetAllDoctors()
        {
            return await context.Doctors.ToListAsync();
        }

        public async Task<List<Specialization>> GetAllSpecilization()
        {
            return await context.Specializations.ToListAsync();
        }
       

        public async Task<List<Doctor>> GetDoctorsBySpecilization(int Code)
        {
            var result= await context.DoctorSpecializations
                                .Where(x=>x.SpecializationId==Code)
                                .Select(x=>x.doctor).ToListAsync();
            return result;
        }
    }

}
