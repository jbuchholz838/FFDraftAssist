﻿#pragma checksum "..\..\..\Modules\RosterWatcher.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "514778963DE410BA0832ADECB216E844795DF7C7CDF44D876C3CAA605E244AF4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FFDraftAssist;
using Infragistics;
using Infragistics.Controls;
using Infragistics.Controls.Editors;
using Infragistics.Controls.Gauges;
using Infragistics.Controls.Grids;
using Infragistics.Controls.Interactions;
using Infragistics.Controls.Layouts;
using Infragistics.Controls.Menus;
using Infragistics.Shared;
using Infragistics.Themes;
using Infragistics.Undo;
using Infragistics.Windows;
using Infragistics.Windows.Controls;
using Infragistics.Windows.Controls.Markup;
using Infragistics.Windows.Converters;
using Infragistics.Windows.DataPresenter;
using Infragistics.Windows.DataPresenter.Calculations;
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
    /// RosterWatcher
    /// </summary>
    public partial class RosterWatcher : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\Modules\RosterWatcher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal FFDraftAssist.RosterWatcher RosterWatcherControl;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Modules\RosterWatcher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboSearch;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Modules\RosterWatcher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Infragistics.Windows.DataPresenter.XamDataGrid RosterSummaryGrid;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Modules\RosterWatcher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Infragistics.Windows.DataPresenter.FieldLayout grdSummaryFieldLayout;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Modules\RosterWatcher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Infragistics.Windows.DataPresenter.FieldSettings SummarySpotFieldSettings;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Modules\RosterWatcher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Infragistics.Windows.DataPresenter.XamDataGrid RosterGrid;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\Modules\RosterWatcher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Infragistics.Windows.DataPresenter.FieldLayout grdFieldLayout;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\Modules\RosterWatcher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Infragistics.Windows.DataPresenter.FieldSettings RosterSpotFieldSettings;
        
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
            System.Uri resourceLocater = new System.Uri("/FFDraftAssist;component/modules/rosterwatcher.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Modules\RosterWatcher.xaml"
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
            this.RosterWatcherControl = ((FFDraftAssist.RosterWatcher)(target));
            return;
            case 2:
            this.cboSearch = ((System.Windows.Controls.ComboBox)(target));
            
            #line 16 "..\..\..\Modules\RosterWatcher.xaml"
            this.cboSearch.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cboSearch_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.RosterSummaryGrid = ((Infragistics.Windows.DataPresenter.XamDataGrid)(target));
            
            #line 19 "..\..\..\Modules\RosterWatcher.xaml"
            this.RosterSummaryGrid.InitializeRecord += new System.EventHandler<Infragistics.Windows.DataPresenter.Events.InitializeRecordEventArgs>(this.XamDataGrid_InitializeRecord);
            
            #line default
            #line hidden
            return;
            case 4:
            this.grdSummaryFieldLayout = ((Infragistics.Windows.DataPresenter.FieldLayout)(target));
            return;
            case 5:
            this.SummarySpotFieldSettings = ((Infragistics.Windows.DataPresenter.FieldSettings)(target));
            return;
            case 6:
            this.RosterGrid = ((Infragistics.Windows.DataPresenter.XamDataGrid)(target));
            
            #line 46 "..\..\..\Modules\RosterWatcher.xaml"
            this.RosterGrid.InitializeRecord += new System.EventHandler<Infragistics.Windows.DataPresenter.Events.InitializeRecordEventArgs>(this.XamDataGrid_InitializeRecord);
            
            #line default
            #line hidden
            return;
            case 7:
            this.grdFieldLayout = ((Infragistics.Windows.DataPresenter.FieldLayout)(target));
            return;
            case 8:
            this.RosterSpotFieldSettings = ((Infragistics.Windows.DataPresenter.FieldSettings)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

