using Microsoft.EntityFrameworkCore;
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
    /// Логика взаимодействия для AddBludo.xaml
    /// </summary>
    public partial class AddBludo : Window
    {
        ApplicationContext db = new ApplicationContext();
        public AddBludo()
        {
            InitializeComponent();
            db.Database.EnsureCreated();
            db.Tables.Load();
            db.Dishes.Load();
            DataContext = db.Dishes.Local.ToObservableCollection();
            ComBox_Dish.DisplayMemberPath = "Name";
            //ComBox_Dish.ItemsSource = MenuBlud1.Dishes;
        }

        private void Button_Click_Back(object sender, RoutedEventArgs e)
        {
            RedZakaz1 redZakaz = new RedZakaz1();
            redZakaz.Show();
            this.Close();
        }

        private void Button_Click_Add(object sender, RoutedEventArgs e)
        {
            if (ComBox_Dish.SelectedItem != null)
            {
                //MenuZal1.tables[RedZakaz1.reserw].Order.Add((WpfLibrary1.Model.Dish)ComBox_Dish.SelectedItem);
                //RedZakaz1 redZakaz = new RedZakaz1();
                //redZakaz.Show();
                //WpfLibrary1.Model.Table tabs = db.Tables.Find(WpfLibrary1.RedZakaz1.reserw);
                using (ApplicationContext db = new ApplicationContext())
                {
                    WpfLibrary1.Model.Dish dish = (WpfLibrary1.Model.Dish)ComBox_Dish.SelectedItem as WpfLibrary1.Model.Dish;
                    WpfLibrary1.Model.Table table = new WpfLibrary1.Model.Table();
                    table = db.Tables.Find(6);
                    if(table.Order==null)
                    {
                        table.Order =new List<WpfLibrary1.Model.Dish>();
                        table.Order.Add(dish);
                    }
                    else
                    {
                        MainWindow1 mainWindow1= new MainWindow1();
                        mainWindow1.Show();
                        table.Order.Add(dish);
                    }
                    db.SaveChanges();
                    this.Close();
                }
            }
        }
    }
}
