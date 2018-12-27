DROP DATABASE QLCONGVIEC
CREATE DATABASE QLCONGVIEC
GO
USE QLCONGVIEC
GO

CREATE TABLE CONGVIEC
(
	MaCongViec INT IDENTITY(1,1),
	TenCV NVARCHAR(100) NOT NULL,
	NguoiGiao INT NOT NULL,
	NgayBatDau DATETIME NOT NULL,
	NgayHetHan DATETIME NOT NULL,
	NgayHoanThanh DATETIME,
	MoTa NVARCHAR(200),
	TienDo INT DEFAULT 0,

	CONSTRAINT PRK_CONGVIEC PRIMARY KEY (MaCongViec)
)
GO
CREATE TABLE PHANCONG
(
	MaPhanCong INT IDENTITY(1,1),
	MaCongViec INT NOT NULL,
	NguoiNhan INT NOT NULL,
	TrangThai BIT DEFAULT 0,
	NgayHoanThanh DATETIME,
	MoTa NVARCHAR(200)

	CONSTRAINT PRK_PHANCONG PRIMARY KEY (MaPhanCong,MaCongViec)
)
GO
CREATE TABLE NHANVIEN
(
	MaNhanVien INT IDENTITY(1,1),
	HoTen NVARCHAR(100) NOT NULL,
	NgaySinh DATETIME NOT NULL,
	DiaChi NVARCHAR(500) NOT NULL,
	ChucVu NVARCHAR(50) NOT NULL,
	MaPhongBan VARCHAR(50) NOT NULL,
	TenDangNhap VARCHAR(50) NOT NULL,
	MatKhau VARCHAR(50) NOT NULL,
	HinhDaiDien VARCHAR(100),

	CONSTRAINT PRK_NHANVIEN PRIMARY KEY(MaNhanVien)
)
GO
Create table PHONGBAN
(
	MaPhongBan VARCHAR(50) NOT NULL,
	TenPhong nvarchar(100) NOT NULL,
	TruongPhong INT,
	CONSTRAINT PRK_PHONGBAN PRIMARY KEY(MaPhongBan)
)
GO

ALTER TABLE CONGVIEC
ADD 
	CONSTRAINT FRK_NGCV_NV FOREIGN KEY (NguoiGiao) REFERENCES NHANVIEN(MaNhanVien)
GO
ALTER TABLE PHANCONG
ADD 
	CONSTRAINT FRK_CV_PC FOREIGN KEY (MaCongViec) REFERENCES CONGVIEC(MaCongViec),
	CONSTRAINT FRK_NNCV_NV FOREIGN KEY (NguoiNhan) REFERENCES NHANVIEN(MaNhanVien)
GO
ALTER TABLE NHANVIEN
ADD
	CONSTRAINT FRK_ND_PB FOREIGN KEY(MaPhongBan) REFERENCES PHONGBAN(MaPhongBan)

ALTER TABLE PHONGBAN
ADD
	CONSTRAINT FRK_TP_NV FOREIGN KEY(TruongPhong) REFERENCES NHANVIEN(MaNhanVien)

--Tạo Trigger
GO
CREATE TRIGGER trg_CapNhatTienDo_update_insert ON PHANCONG AFTER UPDATE, INSERT
AS
BEGIN
    DECLARE  @tongCongViec FLOAT, @tongCongViecHT FLOAT, @maCV INT, @tienDo INT
	SET @maCV = (SELECT TOP 1 MaCongViec FROM inserted)
	SET @tongCongViec = (SELECT COUNT(*) FROM PHANCONG WHERE MaCongViec = @maCV)
	SET @tongCongViecHT = (SELECT COUNT(*) FROM PHANCONG WHERE MaCongViec = @maCV AND TrangThai = 'true')
	SET @tienDo = ((@tongCongViecHT/@tongCongViec)*100)
	IF (@tienDo = 100)
	BEGIN
		DECLARE @ngayhoanthanh DATETIME
		SET @ngayhoanthanh = (SELECT TOP 1 NgayHoanThanh FROM inserted)
		UPDATE CONGVIEC SET TienDo = @tienDo, NgayHoanThanh = @ngayhoanthanh WHERE MaCongViec = @maCV
	END
	ELSE
		UPDATE CONGVIEC SET TienDo = @tienDo, NgayHoanThanh = NULL  WHERE MaCongViec = @maCV
