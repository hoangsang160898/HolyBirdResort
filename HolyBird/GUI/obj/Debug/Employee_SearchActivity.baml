   M S B A M L   `   `   `  ����>  :GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GUIGUI  5      !    GUI.Employee_SearchActivity   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      #localclr-namespace:GUI     5      W SMaterialDesignThemes.Wpf, Version=1.2.0.29218, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	      -   5          N� Title$  Search��5
      .��5      � .+�5   
   �� $��26(�6   $
��Bold"�6"   $
��Left=�64    �� TextAlignment$ Center=�6O   $	��Top=�6g   $	��926��6   $��0,10,0,0q�6�   Quản lí hoạt động6�   �� 5   
   -   5        $��acceptRoom_name��5      {�.  ���#28a745���#28a745$
��Left=�6x   $	��Top=�6�   $��
775,50,0,0q�6�   $��0q�6�   $	��126��6�   .��5      ��  �� Orientation$ 
Horizontal=�6   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=1.2.0.29218, Culture=neutral, PublicKeyToken=null]]   Kind$ CheckboxMarked=�6*   $��19��6@   $��19��6K   �� 5      $ Right=�6   $��82��62   Nhận Phòng6I   5      5      �� 5   
   -   5        $��cancelRoom_name��5      {�.  ���#dc3545���#dc3545$
��Left=�6x   $	��Top=�6�   $��
660,50,0,0q�6�   $	��110��6�   $��0q�6�   .��5      �� $ 
Horizontal=�6   .+�5        $ CloseBox=�6*   $��19��6:   $��19��6F   �� 5      $ Right=�6   $��73��62   Hủy Phòng6H   5      5      �� 5   
   -   5         ��Name$ 
noActivity��5   +   $y�	Collapsed=�6   $	��Top=�6?   $��Center=�6W   $��	0,110,0,0q�6t   Không có hoạt động6�   �� 5   
   -   5         ��Name$ listTransaction��5   �   $��Hidden=�6(   $��Hidden=�6Z   $��	20,87,0,0q�6�   $
��Left=�6�   $	��Top=�6�   $	��438��6�   $	��881��6�   ��5      �� 5       �� DataType$ ActivityDTO��6   .R�5      �� $ 
Horizontal=�6!   $
��Left=�6:   $	��Top=�6U   $	��865��6m   .+�5      ��  �� 
IsReadOnly .  %  !MaterialDesignFloatingHintTextBox#��[  5      $
��Left=�6X   $	��Top=�6s   $	��526��6�   $��13(�6�   ��5   #   �� *MaDoan+.��5   �   )  #MaterialDesignThemes.Wpf.HintAssist   Hint 5       �� 5!   "   $ 
Horizontal=�5"      $��-2 0 0 0q�5#      .+�5$   &     $ ClipboardUser=�5%   %   �� 5&   &   �� 5'   *   $� Mã đoàn��6.   5(   '   5)   #   .��5*   >   5+      �� 5,       . #��[  5-      $
��Left=�6X   $	��Top=�6s   $	��329��6�   $��10,0,0,0q�6�   $��13(�6�   ��5,   "   �� *	TrangThai+.��5-   �    5.      �� 5/   "   $ 
Horizontal=�50   %   $��-2 0 0 0q�51   %   .+�52   &     $ Payment=�53   %   �� 54   &   �� 61   $� Trạng Thái��65   6K   55   #   .��56   >   57      58      59      5;      5<      5=      