if OBJECT_ID('trg_CapNhatTongTien_HDB', 'TR') IS NOT NULL
    DROP TRIGGER trg_CapNhatTongTien_HDB;
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