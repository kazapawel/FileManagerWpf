   M S B A M L   `   `   `  ����I  EFileManagerTwo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:FileManagerTwoFileManagerTwo  5      -    'FileManagerTwo.FileBrowserModuleControl   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:FileManagerTwo     5      .��5
      �� -   5          ��Name$  FileBrowserBorder��5
      $��0q�5      $��5,1,5,1q�5      ._�5   
   �  � RowDefinitions 5      �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $��* �6    �� 5      $
��auto �6    .+�5(      �� -   5         ��Name$ 
drivesList��5)      $��0��5(         DrivesListboxStyle#��[  5*        DrivesItemStyle#��[ 5-      ��5+      �� *Drives+ �� SelectedItem 5,      �� *SelectedDrive+ �� Mode$ TwoWay=�5-      �� 51      $��1��6   .+�53      ��   InfoTextblock#��[ 6   ��54      �� *SelectedDrive.CombineInfo+� 57       � Orientation$ 
Horizontal=�6   $��Stretch=�58      $	��100��59      $��5q�5:      $��3��5;       � Value 5<      �� *SelectedDrive.Percentage+$ OneWay=�5>      �� 5E      $��2��6   #��[ 5F      $��14(�5H      $��2q�5I      ��5G      �� *" SelectedDrive.Directory.FullPath+5I      �� 5M      -   5        $ activeDirectoryListbox��5N      $��3��5M         DirectoryDisplayListboxStyle#��[ 5O      ��5P      �� *SelectedDrive.Directory.Items+ 5Q      �� *&$SelectedDrive.Directory.SelectedItem+��5S      �� 5T       �� 
TargetType" ��6    �� Triggers 5W      ]� 5X      	 ]� 
Conditions	 5Y   "   �� 5Z   &   
 �� Property
 �@��
IsSelected �� Value$
 True��6F   ./�5]   "   ��  �� Property � �� �� Value
 ��ح�6?   �� 5^   "    � ��
 �  ��6?   5_      ]� 5a      	 5b   "   �� 5c   &   
 �@��
IsSelected$ False��6F   ./�5f   "   ��  � ��  ForegroundTestBrush# [ 6?   5g      �� 5j       �� Binding 6*   �� *
IsHidden+ �� Value true6G   .a�5k   "   ��  � ��  ForegroundDarkBrush# [ 6?   5l      .�5p      ��  � �� 5q      �� 5r   "   .R�5s   &   �� $  border��6-   #��z��5t   -   $��0q�5u   -   #��z��5v   -   ._�5w   *   $   FileManagerTwo.FileItemControl  5x   '   5y   #   5{      -   5        5}       � ContextMenu 5�      �� 5�      $��1q�6"   
���  ��  BackgroundDarkBrush#��[ 5�   "   @�5�      m� 5�        BaseMenuItem#��[ 6'     RedPastelBrush#��[ 5�   '    m� Command 5�   '   �� *DoubleClickItemCommand+��5�   "   �� 5�   &    	 ContextmenuTextblock#��[	 60   $
��Open��5�   0   5�      m� 5�      #��[ 6'   #��[ 5�   '    5�   '   �� *CopyItemCommand+��5�   "   �� 5�   &   #��[	 60   $
��Copy��5�   0   5�      m� 5�      #��[ 6'   #��[ 5�   '    5�   '   �� *DeleteItemCommand+��5�   "   �� 5�   &   #��[	 60   $��Delete��5�   0   5�      m� 5�      #��[ 6'   #��[ 5�   '    5�   '   �� *CutItemCommand+��5�   "   �� 5�   &   #��[	 60   $	��Cut��5�   0   5�      5�      5�      �� 5�      $��4��6   ._�5�      �  � ColumnDefinitions 5�      �� 5�      $��* �6+   �� 5�      $
��auto �6+   .+�5�      �� $��0��6     
 InfoTextblock2#��[
 5�       ��5�       �� *+)SelectedDrive.Directory.SelectedItem.Name+�� 5�      $��1��6    #��[
 5�       ��5�       �� *31SelectedDrive.Directory.SelectedItem.CreationTime+5�      5�      5�      5�      5�      