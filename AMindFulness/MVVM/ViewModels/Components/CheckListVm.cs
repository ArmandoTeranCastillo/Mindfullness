using System.Collections.ObjectModel;

namespace AMindFulness.MVVM.ViewModels.Components
{
    public class CheckListVm
    {
        public ObservableCollection<CheckListItem> ItemsSource { get; set; }

        public CheckListVm()
        {
            // Inicializa la colección con algunos elementos de ejemplo
            ItemsSource =
            [
                new CheckListItem { Name = "Item 1", IsSelected = false },
                new CheckListItem { Name = "Item 2", IsSelected = true },
                new CheckListItem { Name = "Item 3", IsSelected = false }
            ];
        }
    }

    public class CheckListItem
    {
        public string Name { get; set; } = string.Empty;
        public bool IsSelected { get; set; }
    }
}
