   M S B A M L   `   `   `  ����>  :GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GUIGUI  5          GUI.Customer_OrderRoom   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      #localclr-namespace:GUI     5      W SMaterialDesignThemes.Wpf, Version=1.2.0.29218, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	      -   5          N� Title$  	OrderRoom��5
      .��5      � .+�5   
   �� -   5        ���#28a745���#28a745$��Right=�5   P   $	��Top=�6l   $��	0,20,25,0q�6�   .��6�   Đặt phòng6�   �� 5   
   -   5         ��Name$ noRoomReserved��5   +   $y�	Collapsed=�6   $��Center=�6C   $	��Top=�6`   $��0,90,0,0q�6x   #!Không có phòng được chọn6�   �� 5   
   -   5         ��Name$ listRoomChoosen��5   �   $��Hidden=�6,   $��Hidden=�6`   $��	20,70,0,0q�6�   $
��Left=�6�   $	��Top=�6�   $	��161��6�   $	��881��6�   ��5      �� 5       �� DataType$ RoomDTO��6   .R�5      ��  �� Orientation$ 
Horizontal=�6!   $
��Left=�6:   $	��Top=�6U   $	��865��6m   .+�5      ��  �� 
IsReadOnly .  %  !MaterialDesignFloatingHintTextBox#��[  5      $
��Left=�6R   $	��Top=�6m   $	��210��6�   $��13(�6�   ��5   #   �� *Id+.��5   �   )  #MaterialDesignThemes.Wpf.HintAssist   Hint 5      �� 5   "   $ 
Horizontal=�5      $��-2 0 0 0q�5      .+�5   &   '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=1.2.0.29218, Culture=neutral, PublicKeyToken=null]]   Kind$ ClipboardUser=�5   %   �� 5   &   �� 5   *   $� Mã phòng��6.   5   '   5   #   .��5   >   5       �� 5!       . #��[  5"      $
��Left=�6R   $	��Top=�6m   $	��210��6�   $��10,0,0,0q�6�   $��13(�6�   ��5!   "   �� *	HangPhong+.��5"   �    5#      �� 5$   "   $ 
Horizontal=�5%      $��-2 0 0 0q�5&      .+�5'   &     $ Payment=�5(   %   �� 5)   &   �� 61   $� Hạng phòng��65   6K   5*   #   .��5+   >   5,      �� 5-       . #��[  5.      $
��Left=�6R   $	��Top=�6m   $	��210��6�   $��10,0,0,0q�6�   $��13(�6�   ��5-   "   �� *SoTang+.��5.   �    5/      �� 50   "   $ 
Horizontal=�51      $��-2 0 0 0q�52      .+�53   &     $ Payment=�54   %   �� 55   &   �� 61   $� Tầng��65   6E   56   #   .��57   >   58      �� 59       . #��[  5:      $
��Left=�6R   $	��Top=�6m   $	��220��6�   $��10,0,0,0q�6�   $��13(�6�   ��59   "   �� *
HinhThuc+.��5:   �    5;      �� 5<   "   $ 
Horizontal=�5=      $��-2 0 0 0q�5>      .+�5?   &     $ Payment=�5@   %   �� 5A   &   �� 61   $� Hình thức��65   6J   5B   #   .��5C   >   5D      5E      5F      5H      �� 5I   
   -   5        $��
listMember��5K      $ 	Họ tên��5L       �� 
IsEditable .  	 �� DisplayMemberPath$	 HoTen��5N      
 �� SelectedValuePath$
 Id��5O       & "MaterialDesignFloatingHintComboBox#��[ 5P      $
��Left=�6I   $	��Top=�6d   $��
26,242,0,0q�6|   $	��160��6�   5Q      �� 5R   
   -   5         ��Name$ addPersonToRoom_name��5R      {�.  ���#ffc107���#ffc107���#212529$
��Left=�6�   $	��Top=�6�   $��194,250,0,0q�6�   .��5S        $ ArrowDropDownCircle=�6&   5T      �� 5U   
   -   5        $ removePerSonInRoom_name��5U      {�.  ���#dc3545���#dc3545���#fff$
��Left=�6�   $	��Top=�6�   $��247,250,0,0q�6�   $��0q�6�   $��32��6�   .��5V        $ RemoveCircle=�6&   5W      �� 5X   
   -   5        $ noRoomOrdered��5X   ,   $y�	Collapsed=�6   $��Center=�6C   $��Bottom=�6`   $��	0,0,0,195q�6{   )'Không có phòng được đặt chỗ6�   �� 5Y   
   -	   5        $ listRoomOrdered��5Y   �   $��Hidden=�63   $��Hidden=�6g   $��
20,298,0,0q�6�   $
��Left=�6�   $	��Top=�6�   $	��219��6�   $	��881��6  ��5Z      �� 5[      $ DetailReservedDTO��6   .R�5\      �� $ 
Horizontal=�6!   $
��Left=�6:   $	��Top=�6U   $	��865��6m   .+�5]      ��  . #��[  5^      $
��Left=�6R   $	��Top=�6m   $	��430��6�   $��13(�6�   ��5]   #   �� *HoTen+.��5^   �    5_      �� 5`   "   $ 
Horizontal=�5a      $��-2 0 0 0q�5b      .+�5c   &     $ ClipboardUser=�5d   %   �� 5e   &   �� 5f   *   $�
 Họ tên��6.   5g   '   5h   #   .��5i   >   5j      �� 5k       . #��[  5l      $
��Left=�6R   $	��Top=�6m   $	��430��6�   $��10,0,0,0q�6�   $��13(�6�   ��5k   "   �� *	MaPhong+.��5l   �    5m      �� 5n   "   $ 
Horizontal=�5o      $��-2 0 0 0q�5p      .+�5q   &     $ Payment=�5r   %   �� 5s   &   �� 61   $� Mã phòng��65   6I   5t   #   .��5u   >   5v      5w      5x      5z      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  5{   
   -
   5        $��alert_success��5{   E   $y�	Collapsed=�6.   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 6Z   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromRight+   Duration$ 0:0:0.4X�.��5|      �� ���#f6ffed �� CornerRadius$ 4��6*   ���#b7eb8f$��1q�6R   $��Right=�6f   $	��Top=�6�   $��	0,15,20,0q�6�   ._�5}      �� $ 
Horizontal=�6   $��Right=�67   $	��Top=�6S   $��40��6k   $	��210��6w   .+�5~        ���#52c41a$ CommentTick=�6C   $��30��6V   $��24��6b   $��18,5,7,5q�6m   �� 5      $��13(�6    $
��Left=�6.   $��Center=�6I   $��18��6d   $��	0,10,0,12q�6p   ���	#D8000000Đặt chỗ thành công6�   5�      5�      5�        5�   
   -   5        $��alert_error��5�   .   $y�	Collapsed=�6A    6X     *SlideInFromRight+$ 0:0:0.4X�.��5�      �� ���#fff1f0$ 4��6*   ���#ffa39e$��1q�6Q   $��Right=�6e   $	��Top=�6�   $��	0,15,21,0q�6�   ._�5�      �� $ 
Horizontal=�6   $��Right=�67   $	��Top=�6S   $��40��6k   $	��187��6w   .+�5�        ���#f5222d$ CommentRemove=�6C   $��30��6X   $��24��6d   $��16,5,7,5q�6o   �� 5�      $��13(�6    $
��Left=�6.   $��Center=�6I   $��18��6d   $��	0,10,0,12q�6p   ���	#D8000000Đặt chỗ thất bại6�   5�      5�      5�      5�      5�      