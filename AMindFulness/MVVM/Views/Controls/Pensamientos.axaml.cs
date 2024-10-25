using AMindFulness.MVVM.ViewModels;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AMindFulness.MVVM.Views.Controls
{
    public partial class Pensamientos : UserControl
    {
        public Pensamientos()
        {
            InitializeComponent();
            DataContext = new PensamientosVm();
        }
    }
}