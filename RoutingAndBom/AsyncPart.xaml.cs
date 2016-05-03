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
using MahApps.Metro.Controls;
using System.Timers;

namespace RoutingAndBom
{
    /// <summary>
    /// AsyncPart.xaml 的交互逻辑
    /// </summary>
    public partial class AsyncPart : MetroWindow
    {
        public AsyncPart()
        {
            InitializeComponent();
            Timer timer = new Timer();
            timer.Interval = 5000;
            timer.Elapsed += delegate
            {
                this.Dispatcher.Invoke(new Action(delegate
                {
                    this.ProgressRing.Visibility = Visibility.Hidden;
                    this.ShowMsg.Visibility = Visibility.Visible;
                    this.AsyncOkBtn.Visibility = Visibility.Visible;
                }));
                timer.Stop();
            };
            timer.Start();
        }

        private void AsyncOK(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
