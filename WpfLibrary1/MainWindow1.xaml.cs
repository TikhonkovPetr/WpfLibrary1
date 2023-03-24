using Microsoft.EntityFrameworkCore;
using Restauran_Manager_WPF;
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
using WpfLibrary1.Model;

namespace WpfLibrary1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow1.xaml
    /// </summary>
    public partial class MainWindow1 : Window
    {
        public MainWindow1()
        {
            InitializeComponent();

        }
        private void Button_Click_Menu_Zal(object sender, RoutedEventArgs e)
        {
            MenuZal1 menuZal = new MenuZal1();
            menuZal.Show();
            //this.Close();
        }

        private void Button_Click_Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
            //System.Windows.Application.Current.Shutdown();
        }

        private void Button_Click_Waiters(object sender, RoutedEventArgs e)
        {
            Waiters1 waiters = new Waiters1();
            waiters.Show();
            //this.Close();
        }

        private void Button_Click_MenuBlud(object sender, RoutedEventArgs e)
        {
            MenuBlud1 menuBlud = new MenuBlud1();
            menuBlud.Show();
            //this.Close();
        }

        private void Button_Click_Red(object sender, RoutedEventArgs e)
        {
            RedZakaz1 redZakaz = new RedZakaz1();
            redZakaz.Show();
            //this.Close();
        }
    }
    public class ApplicationContext : DbContext
    {
        public ApplicationContext()=> Database.Migrate();
        public DbSet<WpfLibrary1.Model.Dish> Dishes { get; set; } = null!;
        public DbSet<WpfLibrary1.Model.Table> Tables { get; set; } = null!;
        public DbSet<WpfLibrary1.Model.Waiter> Waiters { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=MainDB.db");
        }
    }
}
