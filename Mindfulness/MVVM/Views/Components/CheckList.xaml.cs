using System.Collections.ObjectModel;
using System.Windows;

namespace Mindfulness.MVVM.Views.Components
{
    public partial class CheckList 
    {
        public ObservableCollection<CheckListItem> Items
        {
            get => (ObservableCollection<CheckListItem>)GetValue(ItemsProperty);
            set => SetValue(ItemsProperty, value);
        }

        // Usamos DependencyProperty para poder enlazar esta propiedad desde fuera
        public static readonly DependencyProperty ItemsProperty =
            DependencyProperty.Register(nameof(Items), typeof(ObservableCollection<CheckListItem>), typeof(CheckList), new PropertyMetadata(new ObservableCollection<CheckListItem>()));

        public CheckList()
        {
            InitializeComponent();
        }
    }

    public class CheckListItem
    {
        public string Name { get; set; }
        public bool IsChecked { get; set; }
    }
}