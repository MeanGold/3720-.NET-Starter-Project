CREATE PROCEDURE [dbo].[Validate_User]
      @UserName NVARCHAR(20),
      @Password NVARCHAR(20)
AS
BEGIN
      SET NOCOUNT ON;
      DECLARE @UserId INT
     
      SELECT @UserId = Id
      FROM Users WHERE UserName = @UserName AND [Password] = @Password
     
      IF @UserId IS NOT NULL
      BEGIN
            SELECT @UserId
      END
      ELSE
      BEGIN
            SELECT -1 -- User invalid.
      END
END