using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace BindingDemoGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window,INotifyPropertyChanged
    {
            private string btnNameBinding;

            public event PropertyChangedEventHandler PropertyChanged;

            public string BtnNameBinding
            {
                get { return btnNameBinding; }
                set { btnNameBinding = value; OnPropertyChanged(BtnNameBinding); }
            }

            public MainWindow()
            {
                InitializeComponent();
               // this.DataContext = this;
                BtnNameBinding = "Binding data nek";
            }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }    
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1= new Window1(); 
            window1.Show();
        }
    }
}
