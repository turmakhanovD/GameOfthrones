   M S B A M L   `   `   `  ����H  DGameOfThrones, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:GameOfThronesGameOfThrones  5   	       GameOfThrones.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:GameOfThrones     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   
     � Title$  Game of thrones helper��5   	   $	��450��6(   $	��800��65      MaterialDesignBody#���   5
      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5      .��5      � -   5        $��GridWeb��5      $��1��6   #��� ��6=    � RowDefinitions 5   
   �� 5       � ColumnDefinitions 5   
   �� 5      $
��271* �6   �� 5      $��521*  �6   .+�5   
   #  MaterialDesignThemes.Wpf.Card  $��32q�6   $��	16,6,16,0q�6+   $��41��6>   ���	#FF1B19196J   �� 5   
   $��Имя:��6   $
��Left=�6   $��	28,21,0,0q�6:   $	��Top=�6M   ���	#DDFFFFFF6e   �� 5   
   -   5         ��Name$ search��5      $
��Left=�6"   $��23��6=   $��	71,21,0,0q�6I    �� TextWrapping$
 Wrap=�6\   $�� ��6p   $	��Top=�6x   $	��166��6�   ���	#DDFFFFFF �� 
CaretBrush
 ����� �� SelectionBrush
 �����6�   7  1System.Windows.Forms.Integration.WindowsFormsHost  5   
   -   5        	  Name$
	 host��5      $��1��6)   �� 5   
   -   5        
 ��Name$
 characterList��5      $��16,52,16,10q�6)   ���	#FF1B1919���	#DDFFFFFF6l   5       5!      