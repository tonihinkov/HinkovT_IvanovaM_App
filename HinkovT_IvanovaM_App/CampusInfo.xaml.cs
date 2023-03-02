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

namespace HinkovT_IvanovaM_App
{
    /// <summary>
    /// Interaction logic for CampusInfo.xaml
    /// </summary>
    public partial class CampusInfo : Window
    {
        public CampusInfo()
        {
            InitializeComponent();
        }

        private void GoBack3_Click(object sender, RoutedEventArgs e)
        {
            Info goback3 = new Info();
            goback3.Show();
            this.Close();
        }
    }
}
