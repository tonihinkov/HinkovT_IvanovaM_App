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
    /// Interaction logic for Info.xaml
    /// </summary>
    public partial class Info : Window
    {
        public Info()
        {
            InitializeComponent();
        }

        private void Course_Click(object sender, RoutedEventArgs e)
        {
            Course infocourse = new Course();
            infocourse.Show();
            this.Close();
        }

        private void Campus_Click(object sender, RoutedEventArgs e)
        {
            CampusInfo infocampus = new CampusInfo();
            infocampus.Show();
            this.Close();
        }
    }
}
