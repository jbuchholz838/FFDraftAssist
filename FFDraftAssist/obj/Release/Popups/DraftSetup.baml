   M S B A M L   `   `   `  ���� O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem   FFDraftAssist   FFDraftAssist.DraftSetup   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     6sys&clr-namespace:System;assembly=mscorlib     l hInfragisticsWPF4.Editors.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb,Customhttp://infragistics.com/Editors  r nInfragisticsWPF4.DataPresenter.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb0igDP%http://infragistics.com/DataPresenter    � Title$  
DraftSetup��$	��389��$	��571�� � WindowStartupLocation$ CenterScreen=�.���� .+��� -    ��Name$ lblDraftName��$��
Draft Name�� �� Left$ 25��
 �� Top$ 31��$
��Bold"�0  *Infragistics.Windows.Editors.XamTextEditor  -     Name$ txtDraftName��$	 106��$��0q�$ 35��$	��447��1  +Infragistics.Windows.Editors.TextEditorBase   NullText$ 	New Draft��.  (Infragistics.Windows.Editors.ValueEditor   Value �� *	DraftName+�� -   $ lblDraftType��$��
Draft Type��$ 31��$ 62��$
��Bold"��� -    ��Name$ cboDraftType��$	��120��$	 106��$ 66��	 �� Text	 �� *	DraftType+.@��� $��Snake���� $��Linear���� -   $ lblNumRounds��$��
Num Rounds��$ 18��$ 93��$
��Bold"�3  -Infragistics.Windows.Editors.XamNumericEditor  -   
  Name$
 txtNumRounds��$	 106��$��0q�$ 97��$	��120��   	ValueType" �� �� *DraftRounds+4  .Infragistics.Windows.DataPresenter.XamDataGrid  -     Name$ grdTeams��$	 240��$ 66��$	��249��$	��313��:  4Infragistics.Windows.DataPresenter.DataPresenterBase   
DataSource �� *Teams+   FieldSettings 6  0Infragistics.Windows.DataPresenter.FieldSettings     AllowRecordFilteringd `InfragisticsWPF4.v19.1, Version=19.1.20191.392, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb�  �Infragistics.Windows.Helpers.NullableConverter`1[[System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]$ False    	AllowEdit$
 True    CellClickAction$ SelectRecord=�   FieldLayoutSettings <	  6Infragistics.Windows.DataPresenter.FieldLayoutSettings	    	  HighlightAlternateRecords$
 TrueY� 	  AutoGenerateFields$ FalseY� 	  AllowAddNew$
 TrueY� 	  AllowDelete$
 TrueY� 	  FilterUIType$ FilterRecord=� 	  AllowFieldMoving$ No=� 	  AddNewRecordLocation$ OnBottom=�   FieldLayouts 4
  .Infragistics.Windows.DataPresenter.FieldLayout
  -   grdFieldLayout�� 
  
FieldItems. .  (Infragistics.Windows.DataPresenter.Field  2  ,Infragistics.Windows.DataPresenter.FieldItem   Name$ 	PickOrder��   Label$
 Pick��   Width$ 45X�  $ TeamName��$ 	Team Name��$	 150X�  $ UserName��$ Manager Name��$ 75X��� -	    ��Name$ btnStart��$��Start Draft��$
��Left=�$	��Top=�$��80��$	 240��$	 328���� -
   $ btnLUM��$��	LUM Draft��$
��Left=�$	��Top=�$��80��$ 10��$	 293��$��55���� -   $ 
btnVampire��$��Vampire Draft��$
��Left=�$	��Top=�$��80��$	 132��$	 293��$��55���� -   $ 
btnSchutte��$��Schutte Draft��$
��Left=�$	��Top=�$��80��$ 26��$	 278��$y�	Collapsed=