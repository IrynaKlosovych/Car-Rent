﻿#pragma checksum "..\..\AdminMenu.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "698C2B6550C24A6AAE11BB41BB4F1E5CF1FDC9129D4E374A45FEDE3C46AA0BFD"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Course;
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


namespace Course {
    
    
    /// <summary>
    /// AdminMenu
    /// </summary>
    public partial class AdminMenu : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\AdminMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label_admin;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\AdminMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button open_AdminWindow;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\AdminMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button open_DataBaseEditor;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\AdminMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button return_TheCar;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\AdminMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button finesDiscount;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\AdminMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button back_to_log_in;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\AdminMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_exit;
        
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
            System.Uri resourceLocater = new System.Uri("/Course;component/adminmenu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AdminMenu.xaml"
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
            this.label_admin = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.open_AdminWindow = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\AdminMenu.xaml"
            this.open_AdminWindow.Click += new System.Windows.RoutedEventHandler(this.open_AdminWindow_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.open_DataBaseEditor = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\AdminMenu.xaml"
            this.open_DataBaseEditor.Click += new System.Windows.RoutedEventHandler(this.open_DataBaseEditor_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.return_TheCar = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\AdminMenu.xaml"
            this.return_TheCar.Click += new System.Windows.RoutedEventHandler(this.return_TheCar_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.finesDiscount = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\AdminMenu.xaml"
            this.finesDiscount.Click += new System.Windows.RoutedEventHandler(this.finesDiscount_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.back_to_log_in = ((System.Windows.Controls.Button)(target));
            
            #line 69 "..\..\AdminMenu.xaml"
            this.back_to_log_in.Click += new System.Windows.RoutedEventHandler(this.back_to_log_in_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.button_exit = ((System.Windows.Controls.Button)(target));
            
            #line 80 "..\..\AdminMenu.xaml"
            this.button_exit.Click += new System.Windows.RoutedEventHandler(this.button_exit_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