END

GO
CREATE TRIGGER trg_CapNhatTienDo_delete ON PHANCONG AFTER DELETE
AS
BEGIN
	DECLARE  @tongCongViec FLOAT, @tongCongViecHT FLOAT, @maCV INT, @tienDo INT
	SET @maCV = (SELECT TOP 1 MaCongViec FROM deleted)
	SET @tongCongViec = (SELECT COUNT(*) FROM PHANCONG WHERE MaCongViec = @maCV)
	IF(@tongCongViec != 0)
	BEGIN
		SET @tongCongViecHT = (SELECT COUNT(*) FROM PHANCONG WHERE MaCongViec = @maCV AND TrangThai = 'true')
		SET @tienDo = ((@tongCongViecHT/@tongCongViec)*100)
		IF (@tienDo = 100)
		BEGIN
			DECLARE @ngayhoanthanh DATETIME
			SET @ngayhoanthanh = (SELECT TOP 1 NgayHoanThanh FROM PHANCONG WHERE MaCongViec = @maCV ORDER BY NgayHoanThanh DESC)
			UPDATE CONGVIEC SET TienDo = @tienDo, NgayHoanThanh = @ngayhoanthanh WHERE MaCongViec = @maCV
		END
		ELSE
			UPDATE CONGVIEC SET TienDo = @tienDo, NgayHoanThanh = NULL  WHERE MaCongViec = @maCV
	END
END

GO
--Nhập dữ liệu

--Phong ban
INSERT INTO PHONGBAN (MaPhongBan,TenPhong) VALUES('GD', N'Phòng giám đốc')
INSERT INTO PHONGBAN (MaPhongBan,TenPhong) VALUES('KT', N'Phòng kỹ thuật')
INSERT INTO PHONGBAN (MaPhongBan,TenPhong) VALUES('TC', N'Phòng tài chính')
INSERT INTO PHONGBAN (MaPhongBan,TenPhong) VALUES('NS', N'Phòng nhân sự')

--Nguoi dung
INSERT INTO NHANVIEN (HoTen,NgaySinh,DiaChi,ChucVu,MaPhongBan,TenDangNhap,MatKhau,HinhDaiDien)
	VALUES(N'Nguyễn Hoàng Sang', '09/21/1997', N'Phú Lợi, Bình Dương', N'Giám đốc','GD','admin','123456','boy.png')
INSERT INTO NHANVIEN (HoTen,NgaySinh,DiaChi,ChucVu,MaPhongBan,TenDangNhap,MatKhau,HinhDaiDien)
	VALUES(N'Hồ Thái An', '09/01/1997', N'Phú Hòa, Bình Dương', N'Trưởng phòng','KT','thaian','123456','boy-1.png')
INSERT INTO NHANVIEN (HoTen,NgaySinh,DiaChi,ChucVu,MaPhongBan,TenDangNhap,MatKhau,HinhDaiDien)
	VALUES(N'Nguyễn Hoàng Phúc', '08/10/1997', N'Phú Giáo, Bình Dương', N'Nhân viên','KT','hoangphuc','123456','man.png')
INSERT INTO NHANVIEN (HoTen,NgaySinh,DiaChi,ChucVu,MaPhongBan,TenDangNhap,MatKhau,HinhDaiDien)
	VALUES(N'Lê Quang Bình', '07/06/1997', N'Phú Thọ, Bình Dương', N'Nhân viên','KT','quangbinh','123456','man-1.png')
