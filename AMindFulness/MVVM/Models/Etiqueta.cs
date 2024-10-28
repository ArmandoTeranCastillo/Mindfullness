using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AMindFulness.MVVM.Models
{
    public class Etiqueta
    {
        [Key]
        public int Id { get; set; }
        
        [StringLength(300)]
        public string Name { get; set; } = string.Empty;
        
        // Relaciones Indirectas
        public ICollection<Pensamiento> Pensamientos { get; set; } = new List<Pensamiento>();
    }
}