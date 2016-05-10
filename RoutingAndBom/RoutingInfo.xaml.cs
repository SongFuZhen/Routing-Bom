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

            SetTemplateSplitData();

            SetRoutingListData();
        }

        private void SetTemplateSplitData()
        {
           var template_data = new List<template_date>()
            {
                new template_date {id="0", content="" },
                new template_date {id="1", content="Template 1:贴IMM防尘纸" },
                new template_date {id="2", content="Template 2:装USB防尘盖" },
                new template_date {id="3", content="Template 3:组装触摸屏" },
                new template_date {id="4", content="Template 4:手工检测" }
            };

            this.TemplateSplit.ItemsSource = template_data;
        }

        private void SetRoutingListData()
        {
            var routing_data = new List<routing_date>()
            {
                new routing_date {Nr="1", ProductName="贴IMM防尘纸，如图1", WorkStationNr="ZWT01", Status="Released", Release="unrelease"},
                new routing_date {Nr="2", ProductName="装USB防尘盖，如图2", WorkStationNr="ZWT01", Status="new", Release="Release"},
                new routing_date {Nr="3", ProductName="组装触摸屏，如图3", WorkStationNr="ZWT01", Status="Released", Release="unrelease"},
            };
            this.routing_list_data_grid.ItemsSource = routing_data;
        }

        private void NewRouting_Click(object sender, RoutedEventArgs e)
        {
            RoutingDetail rd = new RoutingDetail();
            rd.ShowDialog();
        }

        private void TemplateSplit_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                //如何获取下拉框的值
                RoutingDetail rd = new RoutingDetail();
                rd.SaveAsTemplate.Visibility = Visibility.Hidden;
                rd.Finish.HorizontalAlignment = HorizontalAlignment.Right;
                rd.Finish.Width = 200;
                rd.ShowDialog();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
