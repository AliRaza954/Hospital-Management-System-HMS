﻿#pragma checksum "..\..\AdminWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F251ECDA0A618A92F9DD9CE057E360DADEA844939518003CF3050563FF3F5CAB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace Hospital_Management_System {
    
    
    /// <summary>
    /// AdminWindow
    /// </summary>
    public partial class AdminWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLogout;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblAdmin;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddStaff;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnUpdateDeleteStaff;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddDoctor;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnUpdateDeleteDoctor;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame adminFrame;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button;
        
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
            System.Uri resourceLocater = new System.Uri("/Hospital Management System;component/adminwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AdminWindow.xaml"
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
            this.label = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.btnLogout = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\AdminWindow.xaml"
            this.btnLogout.Click += new System.Windows.RoutedEventHandler(this.btnLogout_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.lblAdmin = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.btnAddStaff = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\AdminWindow.xaml"
            this.btnAddStaff.Click += new System.Windows.RoutedEventHandler(this.btnAddStaff_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnUpdateDeleteStaff = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\AdminWindow.xaml"
            this.btnUpdateDeleteStaff.Click += new System.Windows.RoutedEventHandler(this.btnUpdateDeleteStaff_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnAddDoctor = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\AdminWindow.xaml"
            this.btnAddDoctor.Click += new System.Windows.RoutedEventHandler(this.btnAddDoctor_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnUpdateDeleteDoctor = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\AdminWindow.xaml"
            this.btnUpdateDeleteDoctor.Click += new System.Windows.RoutedEventHandler(this.btnUpdateDeleteDoctor_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 16 "..\..\AdminWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 9:
            this.adminFrame = ((System.Windows.Controls.Frame)(target));
            return;
            case 10:
            
            #line 18 "..\..\AdminWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            case 11:
            this.button = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\AdminWindow.xaml"
            this.button.Click += new System.Windows.RoutedEventHandler(this.button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
