﻿#pragma checksum "..\..\..\UI\Adminlogin.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4F8034E6CCFAF8F8A5F3E7572153CE04DD12F228F41951F69ADB45E5C24A7876"
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
using MahApps.Metro.IconPacks;
using MahApps.Metro.IconPacks.Converter;
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
    /// Adminlogin
    /// </summary>
    public partial class Adminlogin : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 49 "..\..\..\UI\Adminlogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock errormessage;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\UI\Adminlogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox mailText;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\UI\Adminlogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox pwdText1;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\UI\Adminlogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox pwdText2;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\..\UI\Adminlogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button adminlog;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\..\UI\Adminlogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cancelBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/BurgerJoint;component/ui/adminlogin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UI\Adminlogin.xaml"
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
            this.errormessage = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.mailText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.pwdText1 = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 4:
            this.pwdText2 = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 5:
            this.adminlog = ((System.Windows.Controls.Button)(target));
            
            #line 94 "..\..\..\UI\Adminlogin.xaml"
            this.adminlog.Click += new System.Windows.RoutedEventHandler(this.adminlog_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.cancelBtn = ((System.Windows.Controls.Button)(target));
            
            #line 95 "..\..\..\UI\Adminlogin.xaml"
            this.cancelBtn.Click += new System.Windows.RoutedEventHandler(this.cancelBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

