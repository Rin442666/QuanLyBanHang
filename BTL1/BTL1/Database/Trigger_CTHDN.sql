if OBJECT_ID('trg_CapNhatTongTien_HDN', 'TR') IS NOT NULL
    DROP TRIGGER trg_CapNhatTongTien_HDN;
go
CREATE TRIGGER trg_CapNhatTongTien_HDN
ON ChiTietHDN
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;
    IF TRIGGER_NESTLEVEL() > 1
        RETURN;
    UPDATE HoaDonNhap
    SET TongTien = (
        SELECT SUM(SLNhap * Gia)
        FROM ChiTietHDN c
        WHERE c.MaHDN = HoaDonNhap.MaHDN
    )
    WHERE MaHDN IN (
        SELECT MaHDN FROM inserted
        UNION
        SELECT MaHDN FROM deleted
    );
END;
