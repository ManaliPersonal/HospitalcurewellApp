using curewellApp.Database;
using curewellApp.Models;
using Microsoft.EntityFrameworkCore;

namespace curewellApp.Repository
{
    public class SurgeryRepository: ISurgeryRepository
    {
        private readonly CureWellDbContext context;

        public SurgeryRepository(CureWellDbContext _context)
        {
            context=_context;
        }

        public async Task<Surgery> AddSurgey(Surgery surgery)
        {
            var result = context.Surgeries.Add(surgery);
            await context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Surgery> EditSurgey(Surgery surgery)
        {
            context.Update(surgery);
            await context.SaveChangesAsync();
            return surgery;
        }

     

        public async Task<List<Surgery>> GetAllSurgeyTypeForToday()
        {
            return await context.Surgeries
                            .Where(x=>x.SurgeryDate.Date == DateTime.Today.Date)
                            .ToListAsync();
        }

            


    }
    
}
