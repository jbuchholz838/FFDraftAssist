   M S B A M L   `   `   `  ����H  DFFDraftAssist, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:FFDraftAssistFFDraftAssist  5          FFDraftAssist.PlayerList   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5      � �InfragisticsWPF4.Controls.Editors.XamComboEditor.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb� ~InfragisticsWPF4.Controls.Grids.XamSpreadsheet.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cbt pInfragisticsWPF4.Controls.Gauges.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cbd	 `InfragisticsWPF4.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cbp
 lInfragisticsWPF4.DataManager.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb� �InfragisticsWPF4.Controls.Layouts.XamTileManager.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb� �InfragisticsWPF4.Controls.Editors.XamMaskedInput.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cbi eInfragisticsWPF4.Undo.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb{ wInfragisticsWPF4.Controls.Menus.XamMenu.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb=ig$http://schemas.infragistics.com/xaml	    	 
     5      r nInfragisticsWPF4.DataPresenter.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb0igDP%http://infragistics.com/DataPresenter  5      +igDP1http://infragistics.com/Windows 	 5	      l hInfragisticsWPF4.Editors.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb/	igEditorshttp://infragistics.com/Editors  5
      #lclr-namespace:FFDraftAssist  5      -   5          >�Name$  PlayerListControl��5      $��14(�5       � 	Resources 5      *  $FFDraftAssist.NumberEvenOddConverter   EvenOddConvert;  5Infragistics.Windows.DataPresenter.CellValuePresenter �� 
TargetType �� Property �� Value;  5Infragistics.Windows.DataPresenter.DataRecordCellArea �� Triggers �� Binding �� RelativeSource �� Path	 �� 	Converter
 �� Value ^� 
Conditions �� Binding �� Value  LargeFieldText  CenterFieldText  CenterFieldTextBye  GridHeaderStyle8  2Infragistics.Windows.DataPresenter.HeaderLabelArea7  1Infragistics.Windows.DataPresenter.LabelPresenter  
LabelStyle<  6Infragistics.Windows.DataPresenter.DataRecordPresenter��%�  &	        '       '  �     7   &	 0    &	 Q    &	 �    &	 �    &	 ;    '  �      5   
   6#   �� 5   
   "  6   .�5      ��  � ��
 �  ��6+   �� 5       � �� 6,   Z� �� 5       � ��$ 0q�6'   �� 5       � ��$ 0q�6(   �� 5       � ��$ 0q�60   5      �� 5   
   "  6   .�5      ��  � �� 6+   Z� �� 5       �@ BackgroundHover 60   Z� �� 5       �@ BackgroundSelected 63   Z� �� 5       �@ BackgroundAlternate 64   Z� �� 5       �@ BackgroundActive 61   Z� �� 5        � �� 6,   Z� �� 5"       �@ BorderSelectedBrush �	#FF00E8FF64   �� 5#       �@ BorderActiveBrush �	#FF00E8FF62   �� 5$       �@ BorderHoverBrush �	#FF00E8FF61   �� 5%       � ��$ 3q�60    5'      �� 5(       6   ��  �� *Self+$ Record.DataItem.Tier�8	   
 Even6�   .a�5)      ��  � �� �	#FFD8D3D363   �� 5*       � �� �	#FFD8D3D364   �� 5+       � ��$ 0q�69   5,      �� 5-       6   ��  �� *Self+$! Record.DataItem.DraftStatus�
 Drafted6y   .a�5.      ��  � ��
 �  ��63   �� 50       �@ BackgroundSelected �	#FFF942426;   �� 51       �@ BackgroundAlternate
 �  ��6<   52      �� 53       6   ��  �� *Self+$! Record.DataItem.DraftStatus�
 	I Drafted6y   .a�54      ��  � �� �	#FF8747C763   �� 56       �@ BackgroundSelected �	#FFB278EC6;   �� 57       �@ BackgroundAlternate �	#FF8747C76<   �� 58       �@ BackgroundActive �	#FFB278EC69   59      �� 5:       6   ��  �� *Self+$" Record.DataItem.TopAvailable�
 True6z   .a�5;      ��  � �� �	#FFEBF33D63   �� 5<       �@ BackgroundHover �	#FFEBF33D68   �� 5=       �@ BackgroundSelected �	#FFF4FF006;   �� 5>       �@ BackgroundAlternate �	#FFEBF33D6<   �� 5?       �@ BackgroundActive �	#FFEBF33D69   5@      ^� 5A       5B      �� 5C       6$   ��  �� *Self+$* $Record.DataItem.DraftStrategy.Action�
 Ignore6�   �� 5D       6$   ��  �� *Self+$! Record.DataItem.DraftStatus� 	Available6   0�5F      �� 5G       � �� �	#FFFDA50A67   �� 5H       �@ BackgroundHover �	#FFFDA50A6<   �� 5I       �@ BackgroundSelected �	#FFFDA50A6?   �� 5J       �@ BackgroundAlternate �	#FFFDA50A6@   �� 5K       �@ BackgroundActive �	#FFFDA50A6=   5M      ^� 5N       5O      �� 5P       6$   ��  �� *Self+$* $Record.DataItem.DraftStrategy.Action�
 Target6�   �� 5Q       6$   ��  �� *Self+$! Record.DataItem.DraftStatus� 	Available6   0�5S      �� 5T       � �� �	#FF00FF6867   �� 5U       �@ BackgroundHover �	#FF00FF686<   �� 5V       �@ BackgroundSelected �	#FF00FF686?   �� 5W       �@ BackgroundAlternate �	#FF00FF686@   �� 5X       �@ BackgroundActive �	#FF00FF686=   5Z      5\      �� 5]   
   "  6   5_      �� 5`   
   "  6   .�5a      ��  � ��$ Center=�6;   5b      �� 5c   
   "  6    5d      ^� 5e       5f      �� 5g       6$   �� *DataItem.SharesBye+ True6K   �� 5h       6$   �� *DataItem.PickedBy+ 6J   Z� 0�5j      �� 5k       � ��
 � ���67   5m      .�5o      ��  � ��$ Center=�6;   5p      �� 5q   
   "  6(   .�5r      ��  � ��$
 Bold"�6+   �� 5s       � ��$ 0q�6'   5t      �� 5u   
   "  6   .�5v      ��  � ��$ 0q�6'   �� 5w       � ��$ 0q�6(   5x      �� 5y   
   "  6   .�5z      -   5        �� 5{       �@�ToolTip 5|      �� 5}      .+�5~      �� ��6$   �� *DataItem.DraftStrategy.Note+5      5�      5�      5�      .��5�      ]� -   5         ]�Name$ 	dockPanel��5�      .+�5�   
   4  .Infragistics.Windows.DataPresenter.XamDataGrid  -   5          Name$ grdData��5�      $
