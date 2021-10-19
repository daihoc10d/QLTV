create database QLTHUVIEN
go
use QLTHUVIEN
go
create table TaiLieu
(
	MaTaiLieu varchar(10) primary key,
	TenTaiLieu nvarchar(50),
	NamXB int,
	MaTG varchar(10) NOT NULL FOREIGN KEY REFERENCES dbo.TacGia(MaTG),
	MaTheLoai varchar(10) NOT NULL FOREIGN KEY REFERENCES dbo.TheLoai(MaTheLoai),
	MaNXB varchar(10) NOT NULL FOREIGN KEY REFERENCES dbo.NhaXuatBan(MaNXB),
)
go
create table DocGia
(
	MaDG varchar(10) primary key,
	TenDG nvarchar(50),
	NgaySinh datetime,
	GioiTinh nvarchar(5),
	Lop nvarchar(10)
)

go
create table TacGia
(
	MaTG varchar(10) primary key,
	TenTG nvarchar(50),
)
go
create table TheLoai
(
	MaTheLoai varchar(10) primary key,
	TenTheLoai nvarchar(20) default N'Tên thể loại',
)
go
create table NhaXuatBan
(
	MaNXB varchar(10) primary key,
	TenNXB nvarchar(50),
	DiaChi nvarchar(100),
	SDT varchar(10)
)
go
create table NhanVien
(
	MaNV varchar(10) primary key,
	TenNV nvarchar(50),
	NgaySinh datetime,
	GioiTinh nvarchar(5),
	DiaChi nvarchar(100),
	SDT varchar(10)
)
create table PhieuMuon
(
	MaPM varchar(10) primary key,
	MaDG varchar(10) NOT NULL FOREIGN KEY REFERENCES dbo.DocGia(MaDG),
	MaNV varchar(10) NOT NULL FOREIGN KEY REFERENCES dbo.NhanVien(MaNV),
)
create table CTPhieuMuon
(
	MaPM varchar(10) NOT NULL FOREIGN KEY REFERENCES dbo.PhieuMuon(MaPM),
	MaTaiLieu varchar(10) NOT NULL FOREIGN KEY REFERENCES dbo.TaiLieu(MaTaiLieu),
	NgayMuon datetime,
	NgayTra datetime,
	TinhTrang nvarchar(50)
)
create table Account
(
	MaAccount varchar(10) primary key,
	TenAccount varchar(20),
	MKAccount varchar(10),
	MaNV varchar(10) NOT NULL FOREIGN KEY REFERENCES dbo.NhanVien(MaNV)
)

---MaAccount TenAccount MKAccount MaNV
insert into Account values ('1','admin', '050701', 'NV04')
insert into Account values ('2','admin2', '123456', 'NV03')
insert into Account values ('3','admin3', '123456', 'NV02')
insert into Account values ('4','admin4', '123456', 'NV01')
---mapm madg manv
insert into PhieuMuon values ('1','1','NV01')
insert into PhieuMuon values ('2','2','NV02')
insert into PhieuMuon values ('3','3','NV03')
insert into PhieuMuon values ('4','7','NV02')
insert into PhieuMuon values ('5','15','NV01')

---MaPM MaTaiLieu NgayMuon NgayTra TinhTrang
insert into CTPhieuMuon values ('1','1','7/5/2021','9/8/2021','ok')
insert into CTPhieuMuon values ('2','3','8/4/2021','9/4/2021','ok')
insert into CTPhieuMuon values ('3','4','7/23/2021','9/19/2021','ok')
insert into CTPhieuMuon values ('4','2','8/12/2021','9/28/2021','ok')
insert into CTPhieuMuon values ('5','3','8/27/2021','9/9/2021','ok')


----
insert into DocGia values ('1',N'Phạm Ngọc Hải','5/5/2001','Nam','C1')
insert into DocGia values ('2',N'Phạm Hải NGọc','6/7/2003','Nam','B5')
insert into DocGia values ('3',N'Phạm Minh Hoang','1/2/2001','Nam','A2')
insert into DocGia values ('7',N'Nguyễn Thanh Hải','11/12/2012',N'Nữ','D3')
insert into DocGia values ('15',N'Hữu Hoàng Hiếu','1/10/2010',N'Nữ','E1')

----
insert into TaiLieu values ('1', N'Lập trình hướng đối tượng',2010, N'KB', N'LT', 'ND')
insert into TaiLieu values ('2', N'Nhập môn lập trình',2011, N'GS', N'TL', 'TT')
insert into TaiLieu values ('3', N'Kỹ Thuật Lập Trình',2001, N'KB', N'GT', 'SG')
insert into TaiLieu values ('4', N'Thiết Kế Phần Mềm',2019, N'GS', N'LT', 'KD')

---
insert into TheLoai values ('DS',N'Đời sống')
insert into TheLoai values ('TL',N'Tài liệu')
insert into TheLoai values ('GT',N'Giải trí')
insert into TheLoai values ('HH',N'Hài hước')
insert into TheLoai values ('LT',N'Lập trình')
---
insert into TacGia values ('DS',N'Danh Sinh')
insert into TacGia values ('NC',N'Nam Cao')
insert into TacGia values ('TH',N'Tô Hoài')
insert into TacGia values ('GS',N'Giáo Sư')
insert into TacGia values ('KB',N'Không biết')
---
insert into NhaXuatBan values ('KD',N'Kim Đồng','Q3','111')
insert into NhaXuatBan values ('ND',N'Nhân Dân','Q6','222')
insert into NhaXuatBan values ('TT',N'Tuổi Trẻ','Q1','333')
insert into NhaXuatBan values ('SG',N'Sài Gòn','Q1','444')
---
insert into NhanVien values ('NV01',N'Ngọc Trinh','12/13/1999',N'Nữ',N'Q1','0123456789')
insert into NhanVien values ('NV02',N'Vĩnh Hưng','11/3/1981',N'Nam',N'Q10','4444444')
insert into NhanVien values ('NV03',N'Phương Hằng','5/6/2002',N'Nam',N'Q11','7777777')
insert into NhanVien values ('NV04',N'Phùng Đại Học','12/1/2001',N'Nam',N'Q1','0123456789')

drop table TheLoai
drop table TaiLieu 
drop table DocGia
drop table PhieuMuon
drop table CTPhieuMuon
drop table TacGia
drop table NhaXuatBan
drop table NhanVien

1234 test
