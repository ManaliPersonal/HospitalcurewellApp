using curewellApp.Database;
using curewellApp.Models;

namespace curewellApp.Services
{
    public interface ISurgeryService
    {
             
        Task<List<Surgery>> GetAllSurgeyTypeForToday();       

        Task<Surgery> AddSurgey(Surgery surgery);

        Task<Surgery> EditSurgey(Surgery surgery);
        

    }
}