   M S B A M L   `   `   `  ����>  :13B, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:_13B_13B  5   	       _13B.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:_13B     5   	   -   5        $��window��5   	     � Title$  
MainWindow��6   $	��450��6*   $	��800��67    � 	Resources 5	         validationTemplate  textBoxInError �� 
TargetType �� Triggers P� Property P� Value �� Property �� Value �� RelativeSource	 �� Path��%q  &	        &	 r     �� 5
   
   .R�5      ]� .+�5      �� �� 5      
���  ��$��20(�6-   !6>   5      5      �� 5   
   " ��6'    5      P� 5       �@=�HasError . . �5      ��  � ��
 �  ��63   �� 5       �@�ToolTip 60   ��  �� *Self+$&	  (Validation.Errors)/ErrorContent�5      5      5      .��5      ]� $��3q�6   .+�5   
   � $	��Top=�6   
 � RowDefinitions
 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6     � ColumnDefinitions 5!      �� 5"      $
��Auto �6#   �� 5#      .+�5&      �� -   5        $��count_textBox��5&      $��0��6+   $��0��68    =� ErrorTemplate# [  6H   #��[ 5'      $	��3 0q�5(      $	��100��6#   $
��Left=�6/   .��6J   ��5)      �� 5*       �� ElementName$ window��6   $	 Count�63    �� UpdateSourceTrigger$ PropertyChanged=�6@    �� ValidationRules 5+         _13B.TrolleyCountRule  5,      
   Min$ 2��65   
   Max$ 60��6=   5.      .��5/       50      �� 52      -   5        $��	ok_button��52      $��1��6&   $��0��63   $��3q�6C   $	��100��6N   $
��Left=�6Z   $��Подтвердить��6u   ��53      �� 54      " ��6   .�55      ��  � {� .  66    56      �� 57       �� Binding 6*   �� $	 (Validation.HasError)�$ count_textBox�� �� Value	 False6t   .a�58   "   ��  � {� . 6>   59      5;      5=      �� 5?      -   5        $��start_label��5?      $��2��6'   $��1��68   $��3q�6H   $��20(�6S   5@      � 5B   
   -   5        $��trolleys_wrapPanel��5B      $	��Top=�6.    � Orientation$ 
Horizontal=�6C    � 
ItemHeight$ 50��6\    � 	ItemWidth$ 50��6l    5C      ��%w   '��       �� 5D      " ��6   .�5E      ��  � ��$ 3q�6/   �� 5F       � ��
 � � �63   5G      5H      5I      �� 5K   
   -   5        $��log_textBox��5K       �� 
IsReadOnly . " �� VerticalScrollBarVisibility$ Visible=�67   $ �� HorizontalScrollBarVisibility$ Disabled=�6]    �� TextWrapping$
 Wrap=�6�    �� AcceptsReturn . 6�   5L      5M      