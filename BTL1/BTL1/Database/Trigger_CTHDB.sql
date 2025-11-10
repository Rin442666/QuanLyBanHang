if OBJECT_ID('trg_CapNhatSoLuongHangBan', 'TR') IS NOT NULL
    DROP TRIGGER trg_CapNhatSoLuongHangBan;
go
create trigger trg_CapNhatSoLuongHangBan
on ChiTietHDB
after insert, update, delete
as
begin
    set nocount on;
    IF TRIGGER_NESTLEVEL() > 1
        RETURN;
    update HangHoa
    set SLTon = SLTon - isnull(i.SLBan,0) + isnull(d.SLBan,0)
    from HangHoa h
    left join inserted i on h.MaHH = i.MaHH
    left join deleted d on h.MaHH = d.MaHH
    where i.MaHH is not null or d.MaHH is not null;
end;
go
