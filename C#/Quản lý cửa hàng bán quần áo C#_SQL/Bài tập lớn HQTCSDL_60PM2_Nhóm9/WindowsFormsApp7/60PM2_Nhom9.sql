	use QLCuaHang
	go


create table nhanvien 
(
MaNV nchar(5) not null primary key,
TenNV nvarchar(30) not null,
Diachi nvarchar(30),
SDTNV int,
Ngaysinh date,
Gioitinh nvarchar(3),
Chucvu nvarchar(30) ,
Luong float
)

Create table TaiKhoan
(       ID_tk nchar(5) NOT NULL primary key,
		MaNV int not null,
		TenDN nvarchar(10),
		Matkhau nvarchar(10),
		[admin] bit,
		foreign key (MaNV) REFERENCES nhanvien(MaNV)
)


create table loaiSP
(
MaLSP int primary key ,
TenLSP nvarchar(30),
)

create table khachhang
(
MaKH nchar(5)not null primary key,
TenKH nvarchar(30) not null,
Diachi nvarchar(30),
Ngaysinh date,
Gioitinh nvarchar(3),
Email nvarchar(30),
SDTKH int 
)

create table sanpham
(
MaSP nchar(5)not null primary key,
TenSP nvarchar(30) not null,
Mota nvarchar(30) null,
Slton int,
MaLSP int,
foreign key(MaLSP) references loaiSP(MaLSP),
)


create table DonHang
(
MaDH nchar(5) primary key,
NgayDH date,
DiaChiGH nvarchar(30),
Tongtien float,
MaKH nchar(5),
foreign key (MaKH) references khachhang(MaKH),
MaNV nchar(5),
foreign key(MaNV) references nhanvien(MaNV)
)

create table ChitietDH
(
 MactHD nchar(5) not null primary key, 
Soluong int,
Thanhtien float,
MaDH nchar(5),
foreign key (MaDH) references DonHang(MaDH),
MaSP nchar(5),
foreign key (MaSP) references sanpham(MaSP),
)




--1 Tạo thủ tục lấy danh sách nhân viên
Create proc Prd_DS_nhanvien
as
begin
Select MaNV,TenNV,Diachi,SDTNV,Chucvu,Luong from nhanvien
End


 --2 Tạo thủ tục lấy tên loại sản phẩm
create procedure sp_tenloaisp @MaSP nvarchar(50)
as select L.TenLSP 
from loaiSP L, sanpham S
where S.MaLSP= L.MaLSP and @MaSP=S.MaSP

--3 Tạo thủ tục thêm nhân viên
Create  Proc Prd_IS_nhanvien
@MaNV int not null,
@TenNV nvarchar(30) not null,
@Diachi nvarchar(30),
@SDTNV int,
@Ngaysinh date,
@Gioitinh nvarchar(30),
@Chucvu nvarchar(30),
@Luong float
as
begin
insert into nhanvien(MaNV,TenNV,Diachi,SDTNV,Ngaysinh,Gioitinh,Chucvu,Luong) 
values(@MaNV,@TenNV,@Diachi,@SDTNV,@Ngaysinh,@Gioitinh,@Chucvu,@Luong)
End



--4 Tạo thủ tục tìm kiếm một khách hàng nào đó 
create proc Prd_TK_Khachhang
@Tenkhachhang nvarchar(30)
as 
begin
if(@Tenkhachhang='')
print 'không tìm thấy';
else
begin
select * from khachhang 
where TenKH like '%'+@Tenkhachhang+'%'
end
end


--5 Tạo thủ tục tìm kiếm 1 nhân viên nào đó theo tên nhân viên gần đúng của họ.
create proc Prd_TKnhanvien
@Tennhanvien nvarchar(30)
as 
begin
if(@Tennhanvien='')
print 'không tìm thấy';
else
begin
select * from nhanvien 
where TenNV like '%'+@Tennhanvien+'%'
end
end


--6 Thủ tục lấy ra sản phẩm bán trong 1 ngày
Create proc Slsanpham
 @Masp char(30)
as
Begin
Declare @sluongxuat INT
Select @sluongxuat=SUM(ChitietDH.Soluong)
From sanpham SP,  ChitietDH 
where 
SP.MaSP=ChitietDH.MaDH and @Masp= SP.MaSP
Print @sluongxuat
End
	




--Hàm

