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
        public List<int> Distorsiones { get; set; } = [];
        public List<int> Etiquetas { get; set; } = [];
        
        [StringLength(800)]
        public string Reformacion { get; set; } = string.Empty;
        
        public DateTime Fecha { get; set; } = DateTime.Now;
        public DateTime FechaModificacion { get; set; } = DateTime.Now;
        public DateTime FechaReformacion { get; set; } = DateTime.Now;
        
        [ForeignKey(("Distorsiones"))]
        public List<DistorsionCognitiva> DistorsionesCognitivas { get; set; } = [];
        
        [ForeignKey(("Etiquetas"))]
        public List<Etiqueta> EtiquetasPensamiento { get; set; } = [];
    }
}