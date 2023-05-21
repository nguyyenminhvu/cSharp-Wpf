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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TodoList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static List<ItemContent> listItemContent=  new List<ItemContent>();
        public MainWindow()
        {
            InitializeComponent();
        }
        int i = 0;
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string text = tbAdd.Text;
            if (!string.IsNullOrEmpty(text))
            {
                ItemContent itemContent = new ItemContent(i, text);
                listItemContent.Add(itemContent);
                tbbAdd.Text += text + "\n";
                i++;
            }
            else
            {
                MessageBox.Show("Input please !");
            }
        }
        void ClearITem()
        {
            tbbAdd.Text="";
            foreach (var item in listItemContent)
            {
                tbbAdd.Text += item.Contents +"\n";
            }

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //delete
            string id_raw = tbId.Text;
            int id;
            Boolean check = int.TryParse(id_raw,out id);
            if (check) {
              if(listItemContent!=null&& listItemContent.Count > 0)
                {
                    if (id>0 && id<listItemContent.Count-1)
                    {
                        listItemContent.RemoveAt(id);
                        ClearITem();
                    }
                    else
                    {
                        MessageBox.Show("Too large !");
                    }
                }
                else
                {
                    MessageBox.Show("Add please !");
                }
            }
            else
            {
                MessageBox.Show("Input integer please !");
            }
     
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string id_raw = tbId.Text;
            int id;
            Boolean check = int.TryParse(id_raw, out id);
            if (check)
            {
                if (listItemContent!=null && listItemContent.Count>0)
                {
                    if (id>0 && id<listItemContent.Count-1)
                    {
                        listItemContent[id].Contents = tbAdd.Text;
                        ClearITem();
                    }
                    else
                    {
                        MessageBox.Show("Too large!");
                    }
                }
                else
                {
                    MessageBox.Show("Input integer please !");
                }
            }
            else
            {
                MessageBox.Show("Input integer please !");
            }

        }
    }
}
