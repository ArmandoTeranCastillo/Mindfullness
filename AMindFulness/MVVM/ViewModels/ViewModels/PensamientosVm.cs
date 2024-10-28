using System.Collections.Generic;
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
        private IEnumerable<CatalogoDto> _distorsiones = new List<CatalogoDto>();
        public IEnumerable<CatalogoDto> Distorsiones
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
            Distorsiones = await UnitOfWork.MindfulnessRepository.GetDistorsionesAsync();
        }
    }
}