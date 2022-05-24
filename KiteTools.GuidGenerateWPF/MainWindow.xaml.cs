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

namespace KiteTools.GuidGenerateWPF
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

        private void generate_Click(object sender, RoutedEventArgs e)
        {
            if (onlyGuid.IsChecked.GetValueOrDefault())
            {
                generateValue.Text = Guid.NewGuid().ToString();
            }else if(idGuid.IsChecked.GetValueOrDefault()){
                generateValue.Text= $"ID = new Guid(\"{ Guid.NewGuid()}\")," ;
            }
            else if (newGuid.IsChecked.GetValueOrDefault())
            {
                generateValue.Text = $"new Guid(\"{ Guid.NewGuid()}\")";
            }


            Clipboard.SetDataObject(generateValue.Text);
        }
    }
}
