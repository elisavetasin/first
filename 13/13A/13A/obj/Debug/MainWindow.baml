   M S B A M L   `   `   `  ����>  :13A, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:_13A_13A  5   	       _13A.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:_13A     5   	     � Title$  
MainWindow��5   	   $	��150��6   $	��300��6)    � 	Resources 5	      "   _13A.DateMultiValueConverter   DateConverter��%   &	          5
   
   6(   5      .��5      � $��Center=�6    5   
    �� 
TargetType �� Property �� Value��%v   '��       �� 5      " ��6   .�5      ��  � ��$ 3q�6+   �� 5       � ��$	 100��6*   5      5       � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5       � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      .+�5   
   �� $��0��6   $��0��6   $��	День:��6-   �� 5    
   -   5        $��day_textBox��5    /   $��0��6   $��1��6   6/   �� 5"   
   $��1��6   $��0��6   $��Месяц:��6-   �� 5#   
   -   5        $��month_textBox��5#   /   $��1��6   $��1��6   6/   �� 5%   
   $��2��6   $��0��6   $��Год:��6-   �� 5&   
   -   5        $��year_textBox��5&   /   $��2��6   $��1��6   6/   (  "System.Windows.Controls.DatePicker  5(   
   -   5        $��
datePicker��5(      $��3��6'   $��2��64   $��Center=�6H   $��Center=�6e      SelectedDate 5)      `� 5*       `� 	Converter# [  6   .1�5+      �� 	 �� Path$
	 Text�6   
 �� ElementName$
 day_textBox��6*   �� 5,      $
	 Text�6   $
 month_textBox��6*   �� 5-      $
	 Text�6   $
 year_textBox��6*   5.      50      51      52      