   M S B A M L   `   `   `  ����>  :GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GUIGUI  5   	       GUI.DashboardEmployee   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   W SMaterialDesignThemes.Wpf, Version=1.2.0.29218, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   localclr-namespace:GUI  5   	     � Icon$  images/g17176-512.png��5	   
    � 
ResizeMode$ CanMinimize=�5
       � Title$ HolyBird - Nhân viên��5   	   $	��576��6&   $	��992��63    � WindowStartupLocation$ CenterScreen=�6@    � 	Resources 5         OpenMenu �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value  	CloseMenu��%�  &	        &	 �     �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ GridMenu��6a   .\�5        $ 0��6'   $ 50Q�63     5      $ 0:0:0.5��6'   $	 180Q�69   5      5      �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ GridMenu��6a   .\�5        $ 0��6'   $	 180Q�63     5      $ 0:0:0.5��6'   $ 50Q�69   5      5      5      	 � Triggers	 5      :� 5   
   
 :� RoutedEvent$
 ButtonBase.Click��6    :� 
SourceName$ ButtonOpenMenu��66   .[�5      �� #��[  6   5      :� 5   
   $
 ButtonBase.Click��6   $ ButtonCloseMenu��66   .[�5      �� #��[ 6   5       .��5"      � ���	#FFDEDEDE.+�5#   
   �� -   5         � Cursor$
 Hand��5#      $��
1415,3,5,0q�6    $	��Top=�64   $��18��6L   $��18��6X   $��0q�6c   $
��Bold"�6�    J� RenderTransformOrigin$ 0.6,0.3&�6�   ��6o   Z� ��5$      '  !MaterialDesignThemes.Wpf.PackIcon  5%      �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=1.2.0.29218, Culture=neutral, PublicKeyToken=null]]   Kind$ Close=�6*   $��12��67   $��12��6C   ��5'      �� 5(       �� 
TargetType" ��6   .�5)      ��  �� Property � �� �� Value �#e74c3c63   �� 5*       � �� �#e74c3c6E   �� 5+       � �� 5,      �� 5-       �� 
TargetType" ��6.   .R�5.   "   �� #��z��6)    �� CornerRadius$ 34��6S   ._�5/   &   �� $��Center=�67   $��Center=�6T   50   #   51      53       �� Triggers 54      P� 55       P� Property �@J�IsMouseOver P� Value . . �56      ��  � �� �#e74c3c6;   �� 57       � �� �#fff6J   58      5:      5<      �� 5=   
   -   5        $
 Hand��5=      $
��Left=�6   $��
1392,3,0,0q�6:   $	��Top=�6N   $��18��6f   $��18��6q   $��0q�6}   $ 0.6,0.3&�6�   $
��Bold"�6�   ��6�   Z� ��5>        5?      $ WindowMinimize=�6*   $��12��6@   $��12��6L   ��5A      �� 5B      " ��6   .�5C      ��  � �� �#FEBC2B63   �� 5D       � �� �#FEBC2B6E   �� 5E       � �� 5F      �� 5G      " ��6.   .R�5H   "   �� #��z��6)   $ 34��6S   ._�5I   &   �� $��Center=�67   $��Center=�6T   5J   #   5L      5N       5O      P� 5P       �@J�IsMouseOver . . �5Q      ��  � �� �#FEBC2B6;   �� 5R       � �� �#fff6J   5S      5U      5W       � 5X   
   -   5          �Name$ GridPrincipal��5X   %   ���#f5f6fa$��55,5,5,5q�6<     � NavigationUIVisibility$ Hidden=�6N   � 5Y   
   -   5         �Name$ GridMenu��5Y      $��50��6!   $
��Left=�6,   ���#2980b9 J� Effect 5Z      3  -System.Windows.Media.Effects.DropShadowEffect  5[         
BlurRadius$ 2Q�6#      ShadowDepth$ 1Q�62      Color$ 	#FFAEAEAE��6B   .+�5]      � .+�5^      � ���#2980b9$ 0.5,0.5&�6,   $��0,0,0,0q�6L   z�5_      V� 5`      .~�5a      �� �� 5b      �� 5c      T� 5d      5e      .+�5g      �� -   5         ��Name$ ButtonOpenMenu��5g       K� ZIndex$ 2��65   $��50��6F   $��50��6R   $��Right=�6]   $	��Top=�6y    0 ,MaterialDesignFloatingActionMiniAccentButton#��[ 6�   
�������$ 
0.61,0.165&�64  ��6�   Z� ��6�   Z� .��5h        ���#fff$
 Menu=�6D   $��25��6P   $��25��6[   5i      �� 5j      -   5        $ ButtonCloseMenu��5j      $y�	Collapsed=�67   $��40��6N   $��40��6Z   $��5q�6e   $��Right=�6p   $	��Top=�6�   #��[ 6�   ���	#FF31577E��6�   Z� ��6   Z� .��5k        ���#FFF$ 	ArrowLeft=�6D   $��25��6U   $��25��6`   5l      5m      � 5n      -   5        $ 
GridCursor��5n      $��0,50,0,0q�6+   ���#e67e22$��5��6R   $
��Left=�6\   $��50��6w   $	��Top=�6�   �� 5o      -   5          ��Name$  ListViewMenu��5o      ���	#FF5C99D6$��Disabled=�6H   ! �� SelectedIndex$! 0��6�   $��0,50,0,0q�6�   .@�5p      �� -	   5        " ��Name$" ItemHome��5p   #   $��50��65   .��5q      �� # �� Orientation$# 
Horizontal=�6%   .+�5r        $ AccountMultiplePlus=�66   $��25��6Q   $��25��6]   ���#fff$��5q�6z   �� 5s      $��Tạo tài khoản��6(   $��Center=�6=   ���#fff$��5q�6j   $��12(�6u   $
��Bold"�6�   5t      5u      �� 5v      $��50��6#   .��5w      �� $# 
Horizontal=�6%   .+�5x        $
 Coin=�66   $��25��6B   ���#fff$��25��6a   $��5q�6l   �� 5y      $��Thanh toán��6(   $��Center=�6:   ���#fff$��5q�6g   $��12(�6s   $
��Bold"�6�   5z      5{      �� 5|      $��50��6#   .��5}      �� $# 
Horizontal=�6%   .+�5~        $ EventSearch=�66   $��25��6I   ���#fff$��25��6g   $��5q�6r   �� 5      $��	Tra cứu��6(   $��Center=�67   ���#fff$��5q�6d   $��12(�6p   $
��Bold"�6~   5�      5�      5�      5�      5�      5�      5�      