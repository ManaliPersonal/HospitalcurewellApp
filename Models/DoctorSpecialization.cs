using System.ComponentModel.DataAnnotations;

namespace curewellApp.Models
{
    public class DoctorSpecialization
    {
        
        public int DoctorId { get; set; }

        public Doctor doctor{get;set;}        
       
        public int SpecializationId { get; set; }

        public Specialization specialization{get;set;}

        public DateTime SpecilizationDate { get; set; }
    }
}