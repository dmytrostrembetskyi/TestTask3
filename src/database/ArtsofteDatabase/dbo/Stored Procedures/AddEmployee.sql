CREATE PROCEDURE [dbo].[AddEmployee]
	@name nvarchar(255),
	@surname nvarchar(255),
	@age int,
    @new_identity INT OUTPUT
AS
BEGIN
    INSERT INTO dbo.Employees(Name,
                              Surname,
                              Age)
    VALUES (@name,
            @surname,
            @age);

     SET @new_identity = SCOPE_IDENTITY();
END