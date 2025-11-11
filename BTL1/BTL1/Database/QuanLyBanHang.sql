drop database QuanLyBanHang;
create database QuanLyBanHang;
use QuanLyBanHang;
go

DELETE FROM ChiTietHDB;  
DELETE FROM HoaDonBan;
DeleTE FROM ChiTietHDN; 
DELETE FROM HoaDonNhap;
DELETE FROM KhachHang;
DELETE FROM TaiKhoan;
DELETE FROM NhanVien;
DELETE FROM HangHoa;
drop trigger trg_CapNhatSoLuongHangBan;
drop trigger trg_CapNhatSoLuongHangNhap;
drop trigger trg_CapNhatTongTieuDung_KH;
DROP TRIGGER trg_CapNhatGia;
DROP TRIGGER trg_CapNhatTongTien_HDB;
DROP TRIGGER trg_CapNhatTongTien_HDN;


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

-- Bảng khách hàng
create table KhachHang (
    MaKH char(10) primary key,
    TenKH nvarchar(100) not null,
    SDT varchar(15),
    TongTieuDung decimal(18,2) default 0 check (TongTieuDung >= 0)  
);

-- Bảng hóa đơn bán
create table HoaDonBan (
    MaHDB char(10) primary key,
    TongTien decimal(18,2) check (TongTien >= 0),
    MaNV char(10) not null,
    NgayBan date not null,
    MaKH char(10) not null,
    foreign key (MaNV) references NhanVien(MaNV),
    foreign key (MaKH) references KhachHang(MaKH)
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
)



-- ========================
-- DỮ LIỆU MẪU
-- ========================

