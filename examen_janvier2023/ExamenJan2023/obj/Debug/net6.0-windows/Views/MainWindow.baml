   M S B A M L   `   `   `  ����H  DExamenJan2023, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:ExamenJan2023ExamenJan2023  5   	       ExamenJan2023.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:ExamenJan2023     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5	         listTemplate��%�   &	        �� 5
   
   .R�5      �� $��0 5 0 5q�6   .+�5      �� $
��Left=�66   $��Center=�6Q   ��6   �� *	ProductId+6Q   �� 5      $��Right=�68   $��Center=�6T   ��6   �� *ProductName+6T   5      5      5      .��5      � $��20q�6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� -   5         ��Name$ productComboBox��5      #��[  5      $��10q�5       ��5      �� *ProductsList+ �� SelectedItem 5      �� *SelectedProduct+5       � 5!   
   $��1��6   $��0��6   $��10q�6,    � DataContext 68   �� *SelectedItem+ �� ElementName$ productComboBox�� 5"      �� 5#      $
��Auto �6#   �� 5$      $
��Auto �6#    5&      �� 5'      $
��Auto �6    �� 5(      $
��Auto �6    �� 5)      $
��Auto �6    �� 5*      $
��Auto �6    .+�5,      �� $��	ProductID��6   $��0��6)   $��0��66   $	��0,5q�6F   �� 5-      $��0��63   $��1��6@   $	��0,5q�6P   ��6   �� *	ProductId+6P   �� 5.      $��ProductName��6   $��1��6+   $��0��68   $	��0,5q�6H   �� 5/      $��1��65   $��1��6B   $	��0,5q�6R   ��6   �� *ProductName+6R   �� 50      $��Category��6   $��2��6(   $��0��65   $	��0,5q�6E   �� 51      $��2��62   $��1��6?   $	��0,5q�6O   ��6   �� *
Category+6O   �� 52      $��Supplier��6   $��3��6(   $��0��65   $	��0,5q�6E   �� 53      $��3��62   $��1��6?   $	��0,5q�6O   ��6   �� *
Supplier+6O   54      � 56   
   $��2��6   $��0��6   $��10q�6,   .+�57      �� $)��#Abandonner le produit sélectionné��6   $��10q�6A   ��6M   �� *RemoveCommand+58      � 59   
   $��0��6   $��3��6   $��1��6-   $��10q�6=    5:      �� 5;      $
��Auto �6    �� 5<      $
��Auto �6    .+�5>      �� $E��?Nombre de Produits par Pays ayant été vendu au moins une fois��6   $��Center=�6]   $��0,0,0,10q�6z   &   System.Windows.Controls.DataGrid  5?         AutoGenerateColumns$ False��6   	   CanUserAddRows$	 False��6]   $��1��6t   ��63   �� *ProductsByCountry+
   Columns
 5@      0  *System.Windows.Controls.DataGridTextColumn  5A      ,  &System.Windows.Controls.DataGridColumn   Header$ Country��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6:   �� *	Country+  5B      $ Nb��6)    65   �� *ProductCount+  5C      $  ��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 63   5E      5F      5H      5I      