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
using System.Windows.Shapes;

namespace WpfLibrary1.RedZakaz_Bluda
{
    /// <summary>
    /// Логика взаимодействия для ClearTable.xaml
    /// </summary>
    public partial class ClearTable : Window
    {
        public ClearTable()
        {
            InitializeComponent();
        }

        private void Button_Yes(object sender, RoutedEventArgs e)
        {
            MenuZal1.tables[RedZakaz1.reserw].Order = new List<WpfLibrary1.Model.Dish>();
            MenuZal1.tables[RedZakaz1.reserw].Busy = false;
            this.Close();
        }

        private void Button_No(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
