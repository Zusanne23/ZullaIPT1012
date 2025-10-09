CREATE PROCEDURE dbo.UpdateDanceStyle
    @Title NVARCHAR(50),
    @NewDanceStyle NVARCHAR(50)
AS
BEGIN
    UPDATE dbo.DanceClass
    SET DanceStyle = @NewDanceStyle
    WHERE Title = @Title;
END;
GO