
/****** Object:  Table [dbo].[Customer]    Script Date: 17-05-2020 10:30:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CustID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](255) NULL,
	[LastName] [nvarchar](255) NULL,
	[Address] [nvarchar](255) NULL,
	[Phone] [nvarchar](255) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[CustID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Login]    Script Date: 17-05-2020 10:30:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[LoginID] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Login] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Movies]    Script Date: 17-05-2020 10:30:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movies](
	[MovieID] [int] IDENTITY(1,1) NOT NULL,
	[Rating] [nvarchar](50) NULL,
	[Title] [nvarchar](255) NULL,
	[Year] [nvarchar](255) NULL,
	[Rental_Cost] [money] NULL,
	[Copies] [nvarchar](50) NULL,
	[Plot] [ntext] NULL,
	[Genre] [nvarchar](50) NULL,
	[ReleaseDate] [date] NULL,
 CONSTRAINT [PK_Movies] PRIMARY KEY CLUSTERED 
(
	[MovieID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[RentedMovies]    Script Date: 17-05-2020 10:30:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RentedMovies](
	[RMID] [int] IDENTITY(1,1) NOT NULL,
	[MoviesIDFK] [int] NULL,
	[CustIDFK] [int] NULL,
	[DateRented] [datetime] NULL,
	[DateReturned] [datetime] NULL,
 CONSTRAINT [PK_RentedMovies] PRIMARY KEY CLUSTERED 
(
	[RMID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[v_Movies]    Script Date: 17-05-2020 10:30:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[v_Movies] AS
Select [MovieID]
      ,[Title]
      ,[Rating]
      ,[Year]
	  ,Genre
	  ,Plot
      ,[Rental_Cost] from Movies

GO
SET IDENTITY_INSERT [dbo].[Customer] ON 

GO
INSERT [dbo].[Customer] ([CustID], [FirstName], [LastName], [Address], [Phone]) VALUES (1, N'Nirmal', N'Singh', N'abcd', N'12344322')
GO
SET IDENTITY_INSERT [dbo].[Customer] OFF
GO
SET IDENTITY_INSERT [dbo].[Login] ON 

GO
INSERT [dbo].[Login] ([ID], [LoginID], [Password]) VALUES (1, N'admin', N'Welcome@123')
GO
SET IDENTITY_INSERT [dbo].[Login] OFF
GO
SET IDENTITY_INSERT [dbo].[Movies] ON 

GO
INSERT [dbo].[Movies] ([MovieID], [Rating], [Title], [Year], [Rental_Cost], [Copies], [Plot], [Genre], [ReleaseDate]) VALUES (1, NULL, N'Hum Tum1', NULL, 2.0000, NULL, N'23', N'2', NULL)
GO
SET IDENTITY_INSERT [dbo].[Movies] OFF
GO
SET IDENTITY_INSERT [dbo].[RentedMovies] ON 

GO
INSERT [dbo].[RentedMovies] ([RMID], [MoviesIDFK], [CustIDFK], [DateRented], [DateReturned]) VALUES (1, 1, 1, CAST(N'2020-05-17 22:02:41.150' AS DateTime), CAST(N'2020-05-17 22:02:55.803' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[RentedMovies] OFF
GO
/****** Object:  StoredProcedure [dbo].[GetMoviesRentalList]    Script Date: 17-05-2020 10:30:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetMoviesRentalList]
(
@rentalType char(1)
)
AS
BEGIN
IF(@rentalType='A')
BEGIN
SelecT RentedMovies.RMID, FirstName, LastName, Address, Title, Rental_Cost, DateRented ,DateReturned from RentedMovies
join Customer on RentedMovies.CustIDFK = Customer.CustID
join Movies on RentedMovies.MoviesIDFK = Movies.MovieID 
END
else
SelecT RentedMovies.RMID, FirstName, LastName, Address, Title, Rental_Cost, DateRented ,DateReturned from RentedMovies
join Customer on RentedMovies.CustIDFK = Customer.CustID
join Movies on RentedMovies.MoviesIDFK = Movies.MovieID where DateReturned is  null
END

GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateRentalReturnMovie]    Script Date: 17-05-2020 10:30:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_UpdateRentalReturnMovie]
(
@rentalID int
)
AS

BEGIN


UPDATE [dbo].[RentedMovies]
   SET  [DateReturned] = GETDATE()
 WHERE RMID =@rentalID
END

GO
/****** Object:  StoredProcedure [dbo].[SPDeleteCustomers]    Script Date: 17-05-2020 10:30:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SPDeleteCustomers]
@customerID int
AS
BEGIN

delete from Customer where CustID=@customerID

END

GO
/****** Object:  StoredProcedure [dbo].[SPDeleteMovies]    Script Date: 17-05-2020 10:30:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SPDeleteMovies]
@movieID int
AS
BEGIN

delete from Movies where MovieID=@movieID
END

GO
/****** Object:  StoredProcedure [dbo].[SPGetCustomerList]    Script Date: 17-05-2020 10:30:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPGetCustomerList]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	SELECT [CustID]
      ,[FirstName]
      ,[LastName]
      ,[Address]
      ,[Phone]
  FROM [dbo].[Customer]
END

GO
/****** Object:  StoredProcedure [dbo].[SPGetMovieList]    Script Date: 17-05-2020 10:30:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPGetMovieList]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
SELECT [MovieID]
      ,[Title]
	  ,[Genre]
      ,[Rental_Cost]
      ,Plot
  FROM [dbo].[Movies]
END

GO
/****** Object:  StoredProcedure [dbo].[SPGetRentalList]    Script Date: 17-05-2020 10:30:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SPGetRentalList]
AS
BEGIN

SelecT RentedMovies.RMID, FirstName, LastName, Address, Title, Rental_Cost, DateRented ,DateReturned from RentedMovies
join Customer on RentedMovies.CustIDFK = Customer.CustID
join Movies on RentedMovies.MoviesIDFK = Movies.MovieID


END

GO
/****** Object:  StoredProcedure [dbo].[SPInsertRentalIssueMovie]    Script Date: 17-05-2020 10:30:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SPInsertRentalIssueMovie]
(
@customerID int,
@movieID int
)
AS

BEGIN


INSERT INTO [dbo].[RentedMovies]
           ([MoviesIDFK]
           ,[CustIDFK]
           ,[DateRented]
           )
     VALUES
           (@movieID
           ,@customerID
           ,GETDATE()
           )
END

GO
/****** Object:  StoredProcedure [dbo].[SPInsertUpdateCustomer]    Script Date: 17-05-2020 10:30:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SPInsertUpdateCustomer]
@FirstName nvarchar(255)
,@LastName nvarchar(255)
,@Address nvarchar(255)
,@Phone nvarchar(255)
,@CustID int=0
AS
BEGIN
IF(@CustID >0)
BEGIN
UPDATE [dbo].[Customer]
   SET [FirstName] = @FirstName
      ,[LastName] = @LastName
      ,[Address] = @Address
      ,[Phone] = @Phone
 WHERE CustID = @CustID
END
ELSE
BEGIN
declare @id int
INSERT INTO [dbo].[Customer]
           ([FirstName]
           ,[LastName]
           ,[Address]
           ,[Phone])
     VALUES
           (@FirstName
           ,@LastName
           ,@Address
           ,@Phone)
  Select @id = SCOPE_IDENTITY()
END

 
END

GO
/****** Object:  StoredProcedure [dbo].[SPInsertUpdateMovies]    Script Date: 17-05-2020 10:30:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SPInsertUpdateMovies]
(
@Rating nvarchar(50)=null
,@Title nvarchar(255)
,@Year nvarchar(255)=null
,@Rental_Cost money
,@Copies nvarchar(50)=null
,@Plot ntext
,@Genre nvarchar(50)
,@MovieID int =0
)
AS
BEGIN

if(@MovieID >0)
BEGIN

UPDATE [dbo].[Movies]
   SET [Rating] = @Rating
      ,[Title] = @Title
      ,[Year] = @Year
      ,[Rental_Cost] = @Rental_Cost
      ,[Copies] = @Copies
      ,[Plot] = @Plot
      ,[Genre] = @Genre
 WHERE MovieID = @MovieID

END
ELSE
BEGIN



INSERT INTO [dbo].[Movies]
           ([Rating]
           ,[Title]
           ,[Year]
           ,[Rental_Cost]
           ,[Copies]
           ,[Plot]
           ,[Genre])
     VALUES
           (@Rating
           ,@Title
           ,@Year
           ,@Rental_Cost
           ,@Copies
           ,@Plot
           ,@Genre)
END
END


GO
/****** Object:  StoredProcedure [dbo].[SPUpdateRentalReturnMovie]    Script Date: 17-05-2020 10:30:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SPUpdateRentalReturnMovie]
(
@rentalID int
)
AS

BEGIN


UPDATE [dbo].[RentedMovies]
   SET  [DateReturned] = GETDATE()
 WHERE RMID =@rentalID
END

GO
/****** Object:  StoredProcedure [dbo].[SPUserLogin]    Script Date: 17-05-2020 10:30:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SPUserLogin] 
@userID varchar(100),
@pwd Nvarchar(510)
as
Begin
		
select * from Login where LoginID=@userID and Password=@pwd

	
End

GO
USE [master]
GO
ALTER DATABASE [VideoRental_Navjit] SET  READ_WRITE 
GO