-- HÀNG HÓA
insert into HangHoa values
('HH01', N'Nước suối Aquafina 500ml', 200, 5000, N'Được lấy từ nguồn nước ngầm đảm bảo trải qua quy trình khử trùng, lọc sạch các tạp chất.', N'Chai'),
('HH02', N'Coca Cola lon 330ml', 150, 10000, N'Nước ngọt giải khát chính hãng từ thương hiệu nước ngọt Coca Cola được nhiều người yêu thích với hương vị thơm ngon, sảng khoái.', N'Lon'),
('HH03', N'Pepsi lon 330ml', 180, 10000, N'Sản phẩm nước ngọt giúp bổ sung năng lượng, kích thích tiêu hóa ngon miệng và mang đến cảm giác sảng khoái. Sản phẩm chính hãng thương hiệu nước ngọt Pepsi nổi tiếng toàn cầu.', N'Lon'),
('HH04', N'Trà xanh 0 độ 455ml', 160, 9000, N'Là sự kết hợp hài hòa, tươi mát giữa vị trà xanh chát dịu từ vùng đất Thái Nguyên và vị chanh tươi chua vừa tạo nên điểm nhấn, cùng vị ngọt nhẹ nhàng không gắt, mang đến sản phẩm giải khát tuyệt vời.', N'Chai'),
('HH05', N'Sữa tươi Vinamilk 1L', 100, 38000, N'Được chế biến từ nguồn sữa tươi 100% chứa nhiều dưỡng chất như vitamin A, D3, canxi,... tốt cho xương và hệ miễn dịch, sữa tươi Vinamilk là thương hiệu được tin dùng hàng đầu với chất lượng tuyệt vời.', N'Hộp'),
('HH06', N'Bánh Oreo 180g', 120, 18000, N'Bánh quy nhân kem vani Oreo gói 119.6g từ thương hiệu bánh quy Oreo kết hợp hoàn hảo với vỏ bánh socola đen và nhân kem vani thơm béo bắt vị hoàn hảo.', N'Gói'),
('HH07', N'Kẹo Alpenliebe', 300, 1000, N'Kẹo cứng Alpenliebe thơm ngon, ngọt và thích thú khi ăn. Kẹo cứng phù hợp để ăn vặt.', N'Cái'),
('HH08', N'Mì Hảo Hảo tôm chua cay', 400, 4000, N'Sợi mì của mì Hảo Hảo dai ngon hòa quyện vị Tomyum đậm đà, mang lại bữa ăn nhanh đầy năng lượng.', N'Gói'),
('HH09', N'Dầu ăn Simply 1L', 80, 69000, N'Dầu ăn Simply là loại dầu ăn sử dụng nguyên liệu chọn lọc, không chất bảo quản, tạo màu, rất an toàn cho sức khỏe.', N'Chai'),
('HH10', N'Mì Kokomi tôm chua cay', 360, 3500, N'Sợi mì vàng dai ngon hòa quyện trong nước súp mì Kokomi vị tôm chua cay đậm đà thấm đẫm từng sợi cùng hương thơm lừng quyến rũ.', N'Gói'),
('HH11', N'Nam Ngư ớt tỏi Lý Sơn', 100, 36000, N'Nước chấm chua ngọt Nam Ngư ớt tỏi Lý Sơn chai 300ml làm từ 100% tỏi đảo Lý Sơn cùng vị chua ngọt, cay the hấp dẫn, phù hợp với nhiều món ăn.', N'Chai'),
('HH12', N'Muối I-ốt 500g', 200, 5000, N'Muối có màu sắc và vị mặn đặc trưng, được dùng làm phụ gia trực tiếp trong các bếp ăn.', N'Gói'),
('HH13', N'Đường cát trắng 1kg', 150, 22000, N'Đường được đóng gói trên dây chuyền hoàn toàn tự động, đảm bảo vệ sinh, với hạt đường to đều, có độ tinh khiết cao.', N'Gói'),
('HH14', N'Bột giặt OMO 3kg', 80, 135000, N'Bột giặt có khả năng xoáy bay vết bẩn cứng đầu chỉ sau 1 lần giặt cho quần áo trắng sạch tinh tươm.', N'Túi'),
('HH15', N'Nước rửa chén Sunlight 800ml', 100, 28000, N'Nước rửa chén Sunlight được tin dùng bởi hiệu quả làm sạch tốt, hương thơm dễ chịu và an toàn khi sử dụng.', N'Chai'),
('HH16', N'Khăn giấy Pulppy 10 cuộn', 60, 60000, N'Khăn giấy Pulppy sản xuất tại Việt Nam trên dây chuyền công nghệ cao, sản phẩm hoàn toàn không có hoá chất độc hại mềm mại.', N'Gói'),
('HH17', N'Cà phê sữa VinaCafé Chất', 90, 45000, N'Thưởng thức cốc cà phê hòa tan 3 trong 1 – Vinacafé đậm vị, sánh mịn, thơm nồng nàn cho bạn ngày mới tràn đầy năng lượng.', N'Hộp'),
('HH18', N'Sữa chua Vinamilk', 120, 7000, N'Sữa chua Vinamilk chứa nhiều canxi, vitamin, khoáng chất ở dạng dễ hấp thu, kích thích vị giác, tăng cường sức khỏe hệ tiêu hóa, miễn dịch.', N'Hộp'),
('HH19', N'Bánh Chocopie 360g', 110, 40000, N'Bánh chocopie với lớp socola béo, thơm mà không bị đắng phủ bên ngoài lớp bánh xốp mịn rất ngon.', N'Hộp'),
('HH20', N'Nước tăng lực Sting 500ml', 180, 9000, N'Nước tăng lực Sting là dòng nước tăng lực với mùi vị thơm ngon, sảng khoái, bổ sung hồng sâm chất lượng. Tài lộc quá lớn', N'Chai');

