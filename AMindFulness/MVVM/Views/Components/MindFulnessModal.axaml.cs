using Avalonia.Controls;

namespace AMindFulness.MVVM.Views.Components
{
    public partial class MindFulnessModal : Window
    {
        public MindFulnessModal()
        {
            InitializeComponent();
        }
        
        public void SetContent(Control content)
        {
            ModalContent.Content = content; 
        }
    }
}