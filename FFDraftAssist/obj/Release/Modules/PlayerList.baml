   M S B A M L   `   `   `  ���� H  DFFDraftAssist, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:FFDraftAssistFFDraftAssist      FFDraftAssist.PlayerList   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  � �InfragisticsWPF4.Controls.Editors.XamComboEditor.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb� ~InfragisticsWPF4.Controls.Grids.XamSpreadsheet.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cbt pInfragisticsWPF4.Controls.Gauges.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cbd	 `InfragisticsWPF4.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cbp
 lInfragisticsWPF4.DataManager.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb� �InfragisticsWPF4.Controls.Layouts.XamTileManager.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb� �InfragisticsWPF4.Controls.Editors.XamMaskedInput.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cbi eInfragisticsWPF4.Undo.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb{ wInfragisticsWPF4.Controls.Menus.XamMenu.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb=ig$http://schemas.infragistics.com/xaml	    	 
     r nInfragisticsWPF4.DataPresenter.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb0igDP%http://infragistics.com/DataPresenter  +igDP1http://infragistics.com/Windows 	 l hInfragisticsWPF4.Editors.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb/	igEditorshttp://infragistics.com/Editors  #lclr-namespace:FFDraftAssist  -     >�Name$  PlayerListControl��$��14(� � 	Resources *  $FFDraftAssist.NumberEvenOddConverter   EvenOddConvert;  5Infragistics.Windows.DataPresenter.CellValuePresenter �� 
TargetType �� Property �� Value;  5Infragistics.Windows.DataPresenter.DataRecordCellArea �� Triggers �� Binding �� RelativeSource �� Path	 �� 	Converter
 �� Value ^� 
Conditions �� Binding �� Value  LargeFieldText  CenterFieldText  CenterFieldTextBye  GridHeaderStyle8  2Infragistics.Windows.DataPresenter.HeaderLabelArea7  1Infragistics.Windows.DataPresenter.LabelPresenter  
LabelStyle<  6Infragistics.Windows.DataPresenter.DataRecordPresenter��%�
  &	        '       '       7   &	 �    &	 �    &	 �    &	 �	    &	 �	    '  
      �� "  .���  � ��
 �  ����  � �� Z� ��  � ��$ 0q���  � ��$ 0q���  � ��$ 0q��� "  .���  � �� Z� ��  �@ BackgroundHover Z� ��  �@ BackgroundSelected Z� ��  �@ BackgroundAlternate Z� ��  �@ BackgroundActive Z� ��  � �� Z� ��  �@ BorderSelectedBrush �	#FF00E8FF��  �@ BorderActiveBrush �	#FF00E8FF��  �@ BorderHoverBrush �	#FF00E8FF��  � ��$ 3q� ��  ��  �� *Self+$ Record.DataItem.Tier�8	   
 Even.a���  � �� �	#FFD8D3D3��  � �� �	#FFD8D3D3��  � ��$ 0q���  ��  �� *Self+$! Record.DataItem.DraftStatus�
 Drafted.a���  � ��
 �  ����  �@ BackgroundSelected �	#FFF94242��  �@ BackgroundAlternate
 �  ����  ��  �� *Self+$! Record.DataItem.DraftStatus�
 	I Drafted.a���  � �� �	#FF8747C7��  �@ BackgroundSelected �	#FFB278EC��  �@ BackgroundAlternate �	#FF8747C7��  �@ BackgroundActive �	#FFB278EC��  ��  �� *Self+$" Record.DataItem.TopAvailable�
 True.a���  � �� �	#FFEBF33D��  �@ BackgroundHover �	#FFEBF33D��  �@ BackgroundSelected �	#FFF4FF00��  �@ BackgroundAlternate �	#FFEBF33D��  �@ BackgroundActive �	#FFEBF33D^�  ��  ��  �� *Self+$* $Record.DataItem.DraftStrategy.Action�
 Ignore��  ��  �� *Self+$! Record.DataItem.DraftStatus� 	Available0���  � �� �	#FFFDA50A��  �@ BackgroundHover �	#FFFDA50A��  �@ BackgroundSelected �	#FFFDA50A��  �@ BackgroundAlternate �	#FFFDA50A��  �@ BackgroundActive �	#FFFDA50A^�  ��  ��  �� *Self+$* $Record.DataItem.DraftStrategy.Action�
 Target��  ��  �� *Self+$! Record.DataItem.DraftStatus� 	Available0���  � �� �	#FF00FF68��  �@ BackgroundHover �	#FF00FF68��  �@ BackgroundSelected �	#FF00FF68��  �@ BackgroundAlternate �	#FF00FF68��  �@ BackgroundActive �	#FF00FF68�� "  �� "  .���  � ��$ Center=��� "   ^�  ��  �� *DataItem.SharesBye+ True��  �� *DataItem.PickedBy+ Z� 0���  � ��
 � ���.���  � ��$ Center=��� "  .���  � ��$
 Bold"���  � ��$ 0q��� "  .���  � ��$ 0q���  � ��$ 0q��� "  .�-   ��  �@�ToolTip �� .+��� ���� *DataItem.DraftStrategy.Note+.��]� -    ]�Name$ 	dockPanel��.+�4  .Infragistics.Windows.DataPresenter.XamDataGrid  -     Name$ grdData��$
��Left=�$	��Top=�$	��Top=�:  4Infragistics.Windows.DataPresenter.DataPresenterBase   SelectedDataItemsScope$ RecordsOnly=�$   IsSynchronizedWithCurrentItem .    ScrollingMode$ 	Immediate=����	#FFB4B1B1   GroupByAreaLocation$
 None=�   
DataSource �� *CurrentDraft.Players+���� *ActualWidth+ �� ElementName$ 	dockPanel�� �� Mode$ OneWay=����� *ActualHeight+$ 	dockPanel��$ OneWay=����� *
FontSize+$ PlayerListControl��  P� Property P� Value��%�   '��       �� " �� P�  �@��Orientation$ Vertical=�. ���  � ��$ 5����  � ��$ 1��P�  �@��Orientation$ 
Horizontal=�. ���  � ��$ 10����  � ��$ 1��   FieldSettings 6	  0Infragistics.Windows.DataPresenter.FieldSettings	   	  LabelPresenterStyle# [  	  AllowRecordFiltering�
 	 �Infragistics.Windows.Helpers.NullableConverter`1[[System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]$ False
  	  AllowGroupBy$ False
  	  	AllowEdit$ False
  	  CellClickAction$ SelectRecord=� 	  
CellHeight$ 30Q�  	  AllowResize$
  True
 !   FieldLayoutSettings! <  6Infragistics.Windows.DataPresenter.FieldLayoutSettings  "   HeaderLabelAreaStyle#" [  #   HighlightAlternateRecords$
# TrueY�$   AutoGenerateFields$$ FalseY�%   AllowAddNew$% FalseY�&   AllowDelete$& FalseY�'   FilterUIType$' FilterRecord=�(   AllowFieldMoving$( No=�)   RecordSelectorLocation$
) None=�*   AutoFitMode$* Always=�+   FieldLayouts+ 4  .Infragistics.Windows.DataPresenter.FieldLayout  -   grdFieldLayout��,   SortedFields, =  7Infragistics.Windows.DataPresenter.FieldSortDescription  -   	IsGroupBy- .  .   	Direction$. 
Descending=�/   	FieldName$/ Value��0   
FieldItems.0 .  (Infragistics.Windows.DataPresenter.Field  2  ,Infragistics.Windows.DataPresenter.FieldItem1   Name$1 
PlayerName��2   Label$2 Player Name��3   Width$	3 155X�4   CellValuePresenterStyle#4 [   $1 Position��$	2 Pos��$3 40X�#4 [ 5   LabelTextAlignment� 	 �Infragistics.Windows.Helpers.NullableConverter`1[[System.Windows.TextAlignment, PresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35]]$5 Center 
6   Tag$
6 Hide��  $1 TeamName��$2 #��$3 25X�7   
Visibility$7 	Collapsed=�#4 [ $5 Center $
6 Hide��8   BindingType$8 UseAlternateBinding=�9   AlternateBinding9 �� *PickedBy.UserName+  $
1 Team��$
2 Team��$3 45X�#4 [ $5 Center $
6 Hide��  $	1 Bye��$	2 Bye��$3 38X�#4 [ $5 Center $
6 Hide��  $
1 Rank��$	2 ADP��$3 50X�#4 [ $5 Center $
6 Hide��  $1 Value��$	2 Val��$3 50X�#4 [ $5 Center $
6 Hide��  $1 ScarcityPerc��$
2 PS %��$3 40X�:   Format$: ##��#4 [ $5 Center $
6 Hide��  $
1 Tier��$2 T��$3 30X�#4 [ $5 Center $
6 Hide��  $1 DraftStatus��$2 Status��$3 75X�#4 [ $5 Center $7 	Collapsed=