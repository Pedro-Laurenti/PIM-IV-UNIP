﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "994E9E85DFC22200CFD3CD8F87F4BABEE310BC14"
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

using Protótipo;
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


namespace Protótipo {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 168 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtSenha;
        
        #line default
        #line hidden
        
        
        #line 194 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PwbSenha;
        
        #line default
        #line hidden
        
        
        #line 291 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtSenha1;
        
        #line default
        #line hidden
        
        
        #line 317 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PwbSenha1;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Protótipo;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.TxtSenha = ((System.Windows.Controls.TextBox)(target));
            
            #line 178 "..\..\..\MainWindow.xaml"
            this.TxtSenha.KeyDown += new System.Windows.Input.KeyEventHandler(this.TxtSenha_KeyDown);
            
            #line default
            #line hidden
            
            #line 180 "..\..\..\MainWindow.xaml"
            this.TxtSenha.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtSenha_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.PwbSenha = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 204 "..\..\..\MainWindow.xaml"
            this.PwbSenha.KeyDown += new System.Windows.Input.KeyEventHandler(this.PwbSenha_KeyDown);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 216 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TxtSenha1 = ((System.Windows.Controls.TextBox)(target));
            
            #line 301 "..\..\..\MainWindow.xaml"
            this.TxtSenha1.KeyDown += new System.Windows.Input.KeyEventHandler(this.TxtSenha_KeyDown);
            
            #line default
            #line hidden
            
            #line 303 "..\..\..\MainWindow.xaml"
            this.TxtSenha1.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtSenha_TextChanged1);
            
            #line default
            #line hidden
            return;
            case 5:
            this.PwbSenha1 = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 327 "..\..\..\MainWindow.xaml"
            this.PwbSenha1.KeyDown += new System.Windows.Input.KeyEventHandler(this.PwbSenha_KeyDown1);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 339 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click1);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

