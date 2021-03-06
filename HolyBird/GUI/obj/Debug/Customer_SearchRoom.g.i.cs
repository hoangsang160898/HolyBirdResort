﻿#pragma checksum "..\..\Customer_SearchRoom.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "283241FE8054FA0364B6A1C1DB7EE5D8A6F7C9386B3042C73DBFC68120900D85"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using GUI;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace GUI {
    
    
    /// <summary>
    /// Customer_SearchRoom
    /// </summary>
    public partial class Customer_SearchRoom : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\Customer_SearchRoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox HangPhong_name;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\Customer_SearchRoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Tang_name;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\Customer_SearchRoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox HinhThuc_name;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\Customer_SearchRoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addRoom_name;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\Customer_SearchRoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button removeRoom_name;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\Customer_SearchRoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listSearchRoom;
        
        #line default
        #line hidden
        
        
        #line 154 "..\..\Customer_SearchRoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock noRoomEmpty;
        
        #line default
        #line hidden
        
        
        #line 155 "..\..\Customer_SearchRoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listRoomChoosen;
        
        #line default
        #line hidden
        
        
        #line 225 "..\..\Customer_SearchRoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock noRoomChoosen;
        
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
            System.Uri resourceLocater = new System.Uri("/GUI;component/customer_searchroom.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Customer_SearchRoom.xaml"
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
            
            #line 10 "..\..\Customer_SearchRoom.xaml"
            ((GUI.Customer_SearchRoom)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded_Rooms);
            
            #line default
            #line hidden
            return;
            case 2:
            this.HangPhong_name = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.Tang_name = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.HinhThuc_name = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            
            #line 75 "..\..\Customer_SearchRoom.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.searchRoom);
            
            #line default
            #line hidden
            return;
            case 6:
            this.addRoom_name = ((System.Windows.Controls.Button)(target));
            
            #line 78 "..\..\Customer_SearchRoom.xaml"
            this.addRoom_name.Click += new System.Windows.RoutedEventHandler(this.addRoom);
            
            #line default
            #line hidden
            return;
            case 7:
            this.removeRoom_name = ((System.Windows.Controls.Button)(target));
            
            #line 81 "..\..\Customer_SearchRoom.xaml"
            this.removeRoom_name.Click += new System.Windows.RoutedEventHandler(this.removeRoom);
            
            #line default
            #line hidden
            return;
            case 8:
            this.listSearchRoom = ((System.Windows.Controls.ListView)(target));
            
            #line 84 "..\..\Customer_SearchRoom.xaml"
            this.listSearchRoom.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.selectItemAddRoom);
            
            #line default
            #line hidden
            return;
            case 9:
            this.noRoomEmpty = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.listRoomChoosen = ((System.Windows.Controls.ListView)(target));
            
            #line 155 "..\..\Customer_SearchRoom.xaml"
            this.listRoomChoosen.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.selectItemRemoveRoom);
            
            #line default
            #line hidden
            return;
            case 11:
            this.noRoomChoosen = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

