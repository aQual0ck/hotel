﻿#pragma checksum "..\..\..\Pages\PageRooms.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7705675F67E706045EFA66D85D484E6328FC809C1BB6CDF5C8D8EFF026B9C7D0"
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
    /// PageRooms
    /// </summary>
    public partial class PageRooms : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 18 "..\..\..\Pages\PageRooms.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem menuAdd;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Pages\PageRooms.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem menuUpdate;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Pages\PageRooms.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbCategory;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Pages\PageRooms.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbStatus;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Pages\PageRooms.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgrRooms;
        
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
            System.Uri resourceLocater = new System.Uri("/hotel;component/pages/pagerooms.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\PageRooms.xaml"
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
            this.menuAdd = ((System.Windows.Controls.MenuItem)(target));
            
            #line 18 "..\..\..\Pages\PageRooms.xaml"
            this.menuAdd.Click += new System.Windows.RoutedEventHandler(this.menuAdd_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.menuUpdate = ((System.Windows.Controls.MenuItem)(target));
            
            #line 19 "..\..\..\Pages\PageRooms.xaml"
            this.menuUpdate.Click += new System.Windows.RoutedEventHandler(this.menuUpdate_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cmbCategory = ((System.Windows.Controls.ComboBox)(target));
            
            #line 23 "..\..\..\Pages\PageRooms.xaml"
            this.cmbCategory.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbCategory_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cmbStatus = ((System.Windows.Controls.ComboBox)(target));
            
            #line 25 "..\..\..\Pages\PageRooms.xaml"
            this.cmbStatus.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbStatus_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.dgrRooms = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            System.Windows.EventSetter eventSetter;
            switch (connectionId)
            {
            case 6:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.Controls.Control.MouseDoubleClickEvent;
            
            #line 32 "..\..\..\Pages\PageRooms.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseButtonEventHandler(this.DataGridRow_MouseDoubleClick);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            }
        }
    }
}

