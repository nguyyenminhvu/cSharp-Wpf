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
    /// Interaction logic for WriteFile.xaml
    /// </summary>
    public partial class WriteFile : Window
    {
        private MainWindow mainWindow;

        public MainWindow MainWindow
        {
            get { return mainWindow; }
            set { mainWindow = value; }
        }

        public WriteFile()
        {
            InitializeComponent();
        }

        private void btnOkWrite_Click(object sender, RoutedEventArgs e)
        {
            string path=txbInputWriteFile.Text;
            mainWindow.PathFile= path;  
            this.Close();
        }
    }
}
