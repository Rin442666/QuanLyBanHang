create database QuanLyBanHang;
use QuanLyBanHang;
go


-- Bảng hàng hóa
create table HangHoa (
    MaHH char(10) primary key,
    TenHH nvarchar(100) not null,
    SLTon int check (SLTon >= 0),
    Gia decimal(18,2) check (Gia >= 0),
    MoTa nvarchar(255),
    DonVi nvarchar(20),
);

-- Bảng nhân viên
create table NhanVien (
    MaNV char(10) primary key,
    ChucVu nvarchar(50),
    TenNV nvarchar(100) not null,
    Que nvarchar(100),
    NgaySinh date,
    Email nvarchar(100) null,
    SDT varchar(15) null,
);


-- Bảng tài khoản
create table TaiKhoan (
    MaNV char(10) primary key,
    TaiKhoan varchar(50) unique not null,
    MatKhau varchar(100) not null,
    PhanQuyen nvarchar(50),
    constraint FK_TaiKhoan_NV foreign key (MaNV) references NhanVien(MaNV)
);


-- Bảng hóa đơn bán
create table HoaDonBan (
    MaHDB char(10) primary key,
    TongTien decimal(18,2) check (TongTien >= 0),
    MaNV char(10) not null,
    NgayBan date not null,
    MaKH char(10),
    foreign key (MaNV) references NhanVien(MaNV)
);

-- Bảng chi tiết hóa đơn bán
create table ChiTietHDB (
    MaHDB char(10),
    MaHH char(10),
    SLBan int check (SLBan > 0),
    primary key (MaHDB, MaHH),
    foreign key (MaHDB) references HoaDonBan(MaHDB),
    foreign key (MaHH) references HangHoa(MaHH)
);

-- Bảng hóa đơn nhập
create table HoaDonNhap (
    MaHDN char(10) primary key,
    NgayNhap date not null,
    MaNV char(10) not null,
    TongTien decimal(18,2) check (TongTien >= 0),
    foreign key (MaNV) references NhanVien(MaNV)
);

-- Bảng chi tiết hóa đơn nhập
create table ChiTietHDN (
    MaHDN char(10),
    MaHH char(10),
    SLNhap int check (SLNhap > 0),
    Gia decimal(18,2) check (Gia >= 0),
    primary key (MaHDN, MaHH),
    foreign key (MaHDN) references HoaDonNhap(MaHDN),
    foreign key (MaHH) references HangHoa(MaHH)
);

-- Bảng khách hàng
create table KhachHang (
    MaKH char(10) primary key,
    TenKH nvarchar(100) not null,
    SDT varchar(15),
    MaHDB char(10) null,
    TongTieuDung decimal(18,2) default 0 check (TongTieuDung >= 0),
    foreign key (MaHDB) references HoaDonBan(MaHDB)
);
