using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
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
using System.Xaml;

namespace colorСustomization
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<colorAdd> ColorsCollection;
        public MainWindow()
        {
            InitializeComponent();
            ColorsCollection = new ObservableCollection<colorAdd>();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            ColorsCollection.Add(new colorAdd() { hexColorName = labelFinishColor.Background.ToString()});
            List.DataContext = ColorsCollection;
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            Button cmd = (Button)sender;
            if (cmd.DataContext is colorAdd)
            {

                colorAdd deleteme = (colorAdd)cmd.DataContext;
                ColorsCollection.Remove(deleteme);

            }
        }
    }
}
