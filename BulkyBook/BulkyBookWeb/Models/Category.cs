using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyBookWeb.Models
{
    public class Category
    {
        [Required]
        [DisplayName("Weight (in KG)")]
        public double WeightInKg { get; set; }
        [Required]
        [DisplayName("Height (in CM)")]
        public double HeightInCm { get; set; }
        public string BMI { get; set; } = string.Empty;
    }
}
