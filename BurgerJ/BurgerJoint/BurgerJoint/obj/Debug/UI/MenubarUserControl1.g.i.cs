﻿#pragma checksum "..\..\..\UI\MenubarUserControl1.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A7F2BA7CF4E7535152AB83BD91AEB08DBFA60B44B105D42E47F9760026D1A50E"
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
    /// MenubarUserControl1
    /// </summary>
    public partial class MenubarUserControl1 : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 76 "..\..\..\UI\MenubarUserControl1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Menu myMenu;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\UI\MenubarUserControl1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem Home;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\UI\MenubarUserControl1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem Burger;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\UI\MenubarUserControl1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem Beverage;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\..\UI\MenubarUserControl1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem Side;
        
        #line default
        #line hidden
        
        
        #line 125 "..\..\..\UI\MenubarUserControl1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem About;
        
        #line default
        #line hidden
        
        
        #line 130 "..\..\..\UI\MenubarUserControl1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem Exit;
        
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
            System.Uri resourceLocater = new System.Uri("/BurgerJoint;component/ui/menubarusercontrol1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UI\MenubarUserControl1.xaml"
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
            this.myMenu = ((System.Windows.Controls.Menu)(target));
            return;
            case 2:
            this.Home = ((System.Windows.Controls.MenuItem)(target));
            
            #line 77 "..\..\..\UI\MenubarUserControl1.xaml"
            this.Home.Click += new System.Windows.RoutedEventHandler(this.Home_Click_1);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Burger = ((System.Windows.Controls.MenuItem)(target));
            
            #line 83 "..\..\..\UI\MenubarUserControl1.xaml"
            this.Burger.Click += new System.Windows.RoutedEventHandler(this.Burger_Click_1);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Beverage = ((System.Windows.Controls.MenuItem)(target));
            
            #line 97 "..\..\..\UI\MenubarUserControl1.xaml"
            this.Beverage.Click += new System.Windows.RoutedEventHandler(this.Beverage_Click_1);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Side = ((System.Windows.Controls.MenuItem)(target));
            
            #line 111 "..\..\..\UI\MenubarUserControl1.xaml"
            this.Side.Click += new System.Windows.RoutedEventHandler(this.Side_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.About = ((System.Windows.Controls.MenuItem)(target));
            
            #line 125 "..\..\..\UI\MenubarUserControl1.xaml"
            this.About.Click += new System.Windows.RoutedEventHandler(this.About_Click_1);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Exit = ((System.Windows.Controls.MenuItem)(target));
            
            #line 130 "..\..\..\UI\MenubarUserControl1.xaml"
            this.Exit.Click += new System.Windows.RoutedEventHandler(this.Exit_Click_1);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

