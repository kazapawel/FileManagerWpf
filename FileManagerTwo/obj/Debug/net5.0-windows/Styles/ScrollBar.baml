   M S B A M L   `   `   `  ����I  EFileManagerTwo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:FileManagerTwoFileManagerTwo  5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   ScrollBarThumb  �� 
TargetType �� Property �� Value �� 
TargetType ��Name J� SnapsToDevicePixels �� CornerRadius J� Opacity �� Triggers	 :� RoutedEvent	
 W� To g� Duration �� 
TargetName �� TargetProperty �� RelativeSource �Name �� Padding ]�Name J� IsMouseOver ]� DecreaseRepeatButton �� PageUpCommand ]� IncreaseRepeatButton �� PageDownCommand ]� Thumb �� Triggers P� Property P� Value �� PageLeftCommand �� PageRightCommand�� 5      F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml     5      &localclr-namespace:FileManagerTwo  5      %w  &	        '�� �    7   7   �� 5      "  n�6#   .�5   
   ��  �@�OverridesDefaultStyle$
 true��62   �� 5   
    � ��$ false��6&   �� 5	   
    � �� 5
      �� 5      " n�6"   .R�5      �� $ 	rectangle��6   $
 True��5   !   
�������$ 1��5   !   $	 0.3Q�5   !   
���� ��#��z��5   !   #��z��5   !    5      :� 5      $	 
MouseEnter��6'   .[�5      �� .��5   "   �� .��5   &   W� 
 166   $ 	0:0:0:0.1D�6=   $ 	rectangle��6R   $ Opacity�6t   5   #   5      5      :� 5      $	 
MouseLeave��6'   .[�5      �� .��5   "   �� .��5   &   W� 
 0.366   $ 	0:0:0:0.1D�6?   $ 	rectangle��6T   $ Opacity�6v   5    #   5!      5"      5%      5'      5(      �� 5+      "  ��6   .�5-   
   ��  �@��IsPressAndHoldEnabled$ false��69   �� 5.   
    �@��IsFlicksEnabled$ false��63   �� 5/   
    � ��$ 8��6"   �� 50   
    � ��$ 5,0,0,0q�6#   �� 51   
    � �� 6%   �� *Width+ �� *Self+�� 53   
    � �� 54      �� 55      " ��6"   .R�56      � $ Bg��6   $
 true��6'   
������ .+�59      �� $	 0,5q�6!   ._�5;      ]� $ 
PART_Track��6$   $
��true��5<   $   #{�z 5=   $   $��14��5>   $   $��Center=�5?   $   $��1��5@   $    5B   "   �� 5C   &   $ 0Q�63   #��Z 6?    5E   "   �� 5F   &   $ 0Q�63   #��Z 6?    5H   "   n� 5I   &   8��  6,   5K      5L      5N      5O      5Q       5S   
   P� 5T       �@��Orientation$ 
Horizontal=�6-   . �5U      ��  � ��$
 Auto��6*   �� 5V       � ��$ 0��6-   �� 5W       � ��$ 6��6+   �� 5X       � �� 6.   �� *Height+ �� *Self+�� 5Y       � ��$ 0 0 0 0q�6+   �� 5[       � �� 5\      �� 5]      " ��6*   .R�5^      � $ Bg��6#   $
 true��6/   .+�5_   "   ]� $ 
PART_Track��6(   #{�z 5`   %    5a   &   �� 5b   *   $ 0Q�67   #��Z 6C    5d   &   �� 5e   *   $ 0Q�67   #��Z 6C    5g   &   n� 5h   *   8�� 60   5j   #   5k      5l      5n      5o      5q      5}      