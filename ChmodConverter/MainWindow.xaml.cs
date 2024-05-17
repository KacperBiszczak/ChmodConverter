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

        private void ButtonConvert_Click(object sender, RoutedEventArgs e)
        {
            //try
            //{
            //    TextBoxSymbolicPerm.Text = Utils.NumericToSymbolic(TextBoxNumericPerm.Text);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
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
