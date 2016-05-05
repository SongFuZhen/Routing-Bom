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
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using System.Collections.ObjectModel;

namespace RoutingAndBom
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            SetWorkStationData();
        }

        private void SetWorkStationData()
        {
            var word_station_info_data = new List<work_station_info>(){
                   new work_station_info { work_station_id = "No.1", work_station_name = "No.1:Work Station Name" },
                   new work_station_info { work_station_id = "No.2", work_station_name = "No.2:Work Station Name" },
                   new work_station_info { work_station_id = "No.3", work_station_name = "No.3:Work Station Name" },
                   new work_station_info { work_station_id = "No.4", work_station_name = "No.4:Work Station Name" },
                   new work_station_info { work_station_id = "No.5", work_station_name = "No.5:Work Station Name" },
                   new work_station_info { work_station_id = "No.6", work_station_name = "No.6:Work Station Name" }
                };
            this.work_station_data_grid.ItemsSource = word_station_info_data;
        }

        private void SetPartData()
        {
            var part_data = new List<part_data>(){
                   new part_data { partNr = "No.1", partDescription = "No.1:Work Station Name", partType = "成品" },
                   new part_data { partNr = "No.2", partDescription = "No.2:Work Station Name", partType = "半成品" },
                   new part_data { partNr = "No.3", partDescription = "No.3:Work Station Name", partType = "原材料" },
                   new part_data { partNr = "No.4", partDescription = "No.4:Work Station Name", partType = "半成品" },
                   new part_data { partNr = "No.5", partDescription = "No.5:Work Station Name", partType = "原材料" },
                   new part_data { partNr = "No.6", partDescription = "No.6:Work Station Name", partType = "成品" }
                };
            this.part_info_data_grid.ItemsSource = part_data;
        }

        private void SetRoutingData()
        {
            var routing_data = new List<routing_date>()
            {
                new routing_date {Nr="WICP010101", ProductName="CP01", WorkStationNr="ZWT01", Status="Released", Release="unrelease"},
                new routing_date {Nr="WICP010102", ProductName="CP01", WorkStationNr="ZWT01", Status="new", Release="Release"},
                new routing_date {Nr="WICP010201", ProductName="CP01", WorkStationNr="ZWT01", Status="Released", Release="unrelease"},
                new routing_date {Nr="WICP010201", ProductName="CP02", WorkStationNr="ZWT02", Status="Released", Release="unrelease"},
                new routing_date {Nr="WICP011101", ProductName="CP01", WorkStationNr="ZWT01", Status="Released", Release="unrelease"},
                new routing_date {Nr="WICP012101", ProductName="CP02", WorkStationNr="ZWT01", Status="new", Release="Release"},
            };
            this.routing_data_grid.ItemsSource = routing_data;
        }

        //TODO: Write Data
        private void SetRoutingCBData()
        {

        }

        private void TabClick(object sender, MouseButtonEventArgs e)
        {
            //Change Color
            WorkStationInfoName.Foreground = new SolidColorBrush(Colors.Black);
            PartInfoName.Foreground = new SolidColorBrush(Colors.Black);
            RoutingName.Foreground = new SolidColorBrush(Colors.Black);
            Label label = (Label)sender;
            label.Foreground = new SolidColorBrush(Colors.White);

            //Change Event 
            if (label.Name == "WorkStationInfoName")
            {
                WorkStationInfo.IsSelected = true;
                SetWorkStationData();
            }
            else if (label.Name == "PartInfoName")
            {
                PartInfo.IsSelected = true;
                SetPartData();
            }
            else if (label.Name == "RoutingName")
            {
                Routing.IsSelected = true;
                SetRoutingData();
            }
            else
            {
                WorkStationInfo.IsSelected = true;
                SetWorkStationData();
            }
        }

        private void New_WorkStation(object sender, RoutedEventArgs e)
        {
            //Show Dialog
            WorkStationNewDialog wsnd = new WorkStationNewDialog();
            wsnd.ShowDialog();
        }

        private async void work_station_data_grid_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            //WorkStationNewDialog wsnd = new WorkStationNewDialog();
            //wsnd.ShowDialog();
            if (true)
            {

            }
            else
            {
                await this.ShowMessageAsync("编辑失败", "编辑失败");
            }
        }

        private void work_station_data_grid_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                MessageBox.Show("新增成功", "新增成功", MessageBoxButton.OK);
            }
        }

        private void Async_Part_Info(object sender, RoutedEventArgs e)
        {
            AsyncPart ap = new AsyncPart();
            ap.ShowDialog();
        }

        private void New_Routing(object sender, RoutedEventArgs e)
        {
            RoutingInfo ri = new RoutingInfo();
            ri.ShowDialog();
        }

        private void Show_Detail(object sender, RoutedEventArgs e)
        {
            string Nr = (sender as Button).Tag.ToString();

            RoutingInfo ri = new RoutingInfo();
            ri.EPBA = Nr;
            ri.ShowDialog();
        }
    }
}