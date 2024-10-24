using System.Windows;
using System.Windows.Input;
using Mindfulness.MVVM.ViewModels.Commands;
using Mindfulness.MVVM.Views.Controls;

namespace Mindfulness.MVVM.ViewModels
{
    public class PensamientosVm
    {
        public ICommand CreatePensamientoCommand { get; set; }
        
        public PensamientosVm()
        {
            CreatePensamientoCommand = new RelayCommand(CreatePensamiento);
        }

        private static void CreatePensamiento()
        {
            Window window = new()
            {
                Title = "Nuevo Pensamiento",
            };
            
            ModalPensamiento modalPensamiento = new();
            window.Content = modalPensamiento;
            window.ShowDialog();
        }
    }
}