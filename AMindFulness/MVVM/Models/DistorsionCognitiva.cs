using System.ComponentModel.DataAnnotations;

namespace AMindFulness.MVVM.Models
{
    public class DistorsionCognitiva
    {
        [Key]
        public int Id { get; set; }
        
        [StringLength(300)]
        public string Name { get; set; } = string.Empty;
    }
}