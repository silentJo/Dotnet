   M S B A M L   `   `   `  ����?  ;Exo1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Exo1Exo1  5   	       Exo1.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:Exo1     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5	         
TitreStyle �� Property �� Value  
LabelStyle �� 
TargetType  ItemTemplate �� Orientation��%$  &	        &	 �     &	 �     �� 5
   
   .�5      ��  � ��$ 18(�6/   �� 5       � ��
 �   �62   �� 5       � ��$ 2q�66   5      �� 5   
   " ��6#   .�5      ��  � ��$ Courrier New)�6+   5      �� 5   
   .R�5      �� $ 
Horizontal=�6   $��0 5 0 5q�63   .+�5      �� $��50��6   $��50��6#   $
��Fill=�6/   $��Center=�6W   $��Center=�6r   ��6>   �� *Image+6r   �� 5      $��Center=�68   $��Center=�6S   ��6   �� *Description+6S   5      5      5      .��5      � .+�5   
   �� -   5         ��Name$ listBoxPhotos��5   U   $
��Left=�6   $��Stretch=�6-   $	��150��6I   #��[ 6�   ��6l   �� 6�   �� 5   
   -   5         ��Name$ Titre��5   Z   $��
Top Places��6   $��Center=�6%   $	��Top=�6B   #��[  6i   �� 5   
   -   5         ��Name$ image1��5      $	��Top=�6    $��0,50,0,0q�68   $
��Fill=�6J   $	��250��6Y   $	��250��6e   �� 5   
   -   5        $ Description��5      $
��Left=�6%   $��Description��6@   $��160,250,0,0q�6V   $��80��6k   $��25��6v   #��[ 6�   �� 5   
   -   5        $ 
UIRFichier��5      $
��Left=�6$   $��URI Fichier��6?   $��160,280,0,0q�6U   $��80��6j   $��25��6u   #��[ 6�   �� 5   
   -   5        $ NbVotes��5      $
��Left=�6!   $��nb votes��6<   $��160,310,0,0q�6O   $��80��6d   $��25��6o   #��[ 6{   �� 5    
   -   5        $ Description_value��5       $
��Left=�6+   $��240,250,0,0q�6�   $��25��6�   #��[ 6�   ��6F   �� 	 �� ElementName$	 listBoxPhotos��
 �� Path$
 SelectedItem.Description�6�   �� 5!   
   -   5        $ UIRFichier_value��5!      $
��Left=�6*   $��240,280,0,0q�6�   $��25��6�   #��[ 6�   ��6E   �� $	 listBoxPhotos��$
 SelectedItem.Uri�6�   �� 5"   
   -	   5        $ NbVotes_value��5"      $
��Left=�6'   $��240,310,0,0q�6�   $��25��6�   #��[ 6�   ��6B   �� $	 listBoxPhotos��$
 SelectedItem.NbVotes�6�   �� 5#   
   -
   5        $��30��5#      $��378,484,438,58q�6   .��5$      �� $ 
Horizontal=�6   $	��113��62   .+�5%      �� $��images\jaime.png��6   $��25��62   $��45��6>   $
��Left=�6I   �� 5&      $��Je vote pour��6   $��Center=�60   $��74��6K   5'      5(      5*      5+      