   M S B A M L   `   `   `  ����H  DQuanLyNhanSu, Version=1.11.2.0, Culture=neutral, PublicKeyToken=null+clr-namespace:QuanLyNhanSuQuanLyNhanSu  5   	       QuanLyNhanSu.DangNhap   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:QuanLyNhanSu     5   	   J FWpfAnimatedGif, Version=1.4.18.0, Culture=neutral, PublicKeyToken=null,gif"http://wpfanimatedgif.codeplex.com  5   	   U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  Đăng nhập��5
   	   $	��310��6   $	��650��6(    � 
ResizeMode$ NoResize=�64    � WindowStartupLocation$ CenterScreen=�6J   $��Tahoma)�5      $��15(�6/    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $e _pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Light.xaml?�6%   �� 5      $h bpack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Defaults.xaml?�6%   �� 5      $t npack://application:,,,/MaterialDesignColors;component/Themes/Recommended/Primary/MaterialDesignColor.Blue.xaml?�6%   �� 5      $s mpack://application:,,,/MaterialDesignColors;component/Themes/Recommended/Accent/MaterialDesignColor.Blue.xaml?�6%   �� 5      $4 .pack://application:,,,/ResourceDictionary.xaml?�6%   %    5      .��5      �  � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   .+�5   
   � -   5         �Name$ 	gridIntro��5      $��0��6"   ��5      �� 5       �� EndPoint$ 0.5,1&�6&   	 �� 
StartPoint$	 0.5,0&�67   .��5      � 
 � Color#
 � ��6#    � Offset$ 0Q�6k   � 5       $
 DeepSkyBlue��6#   $	 0.9Q�67   5!      .+�5#      �� $��50,25,50,210.4q�6   .+�5$      �� $��PHẦN MỀM��6    �� TextAlignment$ Center=�6,   $��12(�6C   
�������$
��Thin"�6d   �� 5%      $��QUẢN LÝ NHÂN SỰ��6   $��17(�63   $ Center=�6A   
�������$
��Bold"�6k   5&      �� 5'      $	��165��6   $	��165��6!   "  WpfAnimatedGif.ImageBehavior   AnimatedSource$ /PICTURE/IntroPicture.gif��5(      $��66,69,65.6,21.8q�6Q      RepeatBehavior$ Forever��5)      (  "MaterialDesignThemes.Wpf.ColorZone  5*         Mode$
 Dark=�5+      
������ $	��Top=�5,      $
��Left=�6)   .��5-      d� -   5         d�Name$ btnMenuList��5-       '  #MaterialDesignHamburgerToggleButton#���   5/      50      �� 51      -   5         ��Name$ lbMenu��51      $	��115��6&   $	��130��62    J� Opacity$ 0Q�6?   
����  �$��12(�53   .   $y�Hidden=�6<   $
��Left=�54      $	��Top=�61   $��0,40,0,0q�6I   ��55      �� 56       �� Color$ White��6&    �� Opacity$	 0.8Q�64   .@�58      �� .��6   Đổi mật khẩu6,   �� 59      .��6   Quên mật khẩu6-   �� 5:      .��6   
Thông tin6)   �� 5;      .��6   Thoát6%   5<      5=      � 5>   
   $��1��6   $��Center=�6   $	��220��6<   $	��268��6I    � RowDefinitions 5?      �� 5@      �� 5A      $��1.25* �6    �� 5B      �� 5C      .+�5E      � $��0��6   .+�5F      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Account=�6*   $��39��69   $��34��6E     ForegroundGradient#��[ 6P   �� 5G      -   5         ��Name$ txtTaiKhoan��5H   &   
����  �$	��200��6   $��30��6   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Tài khoản��5I      5J      �� 5K      $��1��6   .+�5L      � .+�5M        $	 Key=�6.   $��39��69   $��29��6E   #��[ 6P   G� 5N      -   5         G�Name$ 
pwbMatKhau��5Q      
����  �$ Password��6/   y�5O      ��  �� ElementName$ btnHienMatKhau�� �� Path$ 
Visibility� �� Mode$ OneWay=���5P      �� $ txtTaiKhoan��$ Width���6P   �� $ txtTaiKhoan��$ Height�5Q   /   �� 5R      -   5        $��txtHienThiMatKhau��5R      
����  �$ Password��5V      y�5T      �� $ btnAnMatKhau��$ 
Visibility���5U      �� $ txtTaiKhoan��$ Width���6P   �� $ txtTaiKhoan��$ Height�5V      �� 5W      -   5         ��Name$ btnHienMatKhau��5W      $��30��5X      $��30��6)   $��Right=�5Z      $��Center=�69   ��5Y      Z� ��63   Z� .��5[        $ EyeOffOutline=�62   
���   �5\   2   5]      �� 5^      -   5        $ btnAnMatKhau��5^      $��30��5_      $��30��6)   $y�Hidden=�5`   J   $��Right=�5a      $��Center=�69   ��5`      Z� ��63   Z� .��5b        $ 
EyeOutline=�62   #��[ 5c   .   5d      5e      �� 5f      -	   5         ��Name$ checkLuuDangNhap��5f   -   $��12(�6   $��0,5,0,0q�6G   .��6X   Lưu đăng nhập � ToolTip 5h      �� 5i      ,*Người khác sử dụng máy tính này�� 5k      cũng có thể đăng nhập5m      5o      5p      �� 5q      -
   5        $ btnDangNhap��5q      $��2��6*   $��35��5r      $	��120��6!     �� 	IsDefault  .   
LinkButton#��[ 5s      .��5t      �� 
�������$��ĐĂNG _NHẬP��6+   5u      �� 5v      $��3��6   $��0,2,0,0q�6&   .+�5w      �� -   5        $��lblDoiMatKhau��5w      
���   �$��Center=�6@   $��12(�5x      $��Italic$�6"     	LinkLabel#��[ 65   .��6X   Đổi mật khẩu6f   �� 5y      -   5        $��lblTaiKhoanKhac��5y      
���   �$��Center=�6C   $��12(�5z      $��Italic$�6&   #��[ 69   .��6\   Tài khoản khác6l   5{      5|      5}      5~      