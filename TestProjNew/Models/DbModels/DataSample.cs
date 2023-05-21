using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NrcTaskWeb.Models.DbModels
{
    public class DataSample
    {
        public int Id { get; set; }
        public int Members { get; set; }
        public int Divisions { get; set; }
        public string GroupName { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string CaptinName { get; set; }
        [NotMapped]
        public bool IsFailed { get; set; }
    }
}
