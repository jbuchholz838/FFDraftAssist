   M S B A M L   `   `   `  ����  FFDraftAssist    FFDraftAssist.MainWindow   5   	   � ~InfragisticsWPF4.Controls.Grids.XamSpreadsheet.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb� �InfragisticsWPF4.Controls.Editors.XamMaskedInput.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb� �InfragisticsWPF4.Controls.Layouts.XamTileManager.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cbp lInfragisticsWPF4.DataManager.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb� �InfragisticsWPF4.Controls.Editors.XamComboEditor.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cbt pInfragisticsWPF4.Controls.Gauges.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb{ wInfragisticsWPF4.Controls.Menus.XamMenu.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cbd `InfragisticsWPF4.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cbi	 eInfragisticsWPF4.Undo.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb=ig$http://schemas.infragistics.com/xaml	         	 p
 lInfragisticsWPF4.DockManager.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cbk gInfragisticsWPF4.Ribbon.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cbt pInfragisticsWPF4.Documents.Excel.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cbr nInfragisticsWPF4.DataPresenter.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cbl hInfragisticsWPF4.Editors.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb>igWPF(http://schemas.infragistics.com/xaml/wpf 
      6:   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
MainWindow��5   	   $
��1000��6   $
��1500��6*    � WindowStartupLocation$ CenterScreen=�67   ���	#FF0A0A0A � WindowState$ 	Maximized=�6s   .��5      ]� -   5         ]�Name$ dockMain��5      .+�5   
   )  #Infragistics.Controls.Menus.XamMenu  $	��Top=�6   $��25��6*   .@�5      -  'Infragistics.Controls.Menus.XamMenuItem  D  >Infragistics.Controls.Menus.Primitives.XamHeaderedItemsControl   Header$ Draft��6   .@�5	        -   5        $ 	New Draft��5	   !   
 � Tag$ NewDraft��64   6a     5
      -   5        $ Spreadsheet Setup��5
   !   $ SpreadsheetSetup��6<   6o     5      -   5        $ 	Autodraft��5   !   .@�5        -   5        $ Autodraft 2 Rounds��5   %   $ Autodraft 2��6A   6q     5      -   5        $ Autodraft 4 Rounds��5   %   $ Autodraft 4��6A   6q     5      -   5        $ Autodraft 6 Rounds��5   %   $ Autodraft 6��6A   6q     5      -   5        $ Autodraft All Rounds��5   %   $ 	Autodraft��6C   6q   5      5        5      $ 
Navigation��6   .@�5        -	   5        $ Draft Center��5   !   $ DraftCenter��67   6e     5      -
   5        $ Draft Board��5   !   $ 
DraftBoard��66   6c   5        5      $
 Edit��6   .@�5        -   5          Name$ menUndo��5   !   $
 Undo��62   $
 Undo��6@   6d     5      -   5        $ 
menRestart��5   !   $ Restart��65   $ Restart��6F   6o   5      5      5 
 /Infragistics.Windows.DockManager.XamDockManager  5   
   $��Bottom=�6   #   AllowMaximizeFloatingWindows . #   AllowMinimizeFloatingWindows . .��5      : 
 4Infragistics.Windows.DockManager.DocumentContentHost  	   Panes.	 5      0 
 *Infragistics.Windows.DockManager.SplitPane  -   5        
  Name$
 panMain��5   "      Panes. 5      3 
 -Infragistics.Windows.DockManager.TabGroupPane  -   5          Name$ 
grpTabPane��5   )   5$      5%      5&      5'      5(      5*      