DROP TRIGGER IF EXISTS trg_CapNhatTongTien_HDB;
GO
CREATE TRIGGER trg_CapNhatTongTien_HDB
ON dbo.ChiTietHDB
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;
    IF TRIGGER_NESTLEVEL() > 1
        RETURN;
    DECLARE @MaHDBAffected TABLE (MaHDB NVARCHAR(10) PRIMARY KEY);
    INSERT INTO @MaHDBAffected (MaHDB)
    SELECT MaHDB FROM inserted
    UNION
    SELECT MaHDB FROM deleted;
    WITH CTE_TongTienMoi AS (
        SELECT 
            ct.MaHDB, 
            SUM(ct.SLBan * hh.Gia) AS SumTienMoi
        FROM dbo.ChiTietHDB AS ct
        INNER JOIN dbo.HangHoa AS hh ON hh.MaHH = ct.MaHH
        INNER JOIN @MaHDBAffected AS affected ON affected.MaHDB = ct.MaHDB
        GROUP BY ct.MaHDB
    )
    UPDATE hdb
    SET hdb.TongTien = ISNULL(cte.SumTienMoi, 0)
    FROM dbo.HoaDonBan AS hdb
    INNER JOIN @MaHDBAffected AS affected ON hdb.MaHDB = affected.MaHDB
    LEFT JOIN CTE_TongTienMoi AS cte ON hdb.MaHDB = cte.MaHDB;
END;