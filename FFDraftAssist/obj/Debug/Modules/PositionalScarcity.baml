   M S B A M L   `   `   `  ����H  DFFDraftAssist, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:FFDraftAssistFFDraftAssist  5      &     FFDraftAssist.PositionalScarcity   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:FFDraftAssist     5      � �InfragisticsWPF4.Controls.Editors.XamComboEditor.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb� ~InfragisticsWPF4.Controls.Grids.XamSpreadsheet.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cbt pInfragisticsWPF4.Controls.Gauges.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cbd `InfragisticsWPF4.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cbp	 lInfragisticsWPF4.DataManager.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb�
 �InfragisticsWPF4.Controls.Layouts.XamTileManager.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb� �InfragisticsWPF4.Controls.Editors.XamMaskedInput.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cbi eInfragisticsWPF4.Undo.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb{ wInfragisticsWPF4.Controls.Menus.XamMenu.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb=ig$http://schemas.infragistics.com/xaml	     	 
    5        � 	Resources  5
      1  +Infragistics.Controls.Gauges.XamRadialGauge �� 
TargetType �� Property �� Value��%�  '        �� 5   
   "  6   .�5      ��  �@ NeedleShape$ Needle=�6,   �� 5       �@ BackingStrokeThickness$ 2Q�67   �� 5       �@ ScaleStartExtent$
 0.45Q�61   �� 5       �@ ScaleEndExtent$
 0.52Q�6/   �� 5       �@ TickStartExtent$
 0.45Q�60   �� 5       �@ TickEndExtent$
 0.52Q�6.   �� 5       �@ TickStrokeThickness$ 1Q�64   �� 5       �@ MinorTickStartExtent$
 0.45Q�65   �� 5       �@ MinorTickEndExtent$
 0.50Q�63   �� 5        �@ MinorTickStrokeThickness$ 0Q�69   �� 5       �@ BackingOuterExtent$
 0.90Q�63   �� 5       �@ LabelExtent$
 0.70Q�6,   5      5      .��5      ]� .+�5   
   �� $��Positional Scarcity��6   $	��Top=�6.   $��20(�6C   $
��Bold"�6Q   $��Center=�6c   $��Center=�6�   $��0,0,0,1q�6�   
���   �6�   � 5   
    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��* �6#   �� 5       $��* �6#   �� 5!      $��* �6#   .+�5#        -   5          Name$ QBGauge��5#       $��0��61      Value 6A   �� *CurrentDraft.QBScarcity+   Ranges 5%      6  0Infragistics.Controls.Gauges.XamRadialGaugeRange     
StartValue$ 75Q�6-   	   EndValue$		 100Q�6=   
   Brush
 �	#FF17FF006L     5&      $ 50Q�6-   $	 75Q�6=   
 �	#FFE8FF006K     5'      $ 25Q�6-   $	 50Q�6=   
 �	#FFFF97006K     5(      $ 0Q�6-   $	 25Q�6<   

 �  ��6J   5*        5+      -   5        $ RBGauge��5+       $��1��61    6A   �� *CurrentDraft.RBScarcity+ 5-        $ 75Q�6-   $		 100Q�6=   
 �	#FF17FF006L     5.      $ 50Q�6-   $	 75Q�6=   
 �	#FFE8FF006K     5/      $ 25Q�6-   $	 50Q�6=   
 �	#FFFF97006K     50      $ 0Q�6-   $	 25Q�6<   

 �  ��6J   52        53      -   5        $ WRGauge��53       $��2��61    6A   �� *CurrentDraft.WRScarcity+ 55        $ 75Q�6-   $		 100Q�6=   
 �	#FF17FF006L     56      $ 50Q�6-   $	 75Q�6=   
 �	#FFE8FF006K     57      $ 25Q�6-   $	 50Q�6=   
 �	#FFFF97006K     58      $ 0Q�6-   $	 25Q�6<   

 �  ��6J   5:        5;      -   5        $ TEGauge��5;       $��3��61    6A   �� *CurrentDraft.TEScarcity+ 5=        $ 75Q�6-   $		 100Q�6=   
 �	#FF17FF006L     5>      $ 50Q�6-   $	 75Q�6=   
 �	#FFE8FF006K     5?      $ 25Q�6-   $	 50Q�6=   
 �	#FFFF97006K     5@      $ 0Q�6-   $	 25Q�6<   

 �  ��6J   5B      �� 5C      $��0��6   $��0��6!   $��QB��61   $��Bottom=�6>   $��Center=�6Y   $��0,0,0,10q�6v   $
��Bold"�6�   �� 5D      $��0��6   $��1��6!   $��RB��61   $��Bottom=�6>   $��Center=�6Y   $��0,0,0,10q�6v   $
��Bold"�6�   �� 5E      $��0��6   $��2��6!   $��WR��61   $��Bottom=�6>   $��Center=�6Y   $��0,0,0,10q�6v   $
��Bold"�6�   �� 5F      $��0��6   $��3��6!   $��TE��61   $��Bottom=�6>   $��Center=�6Y   $��0,0,0,10q�6v   $
��Bold"�6�   5G      5H      5I      