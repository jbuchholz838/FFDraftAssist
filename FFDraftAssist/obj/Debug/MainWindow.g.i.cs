﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BBF4C1206BEE7F4478FE6FB4F7FB3DAC801775785A2790604CE3AABCEA2AE9BD"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Infragistics;
using Infragistics.Controls;
using Infragistics.Controls.Editors;
using Infragistics.Controls.Gauges;
using Infragistics.Controls.Grids;
using Infragistics.Controls.Interactions;
using Infragistics.Controls.Layouts;
using Infragistics.Controls.Menus;
using Infragistics.Documents.Excel;
using Infragistics.Shared;
using Infragistics.Themes;
using Infragistics.Undo;
using Infragistics.Windows;
using Infragistics.Windows.Controls;
using Infragistics.Windows.Controls.Markup;
using Infragistics.Windows.DataPresenter;
using Infragistics.Windows.DataPresenter.Calculations;
using Infragistics.Windows.DockManager;
using Infragistics.Windows.Editors;
using Infragistics.Windows.Reporting;
using Infragistics.Windows.Ribbon;
using Infragistics.Windows.Themes;
using Infragistics.Windows.Tiles;
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


namespace FFDraftAssist {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel dockMain;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Infragistics.Controls.Menus.XamMenuItem menUndo;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Infragistics.Controls.Menus.XamMenuItem menRestart;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Infragistics.Windows.DockManager.SplitPane panMain;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Infragistics.Windows.DockManager.TabGroupPane grpTabPane;
        
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
            System.Uri resourceLocater = new System.Uri("/FFDraftAssist;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            this.dockMain = ((System.Windows.Controls.DockPanel)(target));
            return;
            case 2:
            
            #line 9 "..\..\MainWindow.xaml"
            ((Infragistics.Controls.Menus.XamMenuItem)(target)).Click += new System.EventHandler(this.DraftMenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 10 "..\..\MainWindow.xaml"
            ((Infragistics.Controls.Menus.XamMenuItem)(target)).Click += new System.EventHandler(this.XamMenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 11 "..\..\MainWindow.xaml"
            ((Infragistics.Controls.Menus.XamMenuItem)(target)).Click += new System.EventHandler(this.DraftMenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 12 "..\..\MainWindow.xaml"
            ((Infragistics.Controls.Menus.XamMenuItem)(target)).Click += new System.EventHandler(this.DraftMenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 13 "..\..\MainWindow.xaml"
            ((Infragistics.Controls.Menus.XamMenuItem)(target)).Click += new System.EventHandler(this.DraftMenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 14 "..\..\MainWindow.xaml"
            ((Infragistics.Controls.Menus.XamMenuItem)(target)).Click += new System.EventHandler(this.DraftMenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 15 "..\..\MainWindow.xaml"
            ((Infragistics.Controls.Menus.XamMenuItem)(target)).Click += new System.EventHandler(this.DraftMenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 19 "..\..\MainWindow.xaml"
            ((Infragistics.Controls.Menus.XamMenuItem)(target)).Click += new System.EventHandler(this.XamMenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 20 "..\..\MainWindow.xaml"
            ((Infragistics.Controls.Menus.XamMenuItem)(target)).Click += new System.EventHandler(this.XamMenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.menUndo = ((Infragistics.Controls.Menus.XamMenuItem)(target));
            
            #line 24 "..\..\MainWindow.xaml"
            this.menUndo.Click += new System.EventHandler(this.menUndo_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.menRestart = ((Infragistics.Controls.Menus.XamMenuItem)(target));
            
            #line 25 "..\..\MainWindow.xaml"
            this.menRestart.Click += new System.EventHandler(this.menRestart_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.panMain = ((Infragistics.Windows.DockManager.SplitPane)(target));
            return;
            case 14:
            this.grpTabPane = ((Infragistics.Windows.DockManager.TabGroupPane)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

