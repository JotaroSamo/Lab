using Lab;
using Lab.Page;
using LAB2.DB.DBCONTEXT;
using LAB2.Method;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
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

namespace LAB2.Page
{
    /// <summary>
    /// Логика взаимодействия для Edit.xaml
    /// </summary>
    public partial class Edit
    {
        WorkBD get;
  
        MainWindow mainWindow { get; set; }
        Edit edit;
        public Edit(MainWindow main)
        {
            InitializeComponent();
            mainWindow= main;
            edit = this;
            Refresh();
        }

        private void ADDNewUser(object sender, RoutedEventArgs e)
        {
            mainWindow.frame.Navigate(new AddUser(edit));
            //Add add= new Add(edit);
            //add.Show();
        }
        public void Refresh()
        {
            try {get = new WorkBD(); var source = JsonSerializer.Deserialize<User[]>(get.Get()); DataSource.ItemsSource = source; }
            catch (Exception) { }

        }
        
       
        private void Search(object sender, RoutedEventArgs e)
        {
            get= new WorkBD();
            DataSource.ItemsSource = JsonSerializer.Deserialize<User[]>(get.ISearch(TextSearch.Text));
           
        }

        private void ButtonEdit(object sender, RoutedEventArgs e)
        {
            User user=DataSource.SelectedItem as User;
            mainWindow.frame.Navigate(new AddUser(edit,user.Id));
            
         
        }

        private void ButtonDelete(object sender, RoutedEventArgs e)
        {
            User user = DataSource.SelectedItem as User;
            try { get = new WorkBD(); get.GetDelId(edit, user.Id); }
            catch (Exception) { }
          
           
        }
    }
}
