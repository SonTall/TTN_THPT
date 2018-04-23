create trigger trig_XoaHS on HocSinh instead of delete
as
	declare @mahocsinh varchar(10),@malop varchar(10)
	begin
		select @mahocsinh=mahocsinh from deleted


		delete from BangDiem
		where mahocsinh = @mahocsinh

		delete from ChuyenLop 
		where mahocsinh=@mahocsinh

		delete from HocSinh
		where mahocsinh = @mahocsinh

		print 'Ma nhan vien vua xoa la: ' + @mahocsinh
	end
go

create trigger trig_XoaCV on ChucVu instead of delete
as
	declare @machucvu varchar(10)
	begin
		select @machucvu=machucvu from deleted


		delete from GiaoVien
		where machucvu = @machucvu

		delete from ChucVu 
		where machucvu=@machucvu

		print 'Ma chuc vu vua xoa la: ' + @machucvu
	end
go

create trigger trig_XoaLop on Lop instead of delete
as
	declare @malop varchar(10)
	begin
		select @malop=malop from deleted


		delete from HocSinh
		where malop = @malop

		delete from GiangDay 
		where malop=@malop

		delete from ChuyenLop
		where malopcu=@malop

		delete from Lop
		where malop=@malop

		print 'Ma lop vua xoa la: ' + @malop
	end
go

create trigger trig_GiaoVien on GiaoVien instead of delete
as
	declare @magiaovien varchar(10)
	begin
		select @magiaovien=magiaovien from deleted


		delete from Lop
		where magvchunhiem = @magiaovien

		delete from GiaoVien 
		where magiaovien=@magiaovien

		print 'Ma giao vien vua xoa la: ' + @magiaovien
	end
go




