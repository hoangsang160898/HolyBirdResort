   M S B A M L   `   `   `  ����>  :GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GUIGUI  5           GUI.Employee_CreateAccount   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      #localclr-namespace:GUI     5      W SMaterialDesignThemes.Wpf, Version=1.2.0.29218, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$  CreateAccount��5
      .��5      � $
��Left=�6   $	��926��6&   $	��536��62   .+�5   
   �� $
��Left=�6   $	��Top=�6/   $��
58,122,0,0q�6G   ���#dc3545$
��Bold"�6p   FDLưu ý: Họ và tên là mật khẩu, CMND là tên đăng nhập6�   �� 5   
   -   5        $��MaDoan_name��5      )  #MaterialDesignThemes.Wpf.HintAssist   
Foreground
 � � � %  !MaterialDesignFloatingHintTextBox#��[  5      $
��Left=�6L   $	��Top=�6g   $	��122��6   $��13(�6�   $��
360,10,0,0q�6�   .��6�      Hint 5      �� 5       �� Orientation$ 
Horizontal=�5      $��-2 0 0 0q�5      .+�5      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=1.2.0.29218, Culture=neutral, PublicKeyToken=null]]   Kind$ Barcode=�6.   �� 5      �� 6!   $� Mã đoàn��6%   68   5      .��5   .   5      (  "System.Windows.Controls.DatePicker  5   
   -   5        $��NgayBatDau_name��5      $ Ngày bắt đầu��5       ( $MaterialDesignFloatingHintDatePicker#��[ 5      $��13(�5      $
��Left=�5       $	��Top=�5!      $��
517,10,0,0q�6%   $	��176��69     5"   
   -   5        $��NgayKetThuc_name��5#      $ Ngày kết thúc��5$      #��[ 5%      $��13(�5&      $	��Top=�5'      $
��Left=�5(      $��
725,10,0,0q�6(   $	��176��6<   �� 5)   
   -   5        ���#007bff���#007bff$��	20,13,0,0q�5)   T   $
��Left=�6g   $	��Top=�6�   $	��160��6�   $��32��6�   .��6�   Lưu6�   �� 5*   
   -   5        ���#ffc107���#ffc107$��
185,13,0,0q�5*   U   $
��Left=�6i   $	��Top=�6�   $��87��6�   $��32��6�   ���#212529.��6�   	Clear all6�   �� 5+   
   -   5         ��Name$ leader��5+   /   $ 
Horizontal=�6   $
��Left=�6?   $	��Top=�6Z   $	��881��6r   $��	21,79,0,0q�6~   .+�5,        $ Stars=�6&   $��27��63   $��27��6?   $��	0,10,10,0q�6J   $��13(�6]   ���#F57F176k   �� 5-      -   5        $��HoTenLead_name��5.      #��[  5/      $
��Left=�6L   $	��Top=�6g   $	��500��6   $��13(�6�   .��6�    50      �� 51      $ 
Horizontal=�52      $��-2 0 0 0q�53      .+�54        $ ClipboardUser=�62   �� 55      �� 6%   $� Họ và tên��6)   6>   56      .��57   2   58      �� 59      -   5         ��Name$ CMNDLead_name��5:      #��[  5;      $
��Left=�6L   $	��Top=�6g   $	��334��6   $��10,0,0,0q�6�   $��13(�6�   .��6�    5<      �� 5=      $ 
Horizontal=�5>      $��-2 0 0 0q�5?      .+�5@        $ Payment=�62   �� 5A      �� 6%   $� CMND��6)   69   5B      .��5C   2   5D      5E      �� 5F   
   -	   5        $
��Left=�5F   #   ���#28a745���#28a745$	��Top=�6i   $��861,146,0,0q�6�   $��40��6�   $��0q�6�   ��. .��5G        $ AccountMultiplePlus=�6&   5H      �� 5I   
   -
   5        $
��Left=�5I   &   $	��Top=�6A   $��32��6Y   $��32��6e   ���#dc3545���#dc3545$��824,146,0,0q�6�   $��0,0,0,0q�6�   .��5J        $ AccountRemove=�6&   ���#fff6;   5K      �� 5L   
   -   5         ��Name$ listMember_name��5L   y   $��Hidden=�6   $��Hidden=�6G   $��
20,183,0,0q�6�   $
��Left=�6�   $	��Top=�6�   $	��326��6�   $	��881��6�   ��5M      �� 5N       �� DataType$ CustomerInformationDTO��6   .R�5O      �� $ 
Horizontal=�6!   $
��Left=�6:   $	��Top=�6U   $	��865��6m   .+�5P      �� #��[  5Q      $
��Left=�6R   $	��Top=�6m   $	��526��6�   $��13(�6�   ��5P   #   �� *HoTen+.��5Q   �    5R      �� 5S   "   $ 
Horizontal=�5T      $��-2 0 0 0q�5U      .+�5V   &     $ ClipboardUser=�5W   %   �� 5X   &   �� 5Y   *   $� Họ và tên��6.   5Z   '   5[   #   .��5\   >   5]      �� 5^      #��[  5_      $
��Left=�6R   $	��Top=�6m   $	��329��6�   $��10,0,0,0q�6�   $��13(�6�   ��5^   "   �� *CMND+.��5_   �    5`      �� 5a   "   $ 
Horizontal=�5b      $��-2 0 0 0q�5c      .+�5d   &     $ Payment=�5e   %   �� 5f   &   �� 61   $� CMND��65   6E   5g   #   .��5h   >   5i      5j      5k      5m      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  5n   
   -   5        $��alert_success��5n   .   $y�	Collapsed=�6C   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase	   OpeningEffect	 6Z   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromRight+
   Duration$
 0:0:0.4X�.��5o      �� ���#f6ffed �� CornerRadius$ 4��6*   ���#b7eb8f$��1q�6R   $��Right=�6f   $	��Top=�6�   $��	0,20,25,0q�6�   ._�5p      �� $ 
Horizontal=�6   $��Right=�67   $	��Top=�6S   $��40��6k   $	��210��6w   .+�5q        ���#52c41a$ CommentTick=�6C   $��30��6V   $��24��6b   $��18,5,7,5q�6m   �� 5r      $��13(�6    $
��Left=�6.   $��Center=�6I   $��18��6d   $��	0,10,0,12q�6p   ���	#D8000000!Tạo tài khoản thành công6�   5s      5t      5u        5v   
   -   5        $��alert_error��5v   .   $y�	Collapsed=�6A   	 6X     *SlideInFromRight+$
 0:0:0.4X�.��5w      �� ���#fff1f0$ 4��6*   ���#ffa39e$��1q�6Q   $��Right=�6e   $	��Top=�6�   $��	0,20,26,0q�6�   ._�5x      �� $ 
Horizontal=�6   $��Right=�67   $	��Top=�6S   $��40��6k   $	��187��6w   .+�5y        ���#f5222d$ CommentRemove=�6C   $��30��6X   $��24��6d   $��16,5,7,5q�6o   �� 5z      $��13(�6    $
��Left=�6.   $��Center=�6I   $��18��6d   $��	0,10,0,12q�6p   ���	#D8000000!Tạo tài khoản thất bại6�   5{      5|      5}      5~      5      