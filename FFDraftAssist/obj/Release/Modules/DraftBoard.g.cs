﻿#pragma checksum "..\..\..\Modules\DraftBoard.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6A3DD16A0EAFA1A7021D0E9A7E68993CEFAE210494DD064D92C21125E9E103E0"
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
using Infragistics.Controls.Editors.Primitives;
using Infragistics.Controls.Gauges;
using Infragistics.Controls.Grids;
using Infragistics.Controls.Grids.Primitives;
using Infragistics.Controls.Interactions;
using Infragistics.Controls.Interactions.Primitives;
using Infragistics.Controls.Layouts;
using Infragistics.Controls.Layouts.Primitives;
using Infragistics.Controls.Menus;
using Infragistics.Controls.Menus.Primitives;
using Infragistics.Controls.Primitives;
using Infragistics.Themes;
using Infragistics.Undo;
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
    /// DraftBoard
    /// </summary>
    public partial class DraftBoard : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 36 "..\..\..\Modules\DraftBoard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel dockMain;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Modules\DraftBoard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grdTeamNames;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Modules\DraftBoard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grdRounds;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Modules\DraftBoard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Infragistics.Controls.Layouts.XamTileManager manTiles;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Modules\DraftBoard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Infragistics.Controls.Layouts.NormalModeSettings TileSettings;
        
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
            System.Uri resourceLocater = new System.Uri("/FFDraftAssist;component/modules/draftboard.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Modules\DraftBoard.xaml"
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
            this.grdTeamNames = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.grdRounds = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.manTiles = ((Infragistics.Controls.Layouts.XamTileManager)(target));
            return;
            case 5:
            this.TileSettings = ((Infragistics.Controls.Layouts.NormalModeSettings)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

