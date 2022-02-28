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
using WpfApp2.db;

namespace WpfApp2
{
  
    public partial class MainWindow : Window
    {
        public group363_09Entities connect = new group363_09Entities();
        public MainWindow()
        {
            InitializeComponent();
            BuilMaterials(0);
        }

        void BuilMaterials(int page)
        {
            var list = connect.Material.OrderBy(n => n.Name).ToList();       
            
        }


      /*  private TextBlock createTextBlock(string text, bool underline)
        { 
           
        }*/
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }      
    }
}
