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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            SomeSetupHere();
        }

        /// <summary>
        /// register context menu with label
        /// </summary>
        private void SomeSetupHere()
        {
            ContextMenu cm = new ContextMenu();

            MenuItem mi1 = new MenuItem();
            mi1.Header = "You like clicking";

            MenuItem mi2 = new MenuItem();
            mi2.Header = "This is not cool";

            cm.Items.Add(mi1);
            cm.Items.Add(mi2);

            label3.ContextMenu = cm;
        }

        /// <summary>
        /// Mouse left button down event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lable0MouseLtBtnDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Aha, left button is fun!");
        }

        /// <summary>
        /// Mouse enter event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lable1MouseEnter(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Mouse, this is restricted text!");
        }

        /// <summary>
        /// Mouse double click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lable2MouseDblClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Ouch, double click hurts!");
        }

        /// <summary>
        /// Mouse right button up event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lable3MouseRtBtnUp(object sender, MouseButtonEventArgs e)
        {
            label3.ContextMenu.IsOpen = true;
        }

        /// <summary>
        /// Mouse Leave event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lable4MouseLeave(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Bye!");
        }

        /// <summary>
        /// Mouse move event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lable5MouseMove(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Hehe, its funny");
        }
    }
}
