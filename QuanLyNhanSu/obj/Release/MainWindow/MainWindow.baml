   M S B A M L   `   `   `  ���� H  DQuanLyNhanSu, Version=1.11.2.0, Culture=neutral, PublicKeyToken=null+clr-namespace:QuanLyNhanSuQuanLyNhanSu      QuanLyNhanSu.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  &localclr-namespace:QuanLyNhanSu  -     � Title$  QUẢN LÝ NHÂN SỰ��$��15(�$	��768��$
��1280��$	��768��$
��1280��
������� � 
ResizeMode$ 	CanResize=� � WindowStartupLocation$ CenterScreen=� � WindowState$ 	Maximized=� � 	Resources  �� 
TargetType �� Property �� Value��%y   '��       �� " ��.���  � ��
 ��  ���  � ��$ Medium"���  � ��$ 25����  � ��$ Center=�.��� .+��� -    ��Name$ TabMain��.@��� -   $��tabThongTin��$��
THÔNG TIN��	 �� 
IsSelected	 . .��� 
 � RowDefinitions
 �� $��1* ��� $��2* �.+�� $��1��.+�� $	��Top=�$
��22,0q� � ColumnDefinitions �� �� �� �� �� .+��� -    ��Name$ 	txtTraCuu��$��0��$��	0,0,2.5,0q�$��50,0,0,0q�����  �� ElementName$ btnThemNhanSu�� �� Path$ ActualHeight�'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ AccountSearch=�$��0��
���   �$��5,0,0,0q����� $ btnThemNhanSu��$ ActualHeight����� $ btnThemNhanSu��$ ActualHeight��� -    ��Name$ btnThemNhanSu��$��1��$��2.5,0q�   
LinkButton#��[  $��Normal"�.����  �� Orientation$ 
Horizontal=�.+��� $G��Apack://application:,,,/QuanLyNhanSu;component/PICTURE/addIcon.png��$��30���� $��_THÊM NHÂN SỰ��$��Center=��� -   $ btnXoaNhanSu��$��2��$��2.5,0q�#��[  $��Normal"�.���� $ 
Horizontal=�.+�  
�������$��30��$��30��$ DeleteEmpty=��� $��Center=�$��_XÓA NHÂN SỰ���� -   $ btnSuaThongTin��$��3��$��2.5,0q�#��[  $��Normal"�.���� $ 
Horizontal=�.+��� $L��Fpack://application:,,,/QuanLyNhanSu;component/PICTURE/revisionIcon.png��$��30���� $��Center=�$��_SỬA THÔNG TIN���� -   $ btnTTXuatDanhSach��$��4��$��	2.5,0,0,0q�#��[  $��Normal"�.���� $ 
Horizontal=�.+�  
�������$��30��$��30��$ 
FileExport=��� $��Center=�$��XUẤT _DANH SÁCH���� -	    ��Name$ 
lvThongTin��$��22,60,22,66q� �� View �� .P��� $��Họ và tên�� �� Width$	 150�� �� DisplayMemberBinding �� *HoTen+�� $��	CMND/CCCD��$	 130�� �� CellTemplate �� .R��� $
��Wrap=����� *CMND+�� $��Mã n.viên��$	 130�� �� .R��� $
��Wrap=����� *
MaNhanVien+�� $��G.tính��$ 70�� �� .R��� $
��Wrap=����� *
GioiTinh+�� $��
Ngày sinh��$	 120�� �� .R��� $
��Wrap=����� *
NgaySinh+ �� StringFormat$ 
dd/MM/yyyy���� $��
Quê quán��$	 120�� �� .R��� $
��Wrap=����� *	QueQuan+�� $��Số điện thoại��$	 140�� �� .R��� $
��Wrap=����� *SoDienThoai+�� $��Bộ phận��$	 250�� �� .R��� $
��Wrap=����� *BoPhan+�� $��Chức vụ��$	 120�� �� .R��� $
��Wrap=����� *ChucVu+�� $��
Ngày vào��$	 110�� �� .R��� $
��Wrap=����� *	NgayVao+$ 
dd/MM/yyyy�� �� 
GroupStyle (  "System.Windows.Controls.GroupStyle     ContainerStyle �� " ��.���  � �� �� .R�9�  9� 
IsExpanded . $��5q����� $ 
Horizontal=�.+��� 
������� �� Padding$ 10,2.5q�  TextblockBackgroundGradient#��[ $��18(�$��SemiBold"�$��	Underline{����� *Name+�� 
�������$��15,0,0,0q�$��18(�$��SemiBold"�$��Italic$����� *	ItemCount+�� $�� nhân sự��
�������$��18(�$��SemiBold"�$��Italic$�.���� �� $��Bottom=�$��22q�$ 
Horizontal=�$��Right=�.+��� 
����  �.��Hiện tại có�� 
����  ����� $ 
lvThongTin��$ Items.Count� �� Mode$ OneWay=��� 
����  �.��nhân sự trong danh sách�� $ 
Horizontal=�$��Bottom=�$
��Left=�.+��� -
   $ btnNapLaiNhanSu��$��50��$��50��$��0q�$��	22,0,0,11q� � ToolTip$ Nạp lại danh sách����Z� ��Z� .��  $��50��$��50��$ 	Autorenew=�  ForegroundGradient#��[ �� -   $ btnGroupTheoBoPhan��$��50��$��50��$��0q�$��	22,0,0,11q�$  Gom nhóm theo bộ phận����Z� ��Z� .��  $��50��$��50��$ ServerNetwork=�#��[ � $��0��$��22q� �� �� $��5* �.+��� -    ��Name$ imgAnhDaiDien��$��0��$��/PICTURE/avatar.png��$	��186��$��139.5��$
��Left=�$
��Fill=� _�  _� HasDropShadow .  $��Bottom=�.��42Nhấp phải chuột để tải ảnh (3x4) lên� $��1��
 �� �� �� �� .+�� $��0�� �� $
��1.5* ��� $
��1.2* ��� $
��0.8* �.+�� $��0��$	��320��$
��Left=�.+�]� .+��� 
���   �$
��Left=�$��Center=�$��Họ và tên���� -   $ 
txtHoVaTen��  �� TextWrapping$
  Wrap=�$��Center=�]� $��1��$	��280��$
��Left=�.+��� 
���   �$
��Left=�$��	CMND/CCCD��$��Center=��� -   $ txtCMND_CCCD��$
  Wrap=�$��Center=�� $��2��.+��� $ 
Horizontal=�$��Right=�.+��� 
���   �$��Right=�$��Giới tính��$��Center=��� -   $��cboGioiTinh��! �� SelectedValuePath$! Content��$��90��$��Center=�.@��� $	��Nam���� $
��Nữ��� $��1�� �� $
��1.5* ��� $
��1.2* ��� $
��0.8* �.+�]� $��0��$	��320��$
��Left=�.+��� 
���   �$
��Left=�$��Mã nhân viên��$��Center=� _�  .  $��Bottom=�.��GEMã nhân viên được cấp tự động, không thể thay đổi�� -   $ txtMaNhanVien��
�������{�.  $��Right=�$
  Wrap=�$��Center=�$	��180��.��$K EMã nhân viên được cấp tự động, không thể thay đổi��.���� -   $ btnCopyMaNhanVien��$��Right=�$	��2.5q�$��Center=�$��22��$��22��.���� $��/PICTURE/copyIcon.png��$��1q�]� $��1��$	��280��$
��Left=�.+��� 
���   �$
��Left=�$��
Ngày sinh��$��Center=�(  "System.Windows.Controls.DatePicker  -   $��dtpNgaySinh��$��Center=�� $��2�� �� $
��1.5* ��� $
��1.2* ��� $
��0.8* �.+�]� $��0��$	��320��$
��Left=�.+��� 
���   �$
��Left=�$��
Quê quán��$��Center=��� -   $��
cboQueQuan��$! Content��$��Center=�.@��� $��An Giang���� $��Bà Rịa - Vũng Tàu���� $��Bắc Giang���� $��Bắc Kạn���� $��Bạc Liêu���� $��
Bắc Ninh���� $��	Bến Tre���� $��Bình Định���� $��Bình Dương���� $��Bình Phước���� $��Bình Thuận���� $��Cà Mau���� $��
Cần Thơ���� $��
Cao Bằng���� $��Đà Nẵng���� $��Đắk Lắk���� $��Đắk Nông���� $��Điện Biên���� $��Đồng Nai���� $��Đồng Tháp���� $��Gia Lai���� $��	Hà Giang���� $��Hà Nam���� $��	Hà Nội���� $��	Hà Tĩnh���� $��Hải Dương���� $��Hải Phòng���� $��Hậu Giang���� $��
Hòa Bình���� $��
Hưng Yên���� $��Khánh Hòa���� $��Kiên Giang���� $��Kon Tum���� $��	Lai Châu���� $��Lâm Đồng���� $��Lạng Sơn���� $��Lào Cai���� $��Long An���� $��Nam Định���� $��	Nghệ An���� $��
Ninh Bình���� $��Ninh Thuận���� $��
Phú Thọ���� $��	Phú Yên���� $��Quảng Bình���� $��Quảng Nam���� $��Quảng Ngãi���� $��Quảng Ninh���� $��Quảng Trị���� $��Sóc Trăng���� $��Sơn La���� $��	Tây Ninh���� $��Thái Bình���� $��Thái Nguyên���� $��
Thanh Hóa���� $��Thừa Thiên Huế���� $��Tiền Giang���� $!��Thành phố Hồ Chí Minh���� $��	Trà Vinh���� $��Tuyên Quang���� $��
Vĩnh Long���� $��Vĩnh Phúc���� $��	Yên Bái��]� $��1��$	��280��$
��Left=�.+��� 
���   �$��Số điện thoại��$��Center=��� -   $ txtSoDienThoai��$
  Wrap=�$��Center=�� $��3�� �� $
��1.5* ��� $
��1.2* ��� $
��0.8* �.+�]� $��0��$	��320��$
��Left=�.+��� 
���   �$��Bộ phận��$��Center=��� -   $��	cboBoPhan��" �� DisplayMemberPath$" TenPhongBan��
�������$��Center=�]� $��1��$	��280��$
��Left=�.+��� 
���   �$��Chức vụ��$��Center=��� -   # ��Name$# 	cboChucVu��$! Content��
�������$��Center=��� $ 
Horizontal=�$��2��$��Right=�.+��� 
���   �$��
Ngày vào��$��Center=�  -   $  Name$$ 
dtpNgayVao��$��Right=�$��Center=�$	��160���� -   $��tabChamCong��$��CHẤM CÔNG��.��� $��22q�.+�� {�.  
 �� �� $
��1.5* �.+�� $��0��
 �� �� �� �� .+�� $��0�� �� �� �� .+�]� $��0��$	��350��$
��Left=�.+��� 
���   �$��Center=�.��	Họ tên�� -   $ CC_txtHoTen��
�������$
  Wrap=�$��Center=�{�.  ]� $��1��$	��350��$��Center=�.+��� 
���   �$��Center=�.��Lương Cơ Bản�� -   $ CC_txtLuongCoBan��
�������$
  Wrap=�$��Center=�{�.  ]� $��2��$	��350��$��Right=�.+��� 
���   �$��Center=�.��Trợ cấp hàng tháng�� -   $ CC_txtTroCapHangThang��
�������$
  Wrap=�$��Center=�{�.  � $��1�� �� �� �� .+�]� $��0��$	��350��$
��Left=�.+��� 
���   �$��Center=�.��Bộ phận�� -   $ CC_txtBoPhan��
�������$
  Wrap=�$��Center=�{�.  ]� $��1��$	��350��$��Center=�.+��� 
���   �$��Center=�.��Số ngày đi sớm�� -   $ CC_txtSoNgayDiSom��
�������$
  Wrap=�$��Center=�{�.  ]� $��2��$	��350��$��Right=�.+��� 
���   �$��Center=�.��Số ngày đi muộn�� -   $ CC_txtSoNgayDiMuon��
�������$
  Wrap=�$��Center=�{�.  � $��2�� �� �� �� .+�]� $��0��$	��350��$
��Left=�.+��� 
���   �$��Center=�.��Mã nhân viên�� -   $ CC_txtMaNhanVien��$
  Wrap=�$��Center=�$ Tra cứu chấm công��]� $��1��$	��350��$��Center=�.+��� 
���   �$��Center=�.��Số giờ tăng ca�� -    $ CC_txtSoGioTangCa��
�������$
  Wrap=�$��Center=�{�.  ]� $��2��$	��350��$��Right=�.+��� 
���   �$��Center=�.��Tiền thưởng�� -!   $ CC_txtTienThuong��
�������{�.  $
  Wrap=�$��Center=�� $��3�� �� �� �� .+�]� $��0��$��Center=�$	��350��$
��Left=�.+��� -"   $# 
CC_cbThang��$��	0,0,2.5,0q�$	��100��.@��� $��Tháng 1���� $��Tháng 2���� $��Tháng 3���� $��Tháng 4���� $��Tháng 5���� $��Tháng 6���� $��Tháng 7���� $��Tháng 8���� $��Tháng 9���� $��	Tháng 10���� $��	Tháng 11���� $��	Tháng 12���� -#   $# 	CC_btnNam��$��2.5,0q�$	��100��.@��� $
��2016���� $
��2017���� $
��2018���� $
��2019���� $
��2020���� -$   $ 	CC_btnNap��$��0��$��	2.5,0,0,0q�#��[  .���� $ 
Horizontal=�.+�  $��30��$��30��$ 
FileImport=��� $��Center=�.��_NẠP DỮ LIỆU� $��1��.+��� -%   $ CC_lvDuLieuChamCong��$��	0,10,0,44q� �� .P��� $��	Họ tên��$	 170�� �� .R��� $
��Wrap=����� *NhanSu.HoTen+�� $��Bộ phận��$	 150�� �� .R��� $
��Wrap=����� *NhanSu.BoPhan+�� $��Mã Nhân viên��$	 150�� �� .R��� $
��Wrap=����� *NhanSu.MaNhanVien+�� $��Lương nhận được��$	 150�� �� .R��� $
��Wrap=����� *LuongNhanDuoc+�� $��Ghi chú��$	 150�� �� .R��� $
��Wrap=����� *GhiChu+�� $��Bottom=�$ 
Horizontal=�$��Right=�.+��� 
����  �.��1/Hiện tại có dữ liệu chấm công của�� 
����  ����� $ CC_lvDuLieuChamCong��$ Items.Count�$ OneWay=��� 
����  �.��nhân sự trong danh sách�� $��/PICTURE/ComingSoon.jpg��$��UniformToFill=�$��
0,-350,0,0q�% J� Opacity$	% 0.8Q��� -&   $��tabKhenThuong��$��KHEN THƯỞNG��.��� 
 �� �� .+�� $��0��$��0,0,22,0q� �� $��0.35* ��� $��0.06* ��� .+�� $��0��.+�   QuanLyNhanSu.ListBoPhan  -'   &  Name$& KT_ListBoPhan��$��22q�� $��2��$��15,0,0,0q�
 �� $��5* ��� .+�� $��0�� �� $
��0.5* ��� �� .+��� $��0��$
��Left=�$��0,20,0,0q�.+��� -(   $ KT_imgAvatar��$	��200��$	��150��$��/PICTURE/avatar.png��$
��Fill=��� -)   ' ��Name$' KT_txbChucVu��( �� TextAlignment$( Center=�$
��Wrap=�  textblockForegroundGradient#��[ $��17(�$��Black"�$��Italic$�$��Center=�$	��150��$��0,10,0,0q�� $��1��$	��300��$��20,0,0,0q�
 �� �� �� �� .+�]� $��0��.+��� 
���   �$��Center=�.��	Họ tên�� -*   $ KT_txtHoTen��
�������{�.  $
  Wrap=�$��Center=�]� $��1��.+��� 
���   �$
��Left=�$��Mã nhân viên��$��Center=� _�  .  $��Bottom=�.��GEMã nhân viên được cấp tự động, không thể thay đổi�� -+   $ KT_txtMaNhanVien��
�������{�.  $
  Wrap=�$��Center=�$��Right=�$	��160��.��$K EMã nhân viên được cấp tự động, không thể thay đổi��.���� -,   $��Right=�$	��2.5q�$��Center=�$��22��$��22��.���� $��/PICTURE/copyIcon.png��$��1q�]� $��2��.+��� 
���   �$��Center=�.��Bộ phận�� --   $ KT_txtBoPhan��$
  Wrap=�{�.  
�������$��Center=��� $ 
Horizontal=�$��3��.+��� -.   ) ��Name$) KT_chkCoQuyetDinh��$��Center=�.��Có quyết định�� $ 
Horizontal=�$��3��$��Right=�.+��� 
���   �$��Center=�.��Số vào sổ�� -/   $ KT_txtSoVaoSo��$��Right=�$
  Wrap=�$��Center=�$��90��$' !Số được đánh tự động��
���  ��$
��Bold"�
�������{�.  � $��2��$	��320��$��Right=�
 �� �� �� �� .+�]� $��0��.+��� 
���   �$��Center=�.��Ngày xét khen thưởng  -0   $$ KT_dtpNgayXet��$��Center=�]� $��1��.+��� 
���   �$��Center=�.��Hình thức khen thưởng�� -1   $# KT_cboHinhThucKhen��$��Center=�.@��� -2   $! KT_cboHinhThucKhen_txtItem0��$
  Wrap=����� $ KT_cboHinhThucKhen��$ ActualWidth�]� $��2��.+��� 
���   �$��Center=�.��Giá trị khen thưởng�� -3   $ KT_txtGiaTri��$��Stretch=�$
  Wrap=�$��Right=�]� $��3��.+��� 
���   �$��Center=�.��Lí do�� -4   $ 
KT_txtLiDo��$��Stretch=�$
  Wrap=�� $��1��$��0,0,0,22q� �� �� �� �� .+��� -5   $ 
KT_btnThem��$��0��$��	0,0,2.5,0q�#��[  .���� $ 
Horizontal=�.+�  $��30��$��30��$ DatabasePlus=��� $��Center=�.��_THÊM THÔNG TIN�� -6   $ 	KT_btnXoa��$��1��$��2.5,0q�#��[  .���� $ 
Horizontal=�.+�  $��30��$��30��$ DeleteEmpty=��� $��Center=�.��_XÓA THÔNG TIN�� -7   $ 	KT_btnSua��$��2��$��2.5,0q�#��[  .���� $ 
Horizontal=�.+��� $L��Fpack://application:,,,/QuanLyNhanSu;component/PICTURE/revisionIcon.png��$��30���� $��Center=�.��_SỬATHÔNG TIN�� -8   $ 
KT_btnXuat��$��3��$��	2.5,0,0,0q�#��[  .���� $ 
Horizontal=�.+�  $��30��$��30��$ 
FileExport=��� $��Center=�.��XUẤT T_HÔNG TIN� $��2��.+��� -9   $ KT_lvKhenThuong��$��
22,0,22,66q� �� .P��� $��
Ngày xét��$	 130�� �� *	NgayXet+$ 
dd/MM/yyyy���� $��Số vào sổ��$	 100�� �� *	SoVaoSo+�� $��Bộ phận công tác��$	 180�� �� *BoPhanCongTac+�� $��Lý do khen thưởng��$	 200�� �� *	LyDoXet+�� $!��Hình thức khen thưởng��$	 300�� �� *
HinhThuc+�� $��Giá trị khen thưởng��$	 200�� �� *GiaTri+$ #,###���� $��Ghi chú��$	 100�� �� .R��� $��Center=�{�.  * d� 	IsChecked* �� *CoQuyetDinh+�� $��Bottom=�$��22q�$ 
Horizontal=�$��Right=�.+��� 
����  �.��Hiện tại có�� 
����  ����� $ KT_lvKhenThuong��$ Items.Count�$ OneWay=��� 
����  �.��'%mục khen thưởng trong danh sách�� -:   $��
tabCauHinh��$��CẤU HÌNH��.��� .+��� $	��600��$��
0,50,0,250q�.+��� .+�� .+��� $��Kiểu chữ��
���   �$
��Left=�$	��Top=��� -;   $��
cboKieuChu��$	��334��$	��Top=�$��Right=�� $��Right=����� $ cboPhongBan��$ Width�$ OneWay=�.+��� $ 
Horizontal=�$��Center=�.+��� 
�������.��Có�� 
����������� $ 
cboKieuChu��$ Items.Count�$ OneWay=��� 
�������.��phông chữ�� -<   $ btn_QuayLaiFontMacDinh��$��Right=�$, &Trở lại phông chữ mặc định��.��  $ BackupRestore=�$��30��$��30���� $��0,20,0,0q�.+�� .+��� $��Thiết lập phòng ban��
���   �$
��Left=�$	��Top=��� -=   $��cboPhongBan��$
! Text��$	��334��$	��Top=�$��Right=����� .R��� ���� *TenPhongBan+� $��Right=����� $ cboPhongBan��$ Width�$ OneWay=�.+��� $ 
Horizontal=�.+��� 
�������.��Có�� 
����������� $ cboPhongBan��$ Items.Count�$ OneWay=��� 
�������.��
phòng ban�� $��Right=�$ 
Horizontal=�.+��� ->   $ btnThemPhongBan��$��	0,0,2.5,0q�$��Right=�$ Thêm phòng ban��.��  $
 Plus=�$��30��$��30���� -?   $ btnXoaPhongBan��$��	2.5,0,0,0q�$��Right=�$ Xóa phòng ban��.��  $ Close=�$��30��$��30��� $��0,20,0,0q�.+��� 
���   �.��+)Hậu tố số vào sổ khen thưởng:�� -@   $ txtHauToKhenThuong��$	��334��$��Right=�
���  ��$��SemiBold"�$h bHậu tố chỉ áp dụng cho số được đánh từ thời điểm sau khi áp dụng (Lưu)���� -A   $ btnLuuCauHinh��$��40��$	��140��$��0,120q�#��[  
�������.��LƯU CẤU HÌNH�� $��	0,0,0,100q�$��Bottom=�.+��� -B   $' txtDangNhapHienTai��$��0��$V��PTÀI KHOẢN ĐĂNG NHẬP TÀI KHOẢN ĐĂNG NHẬP TÀI KHOẢN ĐĂNG NHẬP��$��Center=�$( Center=�$
��Wrap=�$��SemiBold"�
����  �$	��300��� $��70��.+��� -C   $ btnDangXuat��$��1��#��[  $��Center=�$	��150��$��40��.���� 
�������$��ĐĂNG XUẤT���� -D   $��lblThongTin��$��This is footer��$��12(�$
��15,5q�$��Center=�$��Bottom=�$��75��  lableFooter#��[ 