using System.Windows;

namespace WpfLibrary
{
    public class Func
    {
        static public void OnWindow_Closing_Confirm(ref System.ComponentModel.CancelEventArgs e)
        {
            var messageBoxResult = MessageBox.Show("Are you sure to exit?", "Exit?", MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes) return;

            e.Cancel = true;
        }
    }
}
