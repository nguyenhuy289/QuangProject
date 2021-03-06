USE [quangproject]
GO
/****** Object:  StoredProcedure [dbo].[BH_GetData_tu_DonHangCho]    Script Date: 6/4/2021 11:25:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





ALTER proc [dbo].[BH_GetData_tu_DonHangCho]
	@Type nvarchar(50),
	@MaPhieu nvarchar(50),
	@MaKH nvarchar(50)
	as
	begin
	declare @abc table
	 (MaNhom nvarchar(50),
	TenNhom nvarchar(50),
	MaHang nvarchar(50),
	 TenHang nvarchar(50),
	 SL float
	 )
	 insert @abc exec TK_TonKho @MaKho = '',@MaNhom = '',@MaHang = '';

	declare @abcd table
	(
	MaHang nvarchar(50),
	TenHang nvarchar(50),
	GiaBan float,
	PTGiamGia float
	)
	insert @abcd exec BH_LayGiaBan @MaKH, ''

	Select a.MaHang, d.TenHang, SL
	into #BC_ChiTietHangCho
		from BH_DonHangCho_Item a 
		left outer join BH_DonHangCho b on a.MaPhieu = b.MaPhieu
		left outer join DM_KhachHang c on b.MaKH = c.MaKH
		left outer join DM_HangHoa d on a.MaHang = d.MaHang

		where convert(nvarchar(10), b.NgayLap, 20) between convert(nvarchar(10), '1900-01-01', 20) and convert(nvarchar(10), '2100-01-01', 20)
		and (c.MaKH = @MaKH)
		and Huy = 0
	Union all
	Select a.MaHang, d.TenHang, SL = -1 * isnull(SL,0)
	from BH_DonHangBan_Item a 
		left outer join BH_DonHangBan b on a.MaPhieu = b.MaPhieu
		left outer join DM_KhachHang c on b.MaKH = c.MaKH
		left outer join DM_HangHoa d on a.MaHang = d.MaHang

		where convert(nvarchar(10), b.NgayLap, 20) between convert(nvarchar(10), '1900-01-01', 20) and convert(nvarchar(10), '2100-01-01', 20)
		and (c.MaKH = @MaKH)
		and Huy = 0

     
	 Select a.MaHang, a.TenHang, SL = sum(SL), GiaBia
	 into #BC_ChiTietHangCho1
	 
			from #BC_ChiTietHangCho a
			left outer join DM_HangHoa b on a.MaHang = b.MaHang
			group by a.MaHang, a.TenHang, GiaBia
	 
	 Select MaHang, TenHang, Nhucau = SL, SL, DonGia = 0, ThanhTien = 0, GiaBia, GhiChu = '', MaPhieu = ''
	 into #BC_ChiTietHangCho2
	 from #BC_ChiTietHangCho1

	 Select a.MaHang, a.TenHang, a.NhuCau, a.SL, TonKho = isnull(b.SL,0), DonGia, ThanhTien, GiaBia, GhiChu, MaPhieu
	 into #BC_ChiTietHangCho3
	 from #BC_ChiTietHangCho2 a
	 left outer join @abc b on a.MaHang = b.MaHang
	 
	 --Select MaHang, TenHang, NhuCau, TonKho, SL,  DonGia, ThanhTien, GhiChu, MaPhieu
	 --from #BC_ChiTietHangCho3

	 Select a.MaHang, a.TenHang, a.NhuCau, a.TonKho, a.SL, DonGia = b.GiaBan, GiaBia, PTGiamGia
	 into #BC_ChiTietHangCho4
	 from #BC_ChiTietHangCho3 a
	 left outer join @abcd b on a.MaHang = b.MaHang

	 if @Type = 'new'
	 begin
		 delete #BC_ChiTietHangCho4 where SL = 0
		 Select MaHang, TenHang, NhuCau, TonKho, SL, DonGia, 
		 ThanhTien = SL * DonGia, GiaBia, GhiChu = '', MaPhieu = @MaPhieu, PTGiamGia
		 from #BC_ChiTietHangCho4
	 end
	 if @Type = 'edit'
	 begin
		Select a.MaHang, c.TenHang, NhuCau = 0, TonKho = isnull(d.SL,0), a.SL, a.DonGia,
		ThanhTien, a.GiaBia, GhiChu, a.MaPhieu, a.PTGiamGia
		from BH_DonHangBan_Item a
		left outer join BH_DonHangBan b on a.MaPhieu = b.MaPhieu
		left outer join DM_HangHoa c on a.MaHang = c.MaHang
		left outer join @abc d on a.MaHang = d.MaHang
		left outer join #BC_ChiTietHangCho4 e on a.MaHang = e.MaHang
		where a.MaPhieu = @MaPhieu

	 end

	drop table #BC_ChiTietHangCho
	drop table #BC_ChiTietHangCho1
	drop table #BC_ChiTietHangCho2
	drop table #BC_ChiTietHangCho3
	drop table #BC_ChiTietHangCho4

	end