   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5   	    FFDraftAssist   FFDraftAssist.DraftSetup   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	   l hInfragisticsWPF4.Editors.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb,Customhttp://infragistics.com/Editors  5   	   r nInfragisticsWPF4.DataPresenter.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb0igDP%http://infragistics.com/DataPresenter  68     � Title$  
DraftSetup��5   	   $	��389��6   $	��571��6)    � WindowStartupLocation$ CenterScreen=�65   .��5      �� .+�5	   
   �� -   5         ��Name$ lblDraftName��5	      $��
Draft Name��6&    �� Left$ 25��6;   
 �� Top$ 31��6L   $
��Bold"�6\   0  *Infragistics.Windows.Editors.XamTextEditor  5
   
   -   5          Name$ txtDraftName��5
      $	 106��65   $��0q�6G   $ 35��6R   $	��447��6b   1  +Infragistics.Windows.Editors.TextEditorBase   NullText$ 	New Draft��6n   .  (Infragistics.Windows.Editors.ValueEditor   Value 6�   �� *	DraftName+�� 5   
   -   5        $ lblDraftType��5      $��
Draft Type��6&   $ 31��6;   $ 62��6L   $
��Bold"�6\   �� 5   
   -   5         ��Name$ cboDraftType��5      $	��120��6)   $	 106��65   $ 66��6G   	 �� Text	 6W   �� *	DraftType+.@�5      �� $��Snake��6   �� 5      $��Linear��6   5      �� 5   
   -   5        $ lblNumRounds��5      $��
Num Rounds��6&   $ 18��6;   $ 93��6L   $
��Bold"�6\   3  -Infragistics.Windows.Editors.XamNumericEditor  5   
   -   5        
  Name$
 txtNumRounds��5   "   $	 106��68   $��0q�6J   $ 97��6U   $	��120��6e      	ValueType" ��6�    6q   �� *DraftRounds+6�   4  .Infragistics.Windows.DataPresenter.XamDataGrid  5   
   -   5          Name$ grdTeams��5      $	 240��6-   $ 66��6?   $	��249��6O   $	��313��6\   :  4Infragistics.Windows.DataPresenter.DataPresenterBase   
DataSource 6h   �� *Teams+   FieldSettings 5      6  0Infragistics.Windows.DataPresenter.FieldSettings  5         AllowRecordFilteringd `InfragisticsWPF4.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb�  �Infragistics.Windows.Helpers.NullableConverter`1[[System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]$ False 6%      	AllowEdit$
 True 6B      CellClickAction$ SelectRecord=�6S      FieldLayoutSettings 5      <	  6Infragistics.Windows.DataPresenter.FieldLayoutSettings	  5        	  HighlightAlternateRecords$
 TrueY�6+    	  AutoGenerateFields$ FalseY�6L    	  AllowAddNew$
 TrueY�6g    	  AllowDelete$
 TrueY�6z    	  FilterUIType$ FilterRecord=�6�    	  AllowFieldMoving$ No=�6�    	  AddNewRecordLocation$ OnBottom=�6�      FieldLayouts 5      4
  .Infragistics.Windows.DataPresenter.FieldLayout
  5      -   5        grdFieldLayout�� 
  
FieldItems. 5      .  (Infragistics.Windows.DataPresenter.Field  2  ,Infragistics.Windows.DataPresenter.FieldItem   Name$ 	PickOrder��6"      Label$
 Pick��63      Width$ 45X�6@     5      $ TeamName��6"   $ 	Team Name��62   $	 150X�6D     5      $ UserName��6"   $ Manager Name��62   $ 75X�6G   5       5"      �� 5$   
   -	   5         ��Name$ btnStart��5$      $��Start Draft��6#   $
��Left=�69   $	��Top=�6T   $��80��6l   $	 240��6�   $	 328��6�   �� 5%   
   -
   5        $ btnLUM��5%      $��	LUM Draft��6!   $
��Left=�65   $	��Top=�6P   $��80��6h   $ 10��6s   $	 293��6�   $��55��6�   �� 5&   
   -   5        $ 
btnVampire��5&      $��Vampire Draft��6%   $
��Left=�6=   $	��Top=�6X   $��80��6p   $	 132��6{   $	 293��6�   $��55��6�   �� 5'   
   -   5        $ 
btnSchutte��5'      $��Schutte Draft��6%   $
��Left=�6=   $	��Top=�6X   $��80��6p   $ 26��6{   $	 278��6�   $y�	Collapsed=�6�   5)      5*      