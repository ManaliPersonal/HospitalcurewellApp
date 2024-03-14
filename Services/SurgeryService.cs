using curewellApp.Database;
using curewellApp.Models;
using curewellApp.Repository;

namespace curewellApp.Services
{
    public class SurgeryService: ISurgeryService
    {
        private readonly ISurgeryRepository surgeryRepository;

        public SurgeryService(ISurgeryRepository _surgeryRepository)
        {
            surgeryRepository=_surgeryRepository;
        }

        public async Task<Surgery> AddSurgey(Surgery surgery)
        {
           return await surgeryRepository.AddSurgey(surgery);
        }

        public async Task<Surgery> EditSurgey(Surgery surgery)
        {
            return await surgeryRepository.EditSurgey(surgery);
        }
      

        public async Task<List<Surgery>> GetAllSurgeyTypeForToday()
        {
            return await surgeryRepository.GetAllSurgeyTypeForToday();
        }

      
    }
    
}
