using System;
using System.Collections.Generic;
using System.IO;
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

namespace OpenFile
{
    /// <summary>
    /// Interaction logic for OpenFileDialog.xaml
    /// </summary>
    public partial class OpenFileDialog : Window
    {
        private MainWindow parentWindow;

        public MainWindow ParentWindow
        {
            get { return parentWindow; }
            set { parentWindow = value; }
        }


        public OpenFileDialog()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void btnClickOpen_Click(object sender, RoutedEventArgs e)
        {
            string path=txbInputPath.Text;
            if (path != null && File.Exists(path))
            {
                string textFile = File.ReadAllText(path);
                parentWindow.txbShow.Text = textFile;
                parentWindow.PathFile = path;
                this.Close();
            }
            else
            {
                MessageBox.Show("Path invalid");
            }
           
        }
    }
}
