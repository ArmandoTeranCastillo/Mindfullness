using System.Collections.Generic;
using AMindFulness.MVVM.ViewModels.ViewModels.Components;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AMindFulness.MVVM.Views.Components
{
    public partial class CheckList : UserControl
    {
        public static readonly StyledProperty<IEnumerable<CheckItem>> ItemsSourceProperty =
            AvaloniaProperty.Register<CheckList, IEnumerable<CheckItem>>(nameof(ItemsSource));
        
        public IEnumerable<CheckItem> ItemsSource
        {
            get => GetValue(ItemsSourceProperty);
            set => SetValue(ItemsSourceProperty, value);
        }

        public CheckList()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }

    // Clase para los elementos de la lista
    public class CheckItem
    {
        public string Name { get; set; }
        public bool IsSelected { get; set; }
    }
}