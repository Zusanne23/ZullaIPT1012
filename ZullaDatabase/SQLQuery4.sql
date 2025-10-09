USE [DanceClassDatabase]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[CreateDanceClass]
		@Title = N'Hip Hop Basics',
		@DanceStyle = N'Hip Hop',
		@Instructor = N'Alyssa Cruz',
		@Schedule = N'Mon 10:00 AM'

SELECT	@return_value as 'Return Value'

GO
C:\Users\User\source\repos\ZullaDatabase\ZullaDatabase\Script.PostDeployment1.sql