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
    /// Логика взаимодействия для Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        private Practika2Entities3 database;
        private ServiceCenter redact;
        Practika2Entities3 PE;
        public Window5(Practika2Entities3 sDBEntities, ServiceCenter reda1)
        {
            this.PE = sDBEntities;
            this.DataContext = reda1;
            InitializeComponent();
        }


        private void btnAdd(object sender, RoutedEventArgs e)
        {
            PE.SaveChanges();
            this.Close();
        }

        private void btnBack(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
