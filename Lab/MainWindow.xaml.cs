using Lab.Method;
using Lab.Page;
using LAB2.Method;
using LAB2.Page;
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

namespace Lab
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


       
        public MainWindow mainWindow;
        public MainWindow()
        {
            InitializeComponent();
            mainWindow=this;
            frame.NavigationService.Navigate(new Edit(mainWindow));
            //  Refresh();
          
        }

        private void OpenEdit(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new Edit(mainWindow));
        }

        private void SettingFront(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new Setting());
        }
        private void SettingCon(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new ConnectionPage());
        }
       

        //public void Refresh()
        //{
        //    try
        //    {
        //        get = new GetSourse();
        //        var source= JsonSerializer.Deserialize<User[]>(get.Get());
        //        GridLab.ItemsSource = source;
        //    }
        //    catch (Exception)
        //    {


        //    }

    }
}
