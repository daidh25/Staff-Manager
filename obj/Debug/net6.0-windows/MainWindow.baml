   M S B A M L   `   `   `  ����O  KDe_On_Tap_Kttx2_Lan1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:De_On_Tap_Kttx2_Lan1De_On_Tap_Kttx2_Lan1  5   	   %    De_On_Tap_Kttx2_Lan1.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:De_On_Tap_Kttx2_Lan1     5   	   -   5          � Title$#  Kiểm tra thường xuyên 2��5   	   $	��450��6)   $	��800��66   $��Times New Roman)�6B   $��18(�6_   .��5
      �  � 	Resources 5   
      tron �� 
TargetType A�Name �� Triggers P� Property P� Value �� 
TargetName �� Property	 �� Value��%D  &	        �� 5      " ��6+   .R�5      � .+�5      A� $ Ellipse��6   #��z��6/   #��z��6S   $��1��6z   �� 5      $��Center=�6'   $��Center=�6D   5       5      P� 5       �@J�IsMouseOver$
 True��65   . �5      �� $ Ellipse��6!    � ��
	 � � �6F   5      5      5      .+�5   
   �� $��Center=�6   $	��317��62   ���	#FFD19898$	��Top=�6R   $	��780��6j   ���	#FFF1EEB8$��0,62,0,0q�6�   �� 5   
   $'��!Quản lý thông tin nhân viên��6   $��Center=�66   $��0,10,0,0q�6S   $	��Top=�6e   
 J� RenderTransformOrigin$
 -0.188,-0.012&�6}   $��32(�6�   ���	#FF4984F16�   �� 5   
   $��Mã Nhân Viên:��6   $
��Left=�6(   $��	33,66,0,0q�6C   $	��Top=�6V   $
 0.071,0.483&�6n   �� 5   
   $��Họ và tên:��6   $
��Left=�6%   $��	33,92,0,0q�6@   $	��Top=�6S   $
 0.071,0.483&�6k   �� 5   
   $��Ngày Sinh:��6   $
��Left=�6%   $��
33,123,0,0q�6@   $	��Top=�6T   $
 0.071,0.483&�6l   �� 5   
   $��Giới Tính:��6   $
��Left=�6%   $��
33,151,0,0q�6@   $	��Top=�6T   $
 0.071,0.483&�6l   �� 5   
   $��Phòng Ban:��6   $
��Left=�6%   $��
33,184,0,0q�6@   $	��Top=�6T   $
 0.071,0.483&�6l   �� 5   
   $��Hệ Số Lương:��6   $
��Left=�6'   $��
37,212,0,0q�6B   $	��Top=�6V   $
 0.071,0.483&�6n   &   System.Windows.Controls.DataGrid  5    
   -   5        $��
dgNhanVien��5       $��52,248,48,55q�6%      AutoGenerateColumns$ False��6;      AlternatingRowBackground
 � � �   CanUserAddRows$ False��6x      Columns 5!      0  *System.Windows.Controls.DataGridTextColumn  5"      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã SP��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 64   �� *MaNv+  5#      $ 	Họ tên��6%    65   �� *HoTen+  5$      $ Giới tính��6%    68   �� *
GioiTinh+  5%      $ 	Phong Ban��6%    68   �� *
PhongBan+  5&      $ 
Ngày Sinh��6%    68   �� *
NgaySinh+  5'      $ Tuổi��6%    63   �� *Tuoi+5)      �� 5*   
   -   5        $
��Nhap��5*      $
��Left=�6!   $��182,384,0,0q�6<   $	��Top=�6Q   $��72��6i   ���	#FF5FA71C���	#FF199B21���	#FFFCFF006�   �� 5+   
   -   5        $��Window2��5+      $
��Left=�6#   $��446,384,0,0q�6>   $	��Top=�6S   ���	#FFEAED10���	#FF3BDC1D6�   �� 5,   
   -   5        $��txtMaNv��5,      $
��Left=�6!   $��
159,66,0,0q�6<    �� TextWrapping$
 Wrap=�6P   $�� ��6d   $	��Top=�6l   $	��278��6�   �� 5-   
   -   5        $��
txtHSLuong��5-      $
��Left=�6$   $��159,216,0,0q�6?   $
 Wrap=�6T   $�� ��6h   $	��Top=�6p   $	��278��6�   �� 5.   
   -   5        $��txtHoTen��5.      $
��Left=�6"   $��
159,96,0,0q�6=   $
 Wrap=�6Q   $�� ��6e   $	��Top=�6m   $	��278��6�   �� 5/   
   -   5        $��cbbPhongBan��5/      $
��Left=�6&   $��159,184,0,0q�6A   $	��Top=�6V   $	��147��6n   	� 50   
   -	   5        $��rbNam��50   �   $	��Nam��6   $
��Left=�6$   $��159,163,0,0q�6?   $	��Top=�6T    	� 	GroupName$ GioiTinh��6l   6�   	� 51   
   -
   5        $
��rbNu��51   �   $
��Nữ��6   $
��Left=�6#   $��256,162,0,0q�6>   $	��Top=�6S   $
 0.211,0.703&�6k   $ GioiTinh��6�   6�   (  "System.Windows.Controls.DatePicker  52   
   -   5        $
��dpNS��52      $
��Left=�6!   $��159,124,0,0q�6<   $	��Top=�6Q   $	��139��6i   54      56      