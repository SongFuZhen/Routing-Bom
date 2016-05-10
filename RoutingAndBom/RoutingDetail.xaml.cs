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
using Microsoft.Win32;
using MahApps.Metro.Controls.Dialogs;

namespace RoutingAndBom
{
    /// <summary>
    /// RoutingDetail.xaml 的交互逻辑
    /// </summary>
    public partial class RoutingDetail : MetroWindow
    {
        int click_count = 0;
        public RoutingDetail()
        {
            InitializeComponent();
        }

        private void AddPart_Click(object sender, RoutedEventArgs e)
        {
            Thickness tn = new Thickness(0, 5, 0, 0);

            TextBox pntb = new TextBox();
            pntb.MinWidth = 200;
            pntb.MaxWidth = 300;
            pntb.Margin = tn;
            pntb.Text = click_count + "PN";
            pntb.Name = "PN" + click_count;

            TextBox sdtb = new TextBox();
            sdtb.MinWidth = 200;
            sdtb.MaxWidth = 300;
            sdtb.Margin = tn;
            sdtb.Text = click_count + "SD";
            sdtb.Name = "SD" + click_count;


            TextBox qtb = new TextBox();
            qtb.MinWidth = 200;
            qtb.MaxWidth = 300;
            qtb.Margin = tn;
            qtb.Text = click_count + "QT";
            qtb.Name = "QT" + click_count;

            PN.Children.Add(pntb);
            Standard.Children.Add(sdtb);
            Quantity.Children.Add(qtb);

            click_count++;
        }

        private void Finish_Routing(object sender, RoutedEventArgs e)
        {
            for (var i = 0; i < click_count; i++)
            {
                RoutingDescription.Text += ForEachTextBox(PN, "PN", i) + ForEachTextBox(Standard, "SD", i) + ForEachTextBox(Quantity, "QT", i);
            }
        }

        private string ForEachTextBox(StackPanel sp, string spname, int count)
        {
            string TextBoxValue = "";
            foreach (var ui in sp.Children)
            {
                if (ui is TextBox)
                {
                    TextBox current = ui as TextBox;
                    if (current.Text == null || current.Text == "")
                    {
                    }
                    else
                    {
                        if (current.Name == spname + count)
                        {
                            TextBoxValue = current.Text;
                        }
                    }
                }
            }
            return TextBoxValue;
        }

        private void UploadImage_Click(object sender, RoutedEventArgs e)
        {
            //System.Diagnostics.Process.Start("explorer.exe", System.Environment.CurrentDirectory);

            // Configure open file dialog box
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            string currentPath = System.AppDomain.CurrentDomain.BaseDirectory;
            dlg.InitialDirectory = currentPath; // initial Path
            dlg.DefaultExt = ".jpg"; // Default file extension
            dlg.Filter = "图片文件(*.jpg,*.gif,*.bmp,*.png)|*.jpg;*.gif;*.bmp;*.png"; // Filter files by extension

            // Show open file dialog box
            Nullable<bool> result = dlg.ShowDialog();

            // Process open file dialog box results
            if (result == true)
            {
                ImageUrl.Content = dlg.FileName;
                BitmapImage bmi = new BitmapImage(new Uri(dlg.FileName));
                ShowImage.Source = bmi;
            }
        }


        private async void SaveAsTemplate_Click(object sender, RoutedEventArgs e)
        {
            var result = await this.ShowInputAsync("模板名称", "请输入模板名称：");

            //用户点击cancel
            if (result == null)
                return;

            //await this.ShowMessageAsync("Good", "保存成功！模板名称为" + result);
        }
    }
}