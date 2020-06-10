
		USE [Config]
		GO
		
		IF EXISTS(SELECT 1 FROM [dbo].[MigrationHistory] WHERE [MigrationId]='68b8ebe3-d545-4328-8ef7-48c1a487ba6f') 
		BEGIN
			PRINT 'Migration "ghhgh" already applied.';
			RETURN;
		END
		
		-- TODO: Insert migration script here.	
		
		DECLARE @Version VARCHAR(100)
		SET @Version = '|VERSIONNUMBER|'
		
		INSERT INTO [dbo].[MigrationHistory]
			([MigrationId], [Version])
			VALUES
			('68b8ebe3-d545-4328-8ef7-48c1a487ba6f', @Version)			
	