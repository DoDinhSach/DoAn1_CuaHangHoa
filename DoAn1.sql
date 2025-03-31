CREATE DATABASE DoAn1_CuaHangHoa;
USE DoAn1_CuaHangHoa;

-- Bảng 1: Loại hoa
CREATE TABLE LoaiHoa (
    MaLoaiHoa INT PRIMARY KEY,
    TenLoaiHoa NVARCHAR(50),
    MoTa NVARCHAR(100)
);

-- Bảng 2: Hoa
CREATE TABLE Hoa (
    MaHoa INT PRIMARY KEY,
    TenHoa NVARCHAR(50),
    GiaTien DECIMAL(15, 2),
    XuatXu NVARCHAR(50),
    MaLoaiHoa INT,
    FOREIGN KEY (MaLoaiHoa) REFERENCES LoaiHoa(MaLoaiHoa)
);

-- Bảng 3: Nhân viên
CREATE TABLE NhanVien (
    MaNV INT PRIMARY KEY,
    TenNV NVARCHAR(50),
    SDT INT,
    QueQuan NVARCHAR(50),
    GioiTinh NVARCHAR(10)
);

-- Bảng 4: Khách hàng
CREATE TABLE KhachHang (
    MaKH INT PRIMARY KEY,
    TenKH NVARCHAR(50),
    SDT INT,
    DiaChi NVARCHAR(100)
);

-- Bảng 5: Hoá đơn nhập
CREATE TABLE DonHangNhap (
    MaDHN INT PRIMARY KEY,
    NgayNhap DATE,
    TenNhaCC NVARCHAR(50),
    MaNV INT,
    FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
);

-- Bảng 6: Chi tiết đơn hàng nhập (ChiTietHDN)
CREATE TABLE ChiTietHDN (
    MaDHN INT,
    MaHoa INT,
    SoLuongNhap INT,
    DonGia DECIMAL(15, 2),
    ThanhTien DECIMAL(15, 2),
    PRIMARY KEY (MaDHN, MaHoa),
    FOREIGN KEY (MaDHN) REFERENCES DonHangNhap(MaDHN),
    FOREIGN KEY (MaHoa) REFERENCES Hoa(MaHoa)
);

-- Bảng 7: Hoá đơn bán
CREATE TABLE HoaDonBan (
    MaHDB INT PRIMARY KEY,
    NgayBan DATE,
    MaKH INT,
    MaNV INT,
    TrangThai NVARCHAR(50),
    FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH),
    FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
);

-- Bảng 8: Chi tiết hoá đơn bán (ChiTietHDB)
CREATE TABLE ChiTietHDB (
    MaHDB INT,
    MaHoa INT,
    SoLuong INT,
    DonGia DECIMAL(15, 2),
    ThanhTien DECIMAL(15, 2),
    PRIMARY KEY (MaHDB, MaHoa),
    FOREIGN KEY (MaHDB) REFERENCES HoaDonBan(MaHDB),
    FOREIGN KEY (MaHoa) REFERENCES Hoa(MaHoa)
);


CREATE TABLE TaiKhoan (
    MaTK VARCHAR(30) PRIMARY KEY,
    TenDangNhap VARCHAR(50) NOT NULL ,
    MatKhau VARCHAR(256) NOT NULL, -- Lưu mật khẩu đã mã hóa
);
  
  drop table LoaiHoa;
  drop table Hoa;
  drop table NhanVien;