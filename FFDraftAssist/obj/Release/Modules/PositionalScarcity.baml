   M S B A M L   `   `   `  ���� H  DFFDraftAssist, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:FFDraftAssistFFDraftAssist  &     FFDraftAssist.PositionalScarcity   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     -localclr-namespace:FFDraftAssist     � �InfragisticsWPF4.Controls.Editors.XamComboEditor.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb� ~InfragisticsWPF4.Controls.Grids.XamSpreadsheet.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cbt pInfragisticsWPF4.Controls.Gauges.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cbd `InfragisticsWPF4.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cbp	 lInfragisticsWPF4.DataManager.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb�
 �InfragisticsWPF4.Controls.Layouts.XamTileManager.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb� �InfragisticsWPF4.Controls.Editors.XamMaskedInput.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cbi eInfragisticsWPF4.Undo.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb{ wInfragisticsWPF4.Controls.Menus.XamMenu.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb=ig$http://schemas.infragistics.com/xaml	     	 
      � 	Resources  1  +Infragistics.Controls.Gauges.XamRadialGauge �� 
TargetType �� Property �� Value��%  '        �� "  .���  �@ NeedleShape$ Needle=���  �@ BackingStrokeThickness$ 2Q���  �@ ScaleStartExtent$
 0.45Q���  �@ ScaleEndExtent$
 0.52Q���  �@ TickStartExtent$
 0.45Q���  �@ TickEndExtent$
 0.52Q���  �@ TickStrokeThickness$ 1Q���  �@ MinorTickStartExtent$
 0.45Q���  �@ MinorTickEndExtent$
 0.50Q���   �@ MinorTickStrokeThickness$ 0Q���  �@ BackingOuterExtent$
 0.90Q���  �@ LabelExtent$
 0.70Q�.��]� .+��� $��Positional Scarcity��$	��Top=�$��20(�$
��Bold"�$��Center=�$��Center=�$��0,0,0,1q�
���   ��  � ColumnDefinitions �� $��* ��� $��* ��� $��* ��� $��* �.+�  -     Name$ QBGauge��$��0��   Value �� *CurrentDraft.QBScarcity+   Ranges 6  0Infragistics.Controls.Gauges.XamRadialGaugeRange     
StartValue$ 75Q�	   EndValue$		 100Q�
   Brush
 �	#FF17FF00  $ 50Q�$	 75Q�
 �	#FFE8FF00  $ 25Q�$	 50Q�
 �	#FFFF9700  $ 0Q�$	 25Q�

 �  ��  -   $ RBGauge��$��1�� �� *CurrentDraft.RBScarcity+   $ 75Q�$		 100Q�
 �	#FF17FF00  $ 50Q�$	 75Q�
 �	#FFE8FF00  $ 25Q�$	 50Q�
 �	#FFFF9700  $ 0Q�$	 25Q�

 �  ��  -   $ WRGauge��$��2�� �� *CurrentDraft.WRScarcity+   $ 75Q�$		 100Q�
 �	#FF17FF00  $ 50Q�$	 75Q�
 �	#FFE8FF00  $ 25Q�$	 50Q�
 �	#FFFF9700  $ 0Q�$	 25Q�

 �  ��  -   $ TEGauge��$��3�� �� *CurrentDraft.TEScarcity+   $ 75Q�$		 100Q�
 �	#FF17FF00  $ 50Q�$	 75Q�
 �	#FFE8FF00  $ 25Q�$	 50Q�
 �	#FFFF9700  $ 0Q�$	 25Q�

 �  ���� $��0��$��0��$��QB��$��Bottom=�$��Center=�$��0,0,0,10q�$
��Bold"��� $��0��$��1��$��RB��$��Bottom=�$��Center=�$��0,0,0,10q�$
��Bold"��� $��0��$��2��$��WR��$��Bottom=�$��Center=�$��0,0,0,10q�$
��Bold"��� $��0��$��3��$��TE��$��Bottom=�$��Center=�$��0,0,0,10q�$
��Bold"