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
    /// Interaction logic for LogInMain.xaml
    /// </summary>
    public partial class LogInMain : Window
    {
        public LogInMain()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            Info loginsubmit = new Info();
            loginsubmit.Show();
            this.Close();
        }
    }
}
