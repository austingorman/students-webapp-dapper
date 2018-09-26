using System.ComponentModel.DataAnnotations;
using Dapper;
using Microsoft.Data.Sqlite;

namespace Workforce.Models
{
    public class Instructor
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [Display(Name = "First name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last name")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Slack Handle")]
        public string SlackHandle { get; set; }
        [Required]
        public string Specialty { get; set; }
        [Required]
        [Display(Name = "Cohort Id")]
        public int CohortId { get; set; }
        [Required]
        public Cohort Cohort { get; set; }

        [Display(Name = "Instructor's Name")]
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}
