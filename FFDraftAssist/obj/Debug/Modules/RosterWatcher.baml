   M S B A M L   `   `   `  ����H  DFFDraftAssist, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:FFDraftAssistFFDraftAssist  5      !    FFDraftAssist.RosterWatcher   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:FFDraftAssist     5      � �InfragisticsWPF4.Controls.Editors.XamComboEditor.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb� ~InfragisticsWPF4.Controls.Grids.XamSpreadsheet.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cbt pInfragisticsWPF4.Controls.Gauges.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cbd `InfragisticsWPF4.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cbp	 lInfragisticsWPF4.DataManager.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb�
 �InfragisticsWPF4.Controls.Layouts.XamTileManager.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb� �InfragisticsWPF4.Controls.Editors.XamMaskedInput.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cbi eInfragisticsWPF4.Undo.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb{ wInfragisticsWPF4.Controls.Menus.XamMenu.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb=ig$http://schemas.infragistics.com/xaml	     	 
    5      r nInfragisticsWPF4.DataPresenter.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb0igDP%http://infragistics.com/DataPresenter  5      /	igWindowshttp://infragistics.com/Windows  5	      -   5          >�Name$  RosterWatcherControl��5
       � 	Resources 5          FFDraftAssist.MyCustomSort   MyCustomSort��%   &	          5   
   6   5      .��5      ]� .+�5   
   �� -   5         ��Name$ 	cboSearch��5      $	��Top=�6&    �� Text$ 	Select...��6;   $��5q�6L   $ �� IsSynchronizedWithCurrentItem$
 TrueY�6X    �� DisplayMemberPath$ TeamName��6�    �� SelectedValuePath$ TeamName��6�    �� 
IsEditable .  ��6}   �� *CurrentDraft.Teams+6�   4  .Infragistics.Windows.DataPresenter.XamDataGrid  5   
   -   5          Name$ RosterSummaryGrid��5      $��Bottom=�66   $	��310��6N   :  4Infragistics.Windows.DataPresenter.DataPresenterBase	   GroupByAreaLocation$
	 None=�6�   
   
DataSource
 6[   �� *CurrentDraft.RosterSummary+��6�   �� *
FontSize+ �� ElementName$ RosterWatcherControl��   FieldLayoutSettings 5      <  6Infragistics.Windows.DataPresenter.FieldLayoutSettings  5          HighlightAlternateRecords$
 TrueY�6+      AutoGenerateFields$ FalseY�6L      AllowAddNew$ FalseY�6g      AutoFitMode$ Always=�6{      AllowDelete$ FalseY�6�      AllowFieldMoving$ No=�6�      RecordSelectorLocation$
 None=�6�      FieldLayouts 5      4  .Infragistics.Windows.DataPresenter.FieldLayout  5      -   5        grdSummaryFieldLayout��   SortedFields 5      =  7Infragistics.Windows.DataPresenter.FieldSortDescription  5         	FieldName$	 Key��64      	IsGroupBy .     	Direction$ 	Ascending=�6V      
FieldItems. 5      .  (Infragistics.Windows.DataPresenter.Field  2  ,Infragistics.Windows.DataPresenter.FieldItem   Name$	 Key��6!      Label$
 Spot��6,      Width$ 75X�69      Settings 5      6	  0Infragistics.Windows.DataPresenter.FieldSettings	  5       -   5        SummarySpotFieldSettings�� 	  SortComparer# [  5    S    	  
CellHeight$ 24Q�6�   5"        5$      $ Value��6!   $ 	# Drafted��6.   $ 50X�6@   !    HorizontalContentAlignment�
  �Infragistics.Windows.Helpers.NullableConverter`1[[System.Windows.HorizontalAlignment, PresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35]]$  Center
 6K   5)      5+        5.   
   -   5        $ 
RosterGrid��5.      $
	 None=�6q   
���   �$��0,0,0,2q�6  
 6/   �� *SelectedItem.Roster+$ 	cboSearch����6�   �� *
FontSize+$ RosterWatcherControl�� 5/        50      $
 TrueY�6+   $ FalseY�6L   $ FalseY�6g   $ Always=�6{   $ FalseY�6�   $ No=�6�   $
 None=�6�    53        54      -   5        grdFieldLayout�� 55        56      $	 Key��64    .  $ 	Ascending=�6V   . 59        $	 Key��6!   $
 Spot��6,   $	 100X�69    5:      	  5;      -   5        RosterSpotFieldSettings��# [  5;   R   $ 24Q�6   5=        5?      $ Player��6!   $	 160X�6p   !   AlternateBinding! 60   �� " �� Path$#" Value.PlayerPicked.PlayerName�6p     5@      $	 Bye��6!   $ 80X�6f   #   
Visibility$# 	Collapsed=�6q   ! 6-   �� $" Value.PlayerPicked.Bye�6q   5B      5D      5E      5F      