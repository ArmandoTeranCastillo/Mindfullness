using System.Reactive;
using AMindFulness.MVVM.Views.Components;
using AMindFulness.Views.Controls;
using ReactiveUI;

namespace AMindFulness.MVVM.ViewModels
{
    public class PensamientosVm
    {
        public ReactiveCommand<Unit, Unit> CreatePensamientoCommand { get; }
        
        public PensamientosVm()
        {
            CreatePensamientoCommand = ReactiveCommand.Create(CreatePensamiento);
        }

        private static void CreatePensamiento()
        {
            MindFulnessModal modal = new();
            ModalPensamiento modalPensamiento = new();
            modal.SetContent(modalPensamiento);
            modal.Show();
        }
    }
}