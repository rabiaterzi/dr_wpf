﻿#pragma checksum "..\..\..\kitap_kategori.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A1D93E1B28B5368D0E5F328230E3AD9C3EF24778"
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
using System.Windows.Controls.Ribbon;
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
using hellowpf;


namespace hellowpf {
    
    
    /// <summary>
    /// kitap_kategori
    /// </summary>
    public partial class kitap_kategori : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\..\kitap_kategori.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ticker;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\kitap_kategori.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnkategori;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\kitap_kategori.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox arama;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\kitap_kategori.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnara;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\kitap_kategori.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnuyegirisi;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\kitap_kategori.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnsepet;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/hellowpf;component/kitap_kategori.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\kitap_kategori.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.ticker = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.btnkategori = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\kitap_kategori.xaml"
            this.btnkategori.Click += new System.Windows.RoutedEventHandler(this.Btngetcategories);
            
            #line default
            #line hidden
            return;
            case 3:
            this.arama = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.btnara = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\..\kitap_kategori.xaml"
            this.btnara.Click += new System.Windows.RoutedEventHandler(this.Btnara);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnuyegirisi = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\kitap_kategori.xaml"
            this.btnuyegirisi.Click += new System.Windows.RoutedEventHandler(this.Btnuyegirisi);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnsepet = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\kitap_kategori.xaml"
            this.btnsepet.Click += new System.Windows.RoutedEventHandler(this.Btnsepet);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 74 "..\..\..\kitap_kategori.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.edebiyatkategori);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
