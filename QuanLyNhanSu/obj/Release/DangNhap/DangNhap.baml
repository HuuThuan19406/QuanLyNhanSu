   M S B A M L   `   `   `  ���� H  DQuanLyNhanSu, Version=1.11.2.0, Culture=neutral, PublicKeyToken=null+clr-namespace:QuanLyNhanSuQuanLyNhanSu      QuanLyNhanSu.DangNhap   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     ,localclr-namespace:QuanLyNhanSu     J FWpfAnimatedGif, Version=1.4.18.0, Culture=neutral, PublicKeyToken=null,gif"http://wpfanimatedgif.codeplex.com  U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    � Title$  Đăng nhập��$	��310��$	��650�� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=�$��Tahoma)�$��15(� � 	Resources  �� MergedDictionaries �� Source��  �� $e _pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Light.xaml?��� $h bpack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Defaults.xaml?��� $t npack://application:,,,/MaterialDesignColors;component/Themes/Recommended/Primary/MaterialDesignColor.Blue.xaml?��� $s mpack://application:,,,/MaterialDesignColors;component/Themes/Recommended/Accent/MaterialDesignColor.Blue.xaml?��� $4 .pack://application:,,,/ResourceDictionary.xaml?�%    .���  � ColumnDefinitions �� �� .+�� -    �Name$ 	gridIntro��$��0������  �� EndPoint$ 0.5,1&�	 �� 
StartPoint$	 0.5,0&�.��� 
 � Color#
 � �� � Offset$ 0Q�� $
 DeepSkyBlue��$	 0.9Q�.+��� $��50,25,50,210.4q�.+��� $��PHẦN MỀM�� �� TextAlignment$ Center=�$��12(�
�������$
��Thin"��� $��QUẢN LÝ NHÂN SỰ��$��17(�$ Center=�
�������$
��Bold"��� $	��165��$	��165��"  WpfAnimatedGif.ImageBehavior   AnimatedSource$ /PICTURE/IntroPicture.gif��$��66,69,65.6,21.8q�   RepeatBehavior$ Forever��(  "MaterialDesignThemes.Wpf.ColorZone     Mode$
 Dark=�
������ $	��Top=�$
��Left=�.��d� -    d�Name$ btnMenuList�� '  #MaterialDesignHamburgerToggleButton#���   �� -    ��Name$ lbMenu��$	��115��$	��130�� J� Opacity$ 0Q�
����  �$��12(�$y�Hidden=�$
��Left=�$	��Top=�$��0,40,0,0q�����  �� Color$ White�� �� Opacity$	 0.8Q�.@��� .��Đổi mật khẩu�� .��Quên mật khẩu�� .��
Thông tin�� .��Thoát� $��1��$��Center=�$	��220��$	��268�� � RowDefinitions �� �� $��1.25* ��� �� .+�� $��0��.+�'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Account=�$��39��$��34��  ForegroundGradient#��[ �� -    ��Name$ txtTaiKhoan��
����  �$	��200��$��30��)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Tài khoản���� $��1��.+�� .+�  $	 Key=�$��39��$��29��#��[ G� -    G�Name$ 
pwbMatKhau��
����  �$ Password��y���  �� ElementName$ btnHienMatKhau�� �� Path$ 
Visibility� �� Mode$ OneWay=����� $ txtTaiKhoan��$ Width����� $ txtTaiKhoan��$ Height��� -   $��txtHienThiMatKhau��
����  �$ Password��y��� $ btnAnMatKhau��$ 
Visibility����� $ txtTaiKhoan��$ Width����� $ txtTaiKhoan��$ Height��� -    ��Name$ btnHienMatKhau��$��30��$��30��$��Right=�$��Center=���Z� ��Z� .��  $ EyeOffOutline=�
���   ��� -   $ btnAnMatKhau��$��30��$��30��$y�Hidden=�$��Right=�$��Center=���Z� ��Z� .��  $ 
EyeOutline=�#��[ �� -	    ��Name$ checkLuuDangNhap��$��12(�$��0,5,0,0q�.��Lưu đăng nhập � ToolTip �� ,*Người khác sử dụng máy tính này�� cũng có thể đăng nhập�� -
   $ btnDangNhap��$��2��$��35��$	��120��  �� 	IsDefault  .   
LinkButton#��[ .���� 
�������$��ĐĂNG _NHẬP���� $��3��$��0,2,0,0q�.+��� -   $��lblDoiMatKhau��
���   �$��Center=�$��12(�$��Italic$�  	LinkLabel#��[ .��Đổi mật khẩu�� -   $��lblTaiKhoanKhac��
���   �$��Center=�$��12(�$��Italic$�#��[ .��Tài khoản khác