��Left=�6X   $	��Top=�6t   $	��Top=�6�   :  4Infragistics.Windows.DataPresenter.DataPresenterBase   SelectedDataItemsScope$ RecordsOnly=�5�      $   IsSynchronizedWithCurrentItem .    ScrollingMode$ 	Immediate=�6�   ���	#FFB4B1B1   GroupByAreaLocation$
 None=�5�   �      
DataSource 5�   ,   �� *CurrentDraft.Players+��5�      �� *ActualWidth+ �� ElementName$ 	dockPanel�� �� Mode$ OneWay=���6]   �� *ActualHeight+$ 	dockPanel��$ OneWay=���5�   f   �� *
FontSize+$ PlayerListControl�� 5�       P� Property P� Value��%K  '��       �� 5�      " ��6    5�      P� 5�       �@��Orientation$ Vertical=�69   . �5�      ��  � ��$ 5��66   �� 5�       � ��$ 1��69   5�      P� 5�       �@��Orientation$ 
Horizontal=�69   . �5�      ��  � ��$ 10��67   �� 5�       � ��$ 1��6:   5�      5�      5�         FieldSettings 5�      6	  0Infragistics.Windows.DataPresenter.FieldSettings	  5�       	  LabelPresenterStyle# [ 6%    	  AllowRecordFiltering�
 	 �Infragistics.Windows.Helpers.NullableConverter`1[[System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]$ False
 6W    	  AllowGroupBy$ False
 6t    	  	AllowEdit$ False
 6�    	  CellClickAction$ SelectRecord=�6�    	  
CellHeight$ 30Q�5�   %     	  AllowResize$
  True
 65   !   FieldLayoutSettings! 5�      <  6Infragistics.Windows.DataPresenter.FieldLayoutSettings  5�      "   HeaderLabelAreaStyle#" [ 6+    #   HighlightAlternateRecords$
# TrueY�6d   $   AutoGenerateFields$$ FalseY�6�   %   AllowAddNew$% FalseY�6�   &   AllowDelete$& FalseY�5�   +   '   FilterUIType$' FilterRecord=�6?   (   AllowFieldMoving$( No=�6[   )   RecordSelectorLocation$
) None=�6q   *   AutoFitMode$* Always=�6�   +   FieldLayouts+ 5�      4  .Infragistics.Windows.DataPresenter.FieldLayout  5�      -   5        grdFieldLayout��,   SortedFields, 5�      =  7Infragistics.Windows.DataPresenter.FieldSortDescription  5�      -   	IsGroupBy- .  .   	Direction$. 
Descending=�6G   /   	FieldName$/ Value��6^   0   
FieldItems.0 5�      .  (Infragistics.Windows.DataPresenter.Field  2  ,Infragistics.Windows.DataPresenter.FieldItem1   Name$1 
PlayerName��6"   2   Label$2 Player Name��64   3   Width$	3 155X�6H   4   CellValuePresenterStyle#4 [ 6T     5�      $1 Position��6"   $	2 Pos��62   $3 40X�6>   #4 [ 6I   5   LabelTextAlignment� 	 �Infragistics.Windows.Helpers.NullableConverter`1[[System.Windows.TextAlignment, PresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35]]$5 Center 6�   
6   Tag$
6 Hide��6�     5�      $1 TeamName��6"   $2 #��62   $3 25X�6<   7   
Visibility$7 	Collapsed=�6G   #4 [ 6^   $5 Center 6�   $
6 Hide��6�   8   BindingType$8 UseAlternateBinding=�6�   9   AlternateBinding9 6�   �� *PickedBy.UserName+6�     5�      $
1 Team��6"   $
2 Team��6.   $3 45X�6;   #4 [ 6F   $5 Center 6�   $
6 Hide��6�     5�      $	1 Bye��6"   $	2 Bye��6-   $3 38X�69   #4 [ 6D   $5 Center 6�   $
6 Hide��6�     5�      $
1 Rank��6"   $	2 ADP��6.   $3 50X�6:   #4 [ 6E   $5 Center 6�   $
6 Hide��6�     5�      $1 Value��6"   $	2 Val��6/   $3 50X�6;   #4 [ 6F   $5 Center 6�   $
6 Hide��6�     5�      $1 ScarcityPerc��6"   $
2 PS %��66   $3 40X�6C   :   Format$: ##��6N   #4 [ 6Z   $5 Center 6�   $
6 Hide��6�     5�      $
1 Tier��6"   $2 T��6.   $3 30X�68   #4 [ 6C   $5 Center 6~   $
6 Hide��6�     5�      $1 DraftStatus��6"   $2 Status��65   $3 75X�6D   #4 [ 6O   $5 Center 6�   $7 	Collapsed=�6�   5�      5�      5�      5�      