﻿#pragma checksum "..\..\..\UI\View.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "49DE9572CA9F0C327CD31ACB01C664DA927F786D3DE6662FB3270CFA22B4BA77"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using BurgerJoint.UI;
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


namespace BurgerJoint.UI {
    
    
    /// <summary>
    /// View
    /// </summary>
    public partial class View : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\UI\View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabControl Tabs1;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\UI\View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox selectCatgry;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\UI\View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button searchBtn;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\UI\View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button clrBtn;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\UI\View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtName;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\UI\View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid reportGrid;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\..\UI\View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button refrshBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/BurgerJoint;component/ui/view.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UI\View.xaml"
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
            this.Tabs1 = ((System.Windows.Controls.TabControl)(target));
            return;
            case 2:
            this.selectCatgry = ((System.Windows.Controls.ComboBox)(target));
            
            #line 23 "..\..\..\UI\View.xaml"
            this.selectCatgry.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.selectCatgry_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.searchBtn = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\UI\View.xaml"
            this.searchBtn.Click += new System.Windows.RoutedEventHandler(this.searchBtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.clrBtn = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.txtName = ((System.Windows.Controls.TextBox)(target));
            
            #line 42 "..\..\..\UI\View.xaml"
            this.txtName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtName_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.reportGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 7:
            this.refrshBtn = ((System.Windows.Controls.Button)(target));
            
            #line 109 "..\..\..\UI\View.xaml"
            this.refrshBtn.Click += new System.Windows.RoutedEventHandler(this.refrshBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

