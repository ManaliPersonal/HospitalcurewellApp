using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace curewellApp.Models
{
    public class Specialization
    {    
         
        public int SpecializationId { get; set; }

        [MaxLength(3)]        
        public string SpecilizationCode { get; set; }


        [MaxLength(30)]
        public string SpecilizationName { get; set; }

        public ICollection<DoctorSpecialization> doctorSpecializations{get;set;}
        public ICollection<Surgery> surgeries{get;set;}
    }
}