   M S B A M L   `   `   `  ����>  :GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GUIGUI  5   	       GUI.DashboardCustomer   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   W SMaterialDesignThemes.Wpf, Version=1.2.0.29218, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   localclr-namespace:GUI  5   	   -   5          � Icon$  images/g17176-512.png��5	   
    � 
ResizeMode$ CanMinimize=�5
       � Title$ HolyBird - Khách hàng��5   	   $	��576��6'   $	��992��64    � WindowStartupLocation$ CenterScreen=�6A    � 	Resources 5         OpenMenu �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value  	CloseMenu��%�  &	        &	 �     �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ GridMenu��6a   .\�5        $ 0��6'   $ 50Q�63     5      $ 0:0:0.5��6'   $	 180Q�69   5      5      �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ GridMenu��6a   .\�5        $ 0��6'   $	 180Q�63     5      $ 0:0:0.5��6'   $ 50Q�69   5      5      5      	 � Triggers	 5      :� 5   
   
 :� RoutedEvent$
 ButtonBase.Click��6    :� 
SourceName$ ButtonOpenMenu��66   .[�5      �� #��[  6   5      :� 5   
   $
 ButtonBase.Click��6   $ ButtonCloseMenu��66   .[�5       �� #��[ 6   5!      .��5#      � ���	#FFDEDEDE.+�5$   
   �� -   5         � Cursor$
 Hand��5$      $��
1415,3,5,0q�6    $	��Top=�64   $��18��6L   $��18��6X   $��0q�6c   $
��Bold"�6�    J� RenderTransformOrigin$ 0.6,0.3&�6�   ��6o   Z� ��5%      '  !MaterialDesignThemes.Wpf.PackIcon  5&      �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=1.2.0.29218, Culture=neutral, PublicKeyToken=null]]   Kind$ Close=�6*   $��12��67   $��12��6C   ��5(      �� 5)       �� 
TargetType" ��6   .�5*      ��  �� Property � �� �� Value �#e74c3c63   �� 5+       � �� �#e74c3c6E   �� 5,       � �� 5-      �� 5.       �� 
TargetType" ��6.   .R�5/   "   �� #��z��6)    �� CornerRadius$ 34��6S   ._�50   &   �� $��Center=�67   $��Center=�6T   51   #   52      54       �� Triggers 55      P� 56       P� Property �@J�IsMouseOver P� Value . . �57      ��  � �� �#e74c3c6;   �� 58       � �� �#fff6J   59      5;      5=      �� 5>   
   -   5        $
 Hand��5>      $
��Left=�6   $��
1392,3,0,0q�6:   $	��Top=�6N   $��18��6f   $��18��6q   $��0q�6}   $ 0.6,0.3&�6�   $
��Bold"�6�   ��6�   Z� ��5?        5@      $ WindowMinimize=�6*   $��12��6@   $��12��6L   ��5B      �� 5C      " ��6   .�5D      ��  � �� �#FEBC2B63   �� 5E       � �� �#FEBC2B6E   �� 5F       � �� 5G      �� 5H      " ��6.   .R�5I   "   �� #��z��6)   $ 34��6S   ._�5J   &   �� $��Center=�67   $��Center=�6T   5K   #   5M      5O       5P      P� 5Q       �@J�IsMouseOver . . �5R      ��  � �� �#FEBC2B6;   �� 5S       � �� �#fff6J   5T      5V      5X       � 5Y   
   -   5          �Name$ GridPrincipal��5Y   %   ���#f5f6fa$��55,5,5,5q�6<     � NavigationUIVisibility$ Hidden=�6N   � 5Z   
   -   5         �Name$ GridMenu��5Z      $��50��6!   $
��Left=�6,   ���#2980b9 J� Effect 5[      3  -System.Windows.Media.Effects.DropShadowEffect  5\         
BlurRadius$ 2Q�6#      ShadowDepth$ 1Q�62      Color$ 	#FFAEAEAE��6B   .+�5^      � .+�5_      � ���#2980b9$ 0.5,0.5&�6,   $��0,0,0,0q�6L   z�5`      V� 5a      .~�5b      �� �� 5c      �� 5d      T� 5e      5f      .+�5h      �� -   5         ��Name$ ButtonOpenMenu��5h      $��50��65   $��50��6A   $��Right=�6L   $	��Top=�6h    0 ,MaterialDesignFloatingActionMiniAccentButton#��[ 6�   
�������$ 
0.61,0.165&�6#  ��6�   Z� ��6�   Z� .��5i        ���#FFF$
 Menu=�6D   $��25��6P   $��25��6[   5j      �� 5k      -   5        $ ButtonCloseMenu��5k      $y�	Collapsed=�67   $��40��6N   $��40��6Z   $��5q�6e   $��Right=�6p   $	��Top=�6�   #��[ 6�   ���	#FF31577E��6�   Z� ��6   Z� .��5l        ���#FFF$ 	ArrowLeft=�6D   $��25��6U   $��25��6`   5m      5n      � 5o      -   5        $ 
GridCursor��5o      $��0,50,0,0q�6+   ���#e67e22$��5��6R   $
��Left=�6\   $��50��6w   $	��Top=�6�   �� 5p      -	   5         ��Name$ ListViewMenu��5p      ���	#FF5C99D6$��Disabled=�6H     �� SelectedIndex$  0��6�   $��0,50,0,0q�6�   .@�5q      �� -
   5        ! ��Name$! ItemHome��5q   #   $��50��65   .��5r      �� " �� Orientation$" 
Horizontal=�6%   .+�5s        $ FeatureSearch=�66   $��25��6K   $��25��6W   ���#fff$��5q�6t   �� 5t      $��Chọn Phòng��6(   $��Center=�6:   ���#fff$��5q�6g   $��12(�6r   $
��Bold"�6�   5u      5v      �� 5w      $��50��6#   .��5x      �� $" 
Horizontal=�6%   .+�5y        $ Hotel=�66   $��25��6C   ���#fff$��25��6b   $��5q�6m   �� 5z      $��Đặt Phòng��6(   $��Center=�69   ���#fff$��5q�6f   $��12(�6r   $
��Bold"�6�   5{      5|      �� 5}      $��50��6#   .��5~      �� $" 
Horizontal=�6%   .+�5        $ ViewList=�66   $��25��6F   ���#fff$��25��6d   $��5q�6o   �� 5�      $��
Chi Tiết��6(   $��Center=�68   ���#fff$��5q�6e   $��12(�6q   $
��Bold"�6   5�      5�      5�      5�      5�      5�      5�      