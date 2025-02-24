using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace B07ASPC09_works.Models
{
    public class DiagonosticContext:DbContext
    {
        public DiagonosticContext(DbContextOptions<DiagonosticContext>options):base(options)
        {
            
        }

        public DbSet<Patient> Patients { get; set; }
    }
   public enum Gender
    {
        Male=1,
        Female,
        Other
    }
    public class Patient
    {
        public int Id { get; set; }
        [StringLength(15)]
       
        public string Name { get; set; }
        public string Age { get; set; }
        public Gender PatientGender { get; set; }
        public string Phone { get; set; }
    }
}
