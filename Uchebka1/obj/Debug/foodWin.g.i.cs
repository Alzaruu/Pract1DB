﻿#pragma checksum "..\..\foodWin.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D8C6A2AF46483B23238D42A902EED41CA9D76C98743556183B406D7D1F0DD944"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using Uchebka1;


namespace Uchebka1 {
    
    
    /// <summary>
    /// foodWin
    /// </summary>
    public partial class foodWin : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\foodWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid foodGridd;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\foodWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox pisalka;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\foodWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button udal;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\foodWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button sozd;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\foodWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button izm;
        
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
            System.Uri resourceLocater = new System.Uri("/Uchebka1;component/foodwin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\foodWin.xaml"
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
            this.foodGridd = ((System.Windows.Controls.DataGrid)(target));
            
            #line 15 "..\..\foodWin.xaml"
            this.foodGridd.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.foodGridd_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.pisalka = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.udal = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\foodWin.xaml"
            this.udal.Click += new System.Windows.RoutedEventHandler(this.udal_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.sozd = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\foodWin.xaml"
            this.sozd.Click += new System.Windows.RoutedEventHandler(this.sozd_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.izm = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\foodWin.xaml"
            this.izm.Click += new System.Windows.RoutedEventHandler(this.izm_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

