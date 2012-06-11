/* 
Insert values into USR_MAJORTOPOGRAPHICALFEATURECODE code table
Created by Bill Elfstrom  4/15/2012 
*/
DECLARE     @return_value int,
            @ID uniqueidentifier

EXEC  @return_value = [dbo].[USP_CHANGEAGENT_GETORCREATECHANGEAGENTFROMCONTEXT]
            @ID = @ID OUTPUT


INSERT INTO dbo.USR_MAJORTOPOGRAPHICALFEATURECODE
           ([ID]
           ,[DESCRIPTION]
           ,[ACTIVE]
           ,[SEQUENCE]
           ,[ADDEDBYID]
           ,[CHANGEDBYID]
           ,[DATEADDED]
           ,[DATECHANGED])
     VALUES (NEWID(), 'Rivers/bodies of water', 1,10,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), 'Mountain ranges', 1,20,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), 'Major cities', 1,30,@ID,@ID,GETDATE(),GETDATE())
	
select * from dbo.USR_MAJORTOPOGRAPHICALFEATURECODE

GO
