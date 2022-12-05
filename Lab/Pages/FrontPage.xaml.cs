using Lab;
using Lab.Method;
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

namespace LAB2.Pages
{
    /// <summary>
    /// Логика взаимодействия для Setting.xaml
    /// </summary>
    //public partial class FrontPage :Page
    //{
    //    MainWindow StartWindow;
    //    public FrontPage(MainWindow startForm)
    //    {
    //        InitializeComponent();

    //        StartWindow = startForm;

    //        ComboFonts.ItemsSource = Fonts.SystemFontFamilies;
    //    }


    //    private void SliderSize_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
    //    {
    //        TextBoxSlider.Text = SliderSize.Value.ToString();
    //        VisualFontSize(int.Parse(SliderSize.Value.ToString()));
    //    }
    //    public void VisualFontSize(int size)
    //    {
    //        if (ExampleText != null)
    //            ExampleText.FontSize = size;
    //    }
    //    public void VisualFontFamily(string font)
    //    {
    //        if (ExampleText != null)
    //            ExampleText.FontFamily = new FontFamily(font);
    //    }

    //    //Применить обновление шрифта
    //    private void ButtonAccept_Click(object sender, RoutedEventArgs e)
    //    {
    //        //FontEditor fontEditor = new FontEditor(this);
    //        //fontEditor.Create(ExampleText.FontFamily.ToString(), int.Parse(ExampleText.FontSize.ToString()));
    //        //fontEditor.Open();
    //        //StartWindow.NavigationMenu.UpdateFonts();
    //    }

    //    //Обновление шрифтов
    //    public void UpdateFont()
    //    {
    //        FontEditor fontEditor = new FontEditor(this);
    //        fontEditor.Open();
    //        SliderSize.Value = fontEditor.FontSize;
    //    }


    //    private void ComboFonts_TextChanged(object sender, TextChangedEventArgs e)
    //    {
    //        TextBoxCombobox.Text = ComboFonts.Text;
    //        VisualFontFamily(ComboFonts.Text);
    //    }

    //    private void Page_Loaded(object sender, RoutedEventArgs e)
    //    {
    //        UpdateFont();
    //    }

    //    private void ComboFonts_SelectionChanged(object sender, SelectionChangedEventArgs e)
    //    {

    //    }
    //}
}
