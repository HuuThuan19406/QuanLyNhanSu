   M S B A M L   `   `   `  ���� H  DQuanLyNhanSu, Version=1.11.2.0, Culture=neutral, PublicKeyToken=null+clr-namespace:QuanLyNhanSuQuanLyNhanSu  "    QuanLyNhanSu.ThemSuaPhongBan   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     ,localclr-namespace:QuanLyNhanSu       � 
ResizeMode$  NoResize=� � WindowStartupLocation$ CenterScreen=�$	��220��$	��350�� � 	Resources  �� 
TargetType �� Property �� Value��%  '��       '�� �     �� " ��.���  � ��$ SemiBold"���  � ��
 ��  ���  � ��$ Center=���  �@��TextWrapping$
 Wrap=���  � ��$ 10,0,0,0q��� " ��.���  � ��$ SemiBold"���  � ��$ Center=���  � ��$
 Wrap=�.��� $��25,10q� � ColumnDefinitions �� $
��0.4* ���  � RowDefinitions �� �� $��2* ��� .+��� $��0��$��0��Tên phòng ban�� $��1��$��0��Danh sách chức vụ�� -    ��Name$ txtPhongBan��$��0��$��1������ *tenPhongBan+�� $��1��$��1��$��50������ *	PdsChucVu+.��	 � ToolTip	 �� Mỗi chức vụ cách nhau�� 75bởi dấu phẩy ',' hoặc dấu chấm phẩy ';'.���� -   
 ��Name$
 
btnXacNhan��$��2��$��1��$��10,0,0,0q�$��15(�$��SemiBold"�$��Center=�$��Center=�   
LinkButton#��[  .��Xác nhận