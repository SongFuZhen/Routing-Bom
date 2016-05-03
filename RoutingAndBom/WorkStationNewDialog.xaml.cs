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
    /// WorkStationNewDialog.xaml 的交互逻辑
    /// </summary>
    public partial class WorkStationNewDialog : MetroWindow
    {
        public WorkStationNewDialog()
        {
            InitializeComponent();
        }

        private void New_WorkStation_Info(object sender, RoutedEventArgs e)
        {
            //Create WorkStation Info
            string get_work_station_id = NewWorkStationID.Text.ToString();
            string get_work_station_name = NewWorkStationName.Text.ToString();

            if (get_work_station_id != null && get_work_station_name != null)
            {
                var work_station_data = new List<work_station_info>()
                {
                    new work_station_info {work_station_id=get_work_station_id,work_station_name=get_work_station_name }
                };

                MainWindow mw = new MainWindow();
                mw.work_station_data_grid.ItemsSource = work_station_data;
                //mw.work_station_data_grid.Initialized=true;
                this.Close();
            }
            else
            {

            }

        }
    }
}
