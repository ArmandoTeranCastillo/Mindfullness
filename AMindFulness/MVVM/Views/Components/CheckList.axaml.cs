using System.Collections.ObjectModel;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AMindFulness.MVVM.Views.Components
{
    public partial class CheckList : UserControl
    {
        public static readonly DirectProperty<CheckList, ObservableCollection<CheckListItem>> ItemsSourceProperty =
            AvaloniaProperty.RegisterDirect<CheckList, ObservableCollection<CheckListItem>>(
                nameof(ItemsSource),
                o => o.ItemsSource,
                (o, v) => o.ItemsSource = v);

        private ObservableCollection<CheckListItem> _itemsSource;
        public ObservableCollection<CheckListItem> ItemsSource
        {
            get => _itemsSource;
            set => SetAndRaise(ItemsSourceProperty, ref _itemsSource, value);
        }

        public CheckList()
        {
            InitializeComponent();
            ItemsSource = []; 
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }

    public class CheckListItem
    {
        public string Name { get; set; }
        public bool IsSelected { get; set; }
    }
}