   M S B A M L   `   `   `  ����I  EFileManagerTwo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:FileManagerTwoFileManagerTwo  5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089  �� 
TargetType   BaseEmptyButtonStyle'   !System.Windows.Shell.WindowChrome �� Property �� Value �� 
TargetType  SystemIconButtonTextblock �� BasedOn ��Name �� Padding ��Name  BasicTextblock �� RelativeSource	 �� Triggers
 P� Property P� Value �� 
TargetName �� Path :� RoutedEvent �� 
TargetName �� TargetProperty	 W� To g� Duration  SystemIconButton ��Name J� RenderTransformOrigin �� BitmapScalingMode �� EdgeMode �� ScaleX �� ScaleY �� Angle�� 5      F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml     5      &localclr-namespace:FileManagerTwo  5      %�  &	        &	 B    7   7  &	 �    7   �� 5      "  ��6   .�5   
   ��   �@  IsHitTestVisibleInChrome$
 True��6B   �� 5   
    � ��
 ���� 6'   �� 5	   
    � ��$ 0q�6,   �� 5
   
    �@�UseLayoutRounding$
 True��6.   �� 5   
    � �� 5      �� 5      " ��6"   .R�5      �� 5      5      5      �� 5      "  ��6   8   .�5   
   ��  � ��$ 0q�6#   �� 5   
    �@J�Opacity$	 0.8Q�6$   �� 5   
    � ��$ 30��6#   �� 5   
    � ��$ 45��6"   �� 5   
    � ��
 �  ��6'   �� 5   
    � �� 5      �� 5      " ��6"   .R�5       �� $ ImageBorder��6   $ 5q�5!      #��z��5"      #��z��5#      
������ ._�5'      �� $ 
ButtonText��6$   8�� $��14(�5)   $   
�������$��Center=�5+   $   $��Center=�5,   $   ��5-   $   �� *Tag+ �� *TemplatedParent+5/      	 52      P� 54      
 �@J�IsMouseOver$
 True��69   . �55      �� $ ImageBorder��56   %    57   %   ��  �� *TemplatedParent+$ 
Background� � ���� 58       �@J�Opacity$ 1Q�68   59      :� 5<      $ 
MouseEnter��6'   .[�5=      �� .��5>   "   �� .��5?   &   W� $ 
ButtonText��66   $ FontSize�6Y    226~   $ 	0:0:0:0.1D�6�   5@   #   5A      5B      :� 5D      $ 
MouseLeave��6'   .[�5E      �� .��5F   "   �� .��5G   &   W� $ 
ButtonText��66   $ FontSize�6Y    166~   $ 	0:0:0:0.1D�6�   5H   #   5I      5J      5N      5P      5Q      �� 5T      "  ��6   8   .�5U   
   ��  � ��$ 0q�6#   �� 5V   
    �@J�Opacity$	 0.8Q�6$   �� 5W   
    � ��$ 30��6#   �� 5X   
    � ��$ 45��6"   �� 5Y   
    � ��
 �  ��6'   �� 5Z   
    � �� 5[      �� 5\      " ��6"   .R�5_      �� $ ImageBorder��6   $ 5q�5`      #��z��5a      #��z��5b      
������ ._�5f      �� $ ImageButton��6    $ .5,.5&�5i       $��Center=�5j       $��Center=�5k       $ HighQuality=�5l       $	��140��5m       $ Aliased=�5n       ��5g       �� *Tag+ �� *TemplatedParent+z�5p      V� 5q   "   .~�5r   &   �� 
ImageScale��$	 1.3Q�6I   $	 1.3Q�6V   �� 5s   &   ImageRotate��$ 0Q�6K   5t   #   5w      5y      	 5|      P� 5~      
 �@J�IsMouseOver$
 True��69   . �5      �� $ ImageBorder��5�   %    5�   %   ��  �� *TemplatedParent+$ 
Background� � ���� 5�       �@J�Opacity$ 1Q�68   5�      :� 5�      $ 
MouseEnter��6'   .[�5�      �� .��5�   "   �� .��5�   &   W� $ 
ImageScale��66   $ (ScaleTransform.ScaleX)�6Y    1.56�   $ 	0:0:0:0.1D�6�   W� 5�   &   $ 
ImageScale��66   $ (ScaleTransform.ScaleY)�6Y    1.56�   $ 	0:0:0:0.1D�6�   5�   #   5�      5�      :� 5�      $ 
MouseLeave��6'   .[�5�      �� .��5�   "   �� .��5�   &   W� $ 
ImageScale��66   $ (ScaleTransform.ScaleX)�6Y    1.36�   $ 	0:0:0:0.1D�6�   W� 5�   &   $ 
ImageScale��66   $ (ScaleTransform.ScaleY)�6Y    1.36�   $ 	0:0:0:0.1D�6�   W� 5�   &   $ ImageRotate��66   $ (RotateTransform.Angle)�6Z    06�   $ 	0:0:0:0.1D�6�   5�   #   5�      5�      5�      5�      5�      5�      