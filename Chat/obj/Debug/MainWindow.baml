   M S B A M L   `   `   `  ����?  ;Chat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ChatChat  5   	       Chat.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:Chat     5   	   -   5          � Title$  Чат��5   	   $��381.5��6   $	��451��6$   ���	#FF153B61 � 
ResizeMode$ NoResize=�6G    � WindowStyle$
 None=�5	   
    � WindowStartupLocation$ CenterScreen=�6    � 	Resources 5       �� 
TargetType   CloseButton �� Property �� Value �� 
TargetType	 ��Name
 J� SnapsToDevicePixels ��Name �� ContentStringFormat �� ContentStringFormat'  !System.Windows.VisualStateManager   VisualStateGroups%  System.Windows.VisualStateGroup   Name   States   System.Windows.VisualState   Name   
Storyboard �� 
TargetName �� TargetProperty	 W� To g� Duration �� Triggers :� RoutedEvent	 �� To P� Property P� Value �� 
TargetName  MinimizeButton  NormalBrush �� 
StartPoint �� EndPoint � Color  � Offset  HorizontalNormalBrush  
LightBrush  HorizontalLightBrush  	DarkBrush  PressedBrush  NormalBorderBrush 	 HorizontalNormalBorderBrush 
 DefaultedBorderBrush  PressedBorderBrush! �� CornerRadius��%�  &	        &	 �    &	 9    &	 �    &	 �    &	 7    &	 �    &	 �    &	 �    &		 9    &	
 �    &	 �    '�� 7    7  7  7 
 7 
 7  7  7  �� 5   
   " ��6   .�5      ��  � �� �	#FF153B616+   �� 5       � ��
 �����6+   �� 5       � ��$	 ✕��6(   �� 5       � ��$ 12(�6)   �� 5       � ��$ 20��6&   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $	 border��6!   ���	#FF153B61#��z��6I   #��z��6}   
 . ._�5      �� $ contentPresenter��6/   #��z��6I   #��z��6}   # z 6�   |�.  #��z��6�   #��z��62  ��. #
 z
 6p  #��z��6�   5        5   "   $ CommonStates��63   . 5   &     $ Disabled��62   . 5   *   �� .��5   .   W� $ border��6>   $ Opacity�6]   $
 0.56X�6�   $ 0:0:0.3D�6�   5   +   5   '     5   &   $ Normal��62   . 5   *   �� .��5    .   W� $ border��6>   $ Opacity�6]   $ 1X�6�   $ 0:0:0.3D�6�   5!   +   5"   '   5#   #   5%       5&      :� 5'      $ Button.MouseEnter��6+   .[�5(   "   �� .��5)   &   �� .��5*   *   �� $ 	#FFB41515X�69   $ border��6H   $ Background.Color�6g   $ 0:0:0.2D�6�   5+   '   5,   #   5-      :� 5.      $ Button.MouseLeave��6+   .[�5/   "   �� .��50   &   �� .��51   *   �� $ 	#FF153B61X�69   $ border��6H   $ Background.Color�6g   $ 0:0:0.2D�6�   52   '   53   #   54      P� 55       � �� . . �56   "   �� $ border��6?    � �� �#4c75a36S   57      59      5;      5<      �� 5=   
   " ��6   .�5>      ��  � �� �	#FF153B616+   �� 5?       � ��
 �����6+   �� 5@       � ��$	 ―��6(   �� 5A       � ��$ 12(�6)   �� 5B       � ��$ 20��6&   �� 5C       � �� 5D      �� 5E      " ��6&   .R�5F      �� $	 border��6!   ���	#FF153B61#��z��6I   #��z��6}   
 . ._�5G      �� $ contentPresenter��6/   #��z��6I   #��z��6}   # z 6�   |�.  #��z��6�   #��z��62  ��. #
 z
 6p  #��z��6�   5H        5I   "   $ CommonStates��63   . 5J   &     $ Disabled��62   . 5K   *   �� .��5L   .   W� $ border��6>   $ Opacity�6]   $
 0.56X�6�   $ 0:0:0.3D�6�   5M   +   5N   '     5O   &   $ Normal��62   . 5P   *   �� .��5Q   .   W� $ border��6>   $ Opacity�6]   $ 1X�6�   $ 0:0:0.3D�6�   5R   +   5S   '   5T   #   5V       5W      :� 5X      $ Button.MouseEnter��6+   .[�5Y   "   �� .��5Z   &   �� .��5[   *   �� $
 GrayX�69   $ border��6C   $ Background.Color�6b   $ 0:0:0.2D�6�   5\   '   5]   #   5^      :� 5_      $ Button.MouseLeave��6+   .[�5`   "   �� .��5a   &   �� .��5b   *   �� $ 	#FF153B61X�69   $ border��6H   $ Background.Color�6g   $ 0:0:0.2D�6�   5c   '   5d   #   5e      P� 5f       � �� . . �5g   "   �� $ border��6?    � ��
 �����6S   5h      5j      5l      5m      �� 5n   
   $	 0,0&�62   $	 0,1&�6C   ��5p      � � 5q      $
 #FFF��6#   $	  0.0Q�60   � 5r      $
 #CCC��6#   $	  1.0Q�60   5s      5u      �� 5v   
   $	 0,0&�6<   $	 1,0&�6M   ��5x      � � 5y      $
 #FFF��6#   $	  0.0Q�60   � 5z      $
 #CCC��6#   $	  1.0Q�60   5{      5}      �� 5~   
   $	 0,0&�61   $	 0,1&�6B   ��5�      � � 5�      $
 #FFF��6#   $	  0.0Q�60   � 5�      $
 #EEE��6#   $	  1.0Q�60   5�      5�      �� 5�   
   $	 0,0&�6;   $	 1,0&�6L   ��5�      � � 5�      $
 #FFF��6#   $	  0.0Q�60   � 5�      $
 #EEE��6#   $	  1.0Q�60   5�      5�      �� 5�   
   $	 0,0&�60   $	 0,1&�6A   ��5�      � � 5�      $
 #FFF��6#   $	  0.0Q�60   � 5�      $
 #AAA��6#   $	  1.0Q�60   5�      5�      �� 5�   
   $	 0,0&�63   $	 0,1&�6D   ��5�      � � 5�      $
 #BBB��6#   $	  0.0Q�60   � 5�      $
 #EEE��6#   $	  0.1Q�60   � 5�      $
 #EEE��6#   $	  0.9Q�60   � 5�      $
 #FFF��6#   $	  1.0Q�60   5�      5�      �� 5�   
   $	 0,0&�68   $	 0,1&�6I   ��5�      � � 5�      $
 #CCC��6#   $	  0.0Q�60   � 5�      $
 #444��6#   $	  1.0Q�60   5�      5�      �� 5�   
   $	 0,0&�6B   $	 1,0&�6S   ��5�      � � 5�      $
 #CCC��6#   $	  0.0Q�60   � 5�      $
 #444��6#   $	  1.0Q�60   5�      5�      �� 5�   
   $	 0,0&�6;   $	 0,1&�6L   ��5�      � � 5�      $
 #777��6#   $	  0.0Q�60   � 5�      $
 #000��6#   $	  1.0Q�60   5�      5�      �� 5�   
   $	 0,0&�69   $	 0,1&�6J   ��5�      � � 5�      $
 #444��6#   $	  0.0Q�60   � 5�      $
 #888��6#   $	  1.0Q�60   5�      5�      �� 5�   
   " ��6   .�5�      ��  �@J�SnapsToDevicePixels . 64   �� 5�       �@�OverridesDefaultStyle . 66   �� 5�       � ��$ 23��6*   �� 5�       � ��$ 75��6)   �� 5�       � �� 5�      �� 5�      " ��6&   .R�5�      �� $	 Border��5�      $! 8��5�      $��1q�5�      8��  8�� ._�5�      �� $��2q�5�      $��Center=�5�      $��Center=�5�      ��. 5�      5�       5�      P� 5�       �@J�IsKeyboardFocused . . �5�   "   �� $ Border��6)   8   � ��6T   5�      P� 5�       �@��IsDefaulted . . �5�   "   �� $ Border��6)   8   � ��6T   5�      P� 5�       �@J�IsMouseOver . . �5�   "   �� $ Border��6)   8   � ��6S   5�      P� 5�       � �� . . �5�   "   �� $ Border��6)   8   � ��6S   �� 5�   "   $ Border��6)   8   � ��6T   5�      5�      5�      5�      5�      .��5�      � " � RowDefinitions" 5�   
   �� 5�      $��22 �6   �� 5�      $��* �6   �� 5�      $��5 �6   �� 5�      $��60 �6   �� 5�      $��40 �6   .+�5�   
   � $��0��6   $��1��6   # � ColumnDefinitions# 5�      �� 5�      $��10 �6#   �� 5�      $��* �6#   �� 5�      $��10 �6#   .+�5�      �� -   5        $ ��Name$$ Scroll��5�      $��1��6+   
