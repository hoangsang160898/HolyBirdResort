﻿#pragma checksum "..\..\Employee_SearchTransaction.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "21672554357E7C33B3C554747BABBB1DEFEBC6CBFE4FD7C41A85748F4D9C9542"
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
    /// Employee_SearchTransaction
    /// </summary>
    public partial class Employee_SearchTransaction : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\Employee_SearchTransaction.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button acceptRoom_name;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\Employee_SearchTransaction.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cancelRoom_name;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\Employee_SearchTransaction.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listTransaction;
        
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
            System.Uri resourceLocater = new System.Uri("/GUI;component/employee_searchtransaction.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Employee_SearchTransaction.xaml"
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
            
            #line 10 "..\..\Employee_SearchTransaction.xaml"
            ((GUI.Employee_SearchTransaction)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded_Transactions);
            
            #line default
            #line hidden
            return;
            case 2:
            this.acceptRoom_name = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\Employee_SearchTransaction.xaml"
            this.acceptRoom_name.Click += new System.Windows.RoutedEventHandler(this.AcceptRoom);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cancelRoom_name = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\Employee_SearchTransaction.xaml"
            this.cancelRoom_name.Click += new System.Windows.RoutedEventHandler(this.cancelRoom);
            
            #line default
            #line hidden
            return;
            case 4:
            this.listTransaction = ((System.Windows.Controls.ListView)(target));
            
            #line 28 "..\..\Employee_SearchTransaction.xaml"
            this.listTransaction.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.selectItem);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

