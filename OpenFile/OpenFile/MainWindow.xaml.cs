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
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OpenFile
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string pathFile;

        public string PathFile
        {
            get { return pathFile; }
            set { pathFile = value; }
        }

        public MainWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation=WindowStartupLocation.CenterScreen;  
        }

        private void btnClickOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ParentWindow = this;
            openFileDialog.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (PathFile != null)
            {
                string STRtext = txbShow.Text;
                File.WriteAllText(PathFile, STRtext);
                if (File.Exists(PathFile))
                {
                    MessageBox.Show("Saved Successful", "System");
                    txbShow.Text = "";
                    PathFile = null;
                }
            }
            else
            {
                MessageBox.Show("Open file please", "System");
            }
        }

        private void btnClickWrite_Click(object sender, RoutedEventArgs e)
        {
            WriteFile writeFile = new WriteFile();
            writeFile.MainWindow = this;
            writeFile.WindowStartupLocation = WindowStartupLocation.CenterScreen;   
            writeFile.ShowDialog();
        }
    }
}
