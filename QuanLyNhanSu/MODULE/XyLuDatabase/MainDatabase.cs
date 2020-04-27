﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaHoa;

namespace QuanLyNhanSu.MODULE.XyLuDatabase
{
    class MainDatabase
    {
        public static string connectNhanSu = @"MODULE\DATABASE\ThongTinNhanSu.xml";
        public static string connectPhongBan = @"MODULE\DATABASE\DanhSachPhongBan.xml";
        public static string connectTaiKhoan = @"MODULE\DATABASE\DanhSachTaiKhoan.xml";
        public static string connectSetUp = @"MODULE\CaiDat.xml";
        public static string idDangNhap { get; set; }
        public const int levelCode = 10;
        public static Hashtable dsNhanSu { get; set; } = new Hashtable();
        public static Hashtable dsPhongBan { get; set; } = new Hashtable();
        public static Hashtable dsTaiKhoan { get; set; } = new Hashtable();
        public static SetUp setUp { get; set; } = new SetUp() { DangNhapMacDinh = dsTaiKhoan["tester"] as TaiKhoan };
        public static void LoadData_NhanSu()
        {
            if (dsNhanSu.Count > 0)
                return;
            GiaiMaFile(connectNhanSu, MaHoaOptions.MixCode, levelCode);
            List<NhanSu> nhanSus = ThaoTacFile.XmlFile<NhanSu>.DocList(connectNhanSu);
            foreach (NhanSu nhanSu in nhanSus)
                dsNhanSu.Add(nhanSu.MaNhanVien, nhanSu);
            MaHoaFile(connectNhanSu, MaHoaOptions.MixCode, levelCode);
        }
        public static void WriteData_NhanSu()
        {
            ThaoTacFile.XmlFile<NhanSu>.GhiList(connectNhanSu,
                                                 ChuyenDoi<NhanSu>.Hashtable_to_List(dsNhanSu));
            MaHoaFile(connectNhanSu, MaHoaOptions.MixCode, levelCode);
        }
        public static void LoadData_PhongBan()
        {
            if (dsPhongBan.Count > 0)
                return;
            GiaiMaFile(connectPhongBan, MaHoaOptions.MixCode, levelCode);
            List<PhongBan> phongBans = ThaoTacFile.XmlFile<PhongBan>.DocList(connectPhongBan);
            foreach (PhongBan phongBan in phongBans)
                dsPhongBan.Add(phongBan.TenPhongBan, phongBan);
            MaHoaFile(connectPhongBan, MaHoaOptions.MixCode, levelCode);
        }
        public static void WriteData_PhongBan()
        {
            ThaoTacFile.XmlFile<PhongBan>.GhiList(connectPhongBan,
                                                 ChuyenDoi<PhongBan>.Hashtable_to_List(dsPhongBan));
            MaHoaFile(connectPhongBan, MaHoaOptions.MixCode, levelCode);
        }
        public static void LoadData_TaiKhoan()
        {
            if (dsTaiKhoan.Count > 0)
                return;
            GiaiMaFile(connectTaiKhoan, MaHoaOptions.MixCode, 1);
            GiaiMaFile(connectTaiKhoan, MaHoaOptions.Binary, 2);
            List<TaiKhoan> taiKhoans = ThaoTacFile.XmlFile<TaiKhoan>.DocList(connectTaiKhoan);
            foreach (TaiKhoan taiKhoan in taiKhoans)
                dsTaiKhoan.Add(taiKhoan.Id, taiKhoan);
            MaHoaFile(connectTaiKhoan, MaHoaOptions.Binary, 2);
            MaHoaFile(connectTaiKhoan, MaHoaOptions.MixCode, 1);
        }
        public static void WriteData_TaiKhoan()
        {
            ThaoTacFile.XmlFile<TaiKhoan>.GhiList(connectTaiKhoan,
                                                 ChuyenDoi<TaiKhoan>.Hashtable_to_List(dsTaiKhoan));
            MaHoaFile(connectTaiKhoan, MaHoaOptions.Binary, 2);
            MaHoaFile(connectTaiKhoan, MaHoaOptions.MixCode, 1);
        }
        public static void LoadData_SetUp()
        {
            setUp = ThaoTacFile.XmlFile<SetUp>.DocList(connectSetUp)[0];
            if (setUp.DangNhapMacDinh.Id != null)
                for (int i = 0; i < 4; i++)
                    setUp.DangNhapMacDinh.Password = BinaryCode.GiaiMa(setUp.DangNhapMacDinh.Password);
        }
        public static void WriteData_SetUp()
        {
            string password = setUp.DangNhapMacDinh.Password;
            if (setUp.DangNhapMacDinh.Id != null)
                for (int i = 0; i < 4; i++)
                    setUp.DangNhapMacDinh.Password = BinaryCode.MaHoa(setUp.DangNhapMacDinh.Password);
            List<SetUp> tmp = new List<SetUp>();
            tmp.Add(setUp);
            ThaoTacFile.XmlFile<SetUp>.GhiList(connectSetUp, tmp);
            setUp.DangNhapMacDinh.Password = password;
        }
        public enum MaHoaOptions
        {
            MixCode,
            Binary
        }
        public static void MaHoaFile(string namePath, MaHoaOptions options, int level)
        {
            switch (options)
            {
                case MaHoaOptions.MixCode:
                    for (int i = 0; i < level; i++)
                        ThaoTacFile.TextFile.Ghi(namePath, MixCode.MaHoa(ThaoTacFile.TextFile.Doc(namePath)));
                    break;
                case MaHoaOptions.Binary:
                    for (int i = 0; i < level; i++)
                        ThaoTacFile.TextFile.Ghi(namePath, BinaryCode.MaHoa(ThaoTacFile.TextFile.Doc(namePath)));
                    break;
            }
        }
        public static void GiaiMaFile(string namePath, MaHoaOptions options, int level)
        {
            switch (options)
            {
                case MaHoaOptions.MixCode:
                    for (int i = 0; i < level; i++)
                        ThaoTacFile.TextFile.Ghi(namePath, MixCode.GiaiMa(ThaoTacFile.TextFile.Doc(namePath)));
                    break;
                case MaHoaOptions.Binary:
                    for (int i = 0; i < level; i++)
                        ThaoTacFile.TextFile.Ghi(namePath, BinaryCode.GiaiMa(ThaoTacFile.TextFile.Doc(namePath)));
                    break;
            }
        }
    }
}