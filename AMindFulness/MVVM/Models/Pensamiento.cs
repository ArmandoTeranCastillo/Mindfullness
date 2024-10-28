using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AMindFulness.MVVM.Models
{
    public class Pensamiento
    {
        [Key]
        public int Id { get; set; }
        
        [StringLength(800)]
        public string Descripcion { get; set; } = string.Empty;
        public List<int>? Distorsiones { get; set; } = [];
        public List<int>? Etiquetas { get; set; } = [];
        
        [StringLength(800)]
        public string? Reformacion { get; set; } = string.Empty;
        
        public DateTime? Fecha { get; set; } 
        public DateTime? FechaModificacion { get; set; } 
        public DateTime? FechaReformacion { get; set; } 
        
        // Relaciones Directas
        public List<DistorsionCognitiva> DistorsionesCognitivas { get; set; } = [];
        public List<Etiqueta> EtiquetasPensamiento { get; set; } = [];
    }
}