-- NHÂN VIÊN
insert into NhanVien values
('NV01', N'Quản lý', N'Hoàng Đình Hào', N'Bắc Giang', '2005-11-17', 'hoanghao@raumart.vn', '0901234567'),
('NV02', N'Nhân viên', N'Hà Văn Hải', N'Thanh Hóa', '2004-04-04', 'hahai@raumart.vn', '0912345678'),
('NV03', N'Nhân viên', N'Hà Vân Phong', N'Hưng Yên', '2005-03-22', 'vanphong@raumart.vn', '0934567890'),
('NV04', N'Nhân viên', N'Nguyễn Quốc Thịnh', N'Hải Dương', '2005-07-05', 'meleewizard@raumart.vn', '0945678901'),
('NV05', N'Nhân viên', N'Lê Duy Gia Bảo', N'Hà Nội', '2005-10-02', 'giabao@raumart.vn', '0903456789'),
('NV06', N'Nhân viên', N'Ngô Thế Minh', N'Hà Nam', '2005-05-05', 'theminh@raumart.vn', '0987654321');

-- KHÁCH HÀNG
insert into KhachHang (MaKH, TenKH, SDT) values
('KH01', N'Nguyễn Huy Hoàng', '0901112222'),
('KH02', N'Trần Văn Minh', '0903334444'),
('KH03', N'Lê Thị Hằng', '0905556666'),
('KH04', N'Phạm Quang Huy', '0907778888'),
('KH05', N'Đỗ Thanh Tâm', '0911113333'),
('KH06', N'Ngô Đức Hiếu', '0914445555'),
('KH07', N'Hoàng Mai Anh', '0916667777');


-- HÓA ĐƠN NHẬP
insert into HoaDonNhap (MaHDN, NgayNhap, MaNV) values
('HDN01', '2025-01-15', 'NV02'),
('HDN02', '2025-02-10', 'NV03'),
('HDN03', '2025-03-05', 'NV04'),
('HDN04', '2025-05-20', 'NV05'),
('HDN05', '2025-07-18', 'NV06');

-- Chi tiết hóa đơn nhập
insert into ChiTietHDN (MaHDN, MaHH, SLNhap) values
('HDN01', 'HH01', 50),
('HDN01', 'HH02', 40),
('HDN01', 'HH03', 50),
('HDN01', 'HH04', 40),
('HDN01', 'HH05', 30),
('HDN01', 'HH06', 30),
('HDN01', 'HH07', 60),
('HDN01', 'HH08', 80),
('HDN01', 'HH09', 20),
('HDN01', 'HH10', 10),

('HDN02', 'HH11', 40),
('HDN02', 'HH12', 60),
('HDN02', 'HH13', 60),
('HDN02', 'HH14', 30),
('HDN02', 'HH15', 40),
('HDN02', 'HH16', 20),
('HDN02', 'HH17', 25),
('HDN02', 'HH18', 30),
('HDN02', 'HH19', 25),
('HDN02', 'HH20', 30),

('HDN03', 'HH01', 60),
('HDN03', 'HH03', 50),
('HDN03', 'HH05', 40),
('HDN03', 'HH07', 80),
('HDN03', 'HH08', 90),
('HDN03', 'HH10', 15),
('HDN03', 'HH12', 70),
('HDN03', 'HH13', 50),
('HDN03', 'HH15', 30),
('HDN03', 'HH19', 20),
('HDN03', 'HH20', 30),

('HDN04', 'HH02', 50),
('HDN04', 'HH04', 40),
('HDN04', 'HH06', 35),
('HDN04', 'HH09', 25),
('HDN04', 'HH11', 30),
('HDN04', 'HH14', 40),
('HDN04', 'HH16', 30),
('HDN04', 'HH17', 40),
('HDN04', 'HH18', 30),
('HDN04', 'HH19', 20),

('HDN05', 'HH01', 70),
('HDN05', 'HH02', 60),
('HDN05', 'HH03', 60),
('HDN05', 'HH04', 50),
('HDN05', 'HH05', 40),
('HDN05', 'HH07', 10),
('HDN05', 'HH09', 20),
('HDN05', 'HH10', 20),
('HDN05', 'HH12', 80),
('HDN05', 'HH13', 60),
('HDN05', 'HH15', 40),
('HDN05', 'HH20', 40);

