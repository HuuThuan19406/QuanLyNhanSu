   M S B A M L   `   `   `  ����H  DQuanLyNhanSu, Version=1.11.2.0, Culture=neutral, PublicKeyToken=null+clr-namespace:QuanLyNhanSuQuanLyNhanSu  5   	   !    QuanLyNhanSu.WaitForLoading   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:QuanLyNhanSu     5   	     � AllowsTransparency  . 
�������$	��1.5q�5   ;    � WindowStyle$
 None=�5	   	    � WindowStartupLocation$ CenterScreen=�6    � Title$ WaitForLoading��5
   	   $	��200��6    $	��400��6-   .��5      � .+�5   
   �� $?��9Chương trình đang được tải, vui lòng đợi...��6   
����  �$��15(�6^   $��Center=�6l   $	��Top=�6�   $��25q�6�   � 5   
   -   5         �Name$ ProgressBar��5       � IsIndeterminate . $��Center=�6B   $��50,50,50,25q�6]   $��15��6r   �� 5   
   -   5         ��Name$ txbThongTin��5      $
��Left=�6)   $��
50,129,0,0q�6D   $
��Wrap=�6X   $��Đang tải xử lý ....��6l   $	��Top=�6�   $��37��6�   $	��297��6�   5      5      