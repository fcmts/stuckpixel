   M S B A M L   `   `   `  ���� E  Astuckpixel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:stuckpixel
stuckpixel      stuckpixel.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:stuckpixel       � Title$  WPF Keyboard Events�� +� FocusedElement ��  �� ElementName$ MyCanvas��.���� -   $��MyCanvas��|�. 
���   � � FocusVisualStyle Z� .+��� -   $
��rec1��$��1��$��1��$��0q� �� Left$ 0��
 �� Top$ 0������  �� Color$
 Blue�� � Triggers :�  :� RoutedEvent$ Loaded��.[���    AnimateFlicker#��[  �� -   $��text01��$��Center=�$��26��$��Center=�	 �� TextWrapping$
	 Wrap=�$ 12��$��78��$��0q�
���   �
�������|�.  .�� :� $ TextBox.TextChanged��.[��� .���� .��W� 
 g� 	BeginTime$
 0:0:0X� g� Duration$ 0:0:1D� W� From$	 0.0X� �� TargetProperty$ Opacity�	 W� To$	 1.0X�W� $
 0:0:1X�$ 0:0:1D�$	 1.0X�$ Opacity�$	 0.0X�.��