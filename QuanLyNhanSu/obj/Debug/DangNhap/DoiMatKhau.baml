   M S B A M L   `   `   `  ����H  DQuanLyNhanSu, Version=1.11.2.0, Culture=neutral, PublicKeyToken=null+clr-namespace:QuanLyNhanSuQuanLyNhanSu  5   	       QuanLyNhanSu.DoiMatKhau   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:QuanLyNhanSu     5   	     � Title$  Đổi Mật Khẩu��5   	   $��15(�6   $	��300��6,   $	��300��69    � 
ResizeMode$ NoResize=�6E    � WindowStartupLocation$ CenterScreen=�6[    � 	Resources 5	       �� 
TargetType �� Property �� Value��%T   '��       �� 5
   
   " ��6   .�5      ��  � ��
 �   �6+   5      5      .��5      � .+�5   
   �� -   5         ��Name$ txtTaiKhoan��5      
����  �$��15(�6?   $��25��6M   $��128,20,19.6,0q�6Y   $	��Top=�6p   .��6�    � ToolTip 5      _� 5      .��6   Tài khoản6%   .��5      5      G� 5   
   -   5        	 G�Name$	 pwbMatKhauCu��5      
����  �$��15(�6D   $��25��6R   $��128,60,19.6,0q�6^   $	��Top=�6u    5      _� 5      .��6   Mật khẩu cũ6'   5      G� 5   
   -   5        $	 pwbMatKhau1��5      
����  �$��15(�6C   $��25��6Q   $��128,100,19.6,0q�6]   $	��Top=�6u    5      _� 5      .��6   Mật khẩu mới6(   5      G� 5   
   -   5        $	 pwbMatKhau2��5      
����  �$��15(�6C   $��25��6Q   $��128,140,19.6,0q�6]   $	��Top=�6u    5      _� 5       $%��Nhập lại mật khẩu mới��6   5"      �� 5#   
   -   5        $��20(�5#      $��40��6   $	��140��6+   $��20,190,20,20q�5$      $��XÁC NHẬN��6'   
 �� 	IsDefault
 . 5%   &   �� 5&   
   $��20,20,184.6,215.4q�6   .��6+   Tài khoản:67   �� 5'   
   $��20,60,184.6,175.4q�6   .��6+   	MK cũ:63   �� 5(   
   $��20,100,170.6,130.4q�6   .��6,   	MK mới:65   �� 5)   
   $��20,140,170.6,92.4q�6   .��6+   Nhập lại MK:69   5*      5+      