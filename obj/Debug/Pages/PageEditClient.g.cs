﻿#pragma checksum "..\..\..\Pages\PageEditClient.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "09700F038832962A5C9383D7BB7F68568179A6F25AAA2656091C2CB8EDA1208B"
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
using hotel.Pages;


namespace hotel.Pages {
    
    
    /// <summary>
    /// PageEditClient
    /// </summary>
    public partial class PageEditClient : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\Pages\PageEditClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem menuBack;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Pages\PageEditClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem menuDel;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Pages\PageEditClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbName;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Pages\PageEditClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEdit;
        
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
            System.Uri resourceLocater = new System.Uri("/hotel;component/pages/pageeditclient.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\PageEditClient.xaml"
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
            this.menuBack = ((System.Windows.Controls.MenuItem)(target));
            
            #line 17 "..\..\..\Pages\PageEditClient.xaml"
            this.menuBack.Click += new System.Windows.RoutedEventHandler(this.menuBack_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.menuDel = ((System.Windows.Controls.MenuItem)(target));
            
            #line 18 "..\..\..\Pages\PageEditClient.xaml"
            this.menuDel.Click += new System.Windows.RoutedEventHandler(this.menuDel_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txbName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.btnEdit = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\Pages\PageEditClient.xaml"
            this.btnEdit.Click += new System.Windows.RoutedEventHandler(this.btnEdit_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

