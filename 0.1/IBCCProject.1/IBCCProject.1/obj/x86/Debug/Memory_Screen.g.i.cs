﻿#pragma checksum "..\..\..\Memory_Screen.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E595ED3AD5E796E30F82128A76B82970"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.36366
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


namespace IBCCProject._1 {
    
    
    /// <summary>
    /// Memory_Screen
    /// </summary>
    public partial class Memory_Screen : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\Memory_Screen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label1;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Memory_Screen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button menuButton;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Memory_Screen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox memoryContent;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Memory_Screen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock memoryTitle;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Memory_Screen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button backButton;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Memory_Screen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button flagButton;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Memory_Screen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label3;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Memory_Screen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Popup Popup1;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\Memory_Screen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelPassword;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Memory_Screen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button confirmFlag;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Memory_Screen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cancelButton;
        
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
            System.Uri resourceLocater = new System.Uri("/IBCCProject.1;component/memory_screen.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Memory_Screen.xaml"
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
            this.label1 = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.menuButton = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\Memory_Screen.xaml"
            this.menuButton.Click += new System.Windows.RoutedEventHandler(this.menuButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.memoryContent = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.memoryTitle = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.backButton = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\Memory_Screen.xaml"
            this.backButton.Click += new System.Windows.RoutedEventHandler(this.backButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.flagButton = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\Memory_Screen.xaml"
            this.flagButton.Click += new System.Windows.RoutedEventHandler(this.flagButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.label3 = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.Popup1 = ((System.Windows.Controls.Primitives.Popup)(target));
            return;
            case 9:
            this.labelPassword = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.confirmFlag = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\..\Memory_Screen.xaml"
            this.confirmFlag.Click += new System.Windows.RoutedEventHandler(this.confirmFlag_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.cancelButton = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\..\Memory_Screen.xaml"
            this.cancelButton.Click += new System.Windows.RoutedEventHandler(this.cancelButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

