CREATE TABLE [dbo].[Universitait]
(
	[Id] INT NOT NULL,
	[NameUniv] TEXT NOt NULL,
	[City] TEXT NOt NULL,
	[Code] INT NOt NULL,
	CONSTRAINT[PK_Table] PRIMARY KEY([Code]), 
    CONSTRAINT [FK_Universitait_ToTable] FOREIGN KEY ([Column]) REFERENCES [ToTable]([ToTableColumn])
)