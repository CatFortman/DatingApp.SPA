
		USE [Config]
		GO
		
		IF EXISTS(SELECT 1 FROM [dbo].[MigrationHistory] WHERE [MigrationId]='8ac7c0c7-c0c6-3e9f-da4b-689dd0bb6985') 
		BEGIN
			PRINT 'Migration "Update location ID" already applied.';
			RETURN;
		END
		
		-- TODO: Insert migration script here.	
		
		DECLARE @Version VARCHAR(100)
		SET @Version = '|VERSIONNUMBER|'
		
		INSERT INTO [dbo].[MigrationHistory]
			([MigrationId], [Version])
			VALUES
			('8ac7c0c7-c0c6-3e9f-da4b-689dd0bb6985', @Version)			
	