--1 hàm trả về số lượng sản phẩm theo từng loại 
Create function SLloaicacsanpham()
returns @kq table ( MaLSP nvarchar(50))
as 
begin
insert
into @kq select MaLSP,COUNT(MaSP) FROM dbo.sanpham
group by MaLSP
return 
end



--2 Hàm tính tổng tiền
Create function TT_Tongtien (@NgayDH date)
returns float
	as 
	begin 
		declare @Tongtien float
		select @Tongtien=SUM(Tongtien) from DonHang
		where DonHang.NgayDH=@NgayDH
		return @Tongtien 
	end

 drop function TT_Tongtien

 --3 Hàm trả về tổng số sản phẩm đã bán 
 Create Function TT_Tsosanphamban()
returns int
as begin
	declare @tong int
	select @tong =(select COUNT(MaSP) from ChitietDH)
	return @tong
END




 --4 Hàm trả về với tham số đầu vào là Email khách hàng
  create function Email_TimDH (@EmailKH nvarchar(30))
returns @Thongtin table(TenKH nvarchar(30),Diachi nvarchar(30) , TenSP nvarchar(50),MaDH int,
Soluong int, Tongtien float)
as begin
insert into @Thongtin
select KH.TenKH , KH.DiachiKH ,SP.TenSP,DH.MaDH , CT.Soluong ,CT.Thanhtien 
  from khachhang KH, sanpham SP,ChitietDH CT , DonHang DH
  where KH.MaKH=DH.MaKH and  SP.MaSP=CT.MaSP and DH.MaHD=CT.MaHD 
  and KH.Email=@EmailKH
  return 
  end 
 
 












--View
	--1 Thông tin Giao dịch mua sản phẩm của khách hàng
	Create view ThontinSP_DatH
	as
	Select  MaKH,TenKH,MaNV,TenNV, NgayDH
	from nhanvien,khachhang,ChitietDH,DonHang
	WHERE (dbo.nhanvien.MaNV=dbo.DonHang.MaNV)AND(dbo.khachhang.MaKH=dbo.DonHang.MaKH)
	AND(dbo.DonHang.MaDH=dbo.ChitietDH.Soluong)


--2 view In ra Các sản phẩm đã thêm 
CREATE VIEW viewsanpham AS 
select sb.MaSP, sb.TenSP , sb.Mota , sb.Slton, lsb.MaLSP,lsb.TenLSP
from sanpham AS sb INNER JOIN loaiSP AS lsb ON sb.MaSP = lsb.MaLSP




--3 Tạo view liệt kê thông tin khách hàng và ngày đặt hàng của khách hàng
Create view viewkhachhang 
as 
select KH.MaKH,KH.TenKH,DH.MaDH,DH.NgayDH
from khachhang KH,DonHangDH
where DH.MaKH=KH.MaKH




--4 Tạo view để hiện thị thông tin các đơn hàng
Create view viewdonhang
as
select DH.MaDH,KH.MaKH,KH.TenKH,KH.Email,DH.NgayDH,DH.DiaChiGH,DH.MaNV,SP.TenSP,CT.Soluong,LSP.TenLSP,NV.TenNV,DH.Tongtien,KH.SDTKH
from DonHang DH,khachhang KH,ChitietDH CT,sanpham SP,nhanvien NV,loaiSP LSP
where
DH.MaKH= KH.MaKH AND SP.MaLSP = LSP.MaLSP AND DH.MaDH = CT.MaDH AND DH.MaNV= NV.MaNV 





--Trigger
 --1 Tạo trigger Xóa thông tin của nhân viên
Create trigger triger_delete_NV
on NhanVien
instead of delete
as
begin
delete from TAIKHOAN where MaNV = (select MaNV from deleted)
delete from NhanVien where MaNV = (select MaNV from deleted)
end

--2 Tạo trigger không cho thiêm nhân viên dưới 18 tuổi
Create trigger triger_notinsert_NV
on NhanVien
for insert 
as
begin
declare @Count int = 0;
select @Count = COUNT(*) from inserted
where YEAR(GETDATE())- YEAR(inserted.Ngaysinh) < 18
if (@Count>0)
begin
	    print N'không được thêm nhân viên nhỏ hơn 18 tuổi'
	    rollback tran
end
end
 

