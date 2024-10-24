using System.Windows.Controls;
using Mindfulness.MVVM.ViewModels;

namespace Mindfulness.MVVM.Views.Controls
{
    public partial class Pensamientos : UserControl
    {
        public Pensamientos()
        {
            InitializeComponent();
            PensamientosVm vm = new();
            DataContext = vm;
        }
    }
}