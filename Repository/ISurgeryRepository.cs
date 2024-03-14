using curewellApp.Database;
using curewellApp.Models;

namespace curewellApp.Repository
{
    public interface ISurgeryRepository
    {              
        
        Task<List<Surgery>> GetAllSurgeyTypeForToday();       

        Task<Surgery> AddSurgey(Surgery surgery);

        Task<Surgery> EditSurgey(Surgery surgery);

      

    }
}