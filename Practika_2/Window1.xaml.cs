using Microsoft.Win32;
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

namespace Practika_2
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            Practika2Entities3 = new Practika2Entities3();
            InitializeComponent();
            Klient.ItemsSource = Practika2Entities3.ServiceCenter.ToList();
        }
        Practika2Entities3 Practika2Entities3 { get; set;}
    
       
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var Dobalenie = new ServiceCenter();
            Practika2Entities3.ServiceCenter.Add(Dobalenie);
            OpenFileDialog das = new OpenFileDialog();
            das.Title = "Выберите изображение";
            das.Filter = "All supported graphics|*.jpeg;*.jpg;*.png|" + " JPEG(*.jpeg;*.jpg)|*.jpeg;*.jpg|" +
            "Portable Network Graphic (*.png)|*.png";
            if (das.ShowDialog() == true)
            {
                Dobalenie.Photo = new Photo { PhotoPath = das.FileName };
            }
            var Dobalenie2 = new Window3(Practika2Entities3, Dobalenie);
            Dobalenie2.ShowDialog();
        }


        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            Button reda = sender as Button;
            var redact = reda.DataContext as ServiceCenter;
            OpenFileDialog das = new OpenFileDialog();
            das.Title = "Выберите изображение";
            das.Filter = "All supported graphics|*.jpeg;*.jpg;*.png|" + " JPEG(*.jpeg;*.jpg)|*.jpeg;*.jpg|" +
            "Portable Network Graphic (*.png)|*.png";
            if (das.ShowDialog() == true)
            {
                redact.Photo = new Photo { PhotoPath = das.FileName };
            }
            var redact2 = new Window5(Practika2Entities3, redact);
            redact2.ShowDialog();

        }
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Practika2Entities3 = new Practika2Entities3();
            ServiceCenter item = Klient.SelectedItem as ServiceCenter;
            try
            {
                ServiceCenter ser = Practika2Entities3.ServiceCenter.Where(c => c.ID == item.ID).Single();
                Practika2Entities3.ServiceCenter.Remove(ser);
                Practika2Entities3.SaveChanges();

                MessageBox.Show("Данные успешно удалены");
                refreshdatagrid();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void refreshdatagrid()
        {
            Practika2Entities3 = new Practika2Entities3();
            Klient.ItemsSource = Practika2Entities3.ServiceCenter.ToList();
            Klient.Items.Refresh();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Practika2Entities3 = new Practika2Entities3();
            Klient.ItemsSource = Practika2Entities3.ServiceCenter.ToList();
            Klient.Items.Refresh();
        }
    }
}
