﻿using LAB2.DB;
using LAB2.DB.DBCONTEXT;
using LAB2.Method;
using LAB2.Page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Lab
{
    /// <summary>
    /// Логика взаимодействия для AddUser.xaml
    /// </summary>
    public partial class AddUser : Window
    {
        WorkBD WorkBD;
        Edit Edit;
        bool ch;
        int ID;
        public AddUser(Edit edit)
        {
            InitializeComponent();
            Edit= edit;
            Lablenotgood.Visibility = Visibility.Collapsed;
            Lablegood.Visibility = Visibility.Collapsed;
            SaveB.Visibility = Visibility.Collapsed;
            ch=true;
        }
        public AddUser(Edit edit,int id)
        {
            InitializeComponent();
            ID=id;
            Lablenotgood.Visibility = Visibility.Collapsed;
            Lablegood.Visibility = Visibility.Collapsed;
            ch = false;
            WorkBD= new WorkBD();
            User user = JsonSerializer.Deserialize<User>(WorkBD.ISearch(id));
            Lbox.Text = user.UserName;
            Pbox.Text = user.Password;
            Cbox.Text = user.Status;
        }

        private void ButtonSave(object sender, RoutedEventArgs e)
        {
            if (Lablegood.Visibility == Visibility.Visible && CheckPassword(Pbox.Text.Trim()))
            {
                WorkBD = new WorkBD();
                User user;
                if (ch==false)
                {
                    user = new User() { Id=ID,UserName = Lbox.Text, Password = Pbox.Text, Status = Cbox.Text};
                }
                else
                {
                    user = new User() { UserName = Lbox.Text, Password = Pbox.Text, Status = Cbox.Text, datereg = DateTime.Now, lastonline = DateTime.Now };
                }
                WorkBD.Save(user, ch);
                Edit.Refresh();
                this.Close();
            }
            else MessageBox.Show("Данные введены неверно!");
           

        }

        private void Lbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            using (UserContext db = new UserContext())
            {
                if (db.Users.FirstOrDefault(p => p.UserName == Lbox.Text) == null)
                {
                    Lablegood.Visibility = Visibility.Visible;
                    Lablenotgood.Visibility = Visibility.Collapsed;
                    SaveB.Visibility = Visibility.Visible;
                }
                else
                {
                    Lablegood.Visibility = Visibility.Collapsed;
                    Lablenotgood.Visibility = Visibility.Visible;
                    SaveB.Visibility = Visibility.Collapsed;
                }
            }
        }
        public bool CheckPassword(string pas1)
        {
            if (pas1.Length > 3 && !pas1.Contains(" ") && Regex.IsMatch(pas1, @"[qQwWeErRtTyYuUiIoOpPaAsSdDfFgGhHjJkKlLzZxXcCvVbBnNmMА-я0-9]+$"))
                return true;
            return false;
        }
    }
}
