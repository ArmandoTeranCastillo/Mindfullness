using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Threading.Tasks;
using AMindFulness.Data.Dependencies.Transients;
using AMindFulness.MVVM.Models.DTOs;
using AMindFulness.MVVM.Views.Components;
using AMindFulness.Views.Controls;
using ReactiveUI;

namespace AMindFulness.MVVM.ViewModels.ViewModels
{
    public class PensamientosVm : ViewModelBase
    {
        // Properties
        private IEnumerable<CheckItem> _distorsiones = new List<CheckItem>();
        public IEnumerable<CheckItem> Distorsiones
        {
            get => _distorsiones;
            set => this.RaiseAndSetIfChanged(ref _distorsiones, value);
        }
        
        // Commands
        public ReactiveCommand<Unit, Unit> LoadDataCommand { get; } 
        public ReactiveCommand<Unit, Unit> CreatePensamientoCommand { get; } 
        
        public PensamientosVm(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            LoadDataCommand = ReactiveCommand.CreateFromTask(LoadData);
            CreatePensamientoCommand = ReactiveCommand.Create(CreatePensamiento);
        }

        private static void CreatePensamiento()
        {
            MindFulnessModal modal = new();
            ModalPensamiento modalPensamiento = new();
            modal.SetContent(modalPensamiento);
            modal.Show();
        }
        
        private async Task LoadData()
        {
            IEnumerable<CatalogoDto> distorsiones = await UnitOfWork.MindfulnessRepository.GetDistorsionesAsync();
            Distorsiones = distorsiones.Select(i => new CheckItem
            {
                Name = i.Name,
                IsSelected = false
            });
        }
    }
}