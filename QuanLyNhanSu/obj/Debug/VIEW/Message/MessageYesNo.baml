   M S B A M L   `   `   `  ����H  DQuanLyNhanSu, Version=1.11.2.0, Culture=neutral, PublicKeyToken=null+clr-namespace:QuanLyNhanSuQuanLyNhanSu  5   	       QuanLyNhanSu.MessageYesNo   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:QuanLyNhanSu     5   	   U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � AllowsTransparency  . 
�������$	��1.5q�5	   ;    � WindowStyle$
 None=�5
   	    � WindowStartupLocation$ CenterScreen=�6   $	��200��5   	   $	��450��6   .��5      � -   5         �Name$ GridMain��5       � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      .+�5   
   � $��0��6      GridBackgroundGradient#��[  5      .+�5      �� -   5         ��Name$ 
lblCaption��5   !   $	��5,0q�6   $��15(�65   $��SemiBold"�6C   .��6Y   CAPTION IN HERE6j   �� 5      -   5         ��Name$ btnClose��5      $��Right=�6'   $��Center=�5      $��30��5       �� IsCancel . $��20(�5      $
��Bold"�6   ��5      Z� ��6'   Z� .��5   1   X64   5      �� 5   
   -   5         ��Name$ 	StackMain��5      	 �� Orientation$	 
Horizontal=�6(   $��20q�6A   $��1��6M   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon  -   5        
  Name$
 packIcon��5   &     ForegroundGradient#��[ 68      Kind$ 
HelpCircle=�5      $��70��6$   $��70��60   $	��5,0q�6;   �� 5      -   5        $ 
StackChild��5      $��Center=�6-   $��Center=�6J   .+�5      �� -   5         ��Name$ 
txbContent��5      
���  ��$
��13.5(�6A   $	��320��5      $
��Wrap=�6$    �� TextAlignment$
 Left=�68   This is content6^   �� 5       $	��170��6   $	 
Horizontal=�6)   $��0,20,0,0q�6B   .+�5!      �� -   5        $ btnOkey��5!       �� 	IsDefault . $��30��5"      $��80��6!   .��6,   
ĐỒNG Ý64   �� 5#      -	   5        $ 	btnCancel��5#      $��30��5$      $��80��6!   $
��10,0q�6,   .��6:   
HỦY BỎ6B   5%      5&      5'      5(      5)      