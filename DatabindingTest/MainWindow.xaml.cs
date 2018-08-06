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
using DatabindingTest.Classes;
using YoutubeSearch;
namespace DatabindingTest
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


        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            VideoSearch vs = new VideoSearch();

            string query = searchTextBox.Text;

            // Make the query 
            List<VideoInformation> vlist = vs.SearchQuery(query, 1);

            // Bind vlist to the listbox.
            SkinListBox.ItemsSource = vlist;
            VideoInformation v = new VideoInformation();
           
            
        }

        private void SkinListBox_MouseDoubleClick_1(object sender, MouseButtonEventArgs e)
        {
            ListBox lb = sender as ListBox;

            VideoInformation vi = lb.SelectedItem as VideoInformation;

            System.Diagnostics.Process.Start(vi.Url);
        }
    }
}
