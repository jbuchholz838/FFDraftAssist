   M S B A M L   `   `   `  ���� H  DFFDraftAssist, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:FFDraftAssistFFDraftAssist  !    FFDraftAssist.RosterWatcher   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     -localclr-namespace:FFDraftAssist     � �InfragisticsWPF4.Controls.Editors.XamComboEditor.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb� ~InfragisticsWPF4.Controls.Grids.XamSpreadsheet.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cbt pInfragisticsWPF4.Controls.Gauges.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cbd `InfragisticsWPF4.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cbp	 lInfragisticsWPF4.DataManager.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb�
 �InfragisticsWPF4.Controls.Layouts.XamTileManager.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb� �InfragisticsWPF4.Controls.Editors.XamMaskedInput.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cbi eInfragisticsWPF4.Undo.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb{ wInfragisticsWPF4.Controls.Menus.XamMenu.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb=ig$http://schemas.infragistics.com/xaml	     	 
    r nInfragisticsWPF4.DataPresenter.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb0igDP%http://infragistics.com/DataPresenter  /	igWindowshttp://infragistics.com/Windows  -     >�Name$  RosterWatcherControl�� � 	Resources     FFDraftAssist.MyCustomSort   MyCustomSort��%   &	          .��]� .+��� -    ��Name$ 	cboSearch��$	��Top=� �� Text$ 	Select...��$��5q�$ �� IsSynchronizedWithCurrentItem$
 TrueY� �� DisplayMemberPath$ TeamName�� �� SelectedValuePath$ TeamName�� �� 
IsEditable .  ���� *CurrentDraft.Teams+4  .Infragistics.Windows.DataPresenter.XamDataGrid  -     Name$ RosterSummaryGrid��$��Bottom=�$	��310��:  4Infragistics.Windows.DataPresenter.DataPresenterBase	   GroupByAreaLocation$
	 None=�
   
DataSource
 �� *CurrentDraft.RosterSummary+���� *
FontSize+ �� ElementName$ RosterWatcherControl��   FieldLayoutSettings <  6Infragistics.Windows.DataPresenter.FieldLayoutSettings      HighlightAlternateRecords$
 TrueY�   AutoGenerateFields$ FalseY�   AllowAddNew$ FalseY�   AutoFitMode$ Always=�   AllowDelete$ FalseY�   AllowFieldMoving$ No=�   RecordSelectorLocation$
 None=�   FieldLayouts 4  .Infragistics.Windows.DataPresenter.FieldLayout  -   grdSummaryFieldLayout��   SortedFields =  7Infragistics.Windows.DataPresenter.FieldSortDescription     	FieldName$	 Key��   	IsGroupBy .     	Direction$ 	Ascending=�   
FieldItems. .  (Infragistics.Windows.DataPresenter.Field  2  ,Infragistics.Windows.DataPresenter.FieldItem   Name$	 Key��   Label$
 Spot��   Width$ 75X�   Settings 6	  0Infragistics.Windows.DataPresenter.FieldSettings	  -   SummarySpotFieldSettings�� 	  SortComparer# [   	  
CellHeight$ 24Q�  $ Value��$ 	# Drafted��$ 50X�!    HorizontalContentAlignment�
  �Infragistics.Windows.Helpers.NullableConverter`1[[System.Windows.HorizontalAlignment, PresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35]]$  Center
   -   $ 
RosterGrid��$
	 None=�
���   �$��0,0,0,2q�
 �� *SelectedItem.Roster+$ 	cboSearch������ *
FontSize+$ RosterWatcherControl��   $
 TrueY�$ FalseY�$ FalseY�$ Always=�$ FalseY�$ No=�$
 None=�   -   grdFieldLayout��   $	 Key�� .  $ 	Ascending=�.   $	 Key��$
 Spot��$	 100X� 	  -   RosterSpotFieldSettings��# [  $ 24Q�  $ Player��$	 160X�!   AlternateBinding! �� " �� Path$#" Value.PlayerPicked.PlayerName�  $	 Bye��$ 80X�#   
Visibility$# 	Collapsed=�! �� $" Value.PlayerPicked.Bye