������ $
��Auto=�5�      .��5�      �� -   5        % ��Name$% ChatText��5�      $��1��6,   $��20(�5�      & �� TextWrapping$
& Wrap=�5�      ' �� 
IsReadOnly' . 5�      5     5     � 5  
   $��1��6   $��3��6   # 5     �� 5     $��10 �6#   �� 5     $��* �6#   �� 5     $��10 �6#   .+�5
     �� -   5        $% MessageText��5
     $��1��6+   $��20(�6;   $
& Wrap=�5     "( �� VerticalScrollBarVisibility$
( Auto=�6*   5     � 5  
   $��1��6   $��4��6   # 5     �� 5     $��10 �6#   �� 5     $��* �6#   �� 5     $��10 �6#   .+�5     �� -   5        ) ��Name$) 
SendButton��5     $��1��6)   * �� 	IsDefault* . $��Отправить��5     $	��120��5     $��30��5     $��0,5,0,5q�5     $��Right=�5     61   5     � 5  
   $��22��6   $	��Top=�6   $��1��63   $��0��6C   .+�5     �� -   5        #��[  5     $��Right=�6:   6V   �� 5      -   5        #��[ 5      $��0,0,20,0q�6=   $��Right=�6O   6k   �� 5!     -   5        + ��Name$+ Nickname��5!     
���2͚�$��10(�6?   $
��Left=�6M   $	��Top=�6h   $��5,0,0,0q�6�   5"     5$     5%     