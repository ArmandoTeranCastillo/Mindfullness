using AMindFulness.Data.Dependencies.Transients;
using ReactiveUI;

namespace AMindFulness.MVVM.ViewModels
{
    public class ViewModelBase(IUnitOfWork unitOfWork) : ReactiveObject
    {
        protected IUnitOfWork UnitOfWork { get; } = unitOfWork;
    }
}