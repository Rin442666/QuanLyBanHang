if OBJECT_ID('trg_CapNhatTongTieuDung_KH', 'TR') IS NOT NULL
    DROP TRIGGER trg_CapNhatTongTieuDung_KH;
go
create trigger trg_CapNhatTongTieuDung_KH
on HoaDonBan
after insert, update, delete
as
begin
    set nocount on;
    if TRIGGER_NESTLEVEL() > 1
        return;
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