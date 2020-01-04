﻿#pragma checksum "..\..\Employee_CreateAccount.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DA0E61C6937AF0C3223F934E7F6A5CDDEEAF55995908956B471C86F578B0A688"
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
    /// Employee_CreateAccount
    /// </summary>
    public partial class Employee_CreateAccount : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\Employee_CreateAccount.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MaDoan_name;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\Employee_CreateAccount.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker NgayBatDau_name;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\Employee_CreateAccount.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker NgayKetThuc_name;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\Employee_CreateAccount.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel leader;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\Employee_CreateAccount.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox HoTenLead_name;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\Employee_CreateAccount.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CMNDLead_name;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\Employee_CreateAccount.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listMember_name;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\Employee_CreateAccount.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.Transitions.TransitioningContent alert_success;
        
        #line default
        #line hidden
        
        
        #line 118 "..\..\Employee_CreateAccount.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.Transitions.TransitioningContent alert_error;
        
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
            System.Uri resourceLocater = new System.Uri("/GUI;component/employee_createaccount.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Employee_CreateAccount.xaml"
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
            this.MaDoan_name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.NgayBatDau_name = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 3:
            this.NgayKetThuc_name = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            
            #line 41 "..\..\Employee_CreateAccount.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.saveInformation);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 42 "..\..\Employee_CreateAccount.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.clearInformation);
            
            #line default
            #line hidden
            return;
            case 6:
            this.leader = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 7:
            this.HoTenLead_name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.CMNDLead_name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            
            #line 70 "..\..\Employee_CreateAccount.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.addMember);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 73 "..\..\Employee_CreateAccount.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.removeMember);
            
            #line default
            #line hidden
            return;
            case 11:
            this.listMember_name = ((System.Windows.Controls.ListView)(target));
            return;
            case 12:
            this.alert_success = ((MaterialDesignThemes.Wpf.Transitions.TransitioningContent)(target));
            return;
            case 13:
            this.alert_error = ((MaterialDesignThemes.Wpf.Transitions.TransitioningContent)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

