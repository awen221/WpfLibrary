using System.Windows;

namespace WpfLibrary.UserControl.Loading
{
    public partial class LoadingPanel
    {
        public LoadingPanel()
        {
            InitializeComponent();
        }

        public bool Visable
        {
            get => Visibility == Visibility.Visible;
            set => Visibility = value ? Visibility.Visible : Visibility.Hidden;
        }
    }
}