﻿#pragma checksum "..\..\RoutingInfo.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3CEEC5B94C3EB63439A2DFF7AB3A20ED"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro.Controls;
using RoutingAndBom;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace RoutingAndBom {
    
    
    /// <summary>
    /// RoutingInfo
    /// </summary>
    public partial class RoutingInfo : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\RoutingInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Routing_Info_Grid;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\RoutingInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border Routing_Info_Title;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\RoutingInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox routing_info_nr;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\RoutingInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox WorkStationCB;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\RoutingInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NewRouting;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\RoutingInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.SplitButton TemplateSplit;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\RoutingInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid routing_list_data_grid;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/RoutingAndBom;component/routinginfo.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\RoutingInfo.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Routing_Info_Grid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.Routing_Info_Title = ((System.Windows.Controls.Border)(target));
            return;
            case 3:
            this.routing_info_nr = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.WorkStationCB = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.NewRouting = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\RoutingInfo.xaml"
            this.NewRouting.Click += new System.Windows.RoutedEventHandler(this.NewRouting_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.TemplateSplit = ((MahApps.Metro.Controls.SplitButton)(target));
            
            #line 78 "..\..\RoutingInfo.xaml"
            this.TemplateSplit.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.TemplateSplit_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.routing_list_data_grid = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