--3 Tạo trigger Xóa tên khách hàng, sẽ xóa đơn hàng khách hàng
create trigger triger_delete_KH
    on khachhang
    instead of delete
    as
    begin	  
		delete from ChitietDH where MaDH = (select MaDH from DonHang where MaKH = (select MaKH from deleted))			
		delete from DonHang where MaDH = (select MaDH from deleted)		
		delete from khachhang where MaKH = (select MaKH from deleted)
	end

-- 4 Tạo trigger kiểm tra số điện thoại bảng khách hàng
Drop trigger dbo.checkSDTKH
Create trigger checkSDTKH
on khachhang
After insert
as
if ((SELECT LEN(SDTKH) FROM inserted) != 10 )
	Begin
	Print N'Kiểm Tra Lại Số Điện Thoại khách hàng'
	Rollback tran
	end
else
	Print N'số điện thoại hợp lệ '

Insert dbo.khachhang
        ( MaKH ,
          TenKH ,
          Diachi ,
          Ngaysinh ,
          Gioitinh,
          Email ,
          SDTKH 
        )
Values  ( N'2' , 
          N'Nguyễn Xuân Hải' , 
          N'18 Trường Trinh' , 
          '1999-06-10' , 
		  N'Nam'  ,
		  N'hai@gmail.com' , 
          N'082880375' 
        ) 



--Phân quyền

--Tạo các login cấp quyền truy cập vào server

sp_addlogin 'Nhanvien1', 'anh3112';
sp_addlogin 'Nhanvien2', 'Dlinh43';
sp_addlogin 'Nhanvien3', 'theanh2';
sp_addlogin 'Nhanvien4', 'vankhanh1';
sp_addlogin 'Nhanvien5', 'thanhtung';
sp_addlogin 'Nhanvien6', 'thiet3';

--tạo các user gán quyền truy cập vào cơ sở dữ liệu
sp_grantdbaccess 'NhanVien1', N'Hải Anh'
sp_grantdbaccess 'NhanVien2', N'Ngọc linh'
sp_grantdbaccess 'NhanVien3', N'Thế Anh'
sp_grantdbaccess 'NhanVien4', N'Diệu Nhi'
sp_grantdbaccess 'NhanVien5', N'Thanhtùng'
sp_grantdbaccess 'NhanVien6', N'Văn Thiết'

	
sp_addrole 'quanly' -- định nghĩa role  và cấp quyền cho role quản lý
	GRANT SELECT,INSERT,UPDATE,DELETE ON nhanvien  to quanly
	GRANT SELECT,INSERT,UPDATE,DELETE ON khachhang  to quanly
	GRANT SELECT,INSERT,UPDATE,DELETE ON sanpham  to quanly
	GRANT SELECT,INSERT,UPDATE,DELETE ON DonHang  to quanly
	GRANT EXECUTE ON dbo.addQuyen  to quanly
	GRANT EXECUTE ON dbo.sp_tenloaisp  to quanly
	GRANT EXECUTE ON dbo.Prd_TK_Khachhang to quanly
	GRANT EXECUTE ON dbo.Prd_TKnhanvien to quanly
    GRANT EXECUTE ON dbo.Prd_IS_nhanvien to quanly

sp_addrole 'Thanhvien' -- định ngĩa role và cấp quyền cho role Thanhvien
	GRANT SELECT ON dbo.NhanVien to Thanhvien
	GRANT SELECT ON KhachHang to Thanhvien
	GRANT SELECT ON MayBAy to Thanhvien
	GRANT SELECT ON DonHang to 
	GRANT SELECT ON dbo.DonhHang to Thanhvien

--Tạo thủ tục để phân quyền 
	Create Proc addQuyen @tk nvarchar(30)  ,@mk nvarchar(30)  ,@quyen nvarchar(30)
	AS 
	BEGIN

    EXECUTE sp_addlogin @tk, @mk  
	execute  sp_grantdbaccess @tk, @tk
	IF (@quyen = 'quanly')
	EXECUTE sp_addrolemember 'quanly',@tk 
	ELSE 
	EXECUTE sp_addrolemember 'quanly',@tk
	End
-- Tạo thủ tục để thu lại quyền:
	CREATE PROC xoaquyen @tk NCHAR(50)
	AS
	BEGIN 
	EXECUTE sp_droplogin @tk
	EXECUTE sp_dropuser @tk 
	END


	create trigger notupdate
	on khachhang
	for update
	as
	if update(TenKH)
	begin
		print 'sửa cl ';
		rollback tran
	end