-- HÓA ĐƠN BÁN
insert into HoaDonBan (MaHDB, MaNV, NgayBan, MaKH) values
('HDB01', 'NV02', '2025-02-15', 'KH01'),
('HDB02', 'NV03', '2025-03-10', 'KH02'),
('HDB03', 'NV05', '2025-03-15', 'KH03'),
('HDB04', 'NV02', '2025-04-20', 'KH01'),
('HDB05', 'NV04', '2025-05-22', 'KH04'),
('HDB06', 'NV03', '2025-06-10', 'KH05'),
('HDB07', 'NV06', '2025-07-15', 'KH06'),
('HDB08', 'NV05', '2025-08-05', 'KH07'),
('HDB09', 'NV03', '2025-09-10', 'KH02'),
('HDB10', 'NV06', '2025-10-05', 'KH07');

-- CHI TIẾT HÓA ĐƠN BÁN
insert into ChiTietHDB values
('HDB01','HH01',5),('HDB01','HH02',3),('HDB01','HH08',10),('HDB01','HH06',2),
('HDB02','HH03',5),('HDB02','HH05',2),('HDB02','HH09',1),('HDB02','HH08',5),
('HDB03','HH04',5),('HDB03','HH06',4),('HDB03','HH07',5),
('HDB04','HH10',2),('HDB04','HH05',2),('HDB04','HH09',1),('HDB04','HH15',3),
('HDB05','HH02',5),('HDB05','HH03',3),('HDB05','HH07',6),('HDB05','HH16',1),
('HDB06','HH04',4),('HDB06','HH05',3),('HDB06','HH17',2),('HDB06','HH19',1),
('HDB07','HH06',3),('HDB07','HH08',10),('HDB07','HH09',1),
('HDB08','HH01',6),('HDB08','HH04',3),('HDB08','HH11',1),('HDB08','HH13',2),
('HDB09','HH07',5),('HDB09','HH08',8),('HDB09','HH12',2),
('HDB10','HH01',10),('HDB10','HH02',5),('HDB10','HH04',3),('HDB10','HH05',4);


-- CẬP NHẬT TỔNG TIÊU DÙNG
UPDATE ct
SET ct.Gia = h.Gia
FROM dbo.ChiTietHDN ct
JOIN dbo.HangHoa h ON ct.MaHH = h.MaHH;

go
create trigger trg_CapNhatTongTien_HDN
on ChiTietHDN
after insert, update, delete
as
begin
    set nocount on;
    update HoaDonNhap
    set TongTien = (
        select sum(c.SLNhap * c.Gia)
        from ChiTietHDN c
        where c.MaHDN = HoaDonNhap.MaHDN
    )
    where HoaDonNhap.MaHDN in (
        select distinct MaHDN from inserted
        union
        select distinct MaHDN from deleted
    );
end;

go
create trigger trg_CapNhatTongTien_HDB
on ChiTietHDB
after insert, update, delete
as
begin
    set nocount on;
    update HoaDonBan
    set TongTien = (
        select sum(c.SLBan * h.Gia)
        from ChiTietHDB c
        join HangHoa h on h.MaHH = c.MaHH
        where c.MaHDB = HoaDonBan.MaHDB
    )
    where HoaDonBan.MaHDB in (
        select distinct MaHDB from inserted
        union
        select distinct MaHDB from deleted
    );
end;

go
create trigger trg_CapNhatTongTieuDung_KH
on HoaDonBan
after insert, update, delete
as
begin
    set nocount on;
    update KhachHang
    set TongTieuDung = (
        select sum(hdb.TongTien)
        from HoaDonBan hdb
        where hdb.MaKH = KhachHang.MaKH
    )
    where KhachHang.MaKH in (
        select distinct MaKH from inserted
        union
        select distinct MaKH from deleted
    );
end;
go

