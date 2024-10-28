using AMindFulness.MVVM.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AMindFulness.Data.Seeds
{
    public class DistorsionCognitivaSeed : IEntityTypeConfiguration<DistorsionCognitiva>
    {
        public void Configure(EntityTypeBuilder<DistorsionCognitiva> builder)
        {
            builder.HasData(
                new DistorsionCognitiva { Id = 1, Name = "Filtraje" },
                new DistorsionCognitiva { Id = 2, Name = "Polarización" },
                new DistorsionCognitiva { Id = 3, Name = "Sobregeneralización" },
                new DistorsionCognitiva { Id = 4, Name = "Desestimar lo Positivo" },
                new DistorsionCognitiva { Id = 5, Name = "Catastrofismo" },
                new DistorsionCognitiva { Id = 6, Name = "Personalización" },
                new DistorsionCognitiva { Id = 7, Name = "Falacia de Control" },
                new DistorsionCognitiva { Id = 8, Name = "Falacia de la Justicia" },
                new DistorsionCognitiva { Id = 9, Name = "Falacia del Cambio" },
                new DistorsionCognitiva { Id = 10, Name = "Culpa" },
                new DistorsionCognitiva { Id = 11, Name = "Deberías" },
                new DistorsionCognitiva { Id = 12, Name = "Razonamiento Emocional" },
                new DistorsionCognitiva { Id = 13, Name = "Etiquetado Global" },
                new DistorsionCognitiva { Id = 14, Name = "Siempre tener la razón" },
                new DistorsionCognitiva { Id = 15, Name = "Precipitar Conclusiones" }
                );
        }
    }
}