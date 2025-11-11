if OBJECT_ID('trg_CapNhatSoLuongHangNhap', 'TR') IS NOT NULL
    DROP TRIGGER trg_CapNhatSoLuongHangNhap;
go
CREATE TRIGGER trg_CapNhatSoLuongHangNhap
ON ChiTietHDN
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;
    IF TRIGGER_NESTLEVEL() > 1
        RETURN;
    UPDATE h
    SET SLTon = SLTon + ISNULL(i.SLNhap, 0) - ISNULL(d.SLNhap, 0)
    FROM HangHoa h
    LEFT JOIN inserted i ON h.MaHH = i.MaHH
    LEFT JOIN deleted d ON h.MaHH = d.MaHH
    WHERE (i.MaHH IS NOT NULL OR d.MaHH IS NOT NULL)
      AND (ISNULL(i.SLNhap,0) <> ISNULL(d.SLNhap,0));
END;