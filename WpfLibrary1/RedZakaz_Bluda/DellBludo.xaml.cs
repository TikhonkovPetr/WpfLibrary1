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
    /// Логика взаимодействия для DellBludo.xaml
    /// </summary>
    public partial class DellBludo : Window
    {
        public DellBludo()
        {
            InitializeComponent();
            for (int i = 0; i <= 1; i++)
            {
                CreateTable(i);
            }
            for (int i = 0; i < MenuZal1.tables[RedZakaz1.reserw].Order.Count(); i++)
            {
                Data_Blud_Table.Items.Add(MenuZal1.tables[RedZakaz1.reserw].Order[i]);
            }

        }
        public void CreateTable(int i)
        {
            var column = new DataGridTextColumn();
            switch (i)
            {
                case 0:
                    column.Header = "Название";
                    column.Binding = new Binding("Name");
                    Data_Blud_Table.Columns.Add(column);
                    break;
                case 1:
                    column.Header = "Стоимость";
                    column.Binding = new Binding("Cost");
                    Data_Blud_Table.Columns.Add(column);
                    break;
            }
        }

        private void Button_Click_Back(object sender, RoutedEventArgs e)
        {
            RedZakaz1 redZakaz = new RedZakaz1();
            redZakaz.Show();
            this.Close();
        }

        private void Button_Click_Dell(object sender, RoutedEventArgs e)
        {
            if (Data_Blud_Table.SelectedItem != null)
            {
                MenuZal1.tables[RedZakaz1.reserw].Order.Remove((WpfLibrary1.Model.Dish)Data_Blud_Table.SelectedItem);
                RedZakaz1 redZakaz = new RedZakaz1();
                redZakaz.Show();
                this.Close();
            }
        }
    }
}
