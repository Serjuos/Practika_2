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
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        Practika2Entities3 PE;
        public Window3(Practika2Entities3 content15, ServiceCenter serviceses)
        {
            this.PE = content15;
            this.DataContext = serviceses;
            InitializeComponent();
        }
        Practika2Entities3 Practika2Entities3 { get; set; }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PE.SaveChanges();
            this.Close();
        }
    }
}
