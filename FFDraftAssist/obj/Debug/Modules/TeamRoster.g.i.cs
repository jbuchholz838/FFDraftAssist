﻿#pragma checksum "..\..\..\Modules\TeamRoster.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5D46A78815D120E644C5E2D4B087C9D1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace FFDraftAssist.Modules {
    
    
    /// <summary>
    /// TeamRoster
    /// </summary>
    public partial class TeamRoster : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\Modules\TeamRoster.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel dockPanel;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\Modules\TeamRoster.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Infragistics.Windows.DataPresenter.XamDataGrid grdData;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Modules\TeamRoster.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Infragistics.Windows.DataPresenter.FieldLayout grdFieldLayout;
        
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
            System.Uri resourceLocater = new System.Uri("/FFDraftAssist;component/modules/teamroster.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Modules\TeamRoster.xaml"
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
            this.dockPanel = ((System.Windows.Controls.DockPanel)(target));
            return;
            case 2:
            this.grdData = ((Infragistics.Windows.DataPresenter.XamDataGrid)(target));
            
            #line 10 "..\..\..\Modules\TeamRoster.xaml"
            this.grdData.SelectedItemsChanged += new System.EventHandler<Infragistics.Windows.DataPresenter.Events.SelectedItemsChangedEventArgs>(this.grdData_SelectedItemsChanged);
            
            #line default
            #line hidden
            
            #line 10 "..\..\..\Modules\TeamRoster.xaml"
            this.grdData.RecordActivated += new System.EventHandler<Infragistics.Windows.DataPresenter.Events.RecordActivatedEventArgs>(this.grdData_RecordActivated);
            
            #line default
            #line hidden
            return;
            case 3:
            this.grdFieldLayout = ((Infragistics.Windows.DataPresenter.FieldLayout)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

