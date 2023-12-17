CREATE TABLE [dbo].[Table]
(
	[код заказа] INT NOT NULL PRIMARY KEY, 
    [код сотрудника] NCHAR(10) NULL, 
    [код товара] NCHAR(10) NULL, 
    [дата размещения] NCHAR(10) NULL, 
    [дата исполнения] NCHAR(10) NULL, 
    [код клиента] NCHAR(10) NULL
)
