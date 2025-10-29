UPDATE c
SET c.Gia = h.Gia
FROM ChiTietHDN AS c
INNER JOIN HangHoa AS h ON c.MaHH = h.MaHH;
if OBJECT_ID('trg_CapNhatGia', 'TR') IS NOT NULL
    DROP TRIGGER trg_CapNhatGia;
go
create trigger trg_CapNhatGia
on dbo.HangHoa
after update
as
begin
    set nocount on;
    update c
    set c.Gia = i.Gia
    from dbo.ChiTietHDN as c
    inner join inserted as i on c.MaHH = i.MaHH;
end;