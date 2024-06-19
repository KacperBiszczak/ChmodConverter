using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ChmodConverter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ConvertCheckBoxes(object sender, RoutedEventArgs e)
        {
         int[] checkBoxPerms = new int[3];

            // Owner rwx 
            if (CheckBoxReadOwner.IsChecked == true)
                checkBoxPerms[0] += 4;

            if (CheckBoxWriteOwner.IsChecked == true)
                checkBoxPerms[0] += 2;

            if (CheckBoxExecuteOwner.IsChecked == true)
                checkBoxPerms[0] += 1;

            // Guest rwx
            if (CheckBoxReadGuest.IsChecked == true)
                checkBoxPerms[1] += 4;

            if (CheckBoxWriteGuest.IsChecked == true)
                checkBoxPerms[1] += 2;

            if (CheckBoxExecuteGuest.IsChecked == true)
                checkBoxPerms[1] += 1;

            // Execute rwx
            if (CheckBoxReadOther.IsChecked == true)
                checkBoxPerms[2] += 4;

            if (CheckBoxWriteOther.IsChecked == true)
                checkBoxPerms[2] += 2;

            if (CheckBoxExecuteOther.IsChecked == true)
                checkBoxPerms[2] += 1;

            // Make a permissions in numeric format
            string result = "";
            foreach (int i in checkBoxPerms)
            {
                result += i;
            }

            TextBoxNumericPerm.Text = result;
        }

        private void TextBoxNumericPerm_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if(!(ReferenceEquals(TextBoxSymbolicPerm, null)) && !(ReferenceEquals(TextBoxNumericPerm, null)))
                    TextBoxSymbolicPerm.Text = Utils.NumericToSymbolic(TextBoxNumericPerm.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
