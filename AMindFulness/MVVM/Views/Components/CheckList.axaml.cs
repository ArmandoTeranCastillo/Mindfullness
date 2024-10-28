using AMindFulness.MVVM.ViewModels.ViewModels.Components;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AMindFulness.MVVM.Views.Components
{
    public partial class CheckList : UserControl
    {
        public CheckList()
        {
            InitializeComponent();
            DataContext = new CheckListVm();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}