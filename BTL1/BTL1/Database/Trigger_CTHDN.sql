if OBJECT_ID('trg_CapNhatTongTien_HDN', 'TR') IS NOT NULL
    DROP TRIGGER trg_CapNhatTongTien_HDN;
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
