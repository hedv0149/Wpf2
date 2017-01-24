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

namespace Wpf2
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        Controller controller;
        public Window2()
        {
            controller = Controller.GetInstance();
            InitializeComponent();
        }

        
        public void ClearTextBoxes()
        {
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxAge.Text = "";
            textBoxTelephone.Text = "";
        }
        private void buttonConfirm_Click(object sender, RoutedEventArgs e)
        {
            controller.AddPerson(textBoxFirstName.Text, textBoxLastName.Text, textBoxAge.Text, textBoxTelephone.Text);
           // ClearTextBoxes();
            MainWindow win = new MainWindow ();
            win.Show();
            this.Close();
        }
    }
}
