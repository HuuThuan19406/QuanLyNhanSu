   M S B A M L   `   `   `  ���� H  DQuanLyNhanSu, Version=1.11.2.0, Culture=neutral, PublicKeyToken=null+clr-namespace:QuanLyNhanSuQuanLyNhanSu      QuanLyNhanSu.Message   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     ,localclr-namespace:QuanLyNhanSu     U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    � AllowsTransparency  . 
�������$	��1.5q� � WindowStyle$
 None=� � WindowStartupLocation$ CenterScreen=�$	��200��$	��450��.��� -    �Name$ GridMain�� � RowDefinitions �� $��30 ��� .+�� $��0��   GridBackgroundGradient#��[  .+��� -    ��Name$ 
lblCaption��$	��5,0q�$��15(�$��SemiBold"�.��CAPTION IN HERE�� -    ��Name$ btnClose��$��Right=�$��Center=�$��30�� �� IsCancel . $��20(�$
��Bold"���Z� ��Z� .��X�� -    ��Name$ 	StackMain��	 �� Orientation$	 
Horizontal=�$��20q�$��1��.+�'  !MaterialDesignThemes.Wpf.PackIcon  -   
  Name$
 packIcon��  ForegroundGradient#��[    Kind$ 	AlarmBell=�$��70��$��70��$	��5,0q��� -   $ 
StackChild��$��Center=�$��Center=�.+��� -    ��Name$ 
txbContent��
���  ��$
��13.5(�$	��320��$
��Wrap=� �� TextAlignment$
 Left=�This is content�� -   $ btnOkey��$��0,20,0,0q� �� 	IsDefault . $��30��$��80��.��ĐÃ HIỂU