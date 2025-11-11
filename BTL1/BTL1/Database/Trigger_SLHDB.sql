if OBJECT_ID('trg_CapNhatSoLuongHangBan', 'TR') IS NOT NULL
    DROP TRIGGER trg_CapNhatSoLuongHangBan;
go
CREATE TRIGGER trg_CapNhatSoLuongHangBan
ON ChiTietHDB
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;
    IF TRIGGER_NESTLEVEL() > 1
        RETURN;
    UPDATE h
    SET SLTon = SLTon - ISNULL(i.SLBan, 0) + ISNULL(d.SLBan, 0)
    FROM HangHoa h
    LEFT JOIN inserted i ON h.MaHH = i.MaHH
    LEFT JOIN deleted d ON h.MaHH = d.MaHH
    WHERE (i.MaHH IS NOT NULL OR d.MaHH IS NOT NULL)
      AND (ISNULL(i.SLBan,0) <> ISNULL(d.SLBan,0));
END;