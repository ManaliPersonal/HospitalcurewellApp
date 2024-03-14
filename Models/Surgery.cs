using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace curewellApp.Models
{
    public class Surgery
    {
        public int SurgeryId { get; set; }
        public int DoctorId { get; set; }
        public DateTime SurgeryDate { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }        
       
        public int SpecializationId { get; set; }

        public Doctor doctor{get;set;}
        public Specialization specialization{get;set;}

    }
}