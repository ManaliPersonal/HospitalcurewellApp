using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace curewellApp.Models
{
    public class Doctor
    {
        public int DoctorID { get; set; }

        [MaxLength(25)]
        public string DoctorName { get; set; }

        public ICollection<DoctorSpecialization> doctorSpecializations {get;set;}
        public ICollection<Surgery> surgeries{get;set;}
    }
}