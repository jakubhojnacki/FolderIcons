﻿#pragma checksum "..\..\LogWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0C527607D4597EB7C75CD83AC7FD32C17017BE937B2376BD1E1D01EE3EA70C1B"
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


namespace JHJ.FolderIcons {
    
    
    /// <summary>
    /// LogWindow
    /// </summary>
    public partial class LogWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 5 "..\..\LogWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel MainPanel;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\LogWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonApplicationMenuItem ExitRibbonApplicationMenuItem;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\LogWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonButton ClearRibbonButton;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\LogWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonButton ExitRibbonButton;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\LogWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LogTextBox;
        
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
            System.Uri resourceLocater = new System.Uri("/FolderIcons;component/logwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\LogWindow.xaml"
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
            
            #line 4 "..\..\LogWindow.xaml"
            ((JHJ.FolderIcons.LogWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.WindowLoaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.MainPanel = ((System.Windows.Controls.DockPanel)(target));
            return;
            case 3:
            this.ExitRibbonApplicationMenuItem = ((System.Windows.Controls.Ribbon.RibbonApplicationMenuItem)(target));
            
            #line 9 "..\..\LogWindow.xaml"
            this.ExitRibbonApplicationMenuItem.Click += new System.Windows.RoutedEventHandler(this.ExitRibbonApplicationMenuItemClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ClearRibbonButton = ((System.Windows.Controls.Ribbon.RibbonButton)(target));
            
            #line 14 "..\..\LogWindow.xaml"
            this.ClearRibbonButton.Click += new System.Windows.RoutedEventHandler(this.ClearLogRibbonButtonClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ExitRibbonButton = ((System.Windows.Controls.Ribbon.RibbonButton)(target));
            
            #line 17 "..\..\LogWindow.xaml"
            this.ExitRibbonButton.Click += new System.Windows.RoutedEventHandler(this.ExitRibbonButtonClick);
            
            #line default
            #line hidden
            return;
            case 6:
            this.LogTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

