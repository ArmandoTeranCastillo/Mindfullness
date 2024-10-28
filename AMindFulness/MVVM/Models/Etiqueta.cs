using System.ComponentModel.DataAnnotations;

namespace AMindFulness.MVVM.Models
{
    public class Etiqueta
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}