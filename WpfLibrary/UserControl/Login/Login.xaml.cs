namespace WpfLibrary.UserControl.Login
{
    /// <summary>
    /// Login.xaml 的互動邏輯
    /// </summary>
    public partial class Login: System.Windows.Controls.UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        public delegate void event_Button_Login_Click(object sender, System.Windows.RoutedEventArgs e);
        public event event_Button_Login_Click Event_Button_Login_Click;

        private void Button_Login_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Event_Button_Login_Click?.Invoke(sender, e);
        }

        //public string Account => TextBox_Account.Text;
        //public string Password => TextBox_Password.Text;
    }
}
