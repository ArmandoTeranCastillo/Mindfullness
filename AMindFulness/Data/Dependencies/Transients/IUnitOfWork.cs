using AMindFulness.Data.Dependencies.Services;

namespace AMindFulness.Data.Dependencies.Transients
{
    public interface IUnitOfWork
    {
        IMindfulnessRepository MindfulnessRepository { get; }
    }
    
    public class UnitOfWork(IMindfulnessRepository mindfulnessRepository) : IUnitOfWork
    {
        public IMindfulnessRepository MindfulnessRepository { get; } = mindfulnessRepository;
    }
}