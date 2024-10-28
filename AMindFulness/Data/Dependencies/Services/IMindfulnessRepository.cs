using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AMindFulness.MVVM.Models;
using AMindFulness.MVVM.Models.DTOs;
using Microsoft.EntityFrameworkCore;

namespace AMindFulness.Data.Dependencies.Services
{
    public interface IMindfulnessRepository
    {
        Task<IEnumerable<CatalogoDto>> GetDistorsionesAsync();
    }
    
    public class MindfulnessRepository(Context context) : IMindfulnessRepository
    {
        public async Task<IEnumerable<CatalogoDto>> GetDistorsionesAsync()
        {
            return await context.Distorsiones
                .AsNoTracking()
                .Select(i => new CatalogoDto
                {
                    Id = i.Id,
                    Name = i.Name
                })
                .ToListAsync();
        }
    }
}