using System.ComponentModel.DataAnnotations;

namespace MetricSystem.Models
{
    public class MetricConv
    {
        [Required(ErrorMessage = "Fahrenheit Value is required.")]
        
        public double? FValue { get; set; }

        

        public double? TempConv()
        {
            return (FValue - 32) * (5.0/9.0);
        }
    }
}