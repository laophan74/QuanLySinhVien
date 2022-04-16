create database QLSV
go
use QLSV
go
create table MonHoc(
	maMH int primary key identity,
	tenMH nvarchar(30),
	soTC int
)
go
create table GiaoVien(
	maGV int primary key identity,
	hoten nvarchar(30),
	dob nvarchar(30),
	gender nvarchar(3),
	phone varchar(11),
	email varchar(30),
	diachia nvarchar(50)
)
go
create table LopHoc(
	maLH int primary key identity,
	maMH int foreign key references MonHoc(maMH),
	maGV int foreign key references GiaoVien(maGV),
	trangthai nvarchar(30),
)
go
create table SinhVien(
	maSV char(30) primary key,
	hoten nvarchar(30),
	dob nvarchar(30),
	gender nvarchar(3),
	phone varchar(11),
	email varchar(30),
	diachia nvarchar(50)
)
go
create table DangKyLop(
	maLH int foreign key references LopHoc(maLH),
	maSV char(30) foreign key references SinhVien(maSV),
	diemGK int,
	diemCK int
	primary key(maLH, maSV)
)
go 
create table TaiKhoan(
	maTK int primary key identity,
	taikhoan nvarchar(30),
	matkhau nvarchar(30),
	loaiTK int
)