INSERT INTO NHANVIEN (HoTen,NgaySinh,DiaChi,ChucVu,MaPhongBan,TenDangNhap,MatKhau,HinhDaiDien)
	VALUES(N'Nguyễn Thanh Trọng', '05/04/1997', N'Thủ Dầu Một, Bình Dương', N'Trưởng phòng','TC','thanhtrong','123456','man-2.png')
INSERT INTO NHANVIEN (HoTen,NgaySinh,DiaChi,ChucVu,MaPhongBan,TenDangNhap,MatKhau,HinhDaiDien)
	VALUES(N'Lại Văn Hiếu', '03/01/1997', N'Bình Phước', N'Trưởng phòng','NS','hieu','123456','man-3.png')

--delete from NHANVIEN

--Cap nhat truong phong
UPDATE PHONGBAN SET TruongPhong = 1 WHERE MaPhongBan = 'GD'
UPDATE PHONGBAN SET TruongPhong = 2 WHERE MaPhongBan = 'KT'
UPDATE PHONGBAN SET TruongPhong = 5 WHERE MaPhongBan = 'TC'
UPDATE PHONGBAN SET TruongPhong = 6 WHERE MaPhongBan = 'NS'

--DBCC CHECKIDENT ('NHANVIEN', RESEED, 0)  
--Cong viec - Phan cong

INSERT INTO CONGVIEC(TenCV,NguoiGiao,NgayBatDau,NgayHetHan,MoTa)
	VALUES(N'Làm việc với đối tác A', 1,'2018-12-26', '2018-12-30',N'Thảo luận về sự án ABC')
INSERT INTO PHANCONG(MaCongViec,NguoiNhan,MoTa)
	VALUES(1,2,N'Chịu trách nhiệm làm việc')
INSERT INTO PHANCONG(MaCongViec,NguoiNhan,MoTa)
	VALUES(1,3,N'Sắp xếp thời gian, địa điểm')

INSERT INTO CONGVIEC(TenCV,NguoiGiao,NgayBatDau,NgayHetHan,MoTa)
	VALUES(N'Phỏng vấn nhân sự', 1,'2018-12-26','2018-12-28',N'Phỏng vấn các nhân viên')
INSERT INTO PHANCONG(MaCongViec,NguoiNhan,MoTa)
	VALUES(2,2,N'Đại diện phỏng vấn')
INSERT INTO PHANCONG(MaCongViec,NguoiNhan,MoTa)
	VALUES(2,3,N'Trợ giúp việc phỏng vấn')

INSERT INTO CONGVIEC(TenCV,NguoiGiao,NgayBatDau,NgayHetHan,MoTa)
	VALUES(N'Hoàn thành báo cáo lương', 1,'2018-12-22', '2018-12-24',N'Hoàn thành gấp việc báo cáo lương')
INSERT INTO PHANCONG(MaCongViec,NguoiNhan,MoTa)
	VALUES(3,2,N'Nộp bản báo cáo cho giám đốc')
INSERT INTO PHANCONG(MaCongViec,NguoiNhan,MoTa)
	VALUES(3,4,N'Thống kê tình hình kinh doanh')
INSERT INTO PHANCONG(MaCongViec,NguoiNhan,MoTa)
	VALUES(3,3,N'Nộp bản báo cáo kỳ trước')

INSERT INTO CONGVIEC(TenCV,NguoiGiao,NgayBatDau,NgayHetHan,MoTa)
	VALUES(N'Họp công ty', 1,'2018-12-22', '2018-12-23',N'Phân bố một số nội dung cho các phòng ban')
INSERT INTO PHANCONG(MaCongViec,NguoiNhan,MoTa)
	VALUES(4,2,N'Chuẩn bị nội dung báo cáo')
INSERT INTO PHANCONG(MaCongViec,NguoiNhan,MoTa)
	VALUES(4,5,N'Chuẩn bị nội dung báo cáo')
INSERT INTO PHANCONG(MaCongViec,NguoiNhan,MoTa)
	VALUES(4,6,N'Chuẩn bị nội dung báo cáo')

