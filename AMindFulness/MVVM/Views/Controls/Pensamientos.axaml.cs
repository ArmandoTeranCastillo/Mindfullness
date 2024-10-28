using AMindFulness.MVVM.ViewModels;
using AMindFulness.MVVM.ViewModels.ViewModels;
using Autofac;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AMindFulness.MVVM.Views.Controls
{
    public partial class Pensamientos : UserControl
    {
        public Pensamientos()
        {
            InitializeComponent();
            DataContext = App.Container.Resolve<PensamientosVm>();
        }
    }
}