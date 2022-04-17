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
	tenMH nvarchar(30),
	maGV int foreign key references GiaoVien(maGV),
	tenGV nvarchar(30),
	trangthai nvarchar(30)
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
	maLH int,
	maMH int,
	tenMH nvarchar(30),
	maGV int,
	tenGV nvarchar(30),
	maSV char(30),
	tenSV nvarchar(30),
	diemGK int,
	diemCK int,
	trangthai nvarchar(30)
)
go 
create table TaiKhoan(
	taikhoan nvarchar(30) primary key,
	matkhau nvarchar(30),
	maSV char(30),
	maGV int,
	loaiTK int
)
