using CatelActiveViewModelsBug.ViewModels;
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

namespace CatelActiveViewModelsBug.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            TabItem1View view = new TabItem1View
            {
                DataContext = new TabItem1ViewModel()
            };

            TabItem tabItem = new TabItem
            {
                Header = "TabItem1ViewWithManualAttachedDataContextViewModel",
                Content = view
            };

            TabControl.Items.Add(tabItem);
        }
    }
}
