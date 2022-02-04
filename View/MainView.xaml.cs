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
using PingUI.ViewModel;

namespace PingUI.View
{
    /// <summary>
    /// Interaktionslogik für MainView.xaml
    /// </summary>
    public partial class MainView : Window
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void topBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void closeBtn_MouseEnter(object sender, MouseEventArgs e)
        {
            var brush = new ImageBrush();
            brush.ImageSource = (BitmapImage)this.FindResource("closeBtnImageActive");
            closeBtn.Background = brush;
        }

        private void closeBtn_MouseLeave(object sender, MouseEventArgs e)
        {
            var brush = new ImageBrush();
            brush.ImageSource = (BitmapImage)this.FindResource("closeBtnImage");
            closeBtn.Background = brush;
        }
    }
}