INSERT INTO CONGVIEC(TenCV,NguoiGiao,NgayBatDau,NgayHetHan,MoTa)
	VALUES(N'Phê duyệt kế hoạch thu chi', 1,'2018-12-26','2018-12-28',N'Phê duyệt kế hoạch thu chi cho phòng Kế toán')
INSERT INTO PHANCONG(MaCongViec,NguoiNhan,MoTa)
	VALUES(5,2,N'Đại diện thực hiện')

INSERT INTO CONGVIEC(TenCV,NguoiGiao,NgayBatDau,NgayHetHan,MoTa)
	VALUES(N'Họp phòng ban', 2,'2018-12-21' ,'2018-11-23',N'Họp tình hình kinh doanh của phòng ban')
INSERT INTO PHANCONG(MaCongViec,NguoiNhan,MoTa)
	VALUES(6,3,N'Chuẩn bị vị trí')
INSERT INTO PHANCONG(MaCongViec,NguoiNhan,MoTa)
	VALUES(6,4,N'Thống kê tình hình')

INSERT INTO CONGVIEC(TenCV,NguoiGiao,NgayBatDau,NgayHetHan,MoTa)
	VALUES(N'Gặp khách hàng B', 2,'2018-12-25', '2018-12-31',N'Trao đổi về vấn đề ABCD')
INSERT INTO PHANCONG(MaCongViec,NguoiNhan,MoTa)
	VALUES(7,3,N'Trực tiếp trao đổi')

INSERT INTO CONGVIEC(TenCV,NguoiGiao,NgayBatDau,NgayHetHan,MoTa)
	VALUES(N'Sắp xếp họp công ty', 1,'2018-12-25', '2018-12-31',N'Thông báo về quy định mới')
INSERT INTO PHANCONG(MaCongViec,NguoiNhan,MoTa)
	VALUES(8,2,N'Chuẩn bị vị trí')
INSERT INTO PHANCONG(MaCongViec,NguoiNhan,MoTa)
	VALUES(8,5,N'Hoàn thành quy định')



--Test
--drop TRIGGER trg_CapNhatTienDo_delete
--drop TRIGGER trg_CapNhatTienDo_update_insert

--UPDATE PHANCONG SET TrangThai = 'true', NgayHoanThanh = GETDATE() WHERE MaPhanCong = 3 

--select * from CONGVIEC LEFT JOIN PHANCONG ON CONGVIEC.MaCongViec = PHANCONG.MaCongViec
--select * from DUAN

--CREATE PROCEDURE CongViecDuocGiao @MaNV int
--AS
--BEGIN
--	SELECT CV.MaCongViec, TenCV, HoTen, NgayBatDau, NgayGiao, NgayHetHan, PC.MoTa, TrangThai
--	FROM CONGVIEC CV JOIN  NHANVIEN ON NguoiGiao = MaNhanVien JOIN PHANCONG PC ON CV.MaCongViec = PC.MaCongViec 
--	WHERE PC.NguoiNhan = @MaNV
--END

--GO
--CREATE PROCEDURE CongViecDaGiao @MaNV int
--AS
--BEGIN
--	SELECT CV.MaCongViec, TenCV, 
--	STUFF(( SELECT  distinct ', ' + s.name
--            FROM    NHANVIEN s
--            WHERE   c.id = s.classid
--            FOR XML PATH('')
--            ), 1, 2, '')  Names
--	, NgayBatDau, NgayGiao, NgayHetHan, TrangThai 
--	FROM CONGVIEC CV JOIN  NHANVIEN ON NguoiGiao = MaNhanVien JOIN PHANCONG PC ON CV.MaCongViec = PC.MaCongViec 
--	WHERE PC.NguoiNhan = @MaNV
--END

--drop proc DanhSachCongViec
-- select * from CONGVIEC order by NgayGiao desc
-- select * from PHANCONG

-- ALTER TABLE CONGVIEC ADD TienDo int
-- ALTER TABLE PHANCONG ADD TrangThai BIT DEFAULT 0