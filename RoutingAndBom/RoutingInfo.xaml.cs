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

namespace RoutingAndBom
{
    /// <summary>
    /// RoutingInfo.xaml 的交互逻辑
    /// </summary>
    public partial class RoutingInfo : MetroWindow
    {
        public string EPBA { get; set; }

        public RoutingInfo()
        {
            InitializeComponent();
        }

        private void RoutingInfoAddBtn(object sender, RoutedEventArgs e)
        {
            StackPanel sp = new StackPanel();
            sp.Orientation = Orientation.Horizontal;
            Thickness tn = new Thickness(0,10,0,0);
            sp.Margin = tn;

            TextBlock part_nr_lb = new TextBlock();
            part_nr_lb.Text = "零件号";
            TextBox part_nr_tb = new TextBox();
            part_nr_tb.MinWidth = 200;
            part_nr_tb.Height = 20;
            TextBlock part_amount_lb = new TextBlock();
            part_amount_lb.Text = "该零件数量";
            Thickness thickness = new Thickness(20,0,0,0);
            part_amount_lb.Margin = thickness;
            TextBox part_amount_tb = new TextBox();
            part_amount_tb.MinWidth = 200;
            part_amount_tb.Height = 20;

            sp.Children.Add(part_nr_lb);
            sp.Children.Add(part_nr_tb);
            sp.Children.Add(part_amount_lb);
            sp.Children.Add(part_amount_tb);

            Part_StackPanel.Children.Add(sp);
        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            if (EPBA != null)
            {
                routing_info_nr.Text = EPBA;
                Routing_Info_Title.IsEnabled = false;
                RoutingInfoBtn.Visibility = Visibility.Hidden;
                image.Visibility = Visibility.Hidden;
                CreateBtnRange.Visibility = Visibility.Hidden;
                PartGroup.MaxHeight = 400;
                PartGroup.IsEnabled = false;
            }
        }
    }
}
