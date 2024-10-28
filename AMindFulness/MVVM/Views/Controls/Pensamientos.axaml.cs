using System;
using AMindFulness.MVVM.ViewModels.ViewModels;
using Autofac;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace AMindFulness.MVVM.Views.Controls
{
    public partial class Pensamientos : UserControl
    {
        public Pensamientos()
        {
            InitializeComponent();
            DataContext = App.Container.Resolve<PensamientosVm>();
            Loaded += OnLoaded;
        }
        
        private void OnLoaded(object? sender, RoutedEventArgs e)
        {
            if (DataContext is PensamientosVm viewModel)
            {
                viewModel.LoadDataCommand.Execute().Subscribe();
            }
        }
    }
}