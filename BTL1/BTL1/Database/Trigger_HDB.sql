DROP TRIGGER IF EXISTS trg_CapNhatTongTieuDung_KH;
GO
CREATE TRIGGER trg_CapNhatTongTieuDung_KH
ON dbo.HoaDonBan
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @MaKHAffected TABLE (MaKH NVARCHAR(10) PRIMARY KEY);
    INSERT INTO @MaKHAffected (MaKH)
    SELECT MaKH FROM inserted
    UNION 
    SELECT MaKH FROM deleted; 
    UPDATE kh
    SET kh.TongTieuDung = ISNULL(TinhTongTien.TongTienMoi, 0)
    FROM dbo.KhachHang AS kh
    INNER JOIN @MaKHAffected AS affected ON kh.MaKH = affected.MaKH
    LEFT JOIN (
        SELECT 
            hdb.MaKH, 
            SUM(ISNULL(hdb.TongTien, 0)) AS TongTienMoi
        FROM dbo.HoaDonBan AS hdb
        INNER JOIN @MaKHAffected AS filter ON hdb.MaKH = filter.MaKH
        GROUP BY hdb.MaKH
    ) AS TinhTongTien ON kh.MaKH = TinhTongTien.MaKH;
END;
GO
