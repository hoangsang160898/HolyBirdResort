   M S B A M L   `   `   `  ����>  :GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GUIGUI  5          GUI.Employee_Payment   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      #localclr-namespace:GUI     5      W SMaterialDesignThemes.Wpf, Version=1.2.0.29218, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      -   5          N� Title$  Payment��5      .��5      � .+�5   
   ��  �� TextAlignment$ Center=�6   $
��Left=�6+   $	��Top=�6F   $��26(�6^   $
��Bold"�6l   $	��926��6~   $��0,20,0,0q�6�   Thống kê thiệt hại6�   �� 5   
   -   5        $��searchIdTeam_name��5       %  !MaterialDesignFloatingHintTextBox#��[  5      $
��Left=�6R   $	��Top=�6m   $	��186��6�   $��13(�6�   $��	25,73,0,0q�6�   ��5      �� *MaDoan+.��5   �   )  #MaterialDesignThemes.Wpf.HintAssist   Hint 5      �� 5       �� Orientation$ 
Horizontal=�5      $��-2 0 0 0q�5      .+�5      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=1.2.0.29218, Culture=neutral, PublicKeyToken=null]]   Kind$ Barcode=�5   %   �� 5      �� 5   *   $� Mã đoàn��6.   5      5      .��5   .   5      �� 5   
   -   5         �� 	IsDefault . ���#ffc107���#212529���#ffc107$��
216,79,0,0q�5   }   $��0q�6�   $��32��6�   $
��Left=�6�   $	��Top=�6�   .��5         $ Search=�6&   66   5!      �� 5"   
   -   5        $��exportBill_name��5"   #   {�.  $��	0,79,25,0q�6M   $��Right=�6`   $	��Top=�6|   .��5#      �� $ 
Horizontal=�6   .+�5$        $ TicketPercent=�6*   $��0q�6?   $��
0,0.25,5,0q�6K   $��Center=�6_   $��19��6|   �� 5%      Xuất hóa đơn6*   5&      5'      �� 5(   
   -   5         ��Name$ noTransaction��5(      $y�	Collapsed=�6+   $��Center=�6B   $	��Top=�6_   $��	0,162,0,0q�6w   20Không có cập nhật thiệt hại phù hợp6�   �� 5)   
   -   5         ��Name$ listDamages��5)   y   $��Hidden=�6   $��Hidden=�6G   $��
20,131,0,0q�6�   $
��Left=�6�   $	��Top=�6�   $	��378��6�   $	��881��6�   ��5*      �� 5+       �� DataType$ 
DamagesDTO��6   .R�5,      �� $ 
Horizontal=�6!   $
��Left=�6:   $	��Top=�6U   $	��865��6m   .+�5-      �� 	 �� 
IsReadOnly	 . #��[  5.      $
��Left=�6R   $	��Top=�6m   $	��270��6�   $��13(�6�   ��5-   #   �� *
Id_Phong+.��5.   �    5/      �� 50   "   $ 
Horizontal=�51      $��-2 0 0 0q�52      .+�53   &     $ ClipboardUser=�54   %   �� 55   &   �� 56   *   $� Mã phòng��6.   57   '   58   #   .��59   >   5:      �� 5;      #��[  5<      $
��Left=�6R   $	��Top=�6m   $	��320��6�   $��10,0,0,0q�6�   $��13(�6�   ��5;   "   �� *TaiSanThietHai+.��5<   �    5=      �� 5>   "   $ 
Horizontal=�5?      $��-2 0 0 0q�5@      .+�5A   &     $ Payment=�5B   %   �� 5C   &   �� 61   $� Tài sản thiệt hại��65   6R   5D   #   .��5E   >   5F      �� 5G      #��[  5H      $
��Left=�6R   $	��Top=�6m   $��10,0,0,0q�6�   $	��270��6�   $��13(�6�   ��5G   #   �� *ChiPhiDenBu+.��5H   �    5I      �� 5J   "   $ 
Horizontal=�5K      $��-2 0 0 0q�5L      .+�5M   &     $ ClipboardUser=�5N   %   �� 5O   &   �� 5P   *   $� Chi phí đền bù��6.   5Q   '   5R   #   .��5S   >   5T      5U      5V      5X      5Y      5Z      