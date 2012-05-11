/* 
Insert values into USR_COUNTRYREGIONCODE code table 
Created by Bill Elfstrom  4/15/2012 
*/

DECLARE     @return_value int,
            @ID uniqueidentifier

EXEC  @return_value = [dbo].[USP_CHANGEAGENT_GETORCREATECHANGEAGENTFROMCONTEXT]
            @ID = @ID OUTPUT


INSERT INTO dbo.USR_COUNTRYREGIONCODE
           ([ID]
           ,[DESCRIPTION]
           ,[ACTIVE]
           ,[SEQUENCE]
           ,[ADDEDBYID]
           ,[CHANGEDBYID]
           ,[DATEADDED]
           ,[DATECHANGED])
     VALUES (NEWID(), 'Africa', 1,10,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), 'Asia - North', 1,20,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), 'Asia - South', 1,30,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), 'Latin America', 1,40,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), 'Middle East', 1,50,@ID,@ID,GETDATE(),GETDATE())

select * from dbo.USR_COUNTRYREGIONCODE

GO
