   M S B A M L   `   `   `  ����H  DQuanLyNhanSu, Version=1.11.2.0, Culture=neutral, PublicKeyToken=null+clr-namespace:QuanLyNhanSuQuanLyNhanSu  5   	   "    QuanLyNhanSu.ThemSuaPhongBan   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:QuanLyNhanSu     5   	     � 
ResizeMode$  NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�6   $	��220��5	   	   $	��350��6    � 	Resources 5
       �� 
TargetType �� Property �� Value��%�  '��       '�� �     �� 5   
   " ��6   .�5      ��  � ��$ SemiBold"�6+   �� 5       � ��
 ��  �6+   �� 5       � ��$ Center=�62   �� 5       �@��TextWrapping$
 Wrap=�6-   �� 5       � ��$ 10,0,0,0q�6'   5      �� 5   
   " ��6   .�5      ��  � ��$ SemiBold"�6+   �� 5       � ��$ Center=�62   �� 5       � ��$
 Wrap=�6-   5      5      .��5      � $��25,10q�6    � ColumnDefinitions 5   
   �� 5      $
��0.4* �6   �� 5       � RowDefinitions 5   
   �� 5      �� 5      $��2* �6   �� 5       .+�5"   
   �� $��0��6   $��0��6!   Tên phòng ban6@   �� 5#   
   $��1��6   $��0��6!   Danh sách chức vụ6D   �� 5$   
   -   5         ��Name$ txtPhongBan��5$   /   $��0��6   $��1��6   ��6D   �� *tenPhongBan+�� 5%   
   $��1��6   $��1��6   $��50��6/   ��6;   �� *	PdsChucVu+.��6V   	 � ToolTip	 5&      �� 5'      Mỗi chức vụ cách nhau�� 5)      75bởi dấu phẩy ',' hoặc dấu chấm phẩy ';'5+      .��5,      5-      �� 5/   
   -   5        
 ��Name$
 
btnXacNhan��5/      $��2��6%   $��1��62   $��10,0,0,0q�6B   $��15(�50      $��SemiBold"�6   $��Center=�51      $��Center=�6.      
LinkButton#��[  52      .��65   Xác nhận6?   53      54      